using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckInn
{
    public partial class RoomCard : UserControl
    {
        public RoomCard()
        {
            InitializeComponent();
        }

        public void SetRoom(string roomNumber, bool isBusy)
        {
            lblRoomNumber.Text = "Room " + roomNumber;

            if (isBusy)
            {
                lblStatus.Text = "Busy";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "Available";
                lblStatus.ForeColor = Color.Green;
            }
        }
    }
}
