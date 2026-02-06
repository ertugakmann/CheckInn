using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CheckInn.Forms
{
    public partial class RoomForm : Form
    {
        RoomRepository roomRepository = new RoomRepository();
        CustomerRepository customerRepository = new CustomerRepository();
        BookingRepository bookingRepository = new BookingRepository();

        private Customer customer;
        private Booking booking;
        private int roomNumber;

        public RoomForm(int roomNumber)
        {
            InitializeComponent();
            this.roomNumber = roomNumber;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
          
          

            
        }

        private void btnSetCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // -------- VALIDATION --------
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Name and Email are required");
                    return;
                }

                if (dateBookingEndsDate.Value <= dateBookingStarts.Value)
                {
                    MessageBox.Show("Booking end date must be after start date");
                    return;
                }

                // -------- CREATE CUSTOMER --------
                Customer customer = new Customer
                {
                    CustomerName = txtName.Text.Trim(),
                    CustomerDOB = dateDOB.Value,
                    CustomerEmail = txtEmail.Text.Trim(),
                    CustomerPhoneNumber = txtPhoneNumber.Text.Trim(), 
                    CustomerAddress = txtAddress.Text.Trim()
                };

                int newCustomerID = customerRepository.CreateCustomer(customer);

                // -------- CREATE BOOKING --------
                Booking booking = new Booking
                {
                    CustomerID = newCustomerID,
                    RoomID = roomNumber,
                    BookingStartsDate = dateBookingStarts.Value,
                    BookingEndsDate = dateBookingEndsDate.Value
                };

                bookingRepository.CreateBooking(booking);

                MessageBox.Show("Customer and booking created successfully ✅");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




    }
}
