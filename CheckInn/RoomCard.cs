using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckInn
{
    public partial class RoomCard : UserControl
    {
        public RoomCard()
        {
            InitializeComponent();

           
            this.Cursor = Cursors.Hand;

            foreach (Control c in this.Controls)
            {
                c.Click += (s, e) => this.OnClick(e);
            }
        }

        public void SetRoom(string roomNumber, string status)
        {
            lblRoomNumber.Text = roomNumber;

            if (status == "Available")
            {
                lblStatus.Text = "Available";
                lblStatus.ForeColor = Color.Green;
            }
            else if (status == "Occupied")
            {
                lblStatus.Text = "Occupied";
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}