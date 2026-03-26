using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckInn.Forms.ReceptionistForms.RoomForms.CheckInForms
{
    public partial class SelectBookingForm : Form
    {
        private List<Booking> bookings;
        private BookingRepository bookingRepository = new BookingRepository();

        public SelectBookingForm(List<Booking> bookings)
        {
            InitializeComponent();
            this.bookings = bookings;
        }

        private void SelectBookingForm_Load(object sender, EventArgs e)
        {
            dgvRoomBookings.AutoGenerateColumns = false;

            // Define columns BEFORE setting DataSource
            dgvRoomBookings.Columns.Clear();
            dgvRoomBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Booking ID",
                DataPropertyName = "BookingID",
                Width = 80
            });
            dgvRoomBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-In",
                DataPropertyName = "BookingStartsDate",
                Width = 120,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });
            dgvRoomBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-Out",
                DataPropertyName = "BookingEndsDate",
                Width = 120,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });
            dgvRoomBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "BookingStatus",
                Width = 100
            });

            // Set DataSource AFTER columns are defined
            dgvRoomBookings.DataSource = bookings;

            if (dgvRoomBookings.Rows.Count > 0)
                dgvRoomBookings.Rows[0].Selected = true;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvRoomBookings.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBooking = (Booking)dgvRoomBookings.CurrentRow.DataBoundItem;

            
            if (selectedBooking.BookingStatus == "CheckedIn")
            {
                MessageBox.Show("This booking is already checked in.",
                                "Already Checked In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Check in booking #{selectedBooking.BookingID}?\n\nCheck-in: {selectedBooking.BookingStartsDate:dd/MM/yyyy}\nCheck-out: {selectedBooking.BookingEndsDate:dd/MM/yyyy}",
                "Confirm Check-In",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            bookingRepository.CheckIn(selectedBooking.BookingID, selectedBooking.RoomID);

            MessageBox.Show("Guest checked in successfully!",
                            "Check-In Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}