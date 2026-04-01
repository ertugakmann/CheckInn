using CheckInn.Forms.ReceptionistForms;
using CheckInn.Forms.ReceptionistForms.RoomForms;
using CheckInn.Forms.ReceptionistForms.RoomForms.CheckInForms;
using CheckInn.Forms.ReceptionistForms.RoomForms.ManageRoomCharges;
using CheckInn.Forms.ReceptionistForms.RoomForms.ManageRoomServiceRequests;
using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CheckInn.Forms
{
    public partial class RoomForm : Form
    {
        RoomRepository roomRepository = new RoomRepository();
        BookingRepository bookingRepository = new BookingRepository();
        ServiceRepository serviceRepository = new ServiceRepository();
        ChargeRepository chargeRepository = new ChargeRepository();

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
            LoadServiceRequests();
            LoadRoomCharges();
        }

        private void btnCreateRoomService_Click(object sender, EventArgs e)
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
                MessageBox.Show("No checked-in guest found. Service requests require an active check-in.", "No Active Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateServiceRequestForm createServiceRequestForm = new CreateServiceRequestForm(selectedRoom.RoomID, checkedInBooking.BookingID);
            createServiceRequestForm.ShowDialog();
            LoadServiceRequests();
        }

        private void btnCreateRoomCharges_Click(object sender, EventArgs e)
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
                MessageBox.Show("No checked-in guest found. Room charges require an active check-in.", "No Active Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateRoomChargeForm createRoomChargeForm = new CreateRoomChargeForm(checkedInBooking.BookingID);
            createRoomChargeForm.ShowDialog();
            LoadRoomCharges();
        }

        private void LoadRoomCharges()
        {
            Booking checkedInBooking = null;

            for (int i = 0; i < selectedRoomBookings.Count; i++)
            {
                if (selectedRoomBookings[i].BookingStatus == "CheckedIn")
                {
                    checkedInBooking = selectedRoomBookings[i];
                }
            }

            dgvRoomCharges.DataSource = null;
            dgvRoomCharges.AutoGenerateColumns = false;
            dgvRoomCharges.Columns.Clear();

            DataGridViewTextBoxColumn colServiceID = new DataGridViewTextBoxColumn();
            colServiceID.DataPropertyName = "ServiceID";
            colServiceID.Visible = false;
            dgvRoomCharges.Columns.Add(colServiceID);

            DataGridViewTextBoxColumn colContent = new DataGridViewTextBoxColumn();
            colContent.HeaderText = "Charge Description";
            colContent.DataPropertyName = "ChargeContent";
            dgvRoomCharges.Columns.Add(colContent);

            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.HeaderText = "Amount";
            colAmount.DataPropertyName = "RoomChargeAmount";
            dgvRoomCharges.Columns.Add(colAmount);

            if (checkedInBooking == null)
            {
                return;
            }

            List<RoomCharge> charges = chargeRepository.GetChargesByBookingID(checkedInBooking.BookingID);
            dgvRoomCharges.DataSource = charges;
            dgvRoomCharges.ReadOnly = true;
            dgvRoomCharges.AllowUserToAddRows = false;
            dgvRoomCharges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvRoomCharges_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            RoomCharge selectedCharge = (RoomCharge)dgvRoomCharges.CurrentRow.DataBoundItem;

            if (selectedCharge == null) return;

            UpdateRoomChargesForm updateForm = new UpdateRoomChargesForm(selectedCharge);
            updateForm.ShowDialog();
            LoadRoomCharges();
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

            LoadUpcomingBookings();
        }

        private void LoadUpcomingBookings()
        {
            gridBookings.DataSource = null;
            gridBookings.AutoGenerateColumns = false;
            gridBookings.Columns.Clear();

            DataGridViewTextBoxColumn colCustomer = new DataGridViewTextBoxColumn();
            colCustomer.HeaderText = "Customer";
            colCustomer.DataPropertyName = "CustomerName";
            gridBookings.Columns.Add(colCustomer);

            DataGridViewTextBoxColumn colCheckIn = new DataGridViewTextBoxColumn();
            colCheckIn.HeaderText = "Check-In Date";
            colCheckIn.DataPropertyName = "CheckIn";
            gridBookings.Columns.Add(colCheckIn);

            DataGridViewTextBoxColumn colCheckOut = new DataGridViewTextBoxColumn();
            colCheckOut.HeaderText = "Check-Out Date";
            colCheckOut.DataPropertyName = "CheckOut";
            gridBookings.Columns.Add(colCheckOut);

            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("CheckIn");
            dt.Columns.Add("CheckOut");

            for (int i = 0; i < selectedRoomBookings.Count; i++)
            {
                if (selectedRoomBookings[i].BookingStartsDate.Date >= DateTime.Now.Date
                    && selectedRoomBookings[i].BookingStatus != "Cancelled"
                    && selectedRoomBookings[i].BookingStatus != "Finished")
                {
                    string customerName = bookingRepository.GetCustomerNameByBookingID(selectedRoomBookings[i].BookingID);

                    DataRow row = dt.NewRow();
                    row["CustomerName"] = customerName;
                    row["CheckIn"] = selectedRoomBookings[i].BookingStartsDate.ToString("dd/MM/yyyy");
                    row["CheckOut"] = selectedRoomBookings[i].BookingEndsDate.ToString("dd/MM/yyyy");
                    dt.Rows.Add(row);
                }
            }

            gridBookings.DataSource = dt;
            gridBookings.ReadOnly = true;
            gridBookings.AllowUserToAddRows = false;
            gridBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            ManageBookingsForm manageBookingsForm = new ManageBookingsForm(selectedRoom.RoomID);
            manageBookingsForm.ShowDialog();
            RefreshRoomStatus();
        }

        private void gridBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadServiceRequests()
        {
            Booking checkedInBooking = null;

            for (int i = 0; i < selectedRoomBookings.Count; i++)
            {
                if (selectedRoomBookings[i].BookingStatus == "CheckedIn")
                {
                    checkedInBooking = selectedRoomBookings[i];
                }
            }

            dgvServiceRequests.AutoGenerateColumns = false;
            dgvServiceRequests.Columns.Clear();

            DataGridViewTextBoxColumn colServiceID = new DataGridViewTextBoxColumn();
            colServiceID.HeaderText = "ServiceID";
            colServiceID.DataPropertyName = "ServiceID";
            colServiceID.Visible = false;
            dgvServiceRequests.Columns.Add(colServiceID);

            DataGridViewTextBoxColumn colContent = new DataGridViewTextBoxColumn();
            colContent.HeaderText = "Service Content";
            colContent.DataPropertyName = "ServiceContent";
            dgvServiceRequests.Columns.Add(colContent);

            DataGridViewTextBoxColumn colTime = new DataGridViewTextBoxColumn();
            colTime.HeaderText = "Request Time";
            colTime.DataPropertyName = "RequestTime";
            dgvServiceRequests.Columns.Add(colTime);

            if (checkedInBooking == null)
            {
                dgvServiceRequests.DataSource = null;
                return;
            }

            List<RoomService> services = serviceRepository.GetServicesByBookingID(checkedInBooking.BookingID);
            dgvServiceRequests.DataSource = services;
            dgvServiceRequests.ReadOnly = true;
            dgvServiceRequests.AllowUserToAddRows = false;
            dgvServiceRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvRoomServiceRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            RoomService selectedService = (RoomService)dgvServiceRequests.CurrentRow.DataBoundItem;

            UpdateServiceRequestsForm updateForm = new UpdateServiceRequestsForm(selectedService);
            updateForm.ShowDialog();
            LoadServiceRequests();
        }


    }
}