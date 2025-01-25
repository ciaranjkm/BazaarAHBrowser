using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaarAHBrowser
{
    public partial class DetailedBazaarViewForm : Form
    {
        public EventHandler OnCloseWindow;

        BazaarProduct product;
        Hypixel_api api;

        public DetailedBazaarViewForm(BazaarProduct bzP, Hypixel_api api)
        {
            InitializeComponent();
            product = bzP;
            this.api = api;
        }

        private void DetailedBazaarViewForm_Load(object sender, EventArgs e)
        {
            buyOrdersComboBox.SelectedIndex = 0;
            sellOrdersComboBox.SelectedIndex = 0;

            itemNameLabelToChange.Text = api.convertItemIdToItemName(product.quick_status.productId);
            averageSellPriceLabelToChange.Text = product.quick_status.sellPrice.ToString();
            averageBuyPriceLabelToChange.Text = product.quick_status.buyPrice.ToString();
            marginLabelToChange.Text = (product.quick_status.buyPrice - product.quick_status.sellPrice).ToString();
            weeklySellsLabelToChange.Text = product.quick_status.sellVolume.ToString();
            weeklyBuyLabelToChange.Text = product.quick_status.buyVolume.ToString();

            totalBuysToChange.Text = product.quick_status.buyOrders.ToString();
            totalSellsToChange.Text = product.quick_status.sellOrders.ToString();

            foreach (sell_summaryItem sellOrder in product.sell_summary)
            {
                sellOrdersComboBox.Items.Add($"{sellOrder.amount}x items @ {sellOrder.pricePerUnit} in {sellOrder.orders.ToString()} orders");
            }
            foreach (buy_summaryItem buyOrder in product.buy_Summary)
            {
                buyOrdersComboBox.Items.Add($"{buyOrder.amount}x items @ {buyOrder.pricePerUnit} in {buyOrder.orders.ToString()} orders");
            }
        }

        private void DetailedBazaarViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnCloseWindow?.Invoke(this, EventArgs.Empty);
        }
    }
}
