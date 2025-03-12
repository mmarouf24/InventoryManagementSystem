namespace InventoryManagementSystem.Screens
{
    partial class AddNewReleaseOrder
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
            label4 = new Label();
            ItemsCombobox = new ComboBox();
            ReleaseOrderItemQTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            CustomersComboBox = new ComboBox();
            WarehousesComboBox = new ComboBox();
            ReleaseOrderDate = new DateTimePicker();
            ConfirmAdd = new Button();
            label25 = new Label();
            CancelAdd = new Button();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            ReleaseOrderNumberTextBox = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ItemsCombobox);
            groupBox1.Controls.Add(ReleaseOrderItemQTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(117, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 162);
            groupBox1.TabIndex = 94;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(8, 139);
            label4.Name = "label4";
            label4.Size = new Size(342, 20);
            label4.TabIndex = 94;
            label4.Text = "You can add more items from Release Order Page!\r\n";
            // 
            // ItemsCombobox
            // 
            ItemsCombobox.FormattingEnabled = true;
            ItemsCombobox.Location = new Point(125, 60);
            ItemsCombobox.Name = "ItemsCombobox";
            ItemsCombobox.Size = new Size(311, 33);
            ItemsCombobox.TabIndex = 87;
            // 
            // ReleaseOrderItemQTextBox
            // 
            ReleaseOrderItemQTextBox.Font = new Font("Segoe UI", 11F);
            ReleaseOrderItemQTextBox.Location = new Point(666, 63);
            ReleaseOrderItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            ReleaseOrderItemQTextBox.Name = "ReleaseOrderItemQTextBox";
            ReleaseOrderItemQTextBox.Size = new Size(311, 32);
            ReleaseOrderItemQTextBox.TabIndex = 83;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(549, 64);
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
            label2.Location = new Point(9, 63);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 81;
            label2.Text = "Item";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(240, 245);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(313, 33);
            CustomersComboBox.TabIndex = 105;
            // 
            // WarehousesComboBox
            // 
            WarehousesComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            WarehousesComboBox.FormattingEnabled = true;
            WarehousesComboBox.Location = new Point(240, 198);
            WarehousesComboBox.Name = "WarehousesComboBox";
            WarehousesComboBox.Size = new Size(313, 33);
            WarehousesComboBox.TabIndex = 104;
            // 
            // ReleaseOrderDate
            // 
            ReleaseOrderDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReleaseOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReleaseOrderDate.Location = new Point(786, 245);
            ReleaseOrderDate.Name = "ReleaseOrderDate";
            ReleaseOrderDate.Size = new Size(308, 27);
            ReleaseOrderDate.TabIndex = 103;
            // 
            // ConfirmAdd
            // 
            ConfirmAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ConfirmAdd.Location = new Point(424, 504);
            ConfirmAdd.Name = "ConfirmAdd";
            ConfirmAdd.Size = new Size(150, 55);
            ConfirmAdd.TabIndex = 102;
            ConfirmAdd.Text = "Add";
            ConfirmAdd.UseVisualStyleBackColor = true;
            ConfirmAdd.Click += ConfirmAdd_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label25.Location = new Point(608, 248);
            label25.Name = "label25";
            label25.Size = new Size(110, 25);
            label25.TabIndex = 101;
            label25.Text = "Order Date";
            // 
            // CancelAdd
            // 
            CancelAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CancelAdd.Location = new Point(626, 504);
            CancelAdd.Name = "CancelAdd";
            CancelAdd.Size = new Size(150, 55);
            CancelAdd.TabIndex = 100;
            CancelAdd.Text = "Cancel";
            CancelAdd.UseVisualStyleBackColor = true;
            CancelAdd.Click += CancelAdd_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label26.Location = new Point(599, 195);
            label26.Name = "label26";
            label26.Size = new Size(143, 25);
            label26.TabIndex = 99;
            label26.Text = "Order Number";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label27.Location = new Point(114, 195);
            label27.Name = "label27";
            label27.Size = new Size(111, 25);
            label27.TabIndex = 98;
            label27.Text = "Warehouse";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label28.Location = new Point(114, 253);
            label28.Name = "label28";
            label28.Size = new Size(98, 25);
            label28.TabIndex = 97;
            label28.Text = "Customer";
            // 
            // ReleaseOrderNumberTextBox
            // 
            ReleaseOrderNumberTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ReleaseOrderNumberTextBox.Location = new Point(786, 195);
            ReleaseOrderNumberTextBox.Name = "ReleaseOrderNumberTextBox";
            ReleaseOrderNumberTextBox.Size = new Size(308, 32);
            ReleaseOrderNumberTextBox.TabIndex = 96;
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
            panel1.TabIndex = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(401, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(415, 67);
            label1.TabIndex = 0;
            label1.Text = "RELEASE ORDER";
            // 
            // AddNewReleaseOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(groupBox1);
            Controls.Add(CustomersComboBox);
            Controls.Add(WarehousesComboBox);
            Controls.Add(ReleaseOrderDate);
            Controls.Add(ConfirmAdd);
            Controls.Add(label25);
            Controls.Add(CancelAdd);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(ReleaseOrderNumberTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddNewReleaseOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Release Order";
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
        private ComboBox ItemsCombobox;
        private TextBox ReleaseOrderItemQTextBox;
        private Label label3;
        private Label label2;
        private ComboBox CustomersComboBox;
        private ComboBox WarehousesComboBox;
        private DateTimePicker ReleaseOrderDate;
        private Button ConfirmAdd;
        private Label label25;
        private Button CancelAdd;
        private Label label26;
        private Label label27;
        private Label label28;
        private TextBox ReleaseOrderNumberTextBox;
        private Panel panel1;
        private Label label1;
    }
}