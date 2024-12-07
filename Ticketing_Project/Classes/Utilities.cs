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
    static class Utilities
    {
        // Class for Downlaoding
        public static Bitmap CaptureToImage(this Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            return bitmap;
        }
        
        public static void GenerateFlashDeals(FlowLayoutPanel panel)
        {
            // Number of flash deals
            const int numCards = 10;

            for (int i = 0; i < numCards; i++)
            {
                int TicketPrice;
                // out the flight price of the ticket
                Ticket randomTicket = FlightRandomizer.RandomTicket(out TicketPrice);

                CardDeal temp = new CardDeal(TicketPrice, randomTicket);
                panel.Controls.Add(temp);
            }
        }

        public static void ShowTicketsOwned(FlowLayoutPanel panel, List<Ticket> ownedTicket)
        {
            foreach (Ticket ticket in ownedTicket)
            {
                TicketTemplate template = new TicketTemplate(ticket);
                panel.Controls.Add(template);
            }
        }

        public static List<string> GenerateCityCountryList()
        {
            List<string> list = new List<string>();
            foreach (var location in Places.AllLocation)
            {
                list.Add($"{location.City} ({location.Country})");
            }

            return list;
        }

        public static void ShowCheckout(Form form, Checkout checkout)
        {
            form.Controls.Add(checkout);
            checkout.BringToFront();
        }

        public static void ShowFlightDetails(Form form, CalculatorFlightDetails FlightDetails)
        {
            form.Controls.Add(FlightDetails);
            FlightDetails.BringToFront();
        }

    }
}
