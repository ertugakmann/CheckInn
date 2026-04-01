using CheckInn.Model;
using System;
using System.Windows.Forms;

namespace CheckInn.Forms.ReceptionistForms.RoomForms.ManageRoomServiceRequests
{
    public partial class UpdateServiceRequestsForm : Form
    {
        ServiceRepository serviceRepository = new ServiceRepository();
        private RoomService roomService;

        public UpdateServiceRequestsForm(RoomService roomService)
        {
            InitializeComponent();
            this.roomService = roomService;
        }

        private void UpdateServiceRequestsForm_Load(object sender, EventArgs e)
        {
            txtServiceContent.Text = roomService.ServiceContent;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtServiceContent.Text == "")
            {
                MessageBox.Show("Please enter a service description.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roomService.ServiceContent = txtServiceContent.Text;
            serviceRepository.UpdateServiceRequest(roomService);
            MessageBox.Show("Service request updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this service request?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                serviceRepository.DeleteServiceRequest(roomService.ServiceID);
                MessageBox.Show("Service request deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}