using CheckInn.Model;
using System;
using System.Windows.Forms;

namespace CheckInn.Forms.ReceptionistForms.RoomForms.ManageRoomCharges
{
    public partial class UpdateRoomChargesForm : Form
    {
        ChargeRepository chargeRepository = new ChargeRepository();
        private RoomCharge roomCharge;

        public UpdateRoomChargesForm(RoomCharge roomCharge)
        {
            InitializeComponent();
            this.roomCharge = roomCharge;
        }

        private void UpdateRoomChargesForm_Load(object sender, EventArgs e)
        {
            txtChargeContent.Text = roomCharge.ChargeContent;
            txtChargeAmount.Text = roomCharge.RoomChargeAmount.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtChargeContent.Text == "" || txtChargeAmount.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roomCharge.ChargeContent = txtChargeContent.Text;
            roomCharge.RoomChargeAmount = Convert.ToDecimal(txtChargeAmount.Text);
            chargeRepository.UpdateRoomCharge(roomCharge);
            MessageBox.Show("Room charge updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this charge?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                chargeRepository.DeleteRoomCharge(roomCharge.ServiceID);
                MessageBox.Show("Room charge deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}