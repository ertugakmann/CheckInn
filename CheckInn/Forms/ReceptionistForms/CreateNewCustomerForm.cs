using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckInn.Forms.ReceptionistForms
{
    public partial class CreateNewCustomerForm : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public CreateNewCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSetCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // -------- VALIDATION --------
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Name and Email are required");
                    return;
                }

                // -------- CREATE CUSTOMER --------
                Customer customer = new Customer
                {
                    CustomerName = txtName.Text.Trim(),
                    CustomerDOB = dateDOB.Value,
                    CustomerEmail = txtEmail.Text.Trim(),
                    CustomerPhoneNumber = txtPhoneNumber.Text.Trim(),
                    CustomerAddress = txtAddress.Text.Trim()
                };

                customerRepository.CreateCustomer(customer);

                MessageBox.Show("Customer created successfully ✅");

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }


        }
    }
}
