namespace InventoryManagementSystem.Screens
{
    partial class AddNewWarehouse
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
            CancelAddItem = new Button();
            ConfirmAddItem = new Button();
            WarehouseMgrTextBox = new TextBox();
            WarehouseAddressTextBox = new TextBox();
            WarehouseNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 131);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(414, 67);
            label1.TabIndex = 0;
            label1.Text = "ADD Warehouse";
            // 
            // CancelAddItem
            // 
            CancelAddItem.Location = new Point(554, 423);
            CancelAddItem.Margin = new Padding(5);
            CancelAddItem.Name = "CancelAddItem";
            CancelAddItem.Size = new Size(175, 45);
            CancelAddItem.TabIndex = 21;
            CancelAddItem.Text = "Cancel";
            CancelAddItem.UseVisualStyleBackColor = true;
            CancelAddItem.Click += CancelAddItem_Click;
            // 
            // ConfirmAddItem
            // 
            ConfirmAddItem.Location = new Point(368, 423);
            ConfirmAddItem.Margin = new Padding(5);
            ConfirmAddItem.Name = "ConfirmAddItem";
            ConfirmAddItem.Size = new Size(175, 45);
            ConfirmAddItem.TabIndex = 20;
            ConfirmAddItem.Text = "Add";
            ConfirmAddItem.UseVisualStyleBackColor = true;
            ConfirmAddItem.Click += ConfirmAddItem_Click;
            // 
            // WarehouseMgrTextBox
            // 
            WarehouseMgrTextBox.Location = new Point(368, 340);
            WarehouseMgrTextBox.Margin = new Padding(5);
            WarehouseMgrTextBox.Name = "WarehouseMgrTextBox";
            WarehouseMgrTextBox.Size = new Size(361, 27);
            WarehouseMgrTextBox.TabIndex = 18;
            // 
            // WarehouseAddressTextBox
            // 
            WarehouseAddressTextBox.Location = new Point(368, 277);
            WarehouseAddressTextBox.Margin = new Padding(5);
            WarehouseAddressTextBox.Name = "WarehouseAddressTextBox";
            WarehouseAddressTextBox.Size = new Size(361, 27);
            WarehouseAddressTextBox.TabIndex = 17;
            // 
            // WarehouseNameTextBox
            // 
            WarehouseNameTextBox.Location = new Point(368, 215);
            WarehouseNameTextBox.Margin = new Padding(5);
            WarehouseNameTextBox.Name = "WarehouseNameTextBox";
            WarehouseNameTextBox.Size = new Size(361, 27);
            WarehouseNameTextBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 343);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 14;
            label4.Text = "Manager";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 280);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 13;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 218);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // AddNewWarehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 555);
            Controls.Add(panel1);
            Controls.Add(CancelAddItem);
            Controls.Add(ConfirmAddItem);
            Controls.Add(WarehouseMgrTextBox);
            Controls.Add(WarehouseAddressTextBox);
            Controls.Add(WarehouseNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddNewWarehouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewWarehouse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button CancelAddItem;
        private Button ConfirmAddItem;
        private TextBox WarehouseMgrTextBox;
        private TextBox WarehouseAddressTextBox;
        private TextBox WarehouseNameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}