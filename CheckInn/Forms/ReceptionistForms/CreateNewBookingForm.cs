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
    public partial class CreateNewBookingForm : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();
        BookingRepository bookingRepository = new BookingRepository();
        RoomRepository roomRepository = new RoomRepository();
        private int preSelectedRoomID;

        public CreateNewBookingForm()
        {
            InitializeComponent();
            preSelectedRoomID = -1;
        }

        public CreateNewBookingForm(int roomID)
        {
            InitializeComponent();
            preSelectedRoomID = roomID;
        }

        private void CreateNewBookingForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Customers
            List<Customer> customers = customerRepository.GetAllCustomers();

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";

            // Rooms
            List<Room> rooms = roomRepository.getAllRooms();

            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "DisplayText";
            cmbRoom.ValueMember = "RoomID";

            // Pre-select the room AFTER DataSource is set
            cmbRoom.SelectedValue = preSelectedRoomID;

            // Show Room Bookings
            gridRoomBookings.AutoGenerateColumns = false;

            gridRoomBookings.Columns.Add("StartDate", "Start Date");
            gridRoomBookings.Columns["StartDate"].DataPropertyName = "BookingStartsDate";

            gridRoomBookings.Columns.Add("EndDate", "End Date");
            gridRoomBookings.Columns["EndDate"].DataPropertyName = "BookingEndsDate";
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem == null) return;

            Customer selectedCustomer = (Customer)cmbCustomer.SelectedItem;

            txtName.Text = selectedCustomer.CustomerName;
            dateDOB.Value = selectedCustomer.CustomerDOB;
            txtEmail.Text = selectedCustomer.CustomerEmail;
            txtPhoneNumber.Text = selectedCustomer.CustomerPhoneNumber;
            txtAddress.Text = selectedCustomer.CustomerAddress;
        }


        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedItem is Room selectedRoom)
            {
                txtRoomType.Text = selectedRoom.RoomType;
                txtRoomPrice.Text = selectedRoom.PricePerNight.ToString();

                List<Booking> bookings = bookingRepository.getSelectedRoomBookings(selectedRoom.RoomID);

                gridRoomBookings.DataSource = bookings;
            }
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // Check Room Availability
                int roomID = Convert.ToInt32(cmbRoom.SelectedValue);

                Booking existingBooking = bookingRepository.CheckRoomAvailability(
                    roomID,
                    dateBookingStarts.Value,
                    dateBookingEndsDate.Value
                );

                if (existingBooking != null)
                {
                    MessageBox.Show(
                        "Room is not available for these dates.\n\n" +
                        "Existing booking:\n" +
                        "Start: " + existingBooking.BookingStartsDate.ToShortDateString() +
                        "\nEnd: " + existingBooking.BookingEndsDate.ToShortDateString(),
                        "Room Not Available"
                    );

                    return;
                }

                // -------- CUSTOMER VALIDATION --------
                if (cmbCustomer.SelectedItem == null)
                {
                    MessageBox.Show("Please select a customer.");
                    return;
                }

                // -------- ROOM VALIDATION --------
                if (cmbRoom.SelectedItem == null)
                {
                    MessageBox.Show("Please select a room.");
                    return;
                }

                // -------- DATE VALIDATION --------
                if (dateBookingStarts.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Booking start date cannot be in the past.");
                    return;
                }

                if (dateBookingEndsDate.Value <= dateBookingStarts.Value)
                {
                    MessageBox.Show("Booking end date must be after the start date.");
                    return;
                }

                // -------- CREATE BOOKING --------
                Booking booking = new Booking
                {
                    CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue),
                    RoomID = Convert.ToInt32(cmbRoom.SelectedValue),
                    BookingStartsDate = dateBookingStarts.Value,
                    BookingEndsDate = dateBookingEndsDate.Value,
                    BookingStatus = "Active"
                };

                bookingRepository.CreateBooking(booking);

                MessageBox.Show("Booking created successfully ✅");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
    }
}
