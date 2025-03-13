using InventoryManagementSystem.Screens;
using InventoryManagementSystem.Tables;
using Microsoft.EntityFrameworkCore;

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

            //Warehouses Data start
            foreach (var warehouse in _Context.Warehouses.ToList())
            {
                WarehouseIdComboBox.Items.Add(warehouse.WarehouseID);
            }
            if (WarehouseIdComboBox.Items.Count > 0)
                WarehouseIdComboBox.SelectedIndex = 0;
            ConfigWarehousesTextBoxes();
            LoadWarehouseData();
            WarehouseIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //Warehouses Data End

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

            //Supply Order Data
            foreach (var supplyOrder in _Context.SupplyOrders.ToList())
            {
                SupplyOrderIdComboBox.Items.Add(supplyOrder.SupplyOrderID);
                SupplyOrdersWaresComboBox.Items.Add(supplyOrder.Warehouse.Name);
                SupplyOrderSuppliersComboBox.Items.Add(supplyOrder.Supplier.Name);
            }
            if (SupplyOrderIdComboBox.Items.Count > 0)
                SupplyOrderIdComboBox.SelectedIndex = 0;
            ConfigSupplyOrderTextBoxes();
            LoadSupplyOrdersData();
            SupplyOrderIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SupplyOrdersWaresComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SupplyOrderSuppliersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Release Order Data
            foreach (var releaseOrder in _Context.ReleaseOrders.ToList())
            {
                ReleaseOrderIdComboBox.Items.Add(releaseOrder.ReleaseOrderID);
                ReleaseOrdersWaresComboBox.Items.Add(releaseOrder.Warehouse.Name);
                ReleaseOrderCustomersComboBox.Items.Add(releaseOrder.Customer.Name);
            }
            if (ReleaseOrderIdComboBox.Items.Count > 0)
                ReleaseOrderIdComboBox.SelectedIndex = 0;
            ConfigReleaseOrderTextBoxes();
            LoadReleaseOrdersData();
            ReleaseOrderIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ReleaseOrdersWaresComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ReleaseOrderCustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Transfer Items Data
            foreach (var warehouse in _Context.Warehouses.ToList())
            {
                FromWarehousesComboBox.Items.Add(warehouse.Name);
                ToWarehousesComboBox.Items.Add(warehouse.Name);
            }
            FromWarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToWarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            foreach (var transfer in _Context.StockTransfers.ToList())
            {
                TransferIDComboBox.Items.Add(transfer.TransferID);
               
            }

            if (TransferIDComboBox.Items.Count > 0)
                TransferIDComboBox.SelectedIndex = 0;
            ConfigTransfersTextBoxes();
            LoadTransfersData();
            TransferIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FromWarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToWarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //Item Start
        #region Item
        private void LoadItemsData()
        {
            ItemsGridView.DataSource = _Context.Items.Select(i => new { i.ItemID, i.Code, i.Name, i.Unit }).ToList();

        }

        private void ConfigItemsTextBoxes()
        {
            var item = _Context.Items.Find(ItemIDComboBox.SelectedItem);
            if (item != null)
            {
                ItemCodeTextBox.Text = item.Code;
                ItemNameTextBox.Text = item.Name;


                UnitComboBox.SelectedItem = item.Unit;
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {


            if (ItemIDComboBox.Items.Count > 0)
            {
            string name = ItemNameTextBox.Text.Trim();
            string code = ItemCodeTextBox.Text.Trim();

            string unit = UnitComboBox.SelectedItem.ToString();

                bool isCodeExists = _Context.Items.Any(i => i.Code == code && i.ItemID != int.Parse(ItemIDComboBox.SelectedItem.ToString()));

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Code you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedItem = _Context.Items.Find(ItemIDComboBox.SelectedItem);


                ExistedItem.Code = code;
                ExistedItem.Name = name;

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
                    .Select(i => new { i.ItemID, i.Code, i.Name, i.Unit })
                    .ToList();
                return;
            }

            var ExistedItems = _Context.Items
                            .Where(i => i.Name.ToLower().Contains(Term))
                            .Select(i => new { i.ItemID, i.Code, i.Name, i.Unit })
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
            if (WarehouseIdComboBox.Items.Count > 0)
            {
            string name = WarehouseNameTextBox.Text.Trim();
            string address = WarehouseAddressTextBox.Text.Trim();
            string manager = WarehouseManagerTextBox.Text.Trim();

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
            if (SupplierIdComboBox.Items.Count > 0)
            {
            string name = SupplierNameTextBox.Text.Trim();
            string phone = SupplierPhoneTextBox.Text.Trim();
            string mobile = SupplierMobileTextBox.Text.Trim();
            string fax = SupplierFaxTextBox.Text.Trim();
            string email = SupplierEmailTextBox.Text.Trim();
            string website = SupplierWebsiteTextBox.Text.Trim();

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
            if (CustomerIdComboBox.Items.Count > 0)
            {
            string name = CustomerNameTextBox.Text.Trim();
            string phone = CustomerPhoneTextBox.Text.Trim();
            string mobile = CustomerMobileTextBox.Text.Trim();
            string fax = CustomerFaxTextBox.Text.Trim();
            string email = CustomerEmailTextBox.Text.Trim();
            string website = CustomerWebsiteTextBox.Text.Trim();

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



        //Supply Order Start
        #region Supply_Order
        private void ConfigSupplyOrderTextBoxes()
        {
            var item = _Context.SupplyOrders.Find(SupplyOrderIdComboBox.SelectedItem);
            if (item != null)
            {
                SupplyOrdersWaresComboBox.SelectedItem = item.Warehouse.Name;
                SupplyOrderSuppliersComboBox.SelectedItem = item.Supplier.Name;
                SupplyOrderNumberTextBox.Text = item.OrderNumber;
                SupplyOrderDate.Value = item.OrderDate;

            }
        }
        private void LoadSupplyOrdersData()
        {
            SupplyOrderGridView.DataSource = _Context.SupplyOrders
                                          .Select(i => new
                                          {
                                              i.SupplyOrderID,
                                              WarehouseName = i.Warehouse != null ? i.Warehouse.Name : "N/A",
                                              SupplierName = i.Supplier != null ? i.Supplier.Name : "N/A",
                                              i.OrderNumber,
                                              i.OrderDate,
                                          })
                                        .ToList();

            if (SupplyOrderGridView.Rows.Count > 0)
            {
                SupplyOrderGridView.Rows[0].Selected = true;
                LoadSupplyOrderItems(Convert.ToInt32(SupplyOrderGridView.Rows[0].Cells["SupplyOrderID"].Value));
            }

        }

        private void SupplyOrderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = Convert.ToInt32(SupplyOrderGridView.Rows[e.RowIndex].Cells["SupplyOrderID"].Value);
            LoadSupplyOrderItems(orderId);

        }
        private void LoadSupplyOrderItems(int i)
        {
            if (i >= 0)
            {

                SupplyOrderItemsGridView.DataSource = _Context.SupplyOrderDetails
                                         .Where(d => d.SupplyOrderID == i)
                                         .Select(i => new
                                         {
                                             i.Item.Name,
                                             i.Quantity,
                                             i.ProductionDate,
                                             i.ExpirationPeriod
                                         })
                                          .ToList();

            }
        }

        private void SupplyOrderIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplyOrderIdComboBox.SelectedIndex >= 0)
            {
                LoadSupplyOrderItems(Convert.ToInt32(SupplyOrderIdComboBox.SelectedItem));
            }
            ConfigSupplyOrderTextBoxes();
        }

        private void EditDeleteSupplyOrderItem_Click(object sender, EventArgs e)
        {
            if (SupplyOrderItemsGridView.Rows.Count > 0)
            {
                EditSupplyOrderItem editForm = new EditSupplyOrderItem(Convert.ToInt32(SupplyOrderIdComboBox.SelectedItem));
                editForm.ShowDialog();
                ConfigSupplyOrderTextBoxes();
                LoadSupplyOrdersData();

            }
            else
            {
                MessageBox.Show("No Items in this Order!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SupplyOrderAddItemToExistedOrder_Click(object sender, EventArgs e)
        {
            AddSupplyOrderItem editForm = new AddSupplyOrderItem(Convert.ToInt32(SupplyOrderIdComboBox.SelectedItem));
            editForm.ShowDialog();
            ConfigSupplyOrderTextBoxes();
            LoadSupplyOrdersData();
        }

        private void EditSupplyOrder_Click(object sender, EventArgs e)
        {

            if (SupplyOrderIdComboBox.Items.Count > 0)
            {
            string ordernumber = SupplyOrderNumberTextBox.Text.Trim();
            DateTime orderDate = SupplyOrderDate.Value;

            string warehouse = SupplyOrdersWaresComboBox.SelectedItem.ToString();
            string supplier = SupplyOrderSuppliersComboBox.SelectedItem.ToString();
                bool isCodeExists = _Context.SupplyOrders.Any(i => i.OrderNumber == ordernumber && i.SupplyOrderID != int.Parse(SupplyOrderIdComboBox.SelectedItem.ToString()));

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Order Number you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedOrder = _Context.SupplyOrders.Find(SupplyOrderIdComboBox.SelectedItem);

                var warehouseId = _Context.Warehouses.Where(i => i.Name == warehouse).FirstOrDefault();
                var supplierId = _Context.Suppliers.Where(i => i.Name == supplier).FirstOrDefault();

                ExistedOrder.WarehouseID = warehouseId.WarehouseID;
                ExistedOrder.SupplierID = supplierId.SupplierID;
                ExistedOrder.OrderNumber = ordernumber;
                ExistedOrder.OrderDate = orderDate;
                _Context.SaveChanges();
                MessageBox.Show("Successfully Edited Supply Order !", "Success", MessageBoxButtons.OK);
                LoadSupplyOrdersData();
            }
            else
                MessageBox.Show("No Supply Orders To Edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DeleteSupplyOrder_Click(object sender, EventArgs e)
        {
            if (SupplyOrderIdComboBox.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                       "Delete Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var orderToDelete = _Context.SupplyOrders.Find(SupplyOrderIdComboBox.SelectedItem);
                    var orderItemsToDelete = _Context.SupplyOrderDetails.Where(d => d.SupplyOrderID == Convert.ToInt32(SupplyOrderIdComboBox.SelectedItem)).ToList();

                    _Context.SupplyOrderDetails.RemoveRange(orderItemsToDelete);
                    _Context.SupplyOrders.Remove(orderToDelete);
                    _Context.SaveChanges();
                    MessageBox.Show("Supply Order deleted successfully!", "Success", MessageBoxButtons.OK);
                    SupplyOrderIdComboBox.Items.Remove(SupplyOrderIdComboBox.SelectedItem);
                    if (SupplyOrderIdComboBox.Items.Count > 0)
                        SupplyOrderIdComboBox.SelectedIndex = 0;
                    ConfigSupplyOrderTextBoxes();
                    LoadSupplyOrdersData();
                }
                else
                {

                    MessageBox.Show("Operation canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("No Supply Orders To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddSupplyOrder_Click(object sender, EventArgs e)
        {
            AddNewSupplyOrder addForm = new AddNewSupplyOrder();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                SupplyOrderIdComboBox.Items.Add(_Context.SupplyOrders.Order().Last().SupplyOrderID);
                LoadSupplyOrdersData();

            }
        }
        private void SupplyOrderSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string Term = SupplyOrderSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(Term))
            {
                LoadSupplyOrdersData();
                return;
            }

            var ExistedOrders = _Context.SupplyOrders
                            .Where(i => i.OrderNumber.Contains(Term))
                            .Select(i => new
                            {
                                i.SupplyOrderID,
                                WarehouseName = i.Warehouse != null ? i.Warehouse.Name : "N/A",
                                SupplierName = i.Supplier != null ? i.Supplier.Name : "N/A",
                                i.OrderNumber,
                                i.OrderDate,
                            })
                            .ToList();
            if (ExistedOrders.Any())
                SupplyOrderGridView.DataSource = ExistedOrders;
        }


        #endregion
        //Supply Order End



        //Release Order Start
        #region Release_Order
        private void ConfigReleaseOrderTextBoxes()
        {
            var item = _Context.ReleaseOrders.Find(ReleaseOrderIdComboBox.SelectedItem);
            if (item != null)
            {
                ReleaseOrdersWaresComboBox.SelectedItem = item.Warehouse.Name;
                ReleaseOrderCustomersComboBox.SelectedItem = item.Customer.Name;
                ReleaseOrderNumberTextBox.Text = item.OrderNumber;
                ReleaseOrderDate.Value = item.OrderDate;

            }
        }
        private void LoadReleaseOrdersData()
        {
            ReleaseOrderGridView.DataSource = _Context.ReleaseOrders
                                          .Select(i => new
                                          {
                                              i.ReleaseOrderID,
                                              WarehouseName = i.Warehouse != null ? i.Warehouse.Name : "N/A",
                                              CustomerName = i.Customer != null ? i.Customer.Name : "N/A",
                                              i.OrderNumber,
                                              i.OrderDate,
                                          })
                                        .ToList();

            if (ReleaseOrderGridView.Rows.Count > 0)
            {
                ReleaseOrderGridView.Rows[0].Selected = true;
                LoadReleaseOrderItems(Convert.ToInt32(ReleaseOrderGridView.Rows[0].Cells["ReleaseOrderID"].Value));
            }

        }

        private void ReleaseOrderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = Convert.ToInt32(ReleaseOrderGridView.Rows[e.RowIndex].Cells["ReleaseOrderID"].Value);
            LoadReleaseOrderItems(orderId);

        }
        private void LoadReleaseOrderItems(int i)
        {
            if (i >= 0)
            {

                ReleaseOrderItemsGridView.DataSource = _Context.ReleaseOrderDetails
                                         .Where(d => d.ReleaseOrderID == i)
                                         .Select(i => new
                                         {
                                             i.Item.Name,
                                             i.Quantity,

                                         })
                                          .ToList();

            }
        }

        private void ReleaseOrderIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReleaseOrderIdComboBox.SelectedIndex >= 0)
            {
                LoadReleaseOrderItems(Convert.ToInt32(ReleaseOrderIdComboBox.SelectedItem));
            }
            ConfigReleaseOrderTextBoxes();
        }

        private void EditDeleteReleaseOrderItem_Click(object sender, EventArgs e)
        {
            if (ReleaseOrderItemsGridView.Rows.Count > 0)
            {
                EditReleaseOrderItem editForm = new EditReleaseOrderItem(Convert.ToInt32(ReleaseOrderIdComboBox.SelectedItem));
                editForm.ShowDialog();
                ConfigReleaseOrderTextBoxes();
                LoadReleaseOrdersData();

            }
            else
            {
                MessageBox.Show("No Items in this Order!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ReleaseOrderAddItemToExistedOrder_Click(object sender, EventArgs e)
        {
            AddReleaseOrderItem editForm = new AddReleaseOrderItem(Convert.ToInt32(ReleaseOrderIdComboBox.SelectedItem));
            editForm.ShowDialog();
            ConfigReleaseOrderTextBoxes();
            LoadReleaseOrdersData();
        }

        private void EditReleaseOrder_Click(object sender, EventArgs e)
        {

            if (ReleaseOrderIdComboBox.Items.Count > 0)
            {
            string ordernumber = ReleaseOrderNumberTextBox.Text.Trim();
            DateTime orderDate = ReleaseOrderDate.Value;

            string warehouse = ReleaseOrdersWaresComboBox.SelectedItem.ToString();
            string customer = ReleaseOrderCustomersComboBox.SelectedItem.ToString();
                bool isCodeExists = _Context.ReleaseOrders.Any(i => i.OrderNumber == ordernumber && i.ReleaseOrderID != int.Parse(ReleaseOrderIdComboBox.SelectedItem.ToString()));

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Order Number you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedOrder = _Context.ReleaseOrders.Find(ReleaseOrderIdComboBox.SelectedItem);

                var warehouseId = _Context.Warehouses.Where(i => i.Name == warehouse).FirstOrDefault();
                var customerId = _Context.Customers.Where(i => i.Name == customer).FirstOrDefault();

                ExistedOrder.WarehouseID = warehouseId.WarehouseID;
                ExistedOrder.CustomerID = customerId.CustomerID;
                ExistedOrder.OrderNumber = ordernumber;
                ExistedOrder.OrderDate = orderDate;
                _Context.SaveChanges();
                MessageBox.Show("Successfully Edited Release Order !", "Success", MessageBoxButtons.OK);
                LoadReleaseOrdersData();
            }
            else
                MessageBox.Show("No Release Orders To Edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DeleteReleaseOrder_Click(object sender, EventArgs e)
        {
            if (ReleaseOrderIdComboBox.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                       "Delete Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var orderToDelete = _Context.ReleaseOrders.Find(ReleaseOrderIdComboBox.SelectedItem);
                    var orderItemsToDelete = _Context.ReleaseOrderDetails.Where(d => d.ReleaseOrderID == Convert.ToInt32(ReleaseOrderIdComboBox.SelectedItem)).ToList();

                    _Context.ReleaseOrderDetails.RemoveRange(orderItemsToDelete);
                    _Context.ReleaseOrders.Remove(orderToDelete);
                    _Context.SaveChanges();
                    MessageBox.Show("Release Order deleted successfully!", "Success", MessageBoxButtons.OK);
                    ReleaseOrderIdComboBox.Items.Remove(ReleaseOrderIdComboBox.SelectedItem);
                    if (ReleaseOrderIdComboBox.Items.Count > 0)
                        ReleaseOrderIdComboBox.SelectedIndex = 0;
                    ConfigReleaseOrderTextBoxes();
                    LoadReleaseOrdersData();
                }
                else
                {

                    MessageBox.Show("Operation canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("No Release Orders To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddReleaseOrder_Click(object sender, EventArgs e)
        {
            AddNewReleaseOrder addForm = new AddNewReleaseOrder();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                ReleaseOrderIdComboBox.Items.Add(_Context.ReleaseOrders.Order().Last().ReleaseOrderID);
                LoadReleaseOrdersData();
            }
        }

        private void ReleaseOrderSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string Term = ReleaseOrderSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(Term))
            {
                LoadReleaseOrdersData();
                return;
            }

            var ExistedOrders = _Context.ReleaseOrders
                            .Where(i => i.OrderNumber.Contains(Term))
                            .Select(i => new
                            {
                                i.ReleaseOrderID,
                                WarehouseName = i.Warehouse != null ? i.Warehouse.Name : "N/A",
                                CustomerName = i.Customer != null ? i.Customer.Name : "N/A",
                                i.OrderNumber,
                                i.OrderDate,
                            })
                            .ToList();
            if (ExistedOrders.Any())
                ReleaseOrderGridView.DataSource = ExistedOrders;
        }




        #endregion
        //Release Order End


        //Transfer Items Start
        #region Transfer_Items
        private void ConfigTransfersTextBoxes()
        {
            var item = _Context.StockTransfers.Find(TransferIDComboBox.SelectedItem);
            if (item != null)
            {
                FromWarehousesComboBox.SelectedItem = item.FromWarehouse.Name;
                ToWarehousesComboBox.SelectedItem = item.ToWarehouse.Name;
                TransferDateItem.Value = item.TransferDate;

            }
        }
        private void LoadTransfersData()
        {
            TransferGridView.DataSource = _Context.StockTransfers
                                          .Select(i => new
                                          {
                                              i.TransferID,
                                              From = i.FromWarehouse.Name != null ? i.FromWarehouse.Name : "N/A",
                                              To = i.ToWarehouse.Name != null ? i.ToWarehouse.Name : "N/A",
                                              i.TransferDate,

                                          })
                                        .ToList();

            if (TransferGridView.Rows.Count > 0)
            {
                TransferGridView.Rows[0].Selected = true;
                LoadTransferItems(Convert.ToInt32(TransferGridView.Rows[0].Cells["TransferID"].Value));
            }

        }
        private void LoadTransferItems(int i)
        {
            if (i >= 0)
            {

                TransferDetailsGridView.DataSource = _Context.StockTransferDetails
                                         .Where(d => d.TransferID == i)
                                         .Select(m => new
                                         {
                                             
                                             m.Item.Name,
                                             m.Quantity,
                                             SUpplier = m.Supplier.Name,
                                             m.ProductionDate,
                                             m.ExpirationPeriod

                                         })
                                          .ToList();

            }
        }

        private void TransferGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int transferId = Convert.ToInt32(TransferGridView.Rows[e.RowIndex].Cells["TransferID"].Value);
            LoadTransferItems(transferId);
        }

        private void TransferIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransferIDComboBox.SelectedIndex >= 0)
            {
                LoadTransferItems(Convert.ToInt32(TransferIDComboBox.SelectedItem));
            }
            ConfigTransfersTextBoxes();
        }

        private void EditDeleteItemTransfer_Click(object sender, EventArgs e)
        {
            if (TransferDetailsGridView.Rows.Count > 0)
            {
                EditTransferItem editForm = new EditTransferItem(Convert.ToInt32(TransferIDComboBox.SelectedItem));
                editForm.ShowDialog();
                ConfigTransfersTextBoxes();
                LoadTransfersData();

            }
            else
            {
                MessageBox.Show("No Items in this Order!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddItemToTransfer_Click(object sender, EventArgs e)
        {
            AddNewItemToTransfer editForm = new AddNewItemToTransfer(Convert.ToInt32(TransferIDComboBox.SelectedItem));
            editForm.ShowDialog();
            ConfigTransfersTextBoxes();
            LoadTransfersData();
        }

        private void EditTransfer_Click(object sender, EventArgs e)
        {

            if (TransferIDComboBox.Items.Count > 0)
            {
                DateTime transferDate = TransferDateItem.Value;

                string fromWarehouse = FromWarehousesComboBox.SelectedItem.ToString();
                string toWarehouse =ToWarehousesComboBox.SelectedItem.ToString();
                if(fromWarehouse==toWarehouse)
                {
                    MessageBox.Show("Editing Failed!, Source and Distination cant be one", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ConfigTransfersTextBoxes();
                    return;
                }
                bool isCodeExists = _Context.StockTransfers.Any(i => i.FromWarehouse.Name == fromWarehouse && i.ToWarehouse.Name == toWarehouse);

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Date you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var ExistedOrder = _Context.StockTransfers.Find(TransferIDComboBox.SelectedItem);

                var fromWarehouseId = _Context.Warehouses.Where(i => i.Name == fromWarehouse).FirstOrDefault();
                var toWarehouseId = _Context.Warehouses.Where(i => i.Name == toWarehouse).FirstOrDefault();
               

                ExistedOrder.FromWarehouseID =fromWarehouseId.WarehouseID;
                ExistedOrder.ToWarehouseID = toWarehouseId.WarehouseID;
                ExistedOrder.TransferDate = transferDate;
                _Context.SaveChanges();
                MessageBox.Show("Successfully Edited Tranfer !", "Success", MessageBoxButtons.OK);
                LoadTransfersData();
            }
            else
                MessageBox.Show("No Transfers To Edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AddNewTransfer_Click(object sender, EventArgs e)
        {
            AddNewTransfer addForm = new AddNewTransfer();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                TransferIDComboBox.Items.Add(_Context.StockTransfers.Order().Last().TransferID);
                LoadTransfersData();
            }

        }







        #endregion
        //Transfer End



    }
}
