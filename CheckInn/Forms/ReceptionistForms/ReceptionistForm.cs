using CheckInn.Forms.ReceptionistForms;
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
        CustomerRepository customerRepository = new CustomerRepository();

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

            List<Room> rooms = roomRepository.getAllRooms();

            foreach (var room in rooms)
            {
                string number = room.RoomID.ToString();
                string status = roomRepository.GetRoomStatus(room.RoomID);

                RoomCard card = new RoomCard(); 
                card.SetRoom(number, status);
                card.Margin = new Padding(10);

                card.Click += (s, e) =>
                {
                    RoomForm roomForm = new RoomForm(Convert.ToInt32(number));
                    roomForm.Show();
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

            // Load Rooms
            LoadRooms();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CreateNewCustomerForm createNewCustomerForm = new CreateNewCustomerForm();
            createNewCustomerForm.ShowDialog();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            CreateNewBookingForm createNewBookingForm = new CreateNewBookingForm();
            createNewBookingForm.ShowDialog();
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            ManageBookingsForm manageBookingsForm = new ManageBookingsForm();
            manageBookingsForm.ShowDialog();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
