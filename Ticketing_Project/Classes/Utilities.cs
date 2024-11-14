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

        public double GeneratePrice(double distance, string boardClass)
        {
            double multiplier;
            int basePrice;
            // Convert degrees of coordinates into kilometers
            double distanceKM = distance * 111;

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

            double price = basePrice + (distanceKM * multiplier);

            return price;
        }

        public double CalculateDistance(Location loc1, Location loc2)
        {
            // utilize distance formula for finding distance between two coordinates
            double x = Math.Pow((loc2.Latitude - loc1.Latitude), 2);
            double y = Math.Pow((loc2.Longitude - loc1.Longitude), 2);
            double distance = Math.Sqrt(x + y);

            return distance;
        }
    }
}
