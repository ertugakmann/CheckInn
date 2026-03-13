using CheckInn.Forms.ReceptionistForms;
using CheckInn.Forms.ReceptionistForms.ManageCustomers;
using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckInn.Forms
{
    public partial class ReceptionistForm : Form
    {
        RoomRepository roomRepository = new RoomRepository();
        CustomerRepository customerRepository = new CustomerRepository();
        BookingRepository bookingRepository = new BookingRepository();

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
                    roomForm.ShowDialog();

                    // refresh UI after room changes
                    LoadRooms();
                    LoadDashboard();
                };

                flwRooms.Controls.Add(card);
            }
        }

        private void FormatBookingGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (grid.Columns["Room"] != null)
                grid.Columns["Room"].HeaderText = "Room";

            if (grid.Columns["Customer"] != null)
                grid.Columns["Customer"].HeaderText = "Customer";

            if (grid.Columns["Check In"] != null)
                grid.Columns["Check In"].HeaderText = "Check-In";

            if (grid.Columns["Check Out"] != null)
                grid.Columns["Check Out"].HeaderText = "Check-Out";
        }

        private void LoadDashboard()
        {
            int totalRooms = bookingRepository.GetTotalRooms();
            int occupiedRooms = bookingRepository.GetOccupiedRooms();

            lblTotalRooms.Text = "Total Rooms: " + totalRooms;
            lblOccupiedRooms.Text = "Occupied Rooms: " + occupiedRooms;
            lblAvailableRooms.Text = "Available Rooms: " + (totalRooms - occupiedRooms);

            gridCheckIns.DataSource = bookingRepository.GetTodaysCheckIns();
            gridCheckOuts.DataSource = bookingRepository.GetTodaysCheckOuts();

            FormatBookingGrid(gridCheckIns);
            FormatBookingGrid(gridCheckOuts);
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            lblStaffName.Text = "Welcome back " + staffDetails.StaffName;

            this.WindowState = FormWindowState.Maximized;

            lblRole.Text = staffRole.RoleName;

            LoadRooms();
            LoadDashboard();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CreateNewCustomerForm createCustomer = new CreateNewCustomerForm();
            createCustomer.ShowDialog();

            LoadDashboard();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            CreateNewBookingForm createBooking = new CreateNewBookingForm();
            createBooking.ShowDialog();

            LoadRooms();
            LoadDashboard();
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            ManageBookingsForm manageBookings = new ManageBookingsForm();
            manageBookings.ShowDialog();

            LoadRooms();
            LoadDashboard();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomerForm manageCustomers = new ManageCustomerForm();
            manageCustomers.ShowDialog();
        }
    }
}