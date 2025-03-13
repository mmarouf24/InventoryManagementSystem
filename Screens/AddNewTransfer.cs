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
    public partial class AddNewTransfer : Form
    {
        EFModel _Context;
        public AddNewTransfer()
        {
            InitializeComponent();
            _Context = new EFModel();
            foreach (var warehouse in _Context.Warehouses.ToList())
            {
                FromWarehousesComboBox.Items.Add(warehouse.Name);
                ToWarehousesComboBox.Items.Add(warehouse.Name);
            }
            FromWarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToWarehousesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var item in _Context.Items.ToList())
            {
                TransferItemsComboBox.Items.Add(item.Name);
            }
            foreach (var supplier in _Context.Suppliers.ToList())
            {
                TransferItemSuppliersComboBox.Items.Add(supplier.Name);
            }

            TransferItemsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TransferItemSuppliersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (TransferItemExpirePeriodTextBox.Text == "" || TransferItemQTextBox.Text == "")
                MessageBox.Show("Enter Data in all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                var transferOrder = new StockTransfer();

                DateTime transferDate = TransferDateItem.Value;

                string fromWarehouse = FromWarehousesComboBox.SelectedItem.ToString();
                string toWarehouse = ToWarehousesComboBox.SelectedItem.ToString();
                bool isCodeExists = _Context.StockTransfers.Any(i => i.FromWarehouse.Name == fromWarehouse && i.ToWarehouse.Name == toWarehouse);

                if (isCodeExists)
                {
                    MessageBox.Show("Editing Failed!, The Date you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var fromWarehouseId = _Context.Warehouses.Where(i => i.Name == fromWarehouse).FirstOrDefault();
                var toWarehouseId = _Context.Warehouses.Where(i => i.Name == toWarehouse).FirstOrDefault();



                transferOrder.FromWarehouseID = fromWarehouseId.WarehouseID;
                transferOrder.ToWarehouseID = toWarehouseId.WarehouseID;
                transferOrder.TransferDate = transferDate;

                _Context.StockTransfers.Add(transferOrder);
                _Context.SaveChanges();


                    var itemId = _Context.Items.Where(i => i.Name == TransferItemsComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var supplierID = _Context.Suppliers.Where(i => i.Name == TransferItemSuppliersComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var item = new StockTransferDetail();
                    item.TransferID=transferOrder.TransferID; 
                    item.ItemID = itemId.ItemID;
                    item.SupplierID = supplierID.SupplierID;
                    item.ExpirationPeriod = int.Parse(TransferItemExpirePeriodTextBox.Text);
                    item.ProductionDate = TransferItemProdDate.Value;
                    item.Quantity = int.Parse(TransferItemQTextBox.Text);


                    _Context.StockTransferDetails.Add(item);
                UpdateStocks();
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Item To Transfer Details!", "Success", MessageBoxButtons.OK);
                    TransferItemExpirePeriodTextBox.Text = TransferItemQTextBox.Text = "";
                    this.DialogResult = DialogResult.OK;
               
            }  
        }
        public void UpdateStocks()
        {

            var transferEntries = _Context.ChangeTracker.Entries<StockTransferDetail>().Where(e => e.State == EntityState.Added).ToList();

            if (!transferEntries.Any())
            {
                return;
            }

            foreach (var entry in transferEntries)
            {
                var transfer = _Context.StockTransfers
                    .FirstOrDefault(t => t.TransferID == entry.Entity.TransferID);

                if (transfer == null)
                {
                    throw new Exception("Stock Transfer not found!");
                }

                var fromStock = _Context.Stocks.FirstOrDefault(s => s.ItemID == entry.Entity.ItemID && s.WarehouseID == transfer.FromWarehouseID);
                var toStock = _Context.Stocks.FirstOrDefault(s => s.ItemID == entry.Entity.ItemID && s.WarehouseID == transfer.ToWarehouseID);

                if (fromStock != null && fromStock.Quantity >= entry.Entity.Quantity)
                {
                    fromStock.Quantity -= entry.Entity.Quantity;
                    _Context.Stocks.Update(fromStock);

                    if (toStock != null)
                    {
                        toStock.Quantity += entry.Entity.Quantity;
                        _Context.Stocks.Update(toStock);
                    }
                    else
                    {
                        _Context.Stocks.Add(new Stock
                        {
                            ItemID = entry.Entity.ItemID,
                            WarehouseID = transfer.ToWarehouseID,
                            Quantity = entry.Entity.Quantity
                        });
                    }
                }
                else
                {
                    throw new Exception($"Insufficient stock in warehouse {transfer.FromWarehouseID} for Item {entry.Entity.ItemID}!");
                }
            }

            _Context.SaveChanges();
        }

    }
}
