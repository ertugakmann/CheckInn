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
            // Customer ComboBox
            List<Customer> customers = customerRepository.GetAllCustomers();

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Details";
            cmbCustomer.ValueMember = "CustomerID";

            // Room ComboBox
            List<Room> rooms = roomRepository.getAllRooms();

            cmbRoom.DataSource = customers;
            cmbRoom.DisplayMember = "Details";
            cmbRoom.ValueMember = "RoomID";
        }

      

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem is Customer selectedCustomer)
            {
                txtName.Text = selectedCustomer.CustomerName;
                dateDOB.Value = selectedCustomer.CustomerDOB;
                txtEmail.Text = selectedCustomer.CustomerEmail;
                txtPhoneNumber.Text = selectedCustomer.CustomerPhoneNumber;
                txtAddress.Text = selectedCustomer.CustomerAddress;
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedItem is Room selectedRoom)
            {
                txtRoomType.Text = selectedRoom.RoomType;
                txtRoomPrice.Text = Convert.ToString(selectedRoom.PricePerNight);
            }
        }


        private void btnSetCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateBookingEndsDate.Value <= dateBookingStarts.Value)
                {
                    MessageBox.Show("Booking end date must be after start date");
                    return;
                }
                // -------- CREATE BOOKING --------
                Booking booking = new Booking
                {
                    CustomerID = Convert.ToInt32(cmbCustomer.Text),
                    RoomID = Convert.ToInt32(cmbRoom.Text),
                    BookingStartsDate = dateBookingStarts.Value,
                    BookingEndsDate = dateBookingEndsDate.Value,
                    BookingStatus = "Confirmed",
                };

                bookingRepository.CreateBooking(booking);

                MessageBox.Show("Booking created successfully ✅");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
