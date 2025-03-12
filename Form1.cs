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
            LoadWarehouseData();
            WarehouseIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            //Items Data
            foreach (var item in _Context.Items.ToList())
            {
                ItemIDComboBox.Items.Add(item.ItemID);
            }
            if (ItemIDComboBox.Items.Count > 0)
                ItemIDComboBox.SelectedIndex = 0;
            ConfigItemsTextBoxes();
            LoadItemsData();
            UnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Suppliers Data
            foreach (var supplier in _Context.Suppliers.ToList())
            {
                SupplierIdComboBox.Items.Add(supplier.SupplierID);
            }
            if (SupplierIdComboBox.Items.Count > 0)
                SupplierIdComboBox.SelectedIndex = 0;
            ConfigSuppliersTextBoxes();
            LoadSuppliersData();
            SupplierIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Customers Data
            foreach (var customer in _Context.Customers.ToList())
            {
                CustomerIdComboBox.Items.Add(customer.CustomerID);
            }
            if (CustomerIdComboBox.Items.Count > 0)
                CustomerIdComboBox.SelectedIndex = 0;
            ConfigCustomersTextBoxes();
            LoadCustomersData();
            CustomerIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;



        }

        //Item Start
        #region Item
        private void LoadItemsData()
        {
            ItemsGridView.DataSource = _Context.Items.Select(i => new { i.ItemID, i.Code, i.Name, i.Quantity, i.Unit }).ToList();

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
        #endregion
        //Item End

        //Warehouse Start
        #region Warehouse
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
        #endregion
        //Warehouse End

        //Supplier Start
        #region Supplier
        private void ConfigSuppliersTextBoxes()
        {
            var item = _Context.Suppliers.Find(SupplierIdComboBox.SelectedItem);
            if (item != null)
            {
                SupplierNameTextBox.Text = item.Name;
                SupplierPhoneTextBox.Text = item.Phone;
                SupplierMobileTextBox.Text = item.Mobile;
                SupplierFaxTextBox.Text = item.Fax;
                SupplierEmailTextBox.Text = item.Email;
                SupplierWebsiteTextBox.Text = item.Website;
            }
        }
        private void LoadSuppliersData()
        {
            SupplierGridView.DataSource = _Context.Suppliers
                                        .Select(i => new { i.SupplierID, i.Name, i.Phone, i.Mobile, i.Fax, i.Email, i.Website })
                                        .ToList();

        }

        private void EditSupplier_Click(object sender, EventArgs e)
        {
            string name = SupplierNameTextBox.Text.Trim();
            string phone = SupplierPhoneTextBox.Text.Trim();
            string mobile = SupplierMobileTextBox.Text.Trim();
            string fax = SupplierFaxTextBox.Text.Trim();
            string email = SupplierEmailTextBox.Text.Trim();
            string website = SupplierWebsiteTextBox.Text.Trim();

            if (SupplierIdComboBox.Items.Count > 0)
            {
                bool isCodeExists = _Context.Suppliers.Any(i => i.Mobile == mobile && i.SupplierID != int.Parse(SupplierIdComboBox.SelectedItem.ToString()));

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Phone you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedSupplier = _Context.Suppliers.Find(SupplierIdComboBox.SelectedItem);


                ExistedSupplier.Name = name;
                ExistedSupplier.Phone = phone;
                ExistedSupplier.Mobile = mobile;
                ExistedSupplier.Fax = fax;
                ExistedSupplier.Email = email;
                ExistedSupplier.Website = website;
                _Context.SaveChanges();
                MessageBox.Show("Successfully Edited Supplier !", "Success", MessageBoxButtons.OK);
                LoadSuppliersData();
            }
            else
                MessageBox.Show("No Suppliers To Edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            if (SupplierIdComboBox.Items.Count > 0)
            {
                var SupplierToDelete = _Context.Suppliers.Find(SupplierIdComboBox.SelectedItem);
                _Context.Suppliers.Remove(SupplierToDelete);
                _Context.SaveChanges();
                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK);
                SupplierIdComboBox.Items.Remove(SupplierIdComboBox.SelectedItem);
                if (SupplierIdComboBox.Items.Count > 0)
                    SupplierIdComboBox.SelectedIndex = 0;
                ConfigSuppliersTextBoxes();
                LoadSuppliersData();
            }
            else
                MessageBox.Show("No Supplierss To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SupplierSearchNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string Term = SupplierSearchNameTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(Term))
            {
                SupplierGridView.DataSource = _Context.Suppliers
                    .Select(i => new { i.SupplierID, i.Name, i.Phone, i.Mobile, i.Fax, i.Email, i.Website })
                    .ToList();
                return;
            }

            var ExistedSuppliers = _Context.Suppliers
                            .Where(i => i.Name.ToLower().Contains(Term))
                            .Select(i => new { i.SupplierID, i.Name, i.Phone, i.Mobile, i.Fax, i.Email, i.Website })
                            .ToList();
            if (ExistedSuppliers.Any())
                SupplierGridView.DataSource = ExistedSuppliers;
        }

        private void SupplierIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigSuppliersTextBoxes();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            AddNewSupplier addForm = new AddNewSupplier();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                SupplierIdComboBox.Items.Add(_Context.Suppliers.Order().Last().SupplierID);
                LoadSuppliersData();
            }
        }
        #endregion
        //Supplier End


        //Customer Start
        #region Customer
        private void ConfigCustomersTextBoxes()
        {
            var item = _Context.Customers.Find(CustomerIdComboBox.SelectedItem);
            if (item != null)
            {
                CustomerNameTextBox.Text = item.Name;
                CustomerPhoneTextBox.Text = item.Phone;
                CustomerMobileTextBox.Text = item.Mobile;
                CustomerFaxTextBox.Text = item.Fax;
                CustomerEmailTextBox.Text = item.Email;
                CustomerWebsiteTextBox.Text = item.Website;
            }
        }
        private void LoadCustomersData()
        {
            CustomersGridView.DataSource = _Context.Customers
                                        .Select(i => new { i.CustomerID, i.Name, i.Phone, i.Mobile, i.Fax, i.Email, i.Website })
                                        .ToList();
        }

        private void EditCustomer_Click(object sender, EventArgs e)
        {
            string name = CustomerNameTextBox.Text.Trim();
            string phone = CustomerPhoneTextBox.Text.Trim();
            string mobile = CustomerMobileTextBox.Text.Trim();
            string fax = CustomerFaxTextBox.Text.Trim();
            string email = CustomerEmailTextBox.Text.Trim();
            string website = CustomerWebsiteTextBox.Text.Trim();

            if (CustomerIdComboBox.Items.Count > 0)
            {
                bool isCodeExists = _Context.Customers.Any(i => i.Mobile == mobile && i.CustomerID != int.Parse(CustomerIdComboBox.SelectedItem.ToString()));

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Phone you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedCustomer = _Context.Customers.Find(CustomerIdComboBox.SelectedItem);


                ExistedCustomer.Name = name;
                ExistedCustomer.Phone = phone;
                ExistedCustomer.Mobile = mobile;
                ExistedCustomer.Fax = fax;
                ExistedCustomer.Email = email;
                ExistedCustomer.Website = website;
                _Context.SaveChanges();
                MessageBox.Show("Successfully Edited Customer !", "Success", MessageBoxButtons.OK);
                LoadCustomersData();
            }
            else
                MessageBox.Show("No Customers To Edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerIdComboBox.Items.Count > 0)
            {
                var CustomerToDelete = _Context.Customers.Find(CustomerIdComboBox.SelectedItem);
                _Context.Customers.Remove(CustomerToDelete);
                _Context.SaveChanges();
                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK);
                CustomerIdComboBox.Items.Remove(CustomerIdComboBox.SelectedItem);
                if (CustomerIdComboBox.Items.Count > 0)
                    CustomerIdComboBox.SelectedIndex = 0;
                ConfigCustomersTextBoxes();
                LoadCustomersData();
            }
            else
                MessageBox.Show("No Customers To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CustomerSearchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string Term = CustomerSearchNameTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(Term))
            {
                CustomersGridView.DataSource = _Context.Customers
                    .Select(i => new { i.CustomerID, i.Name, i.Phone, i.Mobile, i.Fax, i.Email, i.Website })
                    .ToList();
                return;
            }

            var ExistedCustomers = _Context.Customers
                            .Where(i => i.Name.ToLower().Contains(Term))
                            .Select(i => new { i.CustomerID, i.Name, i.Phone, i.Mobile, i.Fax, i.Email, i.Website })
                            .ToList();
            if (ExistedCustomers.Any())
                CustomersGridView.DataSource = ExistedCustomers;
        }

        private void CustomerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigCustomersTextBoxes();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer addForm = new AddNewCustomer();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                CustomerIdComboBox.Items.Add(_Context.Customers.Order().Last().CustomerID);
                LoadCustomersData();
            }
        }


        #endregion
        //Customer End


    }
}
