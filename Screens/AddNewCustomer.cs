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
    public partial class AddNewCustomer : Form
    {
        EFModel _Context;
        public AddNewCustomer()
        {
            InitializeComponent();
            _Context = new EFModel();
        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || CustomerMobileTextBox.Text == "")
                MessageBox.Show("Enter Data at least in Name & Mobile Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string name = CustomerNameTextBox.Text.Trim();
                string phone = CustomerPhoneTextBox.Text.Trim();
                string mobile = CustomerMobileTextBox.Text.Trim();
                string fax = CustomerFaxTextBox.Text.Trim();
                string email = CustomerEmailTextBox.Text.Trim();
                string website = CustomerWebsiteTextBox.Text.Trim();


                var ifExistedCustomer = _Context.Customers.FirstOrDefault(i => i.Mobile == mobile);

                if (ifExistedCustomer == null)
                {
                    var customer = new Customer();

                    customer.Name = name;
                    customer.Phone = phone;
                    customer.Mobile = mobile;
                    customer.Fax = fax;
                    customer.Email = email;
                    customer.Website = website;

                    _Context.Customers.Add(customer);
                    _Context.SaveChanges();
                    MessageBox.Show("Successfully Added Customer !", "Success", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed!. You Entered an Existed Mobile !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void CancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
