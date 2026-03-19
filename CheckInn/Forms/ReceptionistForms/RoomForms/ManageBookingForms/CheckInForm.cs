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

namespace CheckInn.Forms.ReceptionistForms.RoomForms.ManageBookingForms
{
    public partial class CheckInForm : Form
    {
        Room selectedRoom;
        Booking booking;
        BookingRepository bookingRepository = new BookingRepository();
        CustomerRepository customerRepository = new CustomerRepository();
        RoomRepository roomRepository = new RoomRepository();


        public CheckInForm(Room room)
        {
            InitializeComponent();
            selectedRoom = room;
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            // Bookings
            List<Booking> bookings = bookingRepository.getSelectedRoomBookings(selectedRoom.RoomID);

            cmbBooking.DataSource = bookings;
            cmbBooking.DisplayMember = "Booking";
            

          


        }
    }
}
