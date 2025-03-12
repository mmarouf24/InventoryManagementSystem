namespace InventoryManagementSystem.Screens
{
    partial class AddSupplyOrderItem
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
            SupplyOrderItemProdDate = new DateTimePicker();
            ItemsCombobox = new ComboBox();
            SupplyOrderItemExpiryTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            Close = new Button();
            ADdSupplyOrderItemBtn = new Button();
            SupplyOrderItemQTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SupplyOrderItemProdDate
            // 
            SupplyOrderItemProdDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SupplyOrderItemProdDate.Location = new Point(828, 299);
            SupplyOrderItemProdDate.Name = "SupplyOrderItemProdDate";
            SupplyOrderItemProdDate.Size = new Size(337, 27);
            SupplyOrderItemProdDate.TabIndex = 80;
            // 
            // ItemsCombobox
            // 
            ItemsCombobox.FormattingEnabled = true;
            ItemsCombobox.Location = new Point(173, 248);
            ItemsCombobox.Name = "ItemsCombobox";
            ItemsCombobox.Size = new Size(395, 28);
            ItemsCombobox.TabIndex = 79;
            // 
            // SupplyOrderItemExpiryTextBox
            // 
            SupplyOrderItemExpiryTextBox.Font = new Font("Segoe UI", 11F);
            SupplyOrderItemExpiryTextBox.Location = new Point(828, 244);
            SupplyOrderItemExpiryTextBox.Margin = new Padding(6, 5, 6, 5);
            SupplyOrderItemExpiryTextBox.Name = "SupplyOrderItemExpiryTextBox";
            SupplyOrderItemExpiryTextBox.Size = new Size(337, 32);
            SupplyOrderItemExpiryTextBox.TabIndex = 78;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(634, 302);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 77;
            label6.Text = "Production Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(634, 248);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(167, 25);
            label7.TabIndex = 76;
            label7.Text = "Expiration Period";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 5, 6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 131);
            panel1.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(308, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(646, 67);
            label1.TabIndex = 0;
            label1.Text = "ADD SUPPLY ORDER ITEM";
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Close.Location = new Point(634, 396);
            Close.Margin = new Padding(6, 5, 6, 5);
            Close.Name = "Close";
            Close.Size = new Size(197, 45);
            Close.TabIndex = 75;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // ADdSupplyOrderItemBtn
            // 
            ADdSupplyOrderItemBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ADdSupplyOrderItemBtn.Location = new Point(371, 396);
            ADdSupplyOrderItemBtn.Margin = new Padding(6, 5, 6, 5);
            ADdSupplyOrderItemBtn.Name = "ADdSupplyOrderItemBtn";
            ADdSupplyOrderItemBtn.Size = new Size(197, 45);
            ADdSupplyOrderItemBtn.TabIndex = 74;
            ADdSupplyOrderItemBtn.Text = "Add";
            ADdSupplyOrderItemBtn.UseVisualStyleBackColor = true;
            ADdSupplyOrderItemBtn.Click += ADdSupplyOrderItemBtn_Click;
            // 
            // SupplyOrderItemQTextBox
            // 
            SupplyOrderItemQTextBox.Font = new Font("Segoe UI", 11F);
            SupplyOrderItemQTextBox.Location = new Point(173, 299);
            SupplyOrderItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            SupplyOrderItemQTextBox.Name = "SupplyOrderItemQTextBox";
            SupplyOrderItemQTextBox.Size = new Size(395, 32);
            SupplyOrderItemQTextBox.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(79, 302);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 72;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(79, 244);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 71;
            label2.Text = "Item";
            // 
            // AddSupplyOrderItem
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(SupplyOrderItemProdDate);
            Controls.Add(ItemsCombobox);
            Controls.Add(SupplyOrderItemExpiryTextBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(Close);
            Controls.Add(ADdSupplyOrderItemBtn);
            Controls.Add(SupplyOrderItemQTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddSupplyOrderItem";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Supply Order Item";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteSupplyOrderItem;
        private DateTimePicker SupplyOrderItemProdDate;
        private ComboBox ItemsCombobox;
        private TextBox SupplyOrderItemExpiryTextBox;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label1;
        private Button Close;
        private Button ADdSupplyOrderItemBtn;
        private TextBox SupplyOrderItemQTextBox;
        private Label label3;
        private Label label2;
    }
}