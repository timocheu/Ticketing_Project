using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Project.Classes
{
    static class FlightMath
    {
        static public double CalculatePrice(double distance, string boardClass, string TripType, bool deal = false)
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

        static public double CalculateDistance(Location loc1, Location loc2)
        {
            // Latitude and Longitude
            // utilize distance formula for finding distance between two coordinates
            // 5% Error Margin
            double x = Math.Pow((loc2.Latitude - loc1.Latitude), 2);
            double y = Math.Pow((loc2.Longitude - loc1.Longitude), 2);
            double distance = Math.Sqrt(x + y);

            // Return as kilometer
            return distance * 111;
        }

        static public string CalculateDuration(double distance)
        {
            // Average plane speed km/h
            double hours = distance / 880;
            // decimal hours to minutes
            double minutes = 60 * (hours - Math.Truncate(hours));

            string duration = $"{Math.Round(hours)}hr {Math.Round(minutes)}min";
            return duration;
        }
    }
}
