namespace InventoryManagementSystem.Screens
{
    partial class EditSupplyOrderItem
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
            SupplyOrderItemExpiryTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            Close = new Button();
            EditSupplyOrderItemBtn = new Button();
            SupplyOrderItemQTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SupplyOrderItemsComboBox = new ComboBox();
            SupplyOrderItemProdDate = new DateTimePicker();
            DeleteSupplyOrderItem = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SupplyOrderItemExpiryTextBox
            // 
            SupplyOrderItemExpiryTextBox.Font = new Font("Segoe UI", 11F);
            SupplyOrderItemExpiryTextBox.Location = new Point(837, 205);
            SupplyOrderItemExpiryTextBox.Margin = new Padding(6, 5, 6, 5);
            SupplyOrderItemExpiryTextBox.Name = "SupplyOrderItemExpiryTextBox";
            SupplyOrderItemExpiryTextBox.Size = new Size(337, 32);
            SupplyOrderItemExpiryTextBox.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(643, 263);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 62;
            label6.Text = "Production Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(643, 209);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(167, 25);
            label7.TabIndex = 61;
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
            panel1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(542, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 67);
            label1.TabIndex = 0;
            label1.Text = "ITEM";
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Close.Location = new Point(733, 357);
            Close.Margin = new Padding(6, 5, 6, 5);
            Close.Name = "Close";
            Close.Size = new Size(197, 45);
            Close.TabIndex = 60;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // EditSupplyOrderItem
            // 
            EditSupplyOrderItemBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            EditSupplyOrderItemBtn.Location = new Point(256, 357);
            EditSupplyOrderItemBtn.Margin = new Padding(6, 5, 6, 5);
            EditSupplyOrderItemBtn.Name = "EditSupplyOrderItemBtn";
            EditSupplyOrderItemBtn.Size = new Size(197, 45);
            EditSupplyOrderItemBtn.TabIndex = 59;
            EditSupplyOrderItemBtn.Text = "Edit";
            EditSupplyOrderItemBtn.UseVisualStyleBackColor = true;
            EditSupplyOrderItemBtn.Click += EditSupplyOrderItem_Click;
            // 
            // SupplyOrderItemQTextBox
            // 
            SupplyOrderItemQTextBox.Font = new Font("Segoe UI", 11F);
            SupplyOrderItemQTextBox.Location = new Point(182, 260);
            SupplyOrderItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            SupplyOrderItemQTextBox.Name = "SupplyOrderItemQTextBox";
            SupplyOrderItemQTextBox.Size = new Size(395, 32);
            SupplyOrderItemQTextBox.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(88, 263);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 54;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(88, 205);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 53;
            label2.Text = "Item";
            // 
            // SupplyOrderItemsComboBox
            // 
            SupplyOrderItemsComboBox.FormattingEnabled = true;
            SupplyOrderItemsComboBox.Location = new Point(182, 209);
            SupplyOrderItemsComboBox.Name = "SupplyOrderItemsComboBox";
            SupplyOrderItemsComboBox.Size = new Size(395, 28);
            SupplyOrderItemsComboBox.TabIndex = 67;
            SupplyOrderItemsComboBox.SelectedIndexChanged += SupplyOrderItemsComboBox_SelectedIndexChanged;
            // 
            // SupplyOrderItemProdDate
            // 
            SupplyOrderItemProdDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SupplyOrderItemProdDate.Location = new Point(837, 260);
            SupplyOrderItemProdDate.Name = "SupplyOrderItemProdDate";
            SupplyOrderItemProdDate.Size = new Size(337, 27);
            SupplyOrderItemProdDate.TabIndex = 68;
            // 
            // DeleteSupplyOrderItem
            // 
            DeleteSupplyOrderItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DeleteSupplyOrderItem.Location = new Point(494, 357);
            DeleteSupplyOrderItem.Margin = new Padding(6, 5, 6, 5);
            DeleteSupplyOrderItem.Name = "DeleteSupplyOrderItem";
            DeleteSupplyOrderItem.Size = new Size(197, 45);
            DeleteSupplyOrderItem.TabIndex = 69;
            DeleteSupplyOrderItem.Text = "Delete";
            DeleteSupplyOrderItem.UseVisualStyleBackColor = true;
            DeleteSupplyOrderItem.Click += DeleteSupplyOrderItem_Click;
            // 
            // EditSupplyOederItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(DeleteSupplyOrderItem);
            Controls.Add(SupplyOrderItemProdDate);
            Controls.Add(SupplyOrderItemsComboBox);
            Controls.Add(SupplyOrderItemExpiryTextBox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(Close);
            Controls.Add(EditSupplyOrderItemBtn);
            Controls.Add(SupplyOrderItemQTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditSupplyOederItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit or Delete";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SupplyOrderItemExpiryTextBox;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label1;
        private Button Close;
        private Button EditSupplyOrderItemBtn;
        private TextBox SupplyOrderItemQTextBox;
        private Label label3;
        private Label label2;
        private ComboBox SupplyOrderItemsComboBox;
        private DateTimePicker SupplyOrderItemProdDate;
        private Button DeleteSupplyOrderItem;
    }
}