namespace InventoryManagementSystem.Screens
{
    partial class EditTransferItem
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
            DeleteTransferItem = new Button();
            panel1 = new Panel();
            label1 = new Label();
            Close = new Button();
            EditTransferItemBtn = new Button();
            TransferItemProdDate = new DateTimePicker();
            label40 = new Label();
            label2 = new Label();
            TransferItemsComboBox = new ComboBox();
            TransferItemQTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TransferItemSuppliersComboBox = new ComboBox();
            TransferItemExpirePeriodTextBox = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteTransferItem
            // 
            DeleteTransferItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DeleteTransferItem.Location = new Point(508, 482);
            DeleteTransferItem.Margin = new Padding(6, 5, 6, 5);
            DeleteTransferItem.Name = "DeleteTransferItem";
            DeleteTransferItem.Size = new Size(168, 45);
            DeleteTransferItem.TabIndex = 88;
            DeleteTransferItem.Text = "Delete";
            DeleteTransferItem.UseVisualStyleBackColor = true;
            DeleteTransferItem.Click += DeleteTransferItem_Click;
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
            panel1.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(286, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(623, 67);
            label1.TabIndex = 0;
            label1.Text = "TRANSFER ITEM DETAILS";
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Close.Location = new Point(718, 482);
            Close.Margin = new Padding(6, 5, 6, 5);
            Close.Name = "Close";
            Close.Size = new Size(164, 45);
            Close.TabIndex = 86;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // EditTransferItemBtn
            // 
            EditTransferItemBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            EditTransferItemBtn.Location = new Point(312, 482);
            EditTransferItemBtn.Margin = new Padding(6, 5, 6, 5);
            EditTransferItemBtn.Name = "EditTransferItemBtn";
            EditTransferItemBtn.Size = new Size(166, 45);
            EditTransferItemBtn.TabIndex = 85;
            EditTransferItemBtn.Text = "Edit";
            EditTransferItemBtn.UseVisualStyleBackColor = true;
            EditTransferItemBtn.Click += EditTransferItemBtn_Click;
            // 
            // TransferItemProdDate
            // 
            TransferItemProdDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TransferItemProdDate.Location = new Point(509, 294);
            TransferItemProdDate.Name = "TransferItemProdDate";
            TransferItemProdDate.Size = new Size(373, 32);
            TransferItemProdDate.TabIndex = 94;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label40.Location = new Point(312, 294);
            label40.Name = "label40";
            label40.Size = new Size(167, 28);
            label40.TabIndex = 91;
            label40.Text = "Prodcution Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(312, 174);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 98;
            label2.Text = "Item";
            // 
            // TransferItemsComboBox
            // 
            TransferItemsComboBox.FormattingEnabled = true;
            TransferItemsComboBox.Location = new Point(511, 175);
            TransferItemsComboBox.Name = "TransferItemsComboBox";
            TransferItemsComboBox.Size = new Size(373, 28);
            TransferItemsComboBox.TabIndex = 97;
            TransferItemsComboBox.SelectedIndexChanged += TransferItemsComboBox_SelectedIndexChanged;
            // 
            // TransferItemQTextBox
            // 
            TransferItemQTextBox.Font = new Font("Segoe UI", 11F);
            TransferItemQTextBox.Location = new Point(511, 228);
            TransferItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            TransferItemQTextBox.Name = "TransferItemQTextBox";
            TransferItemQTextBox.Size = new Size(373, 32);
            TransferItemQTextBox.TabIndex = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(312, 235);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 99;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(312, 415);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 102;
            label4.Text = "Supplier";
            // 
            // TransferItemSuppliersComboBox
            // 
            TransferItemSuppliersComboBox.FormattingEnabled = true;
            TransferItemSuppliersComboBox.Location = new Point(509, 415);
            TransferItemSuppliersComboBox.Name = "TransferItemSuppliersComboBox";
            TransferItemSuppliersComboBox.Size = new Size(373, 28);
            TransferItemSuppliersComboBox.TabIndex = 101;
            // 
            // TransferItemExpirePeriodTextBox
            // 
            TransferItemExpirePeriodTextBox.Font = new Font("Segoe UI", 11F);
            TransferItemExpirePeriodTextBox.Location = new Point(509, 357);
            TransferItemExpirePeriodTextBox.Margin = new Padding(6, 5, 6, 5);
            TransferItemExpirePeriodTextBox.Name = "TransferItemExpirePeriodTextBox";
            TransferItemExpirePeriodTextBox.Size = new Size(375, 32);
            TransferItemExpirePeriodTextBox.TabIndex = 104;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(311, 360);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 103;
            label5.Text = "Expiration Period";
            // 
            // EditTransferItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(TransferItemExpirePeriodTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TransferItemSuppliersComboBox);
            Controls.Add(TransferItemQTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TransferItemsComboBox);
            Controls.Add(TransferItemProdDate);
            Controls.Add(label40);
            Controls.Add(DeleteTransferItem);
            Controls.Add(panel1);
            Controls.Add(Close);
            Controls.Add(EditTransferItemBtn);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditTransferItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit or Delete Transfer Item";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteTransferItem;
        private Panel panel1;
        private Label label1;
        private Button Close;
        private Button EditTransferItemBtn;
        private DateTimePicker TransferItemProdDate;
        private Label label40;
        private Label label2;
        private ComboBox TransferItemsComboBox;
        private TextBox TransferItemQTextBox;
        private Label label3;
        private Label label4;
        private ComboBox TransferItemSuppliersComboBox;
        private TextBox TransferItemExpirePeriodTextBox;
        private Label label5;
    }
}