using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn.Model
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime CustomerDOB { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; }

        public string Details 
        {
            get { return $"{CustomerID} - {CustomerName}"; }
                
        }
    }
}
