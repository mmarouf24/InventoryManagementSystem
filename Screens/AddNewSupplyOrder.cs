using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Tables;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Screens
{
    public partial class AddNewSupplyOrder : Form
    {
        EFModel _Context;
        public AddNewSupplyOrder()
        {
            InitializeComponent();
            _Context = new EFModel();

            foreach (var warehouse in _Context.Warehouses.ToList())
            {
                WarehousesComboBox.Items.Add(warehouse.Name);
            }

            foreach (var supplier in _Context.Suppliers.ToList())
            {
                SuppliersComboBox.Items.Add(supplier.Name);
            }
            foreach (var item in _Context.Items.ToList())
            {
                ItemsCombobox.Items.Add(item.Name);
            }
            if (WarehousesComboBox.Items.Count > 0)
                WarehousesComboBox.SelectedIndex = 0;

            if (SuppliersComboBox.Items.Count > 0)
                SuppliersComboBox.SelectedIndex = 0;

            if (ItemsCombobox.Items.Count > 0)
                ItemsCombobox.SelectedIndex = 0;

            WarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SuppliersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemsCombobox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (SupplyOrderNumberTextBox.Text == "" || SupplyOrderItemQTextBox.Text == "" || SupplyOrderItemExpiryTextBox.Text == "")
                MessageBox.Show("Enter Data in all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string ordernumber = SupplyOrderNumberTextBox.Text.Trim();
                DateTime orderDate = SupplyOrderDate.Value;
                string warehouse = WarehousesComboBox.SelectedItem.ToString();
                string supplier = SuppliersComboBox.SelectedItem.ToString();

                var ifExistedOrder = _Context.SupplyOrders.FirstOrDefault(i => i.OrderNumber == ordernumber);

                var supplyOrder = new SupplyOrder();
                if (ifExistedOrder == null)
                {



                    var warehouseId = _Context.Warehouses.Where(i => i.Name == warehouse).FirstOrDefault();
                    var supplierId = _Context.Suppliers.Where(i => i.Name == supplier).FirstOrDefault();

                    supplyOrder.WarehouseID = warehouseId.WarehouseID;
                    supplyOrder.SupplierID = supplierId.SupplierID;
                    supplyOrder.OrderNumber = ordernumber;
                    supplyOrder.OrderDate = orderDate;
                    _Context.SupplyOrders.Add(supplyOrder);
                    _Context.SaveChanges();


                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Order Number !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = ItemsCombobox.SelectedItem.ToString();
                int quantity = int.Parse(SupplyOrderItemQTextBox.Text.Trim());
                int expiryPeriod = int.Parse(SupplyOrderItemExpiryTextBox.Text.Trim());
                DateTime prodDate = SupplyOrderItemProdDate.Value;

                var index = _Context.Items.Where(i => i.Name == name).FirstOrDefault();
                var item = new SupplyOrderDetail();

                var newOrder = _Context.SupplyOrders.Where(i => i.OrderNumber == ordernumber).FirstOrDefault();
                item.SupplyOrderID = newOrder.SupplyOrderID;
                item.ExpirationPeriod = expiryPeriod;
                item.ProductionDate = prodDate;
                item.Quantity = quantity;
                item.ItemID = index.ItemID;

                try
                {

                    _Context.SupplyOrderDetails.Add(item);
                    MessageBox.Show("Successfully Added Supply Order and Item To it !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    _Context.SaveChanges();
                    UpdateStockAfterSupply(supplyOrder);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    SupplyOrderItemExpiryTextBox.Text = SupplyOrderItemQTextBox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to Add", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
          private void UpdateStockAfterSupply(SupplyOrder supplyOrder)
        {
            foreach (var detail in supplyOrder.SupplyOrderDetails)
            {
                var stock = _Context.Stocks
                    .FirstOrDefault(s => s.WarehouseID == supplyOrder.WarehouseID && s.ItemID == detail.ItemID);

                if (stock != null)
                {
                    stock.Quantity += detail.Quantity;
                }
                else
                {
                    stock = new Stock
                    {
                        WarehouseID = supplyOrder.WarehouseID,
                        ItemID = detail.ItemID,
                        Quantity = detail.Quantity
                    };
                    _Context.Stocks.Add(stock);
                }
            }

            _Context.SaveChanges();
        }
       
        private void CancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}