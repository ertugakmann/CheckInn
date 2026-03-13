using CheckInn.Forms.ReceptionistForms.ManageBookings;
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
    public partial class ManageCustomerForm : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public ManageCustomerForm()
        {
            InitializeComponent();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = customerRepository.GetAllCustomers();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Customer customer = (Customer)dgvCustomers.CurrentRow.DataBoundItem;

            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(customer);

            updateCustomerForm.ShowDialog();

            dgvCustomers.DataSource = customerRepository.GetAllCustomers();
        }
    }
}
