namespace InventoryManagementSystem.Screens
{
    partial class AddNewTransfer
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            TransferItemSuppliersComboBox = new ComboBox();
            TransferItemExpirePeriodTextBox = new TextBox();
            label5 = new Label();
            TransferItemProdDate = new DateTimePicker();
            label6 = new Label();
            TransferItemQTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TransferItemsComboBox = new ComboBox();
            label4 = new Label();
            ConfirmAdd = new Button();
            CancelAdd = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ToWarehousesComboBox = new ComboBox();
            FromWarehousesComboBox = new ComboBox();
            TransferDateItem = new DateTimePicker();
            label40 = new Label();
            label42 = new Label();
            label43 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TransferItemSuppliersComboBox);
            groupBox1.Controls.Add(TransferItemExpirePeriodTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TransferItemProdDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TransferItemQTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TransferItemsComboBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(129, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 203);
            groupBox1.TabIndex = 106;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(59, 139);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 124;
            label7.Text = "Supplier";
            // 
            // TransferItemSuppliersComboBox
            // 
            TransferItemSuppliersComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TransferItemSuppliersComboBox.FormattingEnabled = true;
            TransferItemSuppliersComboBox.Location = new Point(164, 131);
            TransferItemSuppliersComboBox.Name = "TransferItemSuppliersComboBox";
            TransferItemSuppliersComboBox.Size = new Size(261, 28);
            TransferItemSuppliersComboBox.TabIndex = 123;
            // 
            // TransferItemExpirePeriodTextBox
            // 
            TransferItemExpirePeriodTextBox.Font = new Font("Segoe UI", 9F);
            TransferItemExpirePeriodTextBox.Location = new Point(651, 105);
            TransferItemExpirePeriodTextBox.Margin = new Padding(6, 5, 6, 5);
            TransferItemExpirePeriodTextBox.Name = "TransferItemExpirePeriodTextBox";
            TransferItemExpirePeriodTextBox.Size = new Size(312, 27);
            TransferItemExpirePeriodTextBox.TabIndex = 122;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(483, 105);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 121;
            label5.Text = "Expiration Period";
            // 
            // TransferItemProdDate
            // 
            TransferItemProdDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TransferItemProdDate.Location = new Point(651, 42);
            TransferItemProdDate.Name = "TransferItemProdDate";
            TransferItemProdDate.Size = new Size(310, 27);
            TransferItemProdDate.TabIndex = 120;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(489, 49);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 119;
            label6.Text = "Prodcution Date";
            // 
            // TransferItemQTextBox
            // 
            TransferItemQTextBox.Font = new Font("Segoe UI", 9F);
            TransferItemQTextBox.Location = new Point(164, 88);
            TransferItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            TransferItemQTextBox.Name = "TransferItemQTextBox";
            TransferItemQTextBox.Size = new Size(261, 27);
            TransferItemQTextBox.TabIndex = 118;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(55, 91);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 117;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(59, 42);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 116;
            label2.Text = "Item";
            // 
            // TransferItemsComboBox
            // 
            TransferItemsComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TransferItemsComboBox.FormattingEnabled = true;
            TransferItemsComboBox.Location = new Point(164, 42);
            TransferItemsComboBox.Name = "TransferItemsComboBox";
            TransferItemsComboBox.Size = new Size(261, 28);
            TransferItemsComboBox.TabIndex = 115;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 180);
            label4.Name = "label4";
            label4.Size = new Size(342, 20);
            label4.TabIndex = 94;
            label4.Text = "You can add more items from Release Order Page!\r\n";
            // 
            // ConfirmAdd
            // 
            ConfirmAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ConfirmAdd.Location = new Point(445, 511);
            ConfirmAdd.Name = "ConfirmAdd";
            ConfirmAdd.Size = new Size(150, 55);
            ConfirmAdd.TabIndex = 114;
            ConfirmAdd.Text = "Add";
            ConfirmAdd.UseVisualStyleBackColor = true;
            ConfirmAdd.Click += ConfirmAdd_Click;
            // 
            // CancelAdd
            // 
            CancelAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CancelAdd.Location = new Point(647, 511);
            CancelAdd.Name = "CancelAdd";
            CancelAdd.Size = new Size(150, 55);
            CancelAdd.TabIndex = 112;
            CancelAdd.Text = "Cancel";
            CancelAdd.UseVisualStyleBackColor = true;
            CancelAdd.Click += CancelAdd_Click;
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
            panel1.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(381, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(462, 67);
            label1.TabIndex = 0;
            label1.Text = "TRANSFER ORDER";
            // 
            // ToWarehousesComboBox
            // 
            ToWarehousesComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ToWarehousesComboBox.FormattingEnabled = true;
            ToWarehousesComboBox.Location = new Point(796, 230);
            ToWarehousesComboBox.Name = "ToWarehousesComboBox";
            ToWarehousesComboBox.Size = new Size(330, 33);
            ToWarehousesComboBox.TabIndex = 122;
            // 
            // FromWarehousesComboBox
            // 
            FromWarehousesComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            FromWarehousesComboBox.FormattingEnabled = true;
            FromWarehousesComboBox.Location = new Point(255, 233);
            FromWarehousesComboBox.Name = "FromWarehousesComboBox";
            FromWarehousesComboBox.Size = new Size(313, 33);
            FromWarehousesComboBox.TabIndex = 121;
            // 
            // TransferDateItem
            // 
            TransferDateItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TransferDateItem.Location = new Point(257, 168);
            TransferDateItem.Name = "TransferDateItem";
            TransferDateItem.Size = new Size(869, 32);
            TransferDateItem.TabIndex = 120;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label40.Location = new Point(120, 168);
            label40.Name = "label40";
            label40.Size = new Size(131, 25);
            label40.TabIndex = 117;
            label40.Text = "Transfer Date";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label42.Location = new Point(129, 230);
            label42.Name = "label42";
            label42.Size = new Size(59, 25);
            label42.TabIndex = 116;
            label42.Text = "From";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label43.Location = new Point(698, 236);
            label43.Name = "label43";
            label43.Size = new Size(33, 25);
            label43.TabIndex = 115;
            label43.Text = "To";
            // 
            // AddNewTransfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(ToWarehousesComboBox);
            Controls.Add(FromWarehousesComboBox);
            Controls.Add(TransferDateItem);
            Controls.Add(label40);
            Controls.Add(label42);
            Controls.Add(label43);
            Controls.Add(groupBox1);
            Controls.Add(ConfirmAdd);
            Controls.Add(CancelAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddNewTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Transfer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Button ConfirmAdd;
        private Button CancelAdd;
        private Panel panel1;
        private Label label1;
        private ComboBox ToWarehousesComboBox;
        private ComboBox FromWarehousesComboBox;
        private DateTimePicker TransferDateItem;
        private Label label40;
        private Label label42;
        private Label label43;
        private TextBox TransferItemQTextBox;
        private Label label3;
        private Label label2;
        private ComboBox TransferItemsComboBox;
        private TextBox TransferItemExpirePeriodTextBox;
        private Label label5;
        private DateTimePicker TransferItemProdDate;
        private Label label6;
        private Label label7;
        private ComboBox TransferItemSuppliersComboBox;
    }
}