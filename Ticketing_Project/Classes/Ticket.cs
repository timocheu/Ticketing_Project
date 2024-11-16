using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Project.Classes
{
    public class Ticket
    {
        //CardDeal temp = new CardDeal(price, tripType,loc1.City, loc2.City, "Tuesday, November 4th", duration, boardClass);
        public string From { get; set; }
        public string FromCountryCode { get; set; }
        public string Destination { get; set; }
        public string DestinationCountryCode { get; set; }
        public DateTime FlightDate { get; set; }
        public string BoardClass { get; set; }
        public string TripType { get; set; }
        public string Duration { get; set; }
    }
}
