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
            int staffPIN = Convert.ToInt32(txtStaffPIN.Text);

            var staffDetails = staffRepository.getStaffDetails(staffPIN);
            var staffRole = staffRepository.getStaffRole(staffDetails.RoleID);

            switch (staffRole.RoleName)
            {
                case "Receptionist":
                    ReceptionistForm receptionistForm = new ReceptionistForm(staffDetails, staffRole);
                    receptionistForm.Show();
                    break;

                // Add more cases for different roles

                default: 
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
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
