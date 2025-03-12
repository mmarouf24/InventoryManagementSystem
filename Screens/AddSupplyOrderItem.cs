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
    public partial class AddSupplyOrderItem : Form
    {
        EFModel _Context;
        int SupplyOrderID;
        public AddSupplyOrderItem(int supplyOrderID)
        {
            InitializeComponent();
            _Context = new EFModel();
            SupplyOrderID = supplyOrderID;
            foreach (var item in _Context.Items.ToList())
            {
                ItemsCombobox.Items.Add(item.Name);
            }
            if (ItemsCombobox.Items.Count > 0)
                ItemsCombobox.SelectedIndex = 0;
            ItemsCombobox.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void ADdSupplyOrderItemBtn_Click(object sender, EventArgs e)
        {
            if (SupplyOrderItemQTextBox.Text == "" || SupplyOrderItemExpiryTextBox.Text == "")
                MessageBox.Show("Enter Data at all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string name = ItemsCombobox.SelectedItem.ToString();
                int quantity = int.Parse(SupplyOrderItemQTextBox.Text.Trim());
                int expiryPeriod = int.Parse(SupplyOrderItemExpiryTextBox.Text.Trim());
                DateTime prodDate = SupplyOrderItemProdDate.Value;



                var ifExistedItem = _Context.SupplyOrderDetails
                            .FirstOrDefault(i => i.Item.Name == ItemsCombobox.SelectedItem.ToString());
                if (ifExistedItem == null)
                {
                    var index = _Context.Items.Where(i => i.Name == name).FirstOrDefault();
                    var item = new SupplyOrderDetail();

                    item.SupplyOrderID = SupplyOrderID;
                    item.ExpirationPeriod = expiryPeriod;
                    item.ProductionDate = prodDate;
                    item.Quantity = quantity;
                    item.ItemID = index.ItemID;

                    _Context.SupplyOrderDetails.Add(item);
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Item To Supply order !", "Success", MessageBoxButtons.OK);
                    SupplyOrderItemExpiryTextBox .Text = SupplyOrderItemQTextBox.Text="";
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Data !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
