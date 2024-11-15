using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_Project.Classes
{
    public class Utilities
    {
        // Randomizer
        Random random = new Random();

        Places place = new Places();
        List<Location> data;

        public Utilities()
        {
            data = place.GetLocationList();
        }

        public void Change_Font(Form form)
        {
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
            {
                // Create a font variable
                PrivateFontCollection pfc = new PrivateFontCollection();
                // Locate the path of the font.ttf
                pfc.AddFontFile(Environment.CurrentDirectory + "\\..\\..\\..\\Resources\\Poppins-Regular.ttf");
                // Loop through all the characters in the forms and change it to the corresponding font
                foreach (Control c in form.Controls)
                {
                    c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
                }
            }
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

            return Math.Truncate(price);
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

        private string CalculateDuration(double distance)
        {
            // Average plane speed km/h
            double hours = distance / 880;
            // decimal hours to minutes
            double minutes = 60 * (hours - Math.Truncate(hours));

            string duration = $"{Math.Round(hours)}hr {Math.Round(minutes)}min";
            return duration;
        }

        private string RandomTripType()
        {
            if (random.Next(1, 2) == 1)
            {
                return "Round Trip";
            }

            return "One way";
        }

        private string RandomBoardClass()
        {
            if (random.Next(1, 2) == 1)
            {
                return "Economy";
            }

            return "Business Class";
        }

        private Location RandomLocation() 
        {
            Location location = data[random.Next(0, 1046)];
            return location;
        }

        public void GenerateFlashDeals (FlowLayoutPanel panel)
        {
            // Number of flash deals
            int numCards = 10;

            for ( int i = 0; i < numCards; i++) 
            { 
                Location loc1 = RandomLocation();
                Location loc2 = RandomLocation();
                while (loc1 == loc2)
                {
                    loc2 = RandomLocation();
                }

                // Flight Details
                double distance = CalculateDistance(loc1, loc2);
                string duration = CalculateDuration(distance);
                string boardClass = RandomBoardClass();
                string tripType = RandomTripType();


                int price = (int) GeneratePrice(distance, boardClass, tripType, true);
                CardDeal temp = new CardDeal(price, tripType,loc1.City, loc2.City, "Tuesday, November 4th", duration, boardClass);
                panel.Controls.Add(temp);
            }
        }
    }
}
