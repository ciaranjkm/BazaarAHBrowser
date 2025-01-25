namespace BazaarAHBrowser
{
    partial class DetailedBazaarViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemNameLabel = new Label();
            averageSellPriceLabel = new Label();
            averageBuyPriceLabel = new Label();
            weeklySellsLabel = new Label();
            weeklyBuyLabel = new Label();
            sellOrdersComboBox = new ComboBox();
            buyOrdersComboBox = new ComboBox();
            marginLabel = new Label();
            itemNameLabelToChange = new Label();
            averageSellPriceLabelToChange = new Label();
            averageBuyPriceLabelToChange = new Label();
            marginLabelToChange = new Label();
            weeklySellsLabelToChange = new Label();
            weeklyBuyLabelToChange = new Label();
            totalSellOrdersLabel = new Label();
            totalBuyOrdersLabel = new Label();
            totalBuysToChange = new Label();
            totalSellsToChange = new Label();
            SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(12, 9);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(69, 15);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // averageSellPriceLabel
            // 
            averageSellPriceLabel.AutoSize = true;
            averageSellPriceLabel.Location = new Point(12, 33);
            averageSellPriceLabel.Name = "averageSellPriceLabel";
            averageSellPriceLabel.Size = new Size(106, 15);
            averageSellPriceLabel.TabIndex = 1;
            averageSellPriceLabel.Text = "Average Sell Price: ";
            // 
            // averageBuyPriceLabel
            // 
            averageBuyPriceLabel.AutoSize = true;
            averageBuyPriceLabel.Location = new Point(12, 57);
            averageBuyPriceLabel.Name = "averageBuyPriceLabel";
            averageBuyPriceLabel.Size = new Size(105, 15);
            averageBuyPriceLabel.TabIndex = 2;
            averageBuyPriceLabel.Text = "Average Buy Price:";
            // 
            // weeklySellsLabel
            // 
            weeklySellsLabel.AutoSize = true;
            weeklySellsLabel.Location = new Point(12, 105);
            weeklySellsLabel.Name = "weeklySellsLabel";
            weeklySellsLabel.Size = new Size(77, 15);
            weeklySellsLabel.TabIndex = 3;
            weeklySellsLabel.Text = "Weekly Sells: ";
            // 
            // weeklyBuyLabel
            // 
            weeklyBuyLabel.AutoSize = true;
            weeklyBuyLabel.Location = new Point(12, 129);
            weeklyBuyLabel.Name = "weeklyBuyLabel";
            weeklyBuyLabel.Size = new Size(73, 15);
            weeklyBuyLabel.TabIndex = 4;
            weeklyBuyLabel.Text = "Weekly Buys";
            // 
            // sellOrdersComboBox
            // 
            sellOrdersComboBox.FormattingEnabled = true;
            sellOrdersComboBox.Items.AddRange(new object[] { "=== SELL ORDERS ===" });
            sellOrdersComboBox.Location = new Point(12, 156);
            sellOrdersComboBox.Name = "sellOrdersComboBox";
            sellOrdersComboBox.Size = new Size(287, 23);
            sellOrdersComboBox.TabIndex = 5;
            // 
            // buyOrdersComboBox
            // 
            buyOrdersComboBox.FormattingEnabled = true;
            buyOrdersComboBox.Items.AddRange(new object[] { "=== BUY ORDERS ===" });
            buyOrdersComboBox.Location = new Point(12, 185);
            buyOrdersComboBox.Name = "buyOrdersComboBox";
            buyOrdersComboBox.Size = new Size(287, 23);
            buyOrdersComboBox.TabIndex = 6;
            // 
            // marginLabel
            // 
            marginLabel.AutoSize = true;
            marginLabel.Location = new Point(12, 81);
            marginLabel.Name = "marginLabel";
            marginLabel.Size = new Size(51, 15);
            marginLabel.TabIndex = 7;
            marginLabel.Text = "Margin: ";
            // 
            // itemNameLabelToChange
            // 
            itemNameLabelToChange.AutoSize = true;
            itemNameLabelToChange.Location = new Point(115, 9);
            itemNameLabelToChange.Name = "itemNameLabelToChange";
            itemNameLabelToChange.Size = new Size(38, 15);
            itemNameLabelToChange.TabIndex = 8;
            itemNameLabelToChange.Text = "label1";
            // 
            // averageSellPriceLabelToChange
            // 
            averageSellPriceLabelToChange.AutoSize = true;
            averageSellPriceLabelToChange.Location = new Point(115, 33);
            averageSellPriceLabelToChange.Name = "averageSellPriceLabelToChange";
            averageSellPriceLabelToChange.Size = new Size(38, 15);
            averageSellPriceLabelToChange.TabIndex = 9;
            averageSellPriceLabelToChange.Text = "label2";
            // 
            // averageBuyPriceLabelToChange
            // 
            averageBuyPriceLabelToChange.AutoSize = true;
            averageBuyPriceLabelToChange.Location = new Point(115, 57);
            averageBuyPriceLabelToChange.Name = "averageBuyPriceLabelToChange";
            averageBuyPriceLabelToChange.Size = new Size(38, 15);
            averageBuyPriceLabelToChange.TabIndex = 10;
            averageBuyPriceLabelToChange.Text = "label3";
            // 
            // marginLabelToChange
            // 
            marginLabelToChange.AutoSize = true;
            marginLabelToChange.Location = new Point(115, 81);
            marginLabelToChange.Name = "marginLabelToChange";
            marginLabelToChange.Size = new Size(38, 15);
            marginLabelToChange.TabIndex = 11;
            marginLabelToChange.Text = "label4";
            // 
            // weeklySellsLabelToChange
            // 
            weeklySellsLabelToChange.AutoSize = true;
            weeklySellsLabelToChange.Location = new Point(115, 105);
            weeklySellsLabelToChange.Name = "weeklySellsLabelToChange";
            weeklySellsLabelToChange.Size = new Size(38, 15);
            weeklySellsLabelToChange.TabIndex = 12;
            weeklySellsLabelToChange.Text = "label5";
            // 
            // weeklyBuyLabelToChange
            // 
            weeklyBuyLabelToChange.AutoSize = true;
            weeklyBuyLabelToChange.Location = new Point(115, 129);
            weeklyBuyLabelToChange.Name = "weeklyBuyLabelToChange";
            weeklyBuyLabelToChange.Size = new Size(38, 15);
            weeklyBuyLabelToChange.TabIndex = 13;
            weeklyBuyLabelToChange.Text = "label6";
            // 
            // totalSellOrdersLabel
            // 
            totalSellOrdersLabel.AutoSize = true;
            totalSellOrdersLabel.Location = new Point(12, 211);
            totalSellOrdersLabel.Name = "totalSellOrdersLabel";
            totalSellOrdersLabel.Size = new Size(97, 15);
            totalSellOrdersLabel.TabIndex = 14;
            totalSellOrdersLabel.Text = "Total Sell Orders: ";
            // 
            // totalBuyOrdersLabel
            // 
            totalBuyOrdersLabel.AutoSize = true;
            totalBuyOrdersLabel.Location = new Point(12, 240);
            totalBuyOrdersLabel.Name = "totalBuyOrdersLabel";
            totalBuyOrdersLabel.Size = new Size(99, 15);
            totalBuyOrdersLabel.TabIndex = 15;
            totalBuyOrdersLabel.Text = "Total Buy Orders: ";
            // 
            // totalBuysToChange
            // 
            totalBuysToChange.AutoSize = true;
            totalBuysToChange.Location = new Point(115, 240);
            totalBuysToChange.Name = "totalBuysToChange";
            totalBuysToChange.Size = new Size(99, 15);
            totalBuysToChange.TabIndex = 17;
            totalBuysToChange.Text = "Total Buy Orders: ";
            // 
            // totalSellsToChange
            // 
            totalSellsToChange.AutoSize = true;
            totalSellsToChange.Location = new Point(115, 211);
            totalSellsToChange.Name = "totalSellsToChange";
            totalSellsToChange.Size = new Size(97, 15);
            totalSellsToChange.TabIndex = 16;
            totalSellsToChange.Text = "Total Sell Orders: ";
            // 
            // DetailedBazaarViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 264);
            Controls.Add(totalBuysToChange);
            Controls.Add(totalSellsToChange);
            Controls.Add(totalBuyOrdersLabel);
            Controls.Add(totalSellOrdersLabel);
            Controls.Add(weeklyBuyLabelToChange);
            Controls.Add(weeklySellsLabelToChange);
            Controls.Add(marginLabelToChange);
            Controls.Add(averageBuyPriceLabelToChange);
            Controls.Add(averageSellPriceLabelToChange);
            Controls.Add(itemNameLabelToChange);
            Controls.Add(marginLabel);
            Controls.Add(buyOrdersComboBox);
            Controls.Add(sellOrdersComboBox);
            Controls.Add(weeklyBuyLabel);
            Controls.Add(weeklySellsLabel);
            Controls.Add(averageBuyPriceLabel);
            Controls.Add(averageSellPriceLabel);
            Controls.Add(itemNameLabel);
            Name = "DetailedBazaarViewForm";
            Text = "DetailedBazaarViewForm";
            FormClosed += DetailedBazaarViewForm_FormClosed;
            Load += DetailedBazaarViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemNameLabel;
        private Label averageSellPriceLabel;
        private Label averageBuyPriceLabel;
        private Label weeklySellsLabel;
        private Label weeklyBuyLabel;
        private ComboBox sellOrdersComboBox;
        private ComboBox buyOrdersComboBox;
        private Label marginLabel;
        private Label itemNameLabelToChange;
        private Label averageSellPriceLabelToChange;
        private Label averageBuyPriceLabelToChange;
        private Label marginLabelToChange;
        private Label weeklySellsLabelToChange;
        private Label weeklyBuyLabelToChange;
        private Label totalSellOrdersLabel;
        private Label totalBuyOrdersLabel;
        private Label totalBuysToChange;
        private Label totalSellsToChange;
    }
}