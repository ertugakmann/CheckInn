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

        public CreateNewBookingForm()
        {
            InitializeComponent();
        }

        private void CreateNewBookingForm_Load(object sender, EventArgs e)
        {
            // Customers
            List<Customer> customers = customerRepository.GetAllCustomers();

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";

            // Rooms
            List<Room> rooms = roomRepository.getAllRooms();

            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomType";
            cmbRoom.ValueMember = "RoomID";
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
            }
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            try
            {
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
                    BookingStatus = "Confirmed"
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
