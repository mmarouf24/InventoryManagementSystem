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
    public partial class AddNewReleaseOrder : Form
    {
        EFModel _Context;
        public AddNewReleaseOrder()
        {
            InitializeComponent();
            _Context = new EFModel();

            foreach (var warehouse in _Context.Warehouses.ToList())
            {
                WarehousesComboBox.Items.Add(warehouse.Name);
            }

            foreach (var customer in _Context.Customers.ToList())
            {
                CustomersComboBox.Items.Add(customer.Name);
            }
            foreach (var item in _Context.Items.ToList())
            {
                ItemsCombobox.Items.Add(item.Name);
            }
            if (WarehousesComboBox.Items.Count > 0)
                WarehousesComboBox.SelectedIndex = 0;

            if (CustomersComboBox.Items.Count > 0)
                CustomersComboBox.SelectedIndex = 0;

            if (ItemsCombobox.Items.Count > 0)
                ItemsCombobox.SelectedIndex = 0;

            WarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemsCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (ReleaseOrderNumberTextBox.Text == "" || ReleaseOrderItemQTextBox.Text == "" )
                MessageBox.Show("Enter Data in all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string ordernumber = ReleaseOrderNumberTextBox.Text.Trim();
                DateTime orderDate = ReleaseOrderDate.Value;
                string warehouse = WarehousesComboBox.SelectedItem.ToString();
                string customer = CustomersComboBox.SelectedItem.ToString();

                var ifExistedOrder = _Context.ReleaseOrders.FirstOrDefault(i => i.OrderNumber == ordernumber);

                var releaseOrder = new ReleaseOrder();
                if (ifExistedOrder == null)
                {

                    var warehouseId = _Context.Warehouses.Where(i => i.Name == warehouse).FirstOrDefault();
                    var customerId = _Context.Customers.Where(i => i.Name == customer).FirstOrDefault();

                    releaseOrder.WarehouseID = warehouseId.WarehouseID;
                    releaseOrder.CustomerID = customerId.CustomerID;
                    releaseOrder.OrderNumber = ordernumber;
                    releaseOrder.OrderDate = orderDate;
                    _Context.ReleaseOrders.Add(releaseOrder);
                    _Context.SaveChanges();


                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Order Number !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = ItemsCombobox.SelectedItem.ToString();
                int quantity = int.Parse(ReleaseOrderItemQTextBox.Text.Trim());


                var index = _Context.Items.Where(i => i.Name == name).FirstOrDefault();
                var item = new ReleaseOrderDetail();

                var newOrder = _Context.ReleaseOrders.Where(i => i.OrderNumber == ordernumber).FirstOrDefault();
                item.ReleaseOrderID = newOrder.ReleaseOrderID;
                item.Quantity = quantity;
                item.ItemID = index.ItemID;

                try
                {

                    _Context.ReleaseOrderDetails.Add(item);
                    MessageBox.Show("Successfully Added Release Order and Item To it !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    _Context.SaveChanges();
                    this.DialogResult = DialogResult.OK;

                    UpdateStockAfterRelease(releaseOrder);
                   
                    this.Close();
                    ReleaseOrderItemQTextBox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to Add", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private bool UpdateStockAfterRelease(ReleaseOrder releaseOrder)
        {
            foreach (var detail in releaseOrder.ReleaseOrderDetails)
            {
                var stock = _Context.Stocks
                    .FirstOrDefault(s => s.WarehouseID == releaseOrder.WarehouseID && s.ItemID == detail.ItemID);

                if (stock == null || stock.Quantity < detail.Quantity)
                {
                    MessageBox.Show($"The item {detail.Item.Name} is not available in the required quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;  
                }

                stock.Quantity -= detail.Quantity;
            }

            _Context.SaveChanges();
            return true;
        }
        private void CancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}