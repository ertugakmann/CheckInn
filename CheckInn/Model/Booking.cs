using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn.Model
{
    internal class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public int TotalAmount { get; set; }
        public DateTime BookingStartsDate { get; set; }
        public DateTime BookingEndsDate { get; set; }
        public string BookingStatus { get; set; }
        
    }
}
