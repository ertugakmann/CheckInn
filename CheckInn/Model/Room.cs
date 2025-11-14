using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn.Model
{
    internal class Room
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public float PricePerNight { get; set; }
        public string Status { get; set; }
       
    }
}
