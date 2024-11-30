using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketing_Project.User_controls;

namespace Ticketing_Project.Classes
{
    public class Utilities
    {
        // Randomizer
        Random random = new Random();

        Places place = new Places();
        List<Location> data;

        public void LinkData()
        {
            data = place.GetLocationList();
        }

        public double GeneratePrice(double distance, string boardClass, string TripType, bool deal = false)
        {
            int trips = 1;
            double multiplier;
            int basePrice;
            
            if (TripType == "Round Trip") trips = 2;

            // set prices base on accommodation class
            if (boardClass == "Business Class")
            {
                multiplier = 0.5;
                basePrice = 1500;
            } 
            else
            {
                multiplier = 0.3;
                basePrice = 750;
            }


            double price = (basePrice + (distance * multiplier)) * trips;

            // Check if its a deal
            if (deal == true)
            {
                // Discounted 20% for deals
                Math.Truncate(price - (price * .2));
            }

            return Math.Truncate(price * .2);
        }

        public double CalculateDistance(Location loc1, Location loc2)
        {
            // Latitude and Longitude
            // utilize distance formula for finding distance between two coordinates
            double x = Math.Pow((loc2.Latitude - loc1.Latitude), 2);
            double y = Math.Pow((loc2.Longitude - loc1.Longitude), 2);
            double distance = Math.Sqrt(x + y);

            // Return as kilometer
            return distance * 111;
        }

        internal string CalculateDuration(double distance)
        {
            // Average plane speed km/h
            double hours = distance / 880;
            // decimal hours to minutes
            double minutes = 60 * (hours - Math.Truncate(hours));

            string duration = $"{Math.Round(hours)}hr {Math.Round(minutes)}min";
            return duration;
        }

        protected string RandomTripType()
        {
            if (random.Next(1, 5) == 1)
            {
                return "Round Trip";
            }

            return "One way";
        }

        protected string RandomBoardClass()
        {
            if (random.Next(1, 5) == 1)
            {
                return "Business Class";
            }

            return "Economy";
        }

        protected Location RandomLocation() 
        {
            Location location = data[random.Next(0, 1046)];
            return location;
        }

        protected DateTime RandomDate()
        {
            DateTime currentTime = DateTime.Now;
            currentTime = currentTime.AddDays(random.Next(1, 365));

            return currentTime;
        }

        public void GenerateFlashDeals (FlowLayoutPanel panel)
        {
            // Number of flash deals
            int numCards = 10;

            for ( int i = 0; i < numCards; i++) 
            { 
                Location loc1 = RandomLocation();
                Location loc2 = RandomLocation();
                double distance = CalculateDistance(loc1, loc2);
                while (loc1 == loc2)
                {
                    loc2 = RandomLocation();
                }

                // Flight Details
                Ticket ticket = new Ticket();
                // From
                ticket.From = loc1.City;
                ticket.FromCountry = loc1.Country;
                ticket.FromCountryCode = loc1.Country_Code;
                // Destination
                ticket.Destination = loc2.City;
                ticket.DestinationCountry = loc2.Country;
                ticket.DestinationCountryCode = loc2.Country_Code;
                // Other flight details
                ticket.FlightDate = RandomDate();
                ticket.BoardClass = RandomBoardClass();
                ticket.TripType = RandomTripType();
                ticket.Distance = distance;
                ticket.Duration = CalculateDuration(distance);
                ticket.isDeal = true;
                // Calculate price
                int price = (int) GeneratePrice(distance, ticket.BoardClass, ticket.TripType, ticket.isDeal);

                CardDeal temp = new CardDeal(price, ticket);
                panel.Controls.Add(temp);
            }
        }

        public void ShowTicketsOwned(FlowLayoutPanel panel, List<Ticket> ownedTicket)
        {
            foreach (Ticket ticket in ownedTicket)
            {
                TicketTemplate template = new TicketTemplate(ticket);
                panel.Controls.Add(template);
            }
        }

        public List<string> GenerateCityCountryList()
        {
            List<string> list = new List<string>();
            foreach (var location in data) 
            {
                list.Add($"{location.City} ({location.Country})");
            }

            return list;
        }

        public void ShowCheckout(Form form, Checkout checkout)
        {
            form.Controls.Add(checkout);
            checkout.BringToFront();
        }

        public void ShowFlightDetails(Form form, CalculatorFlightDetails FlightDetails)
        {
            form.Controls.Add(FlightDetails);
            FlightDetails.BringToFront();
        }

        public Location GetLocation(int index)
        {
            return data[index];
        }

        public string RandomGate()
        {
            string[] gates = { "A", "B", "C", "D", "E", "F", };
            return $"{random.Next(1, 100)}-{gates[random.Next(0, 5)]}";
        }

        public string RandomTerminal()
        {
            return $"T-{random.Next(1, 10)}";
        }
        
        public string RandomSeat()
        {
            string[] gates = { "A", "B", "C", "D", "E", "F", };
            return $"{gates[random.Next(0, 5)]}-{random.Next(1, 100)}";
        }
    }
}
