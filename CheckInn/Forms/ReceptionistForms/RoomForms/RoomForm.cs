using CheckInn.Forms.ReceptionistForms;
using CheckInn.Forms.ReceptionistForms.RoomForms;
using CheckInn.Forms.ReceptionistForms.RoomForms.CheckInForms;
using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            selectedRoom = roomRepository.GetSelectedRoom(roomNumber);
            selectedRoomBookings = bookingRepository.getSelectedRoomBookings(selectedRoom.RoomID);

            lblRoomNumber.Text = Convert.ToString(roomNumber);
            lblPricePerNight.Text = "Price Per Night: " + Convert.ToString(selectedRoom.PricePerNight);
            lblRoomType.Text = "Room Type: " + selectedRoom.RoomType;

            RefreshRoomStatus();
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            List<Booking> eligibleBookings = new List<Booking>();

            for (int i = 0; i < selectedRoomBookings.Count; i++)
            {
                if (selectedRoomBookings[i].BookingStatus != "CheckedIn" && selectedRoomBookings[i].BookingStatus != "Cancelled" && selectedRoomBookings[i].BookingStatus != "Finished")
                {
                    eligibleBookings.Add(selectedRoomBookings[i]);
                }
            }

            if (eligibleBookings.Count == 0)
            {
                MessageBox.Show("No active bookings found for this room.", "No Bookings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Booking nearestBooking = eligibleBookings[0];

            for (int i = 0; i < eligibleBookings.Count; i++)
            {
                if (eligibleBookings[i].BookingStartsDate.Date >= DateTime.Now.Date)
                {
                    nearestBooking = eligibleBookings[i];
                    break;
                }
            }

            string customerName = bookingRepository.GetCustomerNameByBookingID(nearestBooking.BookingID);

            if (eligibleBookings.Count == 1)
            {
                DialogResult confirm = MessageBox.Show(
                    "Check in the following guest?\n\nCustomer: " + customerName + "\nCheck-in: " + nearestBooking.BookingStartsDate.ToString("dd/MM/yyyy") + "\nCheck-out: " + nearestBooking.BookingEndsDate.ToString("dd/MM/yyyy"),
                    "Confirm Check-In",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    PerformCheckIn(nearestBooking.BookingID);
                }

                return;
            }

            DialogResult result = MessageBox.Show(
                "Nearest booking found:\n\nCustomer: " + customerName + "\nCheck-in: " + nearestBooking.BookingStartsDate.ToString("dd/MM/yyyy") + "\nCheck-out: " + nearestBooking.BookingEndsDate.ToString("dd/MM/yyyy") + "\n\nClick Yes to check in this guest.\nClick No to choose a different booking.",
                "Confirm Check-In",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                PerformCheckIn(nearestBooking.BookingID);
            }
            else if (result == DialogResult.No)
            {
                SelectBookingForm selectBookingForm = new SelectBookingForm(eligibleBookings);
                if (selectBookingForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshRoomStatus();
                }
            }
        }

        private void PerformCheckIn(int bookingID)
        {
            bookingRepository.CheckIn(bookingID, selectedRoom.RoomID);
            MessageBox.Show("Guest checked in successfully!", "Check-In Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshRoomStatus();
        }

        private void RefreshRoomStatus()
        {
            selectedRoomBookings = bookingRepository.getSelectedRoomBookings(selectedRoom.RoomID);

            string status = roomRepository.GetRoomStatus(selectedRoom.RoomID);
            lblRoomStatus.Text = "Room Status: " + status;

            Booking checkedInBooking = null;

            for (int i = 0; i < selectedRoomBookings.Count; i++)
            {
                if (selectedRoomBookings[i].BookingStatus == "CheckedIn")
                {
                    checkedInBooking = selectedRoomBookings[i];
                }
            }

            if (checkedInBooking != null)
            {
                lblCheckInDate.Text = "Check-In: " + checkedInBooking.BookingStartsDate.ToString("dd/MM/yyyy");
                lblCheckOutDate.Text = "Check-Out: " + checkedInBooking.BookingEndsDate.ToString("dd/MM/yyyy");
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = true;
            }
            else
            {
                lblCheckInDate.Text = "Check-In: --/--/----";
                lblCheckOutDate.Text = "Check-Out: --/--/----";
                btnCheckIn.Enabled = true;
                btnCheckOut.Enabled = false;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Booking checkedInBooking = null;

            for (int i = 0; i < selectedRoomBookings.Count; i++)
            {
                if (selectedRoomBookings[i].BookingStatus == "CheckedIn")
                {
                    checkedInBooking = selectedRoomBookings[i];
                }
            }

            if (checkedInBooking == null)
            {
                MessageBox.Show("No checked-in guest found for this room.");
                return;
            }

            string customerName = bookingRepository.GetCustomerNameByBookingID(checkedInBooking.BookingID);

            DialogResult confirm = MessageBox.Show(
                "Check out " + customerName + "?\n\nCheck-in: " + checkedInBooking.BookingStartsDate.ToString("dd/MM/yyyy") + "\nCheck-out: " + checkedInBooking.BookingEndsDate.ToString("dd/MM/yyyy"),
                "Confirm Check-Out",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                bookingRepository.CheckOut(checkedInBooking.BookingID, selectedRoom.RoomID);
                MessageBox.Show("Guest checked out successfully!");
                RefreshRoomStatus();
            }
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
        
            CreateNewBookingForm createNewBookingForm = new CreateNewBookingForm(selectedRoom.RoomID);
            createNewBookingForm.ShowDialog();
            RefreshRoomStatus();
        
    }
    }
}