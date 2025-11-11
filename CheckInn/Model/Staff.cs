using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn.Model
{
    public class Staff
    {
        public int StaffID { get; set; } 
        public string StaffName { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPhone { get; set; }
        public int StaffPIN { get; set; }
        public int RoleID { get; set; }
        public DateTime StaffDOB { get; set; }

    }
}
