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
    public partial class AddNewWarehouse : Form
    {
        EFModel _Context;

        public AddNewWarehouse()
        {
            InitializeComponent();
            _Context = new EFModel();

        }

        private void ConfirmAddItem_Click(object sender, EventArgs e)
        {
            if (WarehouseNameTextBox.Text == "" || WarehouseAddressTextBox.Text == "" || WarehouseMgrTextBox.Text == "")
                MessageBox.Show("Enter Data in all Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string name = WarehouseNameTextBox.Text.Trim();
                string address = WarehouseAddressTextBox.Text.Trim();
                string manager = WarehouseMgrTextBox.Text.Trim();

                var ifExistedWarehouse = _Context.Warehouses.FirstOrDefault(i => i.Name == name);

                if (ifExistedWarehouse == null)
                {
                    var warehouse = new Warehouse();

                    warehouse.Name = name;
                    warehouse.Address = address;
                    warehouse.Manager = manager;

                    _Context.Warehouses.Add(warehouse);
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Warehouse !", "Success", MessageBoxButtons.OK);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Warehouse Name !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void CancelAddItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
