using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BazaarAHBrowser
{
    public partial class Form1 : Form
    {
        private Hypixel_api api;
        private Dictionary<string, BazaarProduct> bazaarData;
        DataTable dt;
        DataTable currentDt;
        private DateTime timeOfLastBazaarRefresh;

        private DetailedBazaarViewForm? itemToOpenForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            api = new Hypixel_api();
            sortComboBox.SelectedIndex = 0;
            itemToOpenForm = null;
        }

        //BAZAAR

        //events
        private async void refreshBazaarData_Click(object sender, EventArgs e)
        {
            refreshLabel.Text = "Loading bazaar data...";
            refreshBazaarData.Enabled = false;
            await loadAndDisplayBazaarData();

            refreshLabel.Text = "Successfully grabbed data at, " + DateTime.Now.ToString();
            timeOfLastBazaarRefresh = DateTime.Now;
            refreshBazaarData.Enabled = true;
        }

        private void sortBazaarDataASCButton_Click(object sender, EventArgs e)
        {
            currentDt = sortDataTable(currentDt, "ASC");

            clearListView();
            convertDataTableToListView(currentDt);
        }

        private void sortBazarDataDSCButton_Click(object sender, EventArgs e)
        {
            currentDt = sortDataTable(currentDt, "DESC");

            clearListView();
            convertDataTableToListView(currentDt);
        }

        //load bazaar data from api and display, store in datatable and displayed in listview
        private async Task loadAndDisplayBazaarData()
        {
            //refreshingLabel.Text = "Refreshing bazaar data, please wait...";
            bazaarData = await api.loadBazaarDataAPI();
            if (bazaarData != null)
            {
                //convertQuickItemsToListView();
                dt = convertQuickItemsToDataTable();
                currentDt = dt;
                convertDataTableToListView(currentDt);

                timeOfLastBazaarRefresh = DateTime.Now;
                //refreshingLabel.Text = "Successfully refreshed data, last refresh: " + timeOfLastBazaarRefresh.ToString("h:mm:ss tt");
            }
            else
            {
                MessageBox.Show("Unable to get api data. Try again soon...");
            }
        }

        //converts list of quickItems from the bazaar to be turned into a datatable
        private DataTable convertQuickItemsToDataTable()
        {
            List<quick_statusItem> quick_StatusItems = api.returnQuickStatusItems();
            DataTable dt = CreateDataTable(quick_StatusItems);

            sortDataTable(dt, "ASC");

            dt.Columns.RemoveAt(8); //hardcoded the rows to remove as api shouldnt change 
            dt.Columns.RemoveAt(6);
            dt.Columns.RemoveAt(4);
            dt.Columns.RemoveAt(2);

            return dt;
        }

        private void convertDataTableToListView(DataTable dt)
        {
            sortDataTable(dt, "ASC");

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                bazaarListView.Items.Add(item);
            }
        }

        //method to create datatable from a list of any type
        private DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            dataTable.TableName = typeof(T).FullName;
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                values[0] = api.convertItemIdToItemName(values[0].ToString());
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        //method to sort datatable of bazaar
        private DataTable sortDataTable(DataTable dt, string ascOrDsc)
        {
            string sortType = sortComboBox.SelectedItem.ToString();
            switch (sortType)
            {
                case "Item Name":
                    dt.DefaultView.Sort = "productId " + ascOrDsc;
                    break;
                case "Sell Price":
                    dt.DefaultView.Sort = "sellPrice " + ascOrDsc;
                    break;
                case "Buy Price":
                    dt.DefaultView.Sort = "buyPrice " + ascOrDsc;
                    break;
                case "Sold This Week":
                    dt.DefaultView.Sort = "sellMovingWeek " + ascOrDsc;
                    break;
                case "Bought This Week":
                    dt.DefaultView.Sort = "buyMovingWeek " + ascOrDsc;
                    break;
                default:
                    dt.DefaultView.Sort = "productId ASC";
                    break;
            }

            dt = dt.DefaultView.ToTable();
            return dt;
        }

        //clear the list view of all items
        private void clearListView()
        {
            bazaarListView.Items.Clear();
        }

        //search datatable for entry with item id matching the search term in textbox
        private void searchBazaarEntriesButton_Click(object sender, EventArgs e)
        {
            string? searchItem = searchTextBox.Text;

            DataRow[] rows = dt.Select($"{dt.Columns[0].ColumnName.ToString()} like '%{searchItem}%'");

            DataTable foundRows = dt.Clone();
            if (rows.Length != 0)
            {
                foreach (DataRow row in rows)
                {
                    foundRows.ImportRow(row);
                }

                foundRows = sortDataTable(foundRows, "ASC");
                dt = currentDt;

                currentDt = foundRows;

                clearListView();
                convertDataTableToListView(currentDt);

                searchStatusLabel.Text = $"Search Successful. {currentDt.Rows.Count} results found.";
            }
            else
            {
                searchTextBox.Text = string.Empty;
                searchStatusLabel.Text = "Search Unsuccessful. 0 results found.";
            }
        }

        private void openDetailListingButton_Click(object sender, EventArgs e)
        {
            ListViewItem? selectedItemRow = null;

            try
            {
                selectedItemRow = bazaarListView.SelectedItems[0];
            }
            catch
            {
                MessageBox.Show("Haven't selected a row.");
            }

            if (selectedItemRow != null)
            {
                string selectedItemName = selectedItemRow.SubItems[0].Text;
                BazaarProduct itemToOpen = bazaarData[selectedItemName];

                if (itemToOpenForm == null)
                {
                    itemToOpenForm = new DetailedBazaarViewForm(itemToOpen, api);
                    itemToOpenForm.OnCloseWindow += destoryBazaarDetailedForm;
                    itemToOpenForm.ShowDialog();
                }
            }
        }

        private void destoryBazaarDetailedForm(object sender, EventArgs e)
        {
            itemToOpenForm = null;
        }

        private void resetSearchOptions_Click(object sender, EventArgs e)
        {
            currentDt = dt;
            clearListView();
            sortDataTable(currentDt, "ASC");
            convertDataTableToListView(currentDt);
        }
    }
}
