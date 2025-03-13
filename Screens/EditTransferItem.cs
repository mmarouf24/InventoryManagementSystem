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

namespace InventoryManagementSystem.Screens
{
    public partial class EditTransferItem : Form
    {
        EFModel _Context;
        int TransferID;
        public EditTransferItem(int TransferID)
        {
            InitializeComponent();
            _Context = new EFModel();
            this.TransferID = TransferID;

            foreach (var transferItem in _Context.StockTransferDetails.Where(i => i.TransferID == TransferID).ToList())
            {
                TransferItemsComboBox.Items.Add(transferItem.Item.Name);
                TransferItemSuppliersComboBox.Items.Add(transferItem.Supplier.Name);
            }
            if (TransferItemsComboBox.Items.Count > 0)
                TransferItemsComboBox.SelectedIndex = 0;
            TransferItemsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TransferItemSuppliersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ConfigTransfersTextBoxes();

        }
        private void ConfigTransfersTextBoxes()
        {
            if (TransferItemsComboBox.Items.Count > 0)
            {
                var item = _Context.StockTransferDetails
                  .FirstOrDefault(i => i.TransferID == TransferID &&
                        i.Item.Name == TransferItemsComboBox.SelectedItem.ToString());

                if (item != null)
                {
                    TransferItemProdDate.Value = item.ProductionDate;
                    TransferItemExpirePeriodTextBox.Text = item.ExpirationPeriod.ToString();
                    TransferItemQTextBox.Text = item.Quantity.ToString();
                    TransferItemSuppliersComboBox.SelectedItem = item.Supplier.Name;
                }
            }
            else MessageBox.Show("No Items To Delete!", "Warning", MessageBoxButtons.OK);


        }

        private void TransferItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigTransfersTextBoxes();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditTransferItemBtn_Click(object sender, EventArgs e)
        {
            var item = _Context.StockTransferDetails
              .FirstOrDefault(i => i.TransferID == TransferID &&
                        i.Item.Name == TransferItemsComboBox.SelectedItem.ToString());
            if (TransferItemQTextBox.Text != "" && TransferItemExpirePeriodTextBox.Text != "")
            {
                var index = _Context.Suppliers.Where(i => i.Name == TransferItemSuppliersComboBox.ToString()).FirstOrDefault();
                item.Quantity = int.Parse(TransferItemQTextBox.Text);
                item.ProductionDate = TransferItemProdDate.Value;
                item.ExpirationPeriod = int.Parse(TransferItemExpirePeriodTextBox.Text);
                item.SupplierID = index.SupplierID;

                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK);
                _Context.SaveChanges();

            }
            else MessageBox.Show("Enter All Fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DeleteTransferItem_Click(object sender, EventArgs e)
        {
            if (TransferItemsComboBox.Items.Count > 0)
            {
                var ItemToDelete = _Context.StockTransferDetails
                                  .FirstOrDefault(i => i.TransferID == TransferID &&
                                                 i.Item.Name == TransferItemsComboBox.SelectedItem.ToString());
                _Context.StockTransferDetails.Remove(ItemToDelete);
                _Context.SaveChanges();
                MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK);
                TransferItemsComboBox.Items.Remove(TransferItemsComboBox.SelectedItem);
                if (TransferItemsComboBox.Items.Count > 0)
                    TransferItemsComboBox.SelectedIndex = 0;
                ConfigTransfersTextBoxes();
            }
            else
            {
                MessageBox.Show("No items To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
