using System;
using System.Windows.Forms;

namespace CheckInn.Forms.ReceptionistForms.RoomForms
{
    public partial class CreateServiceRequestForm : Form
    {
        ServiceRepository serviceRepository = new ServiceRepository();
        private int roomID;
        private int bookingID;

        public CreateServiceRequestForm(int roomID, int bookingID)
        {
            InitializeComponent();
            this.roomID = roomID;
            this.bookingID = bookingID;
        }

        private void btnRequestService_Click(object sender, EventArgs e)
        {
            if (txtServiceContent.Text == "")
            {
                MessageBox.Show("Please enter a service description.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            serviceRepository.CreateServiceRequest(roomID, bookingID, txtServiceContent.Text);
            MessageBox.Show("Service request created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

     
    }
}