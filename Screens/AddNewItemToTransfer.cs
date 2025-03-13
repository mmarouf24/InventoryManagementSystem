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
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InventoryManagementSystem.Screens
{
    public partial class AddNewItemToTransfer : Form
    {
        EFModel _Context;
        int TransferID;
        public AddNewItemToTransfer(int TransferID)
        {
            InitializeComponent();
            this.TransferID = TransferID;
            _Context = new EFModel();
            foreach (var item in _Context.Items.ToList())
            {
                TransferItemsComboBox.Items.Add(item.Name);

            }     
            foreach (var supplier in _Context.Suppliers.ToList())
            {
               TransferItemSuppliersComboBox.Items.Add(supplier.Name);

            }
            if (TransferItemsComboBox.Items.Count > 0)
                TransferItemsComboBox.SelectedIndex = 0;
            TransferItemsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TransferItemSuppliersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (TransferItemQTextBox.Text == "" || TransferItemExpirePeriodTextBox.Text == "")
                MessageBox.Show("Enter Data at all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var ifExistedItem = _Context.StockTransferDetails
                            .FirstOrDefault(i =>
                            i.Item.Name == TransferItemsComboBox.SelectedItem.ToString()
                            && i.TransferID == TransferID);

                if (ifExistedItem == null)
                {
                    var itemId = _Context.Items.Where(i => i.Name == TransferItemsComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var supplierID = _Context.Suppliers.Where(i => i.Name == TransferItemSuppliersComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var item = new StockTransferDetail();
                    item.TransferID = TransferID;
                    item.ItemID = itemId.ItemID;
                    item.SupplierID = supplierID.SupplierID;
                    item.ExpirationPeriod = int.Parse(TransferItemExpirePeriodTextBox.Text);
                    item.ProductionDate = TransferItemProdDate.Value;
                    item.Quantity = int.Parse(TransferItemQTextBox.Text);


                    _Context.StockTransferDetails.Add(item);
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Item To Transfer Details!", "Success", MessageBoxButtons.OK);
                    TransferItemExpirePeriodTextBox.Text = TransferItemQTextBox.Text = "";
                    UpdateStocks();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
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


        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
