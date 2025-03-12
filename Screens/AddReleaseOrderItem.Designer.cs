namespace InventoryManagementSystem.Screens
{
    partial class AddReleaseOrderItem
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
            label2 = new Label();
            ReleaseOrderItemsComboBox = new ComboBox();
            ReleaseOrderItemQTextBox = new TextBox();
            label3 = new Label();
            Close = new Button();
            AddReleaseOrderItemBtn = new Button();
            panel1.SuspendLayout();
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
            label1.Location = new Point(278, 30);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(672, 67);
            label1.TabIndex = 0;
            label1.Text = "ADD RELEASE ORDER ITEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(103, 212);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 88;
            label2.Text = "Item";
            // 
            // ReleaseOrderItemsComboBox
            // 
            ReleaseOrderItemsComboBox.FormattingEnabled = true;
            ReleaseOrderItemsComboBox.Location = new Point(197, 212);
            ReleaseOrderItemsComboBox.Name = "ReleaseOrderItemsComboBox";
            ReleaseOrderItemsComboBox.Size = new Size(395, 28);
            ReleaseOrderItemsComboBox.TabIndex = 86;
            // 
            // ReleaseOrderItemQTextBox
            // 
            ReleaseOrderItemQTextBox.Font = new Font("Segoe UI", 11F);
            ReleaseOrderItemQTextBox.Location = new Point(741, 212);
            ReleaseOrderItemQTextBox.Margin = new Padding(6, 5, 6, 5);
            ReleaseOrderItemQTextBox.Name = "ReleaseOrderItemQTextBox";
            ReleaseOrderItemQTextBox.Size = new Size(395, 32);
            ReleaseOrderItemQTextBox.TabIndex = 83;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(647, 215);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 82;
            label3.Text = "Quantity";
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Close.Location = new Point(658, 304);
            Close.Margin = new Padding(6, 5, 6, 5);
            Close.Name = "Close";
            Close.Size = new Size(197, 45);
            Close.TabIndex = 90;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // AddReleaseOrderItemBtn
            // 
            AddReleaseOrderItemBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddReleaseOrderItemBtn.Location = new Point(395, 304);
            AddReleaseOrderItemBtn.Margin = new Padding(6, 5, 6, 5);
            AddReleaseOrderItemBtn.Name = "AddReleaseOrderItemBtn";
            AddReleaseOrderItemBtn.Size = new Size(197, 45);
            AddReleaseOrderItemBtn.TabIndex = 89;
            AddReleaseOrderItemBtn.Text = "Add";
            AddReleaseOrderItemBtn.UseVisualStyleBackColor = true;
            AddReleaseOrderItemBtn.Click += AddReleaseOrderItemBtn_Click;
            // 
            // AddReleaseOrderItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(Close);
            Controls.Add(AddReleaseOrderItemBtn);
            Controls.Add(label2);
            Controls.Add(ReleaseOrderItemsComboBox);
            Controls.Add(ReleaseOrderItemQTextBox);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddReleaseOrderItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Release Order Item";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox ReleaseOrderItemsComboBox;
        private TextBox ReleaseOrderItemQTextBox;
        private Label label3;
        private Button Close;
        private Button AddReleaseOrderItemBtn;
    }
}