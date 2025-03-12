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
    public partial class AddNewSupplier : Form
    {
        EFModel _Context;
        public AddNewSupplier()
        {
            InitializeComponent();
            _Context = new EFModel();
        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (SupplierNameTextBox.Text == "" || SupplierMobileTextBox.Text == "")
                MessageBox.Show("Enter Data at least in Name & Mobile Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string name = SupplierNameTextBox.Text.Trim();
                string phone = SupplierPhoneTextBox.Text.Trim();
                string mobile = SupplierMobileTextBox.Text.Trim();
                string fax = SupplierFaxTextBox.Text.Trim();
                string email = SupplierEmailTextBox.Text.Trim();
                string website = SupplierWebsiteTextBox.Text.Trim();


                var ifExistedSupplier = _Context.Suppliers.FirstOrDefault(i => i.Phone == phone);

                if (ifExistedSupplier == null)
                {
                    var supplier = new Supplier();

                    supplier.Name = name;
                    supplier.Phone = phone;
                    supplier.Mobile = mobile;
                    supplier.Fax = fax;
                    supplier.Email = email;
                    supplier.Website = website;

                    _Context.Suppliers.Add(supplier);
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Supplier !", "Success", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Code Item !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void CancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
