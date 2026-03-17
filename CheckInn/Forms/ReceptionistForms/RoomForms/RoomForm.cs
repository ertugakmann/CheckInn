using CheckInn.Forms.ReceptionistForms;
using CheckInn.Forms.ReceptionistForms.RoomForms;
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
        BookingRepository bookingRepository = new BookingRepository();

        private Customer customer;
        private List<Booking> selectedRoomBookings;
        private Booking booking;
        private Room selectedRoom;
        private int roomNumber;

        public RoomForm(int roomNumber)
        {
            InitializeComponent();
            this.roomNumber = roomNumber;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // Get Room Details
            selectedRoom = roomRepository.GetSelectedRoom(roomNumber);

            // Get Booking Details if there is
            selectedRoomBookings = bookingRepository.GetAllBookings();



            lblRoomNumber.Text = Convert.ToString(roomNumber);
          
        }

        private void btnCreateRoomService_Click(object sender, EventArgs e)
        {
            CreateServiceRequestForm createServiceRequestForm = new CreateServiceRequestForm();
            createServiceRequestForm.ShowDialog();
        }

        private void btnCreateRoomCharges_Click(object sender, EventArgs e)
        {
            CreateRoomChargeForm createRoomChargeForm = new CreateRoomChargeForm();
            createRoomChargeForm.ShowDialog();
        }
    }
}
