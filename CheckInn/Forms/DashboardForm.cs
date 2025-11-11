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

namespace CheckInn.Forms
{
    public partial class DashboardForm : Form
    {
        private Staff staffDetails;

        // Constructor parametre alıyor
        public DashboardForm(Staff staffDetails)
        {
            InitializeComponent();
            this.staffDetails = staffDetails;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = $"Welcome back {staffDetails.StaffName}";
        }
    }
}
