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

namespace InventoryManagementSystem
{
    public partial class AddNewItem : Form
    {
        EFModel _Context;
        public AddNewItem()
        {
            InitializeComponent();
            _Context = new EFModel();
            ItemUnitComboBox.SelectedIndex = 0;
            ItemUnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfirmAddItem_Click(object sender, EventArgs e)
        {
            if (ItemNameTextBox.Text == "" || ItemCodeTextBox.Text == "" || ItemQuantityTextBox.Text == "")
                MessageBox.Show("Enter Data in all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string name = ItemNameTextBox.Text.Trim();
                string code = ItemCodeTextBox.Text.Trim();
                int quantity = int.Parse(ItemQuantityTextBox.Text.Trim());
                string unit = ItemUnitComboBox.SelectedItem.ToString();

                var ifExistedItem = _Context.Items.FirstOrDefault(i => i.Code == code);

                if (ifExistedItem == null)
                {
                    var item = new Item();

                    item.Code = code;
                    item.Name = name;
                    item.Quantity = quantity;
                    item.Unit = unit;
                    _Context.Items.Add(item);
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Item !", "Success", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Code Item !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void CancelAddItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
