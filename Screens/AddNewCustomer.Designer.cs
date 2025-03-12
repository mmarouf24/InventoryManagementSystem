namespace InventoryManagementSystem.Screens
{
    partial class AddNewCustomer
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
            CustomerWebsiteTextBox = new TextBox();
            CustomerEmailTextBox = new TextBox();
            CustomerFaxTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            CancelAdd = new Button();
            ConfirmAdd = new Button();
            CustomerMobileTextBox = new TextBox();
            CustomerPhoneTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerWebsiteTextBox
            // 
            CustomerWebsiteTextBox.Font = new Font("Segoe UI", 11F);
            CustomerWebsiteTextBox.Location = new Point(763, 337);
            CustomerWebsiteTextBox.Margin = new Padding(6, 5, 6, 5);
            CustomerWebsiteTextBox.Name = "CustomerWebsiteTextBox";
            CustomerWebsiteTextBox.Size = new Size(406, 32);
            CustomerWebsiteTextBox.TabIndex = 51;
            // 
            // CustomerEmailTextBox
            // 
            CustomerEmailTextBox.Font = new Font("Segoe UI", 11F);
            CustomerEmailTextBox.Location = new Point(763, 278);
            CustomerEmailTextBox.Margin = new Padding(6, 5, 6, 5);
            CustomerEmailTextBox.Name = "CustomerEmailTextBox";
            CustomerEmailTextBox.Size = new Size(406, 32);
            CustomerEmailTextBox.TabIndex = 50;
            // 
            // CustomerFaxTextBox
            // 
            CustomerFaxTextBox.Font = new Font("Segoe UI", 11F);
            CustomerFaxTextBox.Location = new Point(763, 220);
            CustomerFaxTextBox.Margin = new Padding(6, 5, 6, 5);
            CustomerFaxTextBox.Name = "CustomerFaxTextBox";
            CustomerFaxTextBox.Size = new Size(406, 32);
            CustomerFaxTextBox.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(638, 337);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 48;
            label5.Text = "Website";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(638, 278);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 47;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(638, 220);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 46;
            label7.Text = "Fax";
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
            panel1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(440, 32);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(420, 67);
            label1.TabIndex = 0;
            label1.Text = "ADD CUSTOMER";
            // 
            // CancelAdd
            // 
            CancelAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CancelAdd.Location = new Point(638, 428);
            CancelAdd.Margin = new Padding(6, 5, 6, 5);
            CancelAdd.Name = "CancelAdd";
            CancelAdd.Size = new Size(197, 45);
            CancelAdd.TabIndex = 45;
            CancelAdd.Text = "Cancel";
            CancelAdd.UseVisualStyleBackColor = true;
            CancelAdd.Click += CancelAdd_Click;
            // 
            // ConfirmAdd
            // 
            ConfirmAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ConfirmAdd.Location = new Point(405, 428);
            ConfirmAdd.Margin = new Padding(6, 5, 6, 5);
            ConfirmAdd.Name = "ConfirmAdd";
            ConfirmAdd.Size = new Size(197, 45);
            ConfirmAdd.TabIndex = 44;
            ConfirmAdd.Text = "Add";
            ConfirmAdd.UseVisualStyleBackColor = true;
            ConfirmAdd.Click += ConfirmAdd_Click;
            // 
            // CustomerMobileTextBox
            // 
            CustomerMobileTextBox.Font = new Font("Segoe UI", 11F);
            CustomerMobileTextBox.Location = new Point(177, 334);
            CustomerMobileTextBox.Margin = new Padding(6, 5, 6, 5);
            CustomerMobileTextBox.Name = "CustomerMobileTextBox";
            CustomerMobileTextBox.Size = new Size(406, 32);
            CustomerMobileTextBox.TabIndex = 43;
            // 
            // CustomerPhoneTextBox
            // 
            CustomerPhoneTextBox.Font = new Font("Segoe UI", 11F);
            CustomerPhoneTextBox.Location = new Point(177, 275);
            CustomerPhoneTextBox.Margin = new Padding(6, 5, 6, 5);
            CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
            CustomerPhoneTextBox.Size = new Size(406, 32);
            CustomerPhoneTextBox.TabIndex = 42;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Font = new Font("Segoe UI", 11F);
            CustomerNameTextBox.Location = new Point(177, 217);
            CustomerNameTextBox.Margin = new Padding(6, 5, 6, 5);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(406, 32);
            CustomerNameTextBox.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(52, 334);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 40;
            label4.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(52, 275);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 39;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(52, 217);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 38;
            label2.Text = "Name";
            // 
            // AddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 578);
            Controls.Add(CustomerWebsiteTextBox);
            Controls.Add(CustomerEmailTextBox);
            Controls.Add(CustomerFaxTextBox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(CancelAdd);
            Controls.Add(ConfirmAdd);
            Controls.Add(CustomerMobileTextBox);
            Controls.Add(CustomerPhoneTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "AddNewCustomer";
            Text = "AddNewCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CustomerWebsiteTextBox;
        private TextBox CustomerEmailTextBox;
        private TextBox CustomerFaxTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label1;
        private Button CancelAdd;
        private Button ConfirmAdd;
        private TextBox CustomerMobileTextBox;
        private TextBox CustomerPhoneTextBox;
        private TextBox CustomerNameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}