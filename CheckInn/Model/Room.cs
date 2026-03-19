using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn.Model
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }

        public string DisplayText
        {
            get { return RoomID + " - " + RoomType; }
        }

    }
}
