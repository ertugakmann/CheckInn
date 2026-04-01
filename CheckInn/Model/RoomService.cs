using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn.Model
{
    public class RoomService
    {
        public int ServiceID { get; set; }
        public string ServiceContent { get; set; }
        public int RoomID { get; set; }
        public int BookingID { get; set; }
        public DateTime RequestTime { get; set; }
    }
}