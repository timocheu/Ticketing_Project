using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Project.Classes
{
    public class Receipt
    {
        public int ReceiptID { get; set; }
        public DateTime CreationDate { get; set; }
        public string Email { get; set; }
        public int Passengers { get; set; }
        public string PaymentMethod { get; set; }
        public string TripType { get; set; }
        public int Total { get; set; }
    }
}
