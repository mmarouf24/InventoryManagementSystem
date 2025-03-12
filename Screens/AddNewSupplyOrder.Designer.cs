namespace InventoryManagementSystem.Screens
{
    partial class AddNewSupplyOrder
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
            panel1 = new Panel();
            label1 = new Label();
            SuppliersComboBox = new ComboBox();
            WarehousesComboBox = new ComboBox();
            SupplyOrderDate = new DateTimePicker();
            ConfirmAdd = new Button();
            label25 = new Label();
            CancelAdd = new Button();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            SupplyOrderNumberTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            SupplyOrderItemProdDate = new DateTimePicker();
            ItemsCombobox = new ComboBox();
            SupplyOrderItemExpiryTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SupplyOrderItemQTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(460, 31);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 67);
            label1.TabIndex = 0;
            label1.Text = "Supply Order";
            // 
            // SuppliersComboBox
            // 
            SuppliersComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            SuppliersComboBox.FormattingEnabled = true;
            SuppliersComboBox.Location = new Point(240, 226);
            SuppliersComboBox.Name = "SuppliersComboBox";
            SuppliersComboBox.Size = new Size(313, 33);
            SuppliersComboBox.TabIndex = 93;
            // 
            // WarehousesComboBox
            // 
            WarehousesComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            WarehousesComboBox.FormattingEnabled = true;
            WarehousesComboBox.Location = new Point(240, 179);
            WarehousesComboBox.Name = "WarehousesComboBox";
            WarehousesComboBox.Size = new Size(313, 33);
            WarehousesComboBox.TabIndex = 92;
            // 
            // SupplyOrderDate
            // 
            SupplyOrderDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            SupplyOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SupplyOrderDate.Location = new Point(786, 226);
            SupplyOrderDate.Name = "SupplyOrderDate";
            SupplyOrderDate.Size = new Size(308, 27);
            SupplyOrderDate.TabIndex = 91;
            // 
            // ConfirmAdd
            // 
            ConfirmAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ConfirmAdd.Location = new Point(424, 485);
            ConfirmAdd.Name = "ConfirmAdd";
            ConfirmAdd.Size = new Size(150, 55);
            ConfirmAdd.TabIndex = 90;
            ConfirmAdd.Text = "Add";
            ConfirmAdd.UseVisualStyleBackColor = true;
            ConfirmAdd.Click += ConfirmAdd_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label25.Location = new Point(608, 229);
            label25.Name = "label25";
            label25.Size = new Size(110, 25);
            label25.TabIndex = 87;
            label25.Text = "Order Date";
            // 
            // CancelAdd
            // 
            CancelAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CancelAdd.Location = new Point(626, 485);
            CancelAdd.Name = "CancelAdd";
            CancelAdd.Size = new Size(150, 55);
            CancelAdd.TabIndex = 86;
            CancelAdd.Text = "Cancel";
            CancelAdd.UseVisualStyleBackColor = true;
            CancelAdd.Click += CancelAdd_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label26.Location = new Point(599, 176);
            label26.Name = "label26";
            label26.Size = new Size(143, 25);
            label26.TabIndex = 85;
            label26.Text = "Order Number";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label27.Location = new Point(114, 176);
            label27.Name = "label27";
            label27.Size = new Size(111, 25);
            label27.TabIndex = 84;
            label27.Text = "Warehouse";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label28.Location = new Point(114, 234);
            label28.Name = "label28";
            label28.Size = new Size(87, 25);
            label28.TabIndex = 83;
            label28.Text = "Supplier";
            // 
            // SupplyOrderNumberTextBox
            // 
            SupplyOrderNumberTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            SupplyOrderNumberTextBox.Location = new Point(786, 176);
            SupplyOrderNumberTextBox.Name = "SupplyOrderNumberTextBox";
            SupplyOrderNumberTextBox.Size = new Size(308, 32);
            SupplyOrderNumberTextBox.TabIndex = 82;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SupplyOrderItemProdDate);
            groupBox1.Controls.Add(ItemsCombobox);
            groupBox1.Controls.Add(SupplyOrderItemExpiryTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(SupplyOrderItemQTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(117, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(8, 139);
            label4.Name = "label4";
            label4.Size = new Size(336, 20);
            label4.TabIndex = 94;
            label4.Text = "You can add more items from Supply Order Page!\r\n";
            // 
            // SupplyOrderItemProdDate
            // 
            SupplyOrderItemProdDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SupplyOrderItemProdDate.Location = new Point(669, 88);
            SupplyOrderItemProdDate.Name = "SupplyOrderItemProdDate";
            SupplyOrderItemProdDate.Size = new Size(308, 27);
            SupplyOrderItemProdDate.TabIndex = 88;
            // 
            // ItemsCombobox
            // 
            ItemsCombobox.FormattingEnabled = true;
            ItemsCombobox.Location = new Point(125, 37);
            ItemsCombobox.Name = "ItemsCombobox";
            ItemsCombobox.Size = new Size(311, 33);
            ItemsCombobox.TabIndex = 87;
            // 
            // SupplyOrderItemExpiryTextBox
            // 
            SupplyOrderItemExpiryTextBox.Font = new Font("Segoe UI", 11F);
            SupplyOrderItemExpiryTextBox.Location = new Point(669, 37);
            SupplyOrderItemExpiryTextBox.Margin = new Padding(6, 5, 6, 5);
            SupplyOrderItemExpiryTextBox.Name = "SupplyOrderItemExpiryTextBox";
            SupplyOrderItemExpiryTextBox.Size = new Size(308, 32);
            SupplyOrderItemExpiryTextBox.TabIndex = 86;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(482, 91);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 85;
            label6.Text = "Production Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(482, 45);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(167, 25);
            label7.TabIndex = 84;
            label7.Text = "Expiration Period";
            // 
            // SupplyOrderItemQTextBox
            // 
            SupplyOrderItemQTextBox.Font = new Font("Segoe UI", 11F);
            SupplyOrderItemQTextBox.Location = new Point(125, 88);
            SupplyOrderItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            SupplyOrderItemQTextBox.Name = "SupplyOrderItemQTextBox";
            SupplyOrderItemQTextBox.Size = new Size(311, 32);
            SupplyOrderItemQTextBox.TabIndex = 83;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(8, 89);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 82;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(9, 40);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 81;
            label2.Text = "Item";
            // 
            // AddNewSupplyOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(groupBox1);
            Controls.Add(SuppliersComboBox);
            Controls.Add(WarehousesComboBox);
            Controls.Add(SupplyOrderDate);
            Controls.Add(ConfirmAdd);
            Controls.Add(label25);
            Controls.Add(CancelAdd);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(SupplyOrderNumberTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddNewSupplyOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Supply Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private ComboBox SuppliersComboBox;
        private ComboBox WarehousesComboBox;
        private DateTimePicker SupplyOrderDate;
        private Button ConfirmAdd;
        private Label label25;
        private Button CancelAdd;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox SupplyOrderNumberTextBox;
        private GroupBox groupBox1;
        private DateTimePicker SupplyOrderItemProdDate;
        private ComboBox ItemsCombobox;
        private TextBox SupplyOrderItemExpiryTextBox;
        private Label label6;
        private Label label7;
        private TextBox SupplyOrderItemQTextBox;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}