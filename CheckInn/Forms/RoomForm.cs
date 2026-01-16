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
            // TODO: This line of code loads data into the 'checkInnDatabaseDataSet.tblRoom' table. You can move, or remove it, as needed.
            this.tblRoomTableAdapter.Fill(this.checkInnDatabaseDataSet.tblRoom);
            this.WindowState = FormWindowState.Maximized;

            // Combo Box
            List<Room> rooms = roomRepository.getAllRooms();

            cmbRoomID.DataSource = rooms;
            cmbRoomID.DisplayMember = "DisplayText"; // ekranda görünen
            cmbRoomID.ValueMember = "RoomID";        // arka planda tutulan

            cmbRoomID.DropDownStyle = ComboBoxStyle.DropDownList;


            Room room = roomRepository.GetSelectedRoom(roomNumber);

            lblRoomNumber.Text = Convert.ToString(room.RoomID);

            // Set Labels and Forms
            string status = roomRepository.GetRoomStatus(room.RoomID);
            if (status == "Available")
            {
                // Set Labels and forms
                lblStatus.Text = "Available";
                lblStatus.ForeColor = Color.Green;

                lblFormTitle.Text = "Set Customer to the Room";
            }
            else if (status == "Occupied")
            {
                lblStatus.Text = "Occupied";
                lblStatus.ForeColor = Color.Red;

                lblFormTitle.Text = "Manage Room";
            }
          

            
        }

        private void btnSetCustomer_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            booking = new Booking();

            // Set Customer Details to Customer Variable
            customer.CustomerName = txtName.Text;
            customer.CustomerDOB = dateDOB.Value;
            customer.CustomerEmail = txtEmail.Text;
            customer.CustomerPhoneNumber = txtName.Text;
            customer.CustomerAddress = txtAddress.Text;

            customerRepository.CreateCustomer(customer);

            // Create new Booking Record
            
            booking.BookingStartsDate = dateBookingStarts.Value;
            booking.BookingEndsDate = dateBookingEndsDate.Value;

            
        }

      
    }
}
