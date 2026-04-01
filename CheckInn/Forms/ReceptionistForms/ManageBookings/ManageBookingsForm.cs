using CheckInn.Forms.ReceptionistForms.ManageBookings;
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
    public partial class ManageBookingsForm : Form
    {
        BookingRepository bookingRepository = new BookingRepository();
        private int roomID = -1;

        public ManageBookingsForm()
        {
            InitializeComponent();
        }

        public ManageBookingsForm(int roomID)
        {
            InitializeComponent();
            this.roomID = roomID;
        }

        private void ManageBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            dgvBookings.DataSource = null;

            if (roomID == -1)
            {
                dgvBookings.DataSource = bookingRepository.GetAllBookings();
            }
            else
            {
                dgvBookings.DataSource = bookingRepository.getSelectedRoomBookings(roomID);
            }
        }

        private void dgvBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Booking booking = (Booking)dgvBookings.CurrentRow.DataBoundItem;
            UpdateBookingForm updateBookingForm = new UpdateBookingForm(booking);
            updateBookingForm.ShowDialog();

            LoadBookings();
        }
    }
}
