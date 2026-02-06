using CheckInn.Forms;
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

namespace CheckInn
{
    public partial class Form1 : Form
    {
        StaffRepository staffRepository = new StaffRepository();

        public void SignIn()
        {
            if (!int.TryParse(txtStaffPIN.Text, out int staffPIN))
            {
                MessageBox.Show("Enter a valid PIN");
                return;
            }

            var staffDetails = staffRepository.getStaffDetails(staffPIN);

            if (staffDetails == null)
            {
                MessageBox.Show("Staff not found");
                return;
            }

            var staffRole = staffRepository.getStaffRole(staffDetails.RoleID);

            if (staffRole == null)
            {
                MessageBox.Show("Role not found");
                return;
            }

          

            switch (staffRole.RoleName)
            {
                case "Receptionist":
                    ReceptionistForm receptionistForm = new ReceptionistForm(staffDetails, staffRole);
                    receptionistForm.Show();
                    break;

                default:
                    MessageBox.Show("No form mapped for this role");
                    break;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_KeyPress(object sen4der, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Stop the key from being entered
            }
        }

        // Sign in by Staff PIN
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Sign In Function
            SignIn();
        }
    }
}
