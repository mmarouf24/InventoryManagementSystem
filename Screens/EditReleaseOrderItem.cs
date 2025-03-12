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
    public partial class EditReleaseOrderItem : Form
    {
        EFModel _Context;
        int releaseOrderID;
        public EditReleaseOrderItem(int releaseOrderID)
        {
            InitializeComponent();
            this.releaseOrderID = releaseOrderID;
            _Context = new EFModel();
            foreach (var releaseOrderItem in _Context.ReleaseOrderDetails.Where(i => i.ReleaseOrderID == releaseOrderID).ToList())
            {
                ReleaseOrderItemsComboBox.Items.Add(releaseOrderItem.Item.Name);
            }
            if (ReleaseOrderItemsComboBox.Items.Count > 0)
                ReleaseOrderItemsComboBox.SelectedIndex = 0;
            ReleaseOrderItemsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ConfigReleaseOrderItemTextBoxes();
        }

        private void ConfigReleaseOrderItemTextBoxes()
        {
            if (ReleaseOrderItemsComboBox.Items.Count > 0)
            {
                var item = _Context.ReleaseOrderDetails
                   .FirstOrDefault(i => i.ReleaseOrderID == releaseOrderID &&
                         i.Item.Name == ReleaseOrderItemsComboBox.SelectedItem.ToString());

                if (item != null)
                {

                    ReleaseOrderItemQTextBox.Text = item.Quantity.ToString();

                }
            }

        }

        private void ReleaseOrderItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigReleaseOrderItemTextBoxes();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditReleaseOrderItemBtn_Click(object sender, EventArgs e)
        {
            var item = _Context.ReleaseOrderDetails
               .FirstOrDefault(i => i.ReleaseOrderID == releaseOrderID &&
                         i.Item.Name == ReleaseOrderItemsComboBox.SelectedItem.ToString());
            if (ReleaseOrderItemQTextBox.Text != "")
            {


                item.Quantity = int.Parse(ReleaseOrderItemQTextBox.Text);

                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK);
                _Context.SaveChanges();

            }
            else MessageBox.Show("Enter All Fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DeleteReleaseOrderItem_Click(object sender, EventArgs e)
        {

            if (ReleaseOrderItemsComboBox.Items.Count > 0)
            {
                var ItemToDelete = _Context.ReleaseOrderDetails
                                  .FirstOrDefault(i => i.ReleaseOrderID == releaseOrderID &&
                                                 i.Item.Name == ReleaseOrderItemsComboBox.SelectedItem.ToString());
                _Context.ReleaseOrderDetails.Remove(ItemToDelete);
                _Context.SaveChanges();
                MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK);
                ReleaseOrderItemsComboBox.Items.Remove(ReleaseOrderItemsComboBox.SelectedItem);
                if (ReleaseOrderItemsComboBox.Items.Count > 0)
                    ReleaseOrderItemsComboBox.SelectedIndex = 0;
                ConfigReleaseOrderItemTextBoxes();
            }
            else
            {
                MessageBox.Show("No items To Delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}