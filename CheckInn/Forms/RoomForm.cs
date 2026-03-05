using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CheckInn.Forms
{
    public partial class RoomForm : Form
    {
        RoomRepository roomRepository = new RoomRepository();
        CustomerRepository customerRepository = new CustomerRepository();
        BookingRepository bookingRepository = new BookingRepository();

        private Customer customer;
        private Booking booking;
        private int roomNumber;

        public RoomForm(int roomNumber)
        {
            InitializeComponent();
            this.roomNumber = roomNumber;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
         

        }


    }
}
