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

namespace CheckInn.Forms.ReceptionistForms.ManageCustomers
{
    public partial class UpdateCustomerForm : Form
    {
        Customer customer;
        CustomerRepository customerRepository = new CustomerRepository();
        BookingRepository bookingRepository = new BookingRepository();

        public UpdateCustomerForm(Customer selectedCustomer)
        {
            InitializeComponent();
            customer = selectedCustomer;
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = Convert.ToString(customer.CustomerID);
            txtName.Text = customer.CustomerName;
            dateDOB.Value = customer.CustomerDOB;
            txtEmail.Text = customer.CustomerEmail;
            txtPhoneNumber.Text = customer.CustomerPhoneNumber;
            txtAddress.Text = customer.CustomerAddress;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter customer name");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter email");
                return;
            }

            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Enter phone number");
                return;
            }

            try
            {
                customer.CustomerName = txtName.Text;
                customer.CustomerDOB = dateDOB.Value;
                customer.CustomerEmail = txtEmail.Text;
                customer.CustomerPhoneNumber = txtPhoneNumber.Text;
                customer.CustomerAddress = txtAddress.Text;

                customerRepository.UpdateCustomer(customer);

                MessageBox.Show("Customer updated");

                this.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerRepository.CustomerHasBookings(customer.CustomerID))
            {
                MessageBox.Show("Customer cannot be deleted because they have bookings.");
                return;
            }

            customerRepository.DeleteCustomer(customer.CustomerID);

            MessageBox.Show("Customer deleted successfully");

            this.Close();
        }
    }
}