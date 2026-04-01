using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn.Model
{
    public class RoomCharge
    {
        public int ServiceID { get; set; }
        public int BookingID { get; set; }
        public decimal RoomChargeAmount { get; set; }
        public string ChargeContent { get; set; }
    }
}