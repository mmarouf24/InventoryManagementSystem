using InventoryManagementSystem.Screens;
using InventoryManagementSystem.Tables;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        EFModel _Context;
        public Form1()
        {
            InitializeComponent();

            _Context = new EFModel();
            _Context.Database.EnsureCreated();

            //Warehouses Data
            foreach (var warehouse in _Context.Warehouses.ToList())
            {
                WarehouseIdComboBox.Items.Add(warehouse.WarehouseID);
            }
            if (WarehouseIdComboBox.Items.Count > 0)
                WarehouseIdComboBox.SelectedIndex = 0;
            ConfigWarehousesTextBoxes();
            WarehouseIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadWarehouseData();


            //Items Data
            foreach (var item in _Context.Items.ToList())
            {
                ItemIDComboBox.Items.Add(item.ItemID);
            }
            LoadItemsData();
            if (ItemIDComboBox.Items.Count > 0)
                ItemIDComboBox.SelectedIndex = 0;
            ConfigItemsTextBoxes();
            UnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void EditItem_Click(object sender, EventArgs e)
        {


            string name = ItemNameTextBox.Text.Trim();
            string code = ItemCodeTextBox.Text.Trim();
            int quantity = int.Parse(ItemQuantityTextBox.Text.Trim());
            string unit = UnitComboBox.SelectedItem.ToString();

            if (!int.TryParse(ItemQuantityTextBox.Text, out int quan))
            {
                MessageBox.Show("Please Enter a Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ItemIDComboBox.Items.Count > 0)
            {
                bool isCodeExists = _Context.Items.Any(i => i.Code == code && i.ItemID != int.Parse(ItemIDComboBox.SelectedItem.ToString()));

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Code you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedItem = _Context.Items.Find(ItemIDComboBox.SelectedItem);


                ExistedItem.Code = code;
                ExistedItem.Name = name;
                ExistedItem.Quantity = quantity;
                ExistedItem.Unit = unit;
                _Context.SaveChanges();
                MessageBox.Show("Successfully Edited Item !", "Success", MessageBoxButtons.OK);
                LoadItemsData();
            }
            else
                MessageBox.Show("No Items To Edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }



        private void ItemIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigItemsTextBoxes();
        }
        private void ConfigItemsTextBoxes()
        {
            var item = _Context.Items.Find(ItemIDComboBox.SelectedItem);
            if (item != null)
            {
                ItemCodeTextBox.Text = item.Code;
                ItemNameTextBox.Text = item.Name;
                ItemQuantityTextBox.Text = item.Quantity.ToString();

                UnitComboBox.SelectedItem = item.Unit;
            }
        }
        private void ConfigWarehousesTextBoxes()
        {
            var item = _Context.Warehouses.Find(WarehouseIdComboBox.SelectedItem);
            if (item != null)
            {
                WarehouseNameTextBox.Text = item.Name;
                WarehouseAddressTextBox.Text = item.Address;
                WarehouseManagerTextBox.Text = item.Manager;
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (ItemIDComboBox.Items.Count > 0)
            {
                var ItemToDelete = _Context.Items.Find(ItemIDComboBox.SelectedItem);
                _Context.Items.Remove(ItemToDelete);
                _Context.SaveChanges();
                MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK);
                ItemIDComboBox.Items.Remove(ItemIDComboBox.SelectedItem);
                if (ItemIDComboBox.Items.Count > 0)
                    ItemIDComboBox.SelectedIndex = 0;
                ConfigItemsTextBoxes();
                LoadItemsData();
            }
            else
                MessageBox.Show("No Items To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        private void ItemSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string Term = ItemSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(Term))
            {
                ItemsGridView.DataSource = _Context.Items
                    .Select(i => new { i.ItemID, i.Code, i.Name, i.Quantity, i.Unit })
                    .ToList();
                return;
            }

            var ExistedItems = _Context.Items
                            .Where(i => i.Name.ToLower().Contains(Term))
                            .Select(i => new { i.ItemID, i.Code, i.Name, i.Quantity, i.Unit })
                            .ToList();
            if (ExistedItems.Any())
                ItemsGridView.DataSource = ExistedItems;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            AddNewItem addForm = new AddNewItem();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                ItemIDComboBox.Items.Add(_Context.Items.Order().Last().ItemID);
                LoadItemsData();
            }
        }
        private void LoadItemsData()
        {
            ItemsGridView.DataSource = _Context.Items.Select(i => new { i.ItemID, i.Code, i.Name, i.Quantity, i.Unit }).ToList();

        }
        private void LoadWarehouseData()
        {
            WarehousesGridview.DataSource = _Context.Warehouses.Select(i => new { i.WarehouseID, i.Name, i.Address, i.Manager }).ToList();

        }

        private void EditWarehouse_Click(object sender, EventArgs e)
        {
            string name = WarehouseNameTextBox.Text.Trim();
            string address = WarehouseAddressTextBox.Text.Trim();
            string manager = WarehouseManagerTextBox.Text.Trim();

            if (WarehouseIdComboBox.Items.Count > 0)
            {
                bool isCodeExists = _Context.Warehouses.Any(i => i.Name == name && i.WarehouseID != int.Parse(WarehouseIdComboBox.SelectedItem.ToString()));

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The name you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedWarehouse = _Context.Warehouses.Find(WarehouseIdComboBox.SelectedItem);


                ExistedWarehouse.Name = name;
                ExistedWarehouse.Address = address;
                ExistedWarehouse.Manager = manager;
                _Context.SaveChanges();
                MessageBox.Show("Successfully Edited WareHouse !", "Success", MessageBoxButtons.OK);
                LoadWarehouseData();
            }
            else
                MessageBox.Show("No Warehouses To Edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DeleteWarehouse_Click(object sender, EventArgs e)
        {
            if (WarehouseIdComboBox.Items.Count > 0)
            {
                var WarehouseToDelete = _Context.Warehouses.Find(WarehouseIdComboBox.SelectedItem);
                _Context.Warehouses.Remove(WarehouseToDelete);
                _Context.SaveChanges();
                MessageBox.Show("Warehouse deleted successfully!", "Success", MessageBoxButtons.OK);
                WarehouseIdComboBox.Items.Remove(WarehouseIdComboBox.SelectedItem);
                if (WarehouseIdComboBox.Items.Count > 0)
                    WarehouseIdComboBox.SelectedIndex = 0;
                ConfigWarehousesTextBoxes();
                LoadWarehouseData();
            }
            else
                MessageBox.Show("No Warehouses To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void WarehouseSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string Term = WarehouseSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(Term))
            {
                WarehousesGridview.DataSource = _Context.Warehouses
                    .Select(i => new { i.WarehouseID, i.Name, i.Address, i.Manager })
                    .ToList();
                return;
            }

            var ExistedWarehouses = _Context.Warehouses
                            .Where(i => i.Name.ToLower().Contains(Term))
                            .Select(i => new { i.WarehouseID, i.Name, i.Address, i.Manager })
                            .ToList();
            if (ExistedWarehouses.Any())
                WarehousesGridview.DataSource = ExistedWarehouses;
        }

        private void AddWarehouse_Click(object sender, EventArgs e)
        {
            AddNewWarehouse addForm = new AddNewWarehouse();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                WarehouseIdComboBox.Items.Add(_Context.Warehouses.Order().Last().WarehouseID);
                LoadWarehouseData();
            }
        }

        private void WarehouseIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConfigWarehousesTextBoxes();
        }
    }
}
