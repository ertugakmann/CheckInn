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

namespace CheckInn.Forms.ReceptionistForms.ManageBookings
{
    public partial class UpdateBookingForm : Form
    {
        Booking booking;
        BookingRepository bookingRepository = new BookingRepository();
        CustomerRepository customerRepository = new CustomerRepository();
        RoomRepository roomRepository = new RoomRepository();

        public UpdateBookingForm(Booking selectedBooking)
        {
            InitializeComponent();
            booking = selectedBooking;
        }

        private void UpdateBookingForm_Load(object sender, EventArgs e)
        {
            // Customers
            List<Customer> customers = customerRepository.GetAllCustomers();

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";

            // Room
            List<Room> rooms = roomRepository.getAllRooms();

            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomID";
            cmbRoom.ValueMember = "RoomID";

            dateBookingStarts.Value = booking.BookingStartsDate;
            dateBookingEndsDate.Value = booking.BookingEndsDate;

            cmbCustomer.SelectedValue = booking.CustomerID;
            cmbRoom.SelectedValue = booking.RoomID;
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


        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dateBookingEndsDate.Value <= dateBookingStarts.Value)
            {
                MessageBox.Show("End date must be after start date");
                return;
            }

            booking.CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue);
            booking.RoomID = Convert.ToInt32(cmbRoom.SelectedValue);
            booking.BookingStartsDate = dateBookingStarts.Value;
            booking.BookingEndsDate = dateBookingEndsDate.Value;
            booking.TotalAmount = Convert.ToInt32(txtRoomPrice.Text);

            bookingRepository.UpdateBooking(booking);

            MessageBox.Show("Booking updated successfully");

            this.Close();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bookingRepository.CancelBooking(booking.BookingID);
            }
          
            MessageBox.Show("Booking cancelled successfully");

            this.Close();
        }
    }
}
