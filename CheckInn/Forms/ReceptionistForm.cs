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
    public partial class ReceptionistForm : Form
    {
        RoomRepository roomRepository = new RoomRepository();

        private Staff staffDetails;
        private StaffRole staffRole;

        public ReceptionistForm(Staff staffDetails, StaffRole staffRole)
        {
            InitializeComponent();
            this.staffDetails = staffDetails;
            this.staffRole = staffRole;
        }

        private void LoadRooms()
        {
            flwRooms.Controls.Clear();

            
            // there is a problem with the datatable
            DataTable rooms = roomRepository.getAllRooms();

            foreach (DataRow row in rooms.Rows)
            {
                string number = row["RoomNumber"].ToString();
                bool busy = (bool)row["Busy"];

                RoomCard card = new RoomCard();
                card.SetRoom(number, busy);
                card.Margin = new Padding(10);

                // OPTIONAL: click event
                card.Click += (s, e) =>
                {
                    MessageBox.Show("Clicked room " + number);
                };

                flwRooms.Controls.Add(card);
            }
        }


        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = $"Welcome back {staffDetails.StaffName}";

            // Maximize the screen size
            this.WindowState = FormWindowState.Maximized;

            // Hide the first form
            Form1 signInForm = new Form1();
            signInForm.Hide();

            // Set the dynamic text
            lblRole.Text = staffRole.RoleName;
        }

       

    }
}
