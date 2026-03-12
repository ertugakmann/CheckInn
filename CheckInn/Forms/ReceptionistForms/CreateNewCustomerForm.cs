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
                // -------- NAME VALIDATION --------
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Customer name is required.");
                    return;
                }

                // -------- EMAIL VALIDATION --------
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email is required.");
                    return;
                }

                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // -------- PHONE VALIDATION --------
                if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Phone number is required.");
                    return;
                }

                // -------- DATE OF BIRTH VALIDATION --------
                if (dateDOB.Value > DateTime.Now)
                {
                    MessageBox.Show("Date of birth cannot be in the future.");
                    return;
                }

                int age = DateTime.Now.Year - dateDOB.Value.Year;

                if (age < 0)
                {
                    MessageBox.Show("Invalid date of birth.");
                    return;
                }

                // -------- CREATE CUSTOMER --------
                Customer customer = new Customer
                {
                    CustomerName = txtName.Text.Trim(),
                    CustomerDOB = dateDOB.Value.Date,
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
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
    }
}
