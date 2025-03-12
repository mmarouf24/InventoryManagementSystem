namespace InventoryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Tabs = new TabControl();
            Items = new TabPage();
            AddItem = new Button();
            SearchByItemCode = new Label();
            ItemSearchTextBox = new TextBox();
            DeleteItem = new Button();
            ItemIDComboBox = new ComboBox();
            ItemIdLabel = new Label();
            UnitComboBox = new ComboBox();
            ItemUnitLabel = new Label();
            EditItem = new Button();
            ItemQuantityLabel = new Label();
            ItemCodeLabel = new Label();
            ItemNameLabel = new Label();
            ItemQuantityTextBox = new TextBox();
            ItemCodeTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemsGridView = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            Tabs.SuspendLayout();
            Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(Items);
            Tabs.Controls.Add(tabPage2);
            Tabs.Controls.Add(tabPage3);
            Tabs.Dock = DockStyle.Bottom;
            Tabs.ItemSize = new Size(100, 80);
            Tabs.Location = new Point(0, 113);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1366, 629);
            Tabs.TabIndex = 0;
            // 
            // Items
            // 
            Items.BorderStyle = BorderStyle.FixedSingle;
            Items.Controls.Add(AddItem);
            Items.Controls.Add(SearchByItemCode);
            Items.Controls.Add(ItemSearchTextBox);
            Items.Controls.Add(DeleteItem);
            Items.Controls.Add(ItemIDComboBox);
            Items.Controls.Add(ItemIdLabel);
            Items.Controls.Add(UnitComboBox);
            Items.Controls.Add(ItemUnitLabel);
            Items.Controls.Add(EditItem);
            Items.Controls.Add(ItemQuantityLabel);
            Items.Controls.Add(ItemCodeLabel);
            Items.Controls.Add(ItemNameLabel);
            Items.Controls.Add(ItemQuantityTextBox);
            Items.Controls.Add(ItemCodeTextBox);
            Items.Controls.Add(ItemNameTextBox);
            Items.Controls.Add(ItemsGridView);
            Items.Font = new Font("Segoe UI", 11F);
            Items.Location = new Point(4, 84);
            Items.Name = "Items";
            Items.Padding = new Padding(3);
            Items.Size = new Size(1358, 541);
            Items.TabIndex = 0;
            Items.Text = "Items";
            Items.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            AddItem.Location = new Point(1006, 13);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(310, 55);
            AddItem.TabIndex = 15;
            AddItem.Text = "Add Item";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // SearchByItemCode
            // 
            SearchByItemCode.AutoSize = true;
            SearchByItemCode.Location = new Point(1089, 100);
            SearchByItemCode.Name = "SearchByItemCode";
            SearchByItemCode.Size = new Size(143, 25);
            SearchByItemCode.TabIndex = 14;
            SearchByItemCode.Text = "Search By Code";
            // 
            // ItemSearchTextBox
            // 
            ItemSearchTextBox.Location = new Point(1006, 144);
            ItemSearchTextBox.Name = "ItemSearchTextBox";
            ItemSearchTextBox.Size = new Size(310, 32);
            ItemSearchTextBox.TabIndex = 13;
            ItemSearchTextBox.KeyUp += ItemSearchTextBox_KeyUp;
            // 
            // DeleteItem
            // 
            DeleteItem.Location = new Point(631, 121);
            DeleteItem.Name = "DeleteItem";
            DeleteItem.Size = new Size(150, 55);
            DeleteItem.TabIndex = 12;
            DeleteItem.Text = "Delete Item";
            DeleteItem.UseVisualStyleBackColor = true;
            DeleteItem.Click += DeleteItem_Click;
            // 
            // ItemIDComboBox
            // 
            ItemIDComboBox.FormattingEnabled = true;
            ItemIDComboBox.Location = new Point(140, 24);
            ItemIDComboBox.Name = "ItemIDComboBox";
            ItemIDComboBox.Size = new Size(342, 33);
            ItemIDComboBox.TabIndex = 11;
            ItemIDComboBox.SelectedIndexChanged += ItemIDComboBox_SelectedIndexChanged;
            // 
            // ItemIdLabel
            // 
            ItemIdLabel.AutoSize = true;
            ItemIdLabel.Location = new Point(43, 24);
            ItemIdLabel.Name = "ItemIdLabel";
            ItemIdLabel.Size = new Size(72, 25);
            ItemIdLabel.TabIndex = 10;
            ItemIdLabel.Text = "Item ID";
            // 
            // UnitComboBox
            // 
            UnitComboBox.FormattingEnabled = true;
            UnitComboBox.Items.AddRange(new object[] { "Kilogram (kg)", "Piece" });
            UnitComboBox.Location = new Point(633, 75);
            UnitComboBox.Name = "UnitComboBox";
            UnitComboBox.Size = new Size(148, 33);
            UnitComboBox.TabIndex = 9;
            // 
            // ItemUnitLabel
            // 
            ItemUnitLabel.AutoSize = true;
            ItemUnitLabel.Location = new Point(515, 78);
            ItemUnitLabel.Name = "ItemUnitLabel";
            ItemUnitLabel.Size = new Size(47, 25);
            ItemUnitLabel.TabIndex = 8;
            ItemUnitLabel.Text = "Unit";
            // 
            // EditItem
            // 
            EditItem.Location = new Point(787, 121);
            EditItem.Name = "EditItem";
            EditItem.Size = new Size(150, 55);
            EditItem.TabIndex = 7;
            EditItem.Text = "Edit Item";
            EditItem.UseVisualStyleBackColor = true;
            EditItem.Click += EditItem_Click;
            // 
            // ItemQuantityLabel
            // 
            ItemQuantityLabel.AutoSize = true;
            ItemQuantityLabel.Location = new Point(515, 28);
            ItemQuantityLabel.Name = "ItemQuantityLabel";
            ItemQuantityLabel.Size = new Size(84, 25);
            ItemQuantityLabel.TabIndex = 6;
            ItemQuantityLabel.Text = "Quantity";
            // 
            // ItemCodeLabel
            // 
            ItemCodeLabel.AutoSize = true;
            ItemCodeLabel.Location = new Point(43, 75);
            ItemCodeLabel.Name = "ItemCodeLabel";
            ItemCodeLabel.Size = new Size(56, 25);
            ItemCodeLabel.TabIndex = 5;
            ItemCodeLabel.Text = "Code";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(43, 133);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(62, 25);
            ItemNameLabel.TabIndex = 4;
            ItemNameLabel.Text = "Name";
            // 
            // ItemQuantityTextBox
            // 
            ItemQuantityTextBox.Location = new Point(631, 25);
            ItemQuantityTextBox.Name = "ItemQuantityTextBox";
            ItemQuantityTextBox.Size = new Size(310, 32);
            ItemQuantityTextBox.TabIndex = 3;
            // 
            // ItemCodeTextBox
            // 
            ItemCodeTextBox.Location = new Point(140, 75);
            ItemCodeTextBox.Name = "ItemCodeTextBox";
            ItemCodeTextBox.Size = new Size(342, 32);
            ItemCodeTextBox.TabIndex = 2;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(140, 133);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(342, 32);
            ItemNameTextBox.TabIndex = 1;
            // 
            // ItemsGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkCyan;
            ItemsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ItemsGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Teal;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ItemsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ItemsGridView.Dock = DockStyle.Bottom;
            ItemsGridView.EnableHeadersVisualStyles = false;
            ItemsGridView.Location = new Point(3, 213);
            ItemsGridView.Name = "ItemsGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ItemsGridView.RowHeadersWidth = 51;
            ItemsGridView.Size = new Size(1350, 323);
            ItemsGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 84);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1358, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 84);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1358, 541);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 107);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(444, 23);
            label1.Name = "label1";
            label1.Size = new Size(382, 69);
            label1.TabIndex = 0;
            label1.Text = "My Warehouse";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            CancelButton = EditItem;
            ClientSize = new Size(1366, 742);
            Controls.Add(panel1);
            Controls.Add(Tabs);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warehouse";
            Tabs.ResumeLayout(false);
            Items.ResumeLayout(false);
            Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage Items;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView ItemsGridView;
        private Button EditItem;
        private Label ItemQuantityLabel;
        private Label ItemCodeLabel;
        private Label ItemNameLabel;
        private TextBox ItemQuantityTextBox;
        private TextBox ItemCodeTextBox;
        private TextBox ItemNameTextBox;
        private Label ItemUnitLabel;
        private ComboBox UnitComboBox;
        private ComboBox ItemIDComboBox;
        private Label ItemIdLabel;
        private Panel panel1;
        private Label label1;
        private Button DeleteItem;
        private TextBox ItemSearchTextBox;
        private Label SearchByItemCode;
        private Button AddItem;
    }
}
