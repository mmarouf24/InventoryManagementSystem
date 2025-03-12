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
    public partial class EditSupplyOederItem : Form
    {
        EFModel _Context;
        int SupplyOrderID;

        public EditSupplyOederItem(int SupplyOrderID)
        {
            InitializeComponent();

            _Context = new EFModel();
            this.SupplyOrderID = SupplyOrderID;
            foreach (var supplyOrderItem in _Context.SupplyOrderDetails.Where(i => i.SupplyOrderID == SupplyOrderID).ToList())
            {
                SupplyOrderItemsComboBox.Items.Add(supplyOrderItem.Item.Name);
            }
            if (SupplyOrderItemsComboBox.Items.Count > 0)
                SupplyOrderItemsComboBox.SelectedIndex = 0;
            SupplyOrderItemsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ConfigSupplyOrderItemTextBoxes();
        }
        private void ConfigSupplyOrderItemTextBoxes()
        {
            if(SupplyOrderItemsComboBox.Items.Count > 0)
            {
                var item = _Context.SupplyOrderDetails
                   .FirstOrDefault(i => i.SupplyOrderID == SupplyOrderID &&
                         i.Item.Name == SupplyOrderItemsComboBox.SelectedItem.ToString());

                if (item != null)
                {

                    SupplyOrderItemQTextBox.Text = item.Quantity.ToString();
                    SupplyOrderItemExpiryTextBox.Text = item.ExpirationPeriod.ToString();
                    SupplyOrderItemProdDate.Value = item.ProductionDate;

                }
            }
               
        }

        private void SupplyOrderItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigSupplyOrderItemTextBoxes();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditSupplyOrderItem_Click(object sender, EventArgs e)
        {
            var item = _Context.SupplyOrderDetails
                .FirstOrDefault(i => i.SupplyOrderID == SupplyOrderID &&
                          i.Item.Name == SupplyOrderItemsComboBox.SelectedItem.ToString());
            if (SupplyOrderItemQTextBox.Text != "" && SupplyOrderItemExpiryTextBox.Text != "")
            {


                item.Quantity = int.Parse(SupplyOrderItemQTextBox.Text);
                item.ExpirationPeriod = int.Parse(SupplyOrderItemExpiryTextBox.Text);
                item.ProductionDate = SupplyOrderItemProdDate.Value;
                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK);
                _Context.SaveChanges();


            }
            else MessageBox.Show("Enter All Fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void DeleteSupplyOrderItem_Click(object sender, EventArgs e)
        {
            if (SupplyOrderItemsComboBox.Items.Count > 0)
            {
                var ItemToDelete = _Context.SupplyOrderDetails
                                  .FirstOrDefault(i => i.SupplyOrderID == SupplyOrderID &&
                                                 i.Item.Name == SupplyOrderItemsComboBox.SelectedItem.ToString());
                _Context.SupplyOrderDetails.Remove(ItemToDelete);
                _Context.SaveChanges();
                MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK);
                SupplyOrderItemsComboBox.Items.Remove(SupplyOrderItemsComboBox.SelectedItem);
                if (SupplyOrderItemsComboBox.Items.Count > 0)
                    SupplyOrderItemsComboBox.SelectedIndex = 0;
                ConfigSupplyOrderItemTextBoxes();
            }
            else
            {
                MessageBox.Show("No items To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

        }
    }
}
