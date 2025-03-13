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
    public partial class AddReleaseOrderItem : Form
    {
        EFModel _Context;
        int ReleaseOrderID;
        public AddReleaseOrderItem(int releaseOrderID)
        {
            InitializeComponent();
            _Context = new EFModel();
            ReleaseOrderID = releaseOrderID;
            foreach (var item in _Context.Items.ToList())
            {
                ReleaseOrderItemsComboBox.Items.Add(item.Name);
            }
            if (ReleaseOrderItemsComboBox.Items.Count > 0)
                ReleaseOrderItemsComboBox.SelectedIndex = 0;
            ReleaseOrderItemsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void AddReleaseOrderItemBtn_Click(object sender, EventArgs e)
        {
            if (ReleaseOrderItemQTextBox.Text == "" )
                MessageBox.Show("Enter Data at all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string name = ReleaseOrderItemsComboBox.SelectedItem.ToString();
                int quantity = int.Parse(ReleaseOrderItemQTextBox.Text.Trim());
              


                var ifExistedItem = _Context.ReleaseOrderDetails
                            .FirstOrDefault(i => i.Item.Name == ReleaseOrderItemsComboBox.SelectedItem.ToString() && i.ReleaseOrderID==ReleaseOrderID);
                if (ifExistedItem == null)
                {
                    var index = _Context.Items.Where(i => i.Name == name).FirstOrDefault();
                    var item = new ReleaseOrderDetail();

                    item.ReleaseOrderID = ReleaseOrderID;
                    item.Quantity = quantity;
                    item.ItemID = index.ItemID;

                    _Context.ReleaseOrderDetails.Add(item);
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Item To Release order !", "Success", MessageBoxButtons.OK);
                    ReleaseOrderItemQTextBox.Text = "";
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
