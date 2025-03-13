namespace InventoryManagementSystem
{
    partial class AddNewItem
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
            label3 = new Label();
            label5 = new Label();
            ItemCodeTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemUnitComboBox = new ComboBox();
            ConfirmAddItem = new Button();
            CancelAddItem = new Button();
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
            panel1.Size = new Size(1053, 131);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(393, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 67);
            label1.TabIndex = 0;
            label1.Text = "ADD ITEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 175);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 31);
            label2.TabIndex = 1;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 237);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 320);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 31);
            label5.TabIndex = 4;
            label5.Text = "Unit";
            // 
            // ItemCodeTextBox
            // 
            ItemCodeTextBox.Location = new Point(368, 172);
            ItemCodeTextBox.Margin = new Padding(5);
            ItemCodeTextBox.Name = "ItemCodeTextBox";
            ItemCodeTextBox.Size = new Size(361, 38);
            ItemCodeTextBox.TabIndex = 5;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(368, 234);
            ItemNameTextBox.Margin = new Padding(5);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(361, 38);
            ItemNameTextBox.TabIndex = 6;
            // 
            // ItemUnitComboBox
            // 
            ItemUnitComboBox.FormattingEnabled = true;
            ItemUnitComboBox.Items.AddRange(new object[] { "Kilogram (kg)", "Liter (L)", "Piece" });
            ItemUnitComboBox.Location = new Point(368, 320);
            ItemUnitComboBox.Margin = new Padding(5);
            ItemUnitComboBox.Name = "ItemUnitComboBox";
            ItemUnitComboBox.Size = new Size(175, 39);
            ItemUnitComboBox.TabIndex = 8;
            // 
            // ConfirmAddItem
            // 
            ConfirmAddItem.Location = new Point(368, 399);
            ConfirmAddItem.Margin = new Padding(5);
            ConfirmAddItem.Name = "ConfirmAddItem";
            ConfirmAddItem.Size = new Size(175, 45);
            ConfirmAddItem.TabIndex = 9;
            ConfirmAddItem.Text = "Add";
            ConfirmAddItem.UseVisualStyleBackColor = true;
            ConfirmAddItem.Click += ConfirmAddItem_Click;
            // 
            // CancelAddItem
            // 
            CancelAddItem.Location = new Point(554, 399);
            CancelAddItem.Margin = new Padding(5);
            CancelAddItem.Name = "CancelAddItem";
            CancelAddItem.Size = new Size(175, 45);
            CancelAddItem.TabIndex = 10;
            CancelAddItem.Text = "Cancel";
            CancelAddItem.UseVisualStyleBackColor = true;
            CancelAddItem.Click += CancelAddItem_Click;
            // 
            // AddNewItem
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 709);
            Controls.Add(CancelAddItem);
            Controls.Add(ConfirmAddItem);
            Controls.Add(ItemUnitComboBox);
            Controls.Add(ItemNameTextBox);
            Controls.Add(ItemCodeTextBox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5);
            Name = "AddNewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewItem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox ItemCodeTextBox;
        private TextBox ItemNameTextBox;
        private ComboBox ItemUnitComboBox;
        private Button ConfirmAddItem;
        private Button CancelAddItem;
    }
}