namespace BazaarAHBrowser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            refreshBazaarData = new Button();
            bazaarListView = new ListView();
            itemNameColumn = new ColumnHeader();
            sellPriceColumn = new ColumnHeader();
            sellsWeeklyColumn = new ColumnHeader();
            buyPriceColumn = new ColumnHeader();
            buyWeekColumn = new ColumnHeader();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            openDetailListingButton = new Button();
            refreshLabel = new Label();
            searchGroupBox = new GroupBox();
            searchStatusLabel = new Label();
            searchBazaarEntriesButton = new Button();
            resetSearchOptions = new Button();
            label2 = new Label();
            searchTextBox = new TextBox();
            sortGroupBox = new GroupBox();
            sortComboBox = new ComboBox();
            label1 = new Label();
            sortBazarDataDSCButton = new Button();
            sortBazaarDataASCButton = new Button();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            searchGroupBox.SuspendLayout();
            sortGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // refreshBazaarData
            // 
            refreshBazaarData.Location = new Point(680, 350);
            refreshBazaarData.Name = "refreshBazaarData";
            refreshBazaarData.Size = new Size(254, 23);
            refreshBazaarData.TabIndex = 1;
            refreshBazaarData.Text = "Refresh API Data";
            refreshBazaarData.UseVisualStyleBackColor = true;
            refreshBazaarData.Click += refreshBazaarData_Click;
            // 
            // bazaarListView
            // 
            bazaarListView.BackColor = SystemColors.Window;
            bazaarListView.Columns.AddRange(new ColumnHeader[] { itemNameColumn, sellPriceColumn, sellsWeeklyColumn, buyPriceColumn, buyWeekColumn });
            bazaarListView.ForeColor = Color.Black;
            bazaarListView.FullRowSelect = true;
            bazaarListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            bazaarListView.Location = new Point(0, 0);
            bazaarListView.MultiSelect = false;
            bazaarListView.Name = "bazaarListView";
            bazaarListView.Size = new Size(674, 389);
            bazaarListView.TabIndex = 4;
            bazaarListView.UseCompatibleStateImageBehavior = false;
            bazaarListView.View = View.Details;
            // 
            // itemNameColumn
            // 
            itemNameColumn.Text = "Item Name";
            itemNameColumn.Width = 200;
            // 
            // sellPriceColumn
            // 
            sellPriceColumn.Text = "Sell Price";
            sellPriceColumn.Width = 100;
            // 
            // sellsWeeklyColumn
            // 
            sellsWeeklyColumn.DisplayIndex = 3;
            sellsWeeklyColumn.Text = "Sells This Week";
            sellsWeeklyColumn.Width = 130;
            // 
            // buyPriceColumn
            // 
            buyPriceColumn.DisplayIndex = 2;
            buyPriceColumn.Text = "Buy Price";
            buyPriceColumn.Width = 100;
            // 
            // buyWeekColumn
            // 
            buyWeekColumn.Text = "Buys This Week";
            buyWeekColumn.Width = 130;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(948, 426);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(openDetailListingButton);
            tabPage1.Controls.Add(refreshLabel);
            tabPage1.Controls.Add(searchGroupBox);
            tabPage1.Controls.Add(sortGroupBox);
            tabPage1.Controls.Add(bazaarListView);
            tabPage1.Controls.Add(refreshBazaarData);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(940, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bazaar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // openDetailListingButton
            // 
            openDetailListingButton.Location = new Point(680, 304);
            openDetailListingButton.Name = "openDetailListingButton";
            openDetailListingButton.Size = new Size(254, 23);
            openDetailListingButton.TabIndex = 14;
            openDetailListingButton.Text = "More Item Details";
            openDetailListingButton.UseVisualStyleBackColor = true;
            openDetailListingButton.Click += openDetailListingButton_Click;
            // 
            // refreshLabel
            // 
            refreshLabel.AutoSize = true;
            refreshLabel.Location = new Point(677, 376);
            refreshLabel.Name = "refreshLabel";
            refreshLabel.Size = new Size(0, 15);
            refreshLabel.TabIndex = 11;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(searchStatusLabel);
            searchGroupBox.Controls.Add(searchBazaarEntriesButton);
            searchGroupBox.Controls.Add(resetSearchOptions);
            searchGroupBox.Controls.Add(label2);
            searchGroupBox.Controls.Add(searchTextBox);
            searchGroupBox.Location = new Point(679, 55);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(254, 137);
            searchGroupBox.TabIndex = 13;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Search Options";
            // 
            // searchStatusLabel
            // 
            searchStatusLabel.AutoSize = true;
            searchStatusLabel.Location = new Point(6, 99);
            searchStatusLabel.Name = "searchStatusLabel";
            searchStatusLabel.Size = new Size(0, 15);
            searchStatusLabel.TabIndex = 4;
            // 
            // searchBazaarEntriesButton
            // 
            searchBazaarEntriesButton.Location = new Point(91, 72);
            searchBazaarEntriesButton.Name = "searchBazaarEntriesButton";
            searchBazaarEntriesButton.Size = new Size(156, 23);
            searchBazaarEntriesButton.TabIndex = 3;
            searchBazaarEntriesButton.Text = "Search";
            searchBazaarEntriesButton.UseVisualStyleBackColor = true;
            searchBazaarEntriesButton.Click += searchBazaarEntriesButton_Click;
            // 
            // resetSearchOptions
            // 
            resetSearchOptions.Location = new Point(6, 71);
            resetSearchOptions.Name = "resetSearchOptions";
            resetSearchOptions.Size = new Size(79, 25);
            resetSearchOptions.TabIndex = 2;
            resetSearchOptions.Text = "Reset";
            resetSearchOptions.UseVisualStyleBackColor = true;
            resetSearchOptions.Click += resetSearchOptions_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Search Terms:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(6, 42);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(241, 23);
            searchTextBox.TabIndex = 0;
            // 
            // sortGroupBox
            // 
            sortGroupBox.Controls.Add(sortComboBox);
            sortGroupBox.Controls.Add(label1);
            sortGroupBox.Controls.Add(sortBazarDataDSCButton);
            sortGroupBox.Controls.Add(sortBazaarDataASCButton);
            sortGroupBox.Location = new Point(679, 198);
            sortGroupBox.Name = "sortGroupBox";
            sortGroupBox.Size = new Size(254, 100);
            sortGroupBox.TabIndex = 12;
            sortGroupBox.TabStop = false;
            sortGroupBox.Text = "Sort Options";
            // 
            // sortComboBox
            // 
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "Item Name", "Sell Price", "Buy Price", "Sold This Week", "Bought This Week" });
            sortComboBox.Location = new Point(51, 27);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(197, 23);
            sortComboBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Sort By:";
            // 
            // sortBazarDataDSCButton
            // 
            sortBazarDataDSCButton.Location = new Point(145, 56);
            sortBazarDataDSCButton.Name = "sortBazarDataDSCButton";
            sortBazarDataDSCButton.Size = new Size(110, 25);
            sortBazarDataDSCButton.TabIndex = 10;
            sortBazarDataDSCButton.Text = "Sort [ ↓ ]";
            sortBazarDataDSCButton.UseVisualStyleBackColor = true;
            sortBazarDataDSCButton.Click += sortBazarDataDSCButton_Click;
            // 
            // sortBazaarDataASCButton
            // 
            sortBazaarDataASCButton.Location = new Point(6, 56);
            sortBazaarDataASCButton.Name = "sortBazaarDataASCButton";
            sortBazaarDataASCButton.Size = new Size(110, 25);
            sortBazaarDataASCButton.TabIndex = 8;
            sortBazaarDataASCButton.Text = "Sort [ ↑ ]";
            sortBazaarDataASCButton.UseVisualStyleBackColor = true;
            sortBazaarDataASCButton.Click += sortBazaarDataASCButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(940, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Auction House";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(967, 446);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            ShowIcon = false;
            Text = "Bazaar / Auction House Browser v0.1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            sortGroupBox.ResumeLayout(false);
            sortGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button refreshBazaarData;
        private ListView bazaarListView;
        private ColumnHeader itemNameColumn;
        private ColumnHeader sellPriceColumn;
        private ColumnHeader buyPriceColumn;
        private ColumnHeader sellsWeeklyColumn;
        private ColumnHeader buyWeekColumn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button sortBazaarDataASCButton;
        private ComboBox sortComboBox;
        private Button sortBazarDataDSCButton;
        private Label refreshLabel;
        private GroupBox sortGroupBox;
        private GroupBox searchGroupBox;
        private TextBox searchTextBox;
        private Button searchBazaarEntriesButton;
        private Button resetSearchOptions;
        private Label label2;
        private Label searchStatusLabel;
        private Button openDetailListingButton;
    }
}
