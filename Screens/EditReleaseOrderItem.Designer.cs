namespace InventoryManagementSystem.Screens
{
    partial class EditReleaseOrderItem
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
            DeleteReleaseOrderItem = new Button();
            ReleaseOrderItemsComboBox = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            Close = new Button();
            EditReleaseOrderItemBtn = new Button();
            ReleaseOrderItemQTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteReleaseOrderItem
            // 
            DeleteReleaseOrderItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DeleteReleaseOrderItem.Location = new Point(501, 343);
            DeleteReleaseOrderItem.Margin = new Padding(6, 5, 6, 5);
            DeleteReleaseOrderItem.Name = "DeleteReleaseOrderItem";
            DeleteReleaseOrderItem.Size = new Size(197, 45);
            DeleteReleaseOrderItem.TabIndex = 80;
            DeleteReleaseOrderItem.Text = "Delete";
            DeleteReleaseOrderItem.UseVisualStyleBackColor = true;
            DeleteReleaseOrderItem.Click += DeleteReleaseOrderItem_Click;
            // 
            // ReleaseOrderItemsComboBox
            // 
            ReleaseOrderItemsComboBox.FormattingEnabled = true;
            ReleaseOrderItemsComboBox.Location = new Point(196, 233);
            ReleaseOrderItemsComboBox.Name = "ReleaseOrderItemsComboBox";
            ReleaseOrderItemsComboBox.Size = new Size(395, 28);
            ReleaseOrderItemsComboBox.TabIndex = 78;
            ReleaseOrderItemsComboBox.SelectedIndexChanged += ReleaseOrderItemsComboBox_SelectedIndexChanged;
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
            Close.Location = new Point(740, 343);
            Close.Margin = new Padding(6, 5, 6, 5);
            Close.Name = "Close";
            Close.Size = new Size(197, 45);
            Close.TabIndex = 74;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // EditReleaseOrderItemBtn
            // 
            EditReleaseOrderItemBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            EditReleaseOrderItemBtn.Location = new Point(263, 343);
            EditReleaseOrderItemBtn.Margin = new Padding(6, 5, 6, 5);
            EditReleaseOrderItemBtn.Name = "EditReleaseOrderItemBtn";
            EditReleaseOrderItemBtn.Size = new Size(197, 45);
            EditReleaseOrderItemBtn.TabIndex = 73;
            EditReleaseOrderItemBtn.Text = "Edit";
            EditReleaseOrderItemBtn.UseVisualStyleBackColor = true;
            EditReleaseOrderItemBtn.Click += EditReleaseOrderItemBtn_Click;
            // 
            // ReleaseOrderItemQTextBox
            // 
            ReleaseOrderItemQTextBox.Font = new Font("Segoe UI", 11F);
            ReleaseOrderItemQTextBox.Location = new Point(740, 233);
            ReleaseOrderItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            ReleaseOrderItemQTextBox.Name = "ReleaseOrderItemQTextBox";
            ReleaseOrderItemQTextBox.Size = new Size(395, 32);
            ReleaseOrderItemQTextBox.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(646, 236);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 71;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(102, 233);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 81;
            label2.Text = "Item";
            // 
            // EditReleaseOrderItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(label2);
            Controls.Add(DeleteReleaseOrderItem);
            Controls.Add(ReleaseOrderItemsComboBox);
            Controls.Add(panel1);
            Controls.Add(Close);
            Controls.Add(EditReleaseOrderItemBtn);
            Controls.Add(ReleaseOrderItemQTextBox);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditReleaseOrderItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit or Delete Item";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteReleaseOrderItem;
        private ComboBox ReleaseOrderItemsComboBox;
        private Panel panel1;
        private Label label1;
        private Button Close;
        private Button EditReleaseOrderItemBtn;
        private TextBox ReleaseOrderItemQTextBox;
        private Label label3;
        private Label label2;
    }
}