using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Project.Classes
{
    static class FlightRandomizer
    {
        public static readonly Random random = new Random();
        public static readonly string[] gates = { "A", "B", "C", "D", "E", "F", };

        public static Location RandomLocation(List<Location> locations) => locations[random.Next(0, 1046)];
        // Location location = locations[random.Next(0, 1046)];
        // return location;
        public static string RandomTripType() => random.Next(1, 5) == 1 ? "Round Trip" : "One Way";
        public static string RandomBoardClass() => random.Next(1, 5) == 1 ? "Business Class" : "Economy";
        public static DateTime RandomDate() => DateTime.Now.AddDays(random.Next(1, 365));
        public static string RandomGate() => $"{random.Next(1, 100)}-{gates[random.Next(0, 5)]}";
        public static string RandomTerminal() => $"T-{random.Next(1, 10)}";
        public static string RandomSeat() => $"{gates[random.Next(0, 5)]}-";

        public static Ticket RandomTicket(out int ticketPrice)
        {
            // set the data
            Location loc1 = RandomLocation(Places.AllLocation);
            Location loc2 = RandomLocation(Places.AllLocation);
            while (loc1 == loc2)
            {
                loc2 = FlightRandomizer.RandomLocation(Places.AllLocation);
            }
            double distance = FlightMath.CalculateDistance(loc1, loc2);

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
            // Randomize details
            ticket.FlightDate = FlightRandomizer.RandomDate();
            ticket.ReturnDate = ticket.FlightDate.AddDays(random.Next(30, 90));
            ticket.BoardClass = FlightRandomizer.RandomBoardClass();
            ticket.TripType = FlightRandomizer.RandomTripType();
            ticket.Distance = distance;
            ticket.Duration = FlightMath.CalculateDuration(distance);
            ticket.isDeal = true;

            // Calculate price and out the variable
            ticketPrice = (int) FlightMath.CalculatePrice(distance, ticket.BoardClass, ticket.TripType, ticket.isDeal);

            return ticket;
        }
    }
}
