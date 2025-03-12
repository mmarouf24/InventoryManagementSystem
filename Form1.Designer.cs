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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            Warehouse = new TabPage();
            AddWarehouse = new Button();
            label2 = new Label();
            WarehouseSearchTextBox = new TextBox();
            DeleteWarehouse = new Button();
            WarehouseIdComboBox = new ComboBox();
            label3 = new Label();
            EditWarehouse = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            WarehouseManagerTextBox = new TextBox();
            WarehouseNameTextBox = new TextBox();
            WarehouseAddressTextBox = new TextBox();
            WarehousesGridview = new DataGridView();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            Tabs.SuspendLayout();
            Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGridView).BeginInit();
            Warehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarehousesGridview).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(Items);
            Tabs.Controls.Add(Warehouse);
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
            // Warehouse
            // 
            Warehouse.Controls.Add(AddWarehouse);
            Warehouse.Controls.Add(label2);
            Warehouse.Controls.Add(WarehouseSearchTextBox);
            Warehouse.Controls.Add(DeleteWarehouse);
            Warehouse.Controls.Add(WarehouseIdComboBox);
            Warehouse.Controls.Add(label3);
            Warehouse.Controls.Add(EditWarehouse);
            Warehouse.Controls.Add(label5);
            Warehouse.Controls.Add(label6);
            Warehouse.Controls.Add(label7);
            Warehouse.Controls.Add(WarehouseManagerTextBox);
            Warehouse.Controls.Add(WarehouseNameTextBox);
            Warehouse.Controls.Add(WarehouseAddressTextBox);
            Warehouse.Controls.Add(WarehousesGridview);
            Warehouse.Location = new Point(4, 84);
            Warehouse.Name = "Warehouse";
            Warehouse.Padding = new Padding(3);
            Warehouse.Size = new Size(1358, 541);
            Warehouse.TabIndex = 1;
            Warehouse.Text = "Warehouses";
            Warehouse.UseVisualStyleBackColor = true;
            // 
            // AddWarehouse
            // 
            AddWarehouse.Location = new Point(1006, 8);
            AddWarehouse.Name = "AddWarehouse";
            AddWarehouse.Size = new Size(310, 55);
            AddWarehouse.TabIndex = 31;
            AddWarehouse.Text = "Add Warehouse";
            AddWarehouse.UseVisualStyleBackColor = true;
            AddWarehouse.Click += AddWarehouse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1113, 93);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 30;
            label2.Text = "Search By Name";
            // 
            // WarehouseSearchTextBox
            // 
            WarehouseSearchTextBox.Location = new Point(1006, 128);
            WarehouseSearchTextBox.Name = "WarehouseSearchTextBox";
            WarehouseSearchTextBox.Size = new Size(310, 27);
            WarehouseSearchTextBox.TabIndex = 29;
            WarehouseSearchTextBox.KeyUp += WarehouseSearchTextBox_KeyUp;
            // 
            // DeleteWarehouse
            // 
            DeleteWarehouse.Location = new Point(631, 93);
            DeleteWarehouse.Name = "DeleteWarehouse";
            DeleteWarehouse.Size = new Size(150, 55);
            DeleteWarehouse.TabIndex = 28;
            DeleteWarehouse.Text = "Delete Warehouse";
            DeleteWarehouse.UseVisualStyleBackColor = true;
            DeleteWarehouse.Click += DeleteWarehouse_Click;
            // 
            // WarehouseIdComboBox
            // 
            WarehouseIdComboBox.FormattingEnabled = true;
            WarehouseIdComboBox.Location = new Point(150, 15);
            WarehouseIdComboBox.Name = "WarehouseIdComboBox";
            WarehouseIdComboBox.Size = new Size(342, 28);
            WarehouseIdComboBox.TabIndex = 27;
            WarehouseIdComboBox.SelectedIndexChanged += WarehouseIdComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 19);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 26;
            label3.Text = "Warehouse ID";
            // 
            // EditWarehouse
            // 
            EditWarehouse.Location = new Point(791, 93);
            EditWarehouse.Name = "EditWarehouse";
            EditWarehouse.Size = new Size(150, 55);
            EditWarehouse.TabIndex = 23;
            EditWarehouse.Text = "Edit Warehouse";
            EditWarehouse.UseVisualStyleBackColor = true;
            EditWarehouse.Click += EditWarehouse_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 23);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 22;
            label5.Text = "Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 70);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 21;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 128);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 20;
            label7.Text = "Address";
            // 
            // WarehouseManagerTextBox
            // 
            WarehouseManagerTextBox.Location = new Point(631, 20);
            WarehouseManagerTextBox.Name = "WarehouseManagerTextBox";
            WarehouseManagerTextBox.Size = new Size(310, 27);
            WarehouseManagerTextBox.TabIndex = 19;
            // 
            // WarehouseNameTextBox
            // 
            WarehouseNameTextBox.Location = new Point(150, 70);
            WarehouseNameTextBox.Name = "WarehouseNameTextBox";
            WarehouseNameTextBox.Size = new Size(342, 27);
            WarehouseNameTextBox.TabIndex = 18;
            // 
            // WarehouseAddressTextBox
            // 
            WarehouseAddressTextBox.Location = new Point(150, 128);
            WarehouseAddressTextBox.Name = "WarehouseAddressTextBox";
            WarehouseAddressTextBox.Size = new Size(342, 27);
            WarehouseAddressTextBox.TabIndex = 17;
            // 
            // WarehousesGridview
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkCyan;
            WarehousesGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            WarehousesGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WarehousesGridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            WarehousesGridview.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Teal;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Teal;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            WarehousesGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            WarehousesGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            WarehousesGridview.DefaultCellStyle = dataGridViewCellStyle7;
            WarehousesGridview.Dock = DockStyle.Bottom;
            WarehousesGridview.EnableHeadersVisualStyles = false;
            WarehousesGridview.Location = new Point(3, 215);
            WarehousesGridview.Name = "WarehousesGridview";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            WarehousesGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            WarehousesGridview.RowHeadersWidth = 51;
            WarehousesGridview.Size = new Size(1352, 323);
            WarehousesGridview.TabIndex = 16;
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
            Warehouse.ResumeLayout(false);
            Warehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WarehousesGridview).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage Items;
        private TabPage Warehouse;
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
        private Button AddWarehouse;
        private Label label2;
        private TextBox WarehouseSearchTextBox;
        private Button DeleteWarehouse;
        private ComboBox WarehouseIdComboBox;
        private Label label3;
        private Button EditWarehouse;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox WarehouseManagerTextBox;
        private TextBox WarehouseNameTextBox;
        private TextBox WarehouseAddressTextBox;
        private DataGridView WarehousesGridview;
    }
}
