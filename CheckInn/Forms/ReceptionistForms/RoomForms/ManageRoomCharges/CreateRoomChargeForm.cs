using System;
using System.Windows.Forms;

namespace CheckInn.Forms.ReceptionistForms.RoomForms
{
    public partial class CreateRoomChargeForm : Form
    {
        ChargeRepository chargeRepository = new ChargeRepository();
        private int bookingID;

        public CreateRoomChargeForm(int bookingID)
        {
            InitializeComponent();
            this.bookingID = bookingID;
        }

        private void btnCreateCharge_Click(object sender, EventArgs e)
        {
            if (txtChargeContent.Text == "" || txtChargeAmount.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = Convert.ToDecimal(txtChargeAmount.Text);
            chargeRepository.CreateRoomCharge(bookingID, amount, txtChargeContent.Text);
            MessageBox.Show("Room charge added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}