using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketing_Project.Classes;

namespace Ticketing_Project.User_controls
{
    public partial class CalculatorFlightDetails : UserControl
    {
        Ticket _ticket;
        double _price;
        public CalculatorFlightDetails(Ticket ticket, int passengers, double price)
        {
            InitializeComponent();

            _ticket = ticket;
            _price = price;

            double tax = price * .2;
            lbl_TotalTickets.Text = passengers.ToString();

            // LOCATIONS
            lbl_From.Text = $"{ticket.From} ({ticket.FromCountry})";
            lbl_Destination.Text = $"{ticket.Destination} ({ticket.DestinationCountry})";

            // FLIGHT DETAILS
            lbl_Duration.Text = ticket.Duration;
            lbl_Distance.Text = $"{ticket.Distance:F2}KM";
            lbl_PickUpDate.Text = ticket.FlightDate.ToString();

            // BALANCE
            lbl_TripPrice.Text = "₱" + price.ToString("N");
            lbl_Tax.Text = "₱" + ((int)tax).ToString("N");

            // If round trip display 
            if (ticket.TripType == "Round Trip")
            {
                lbl_ReturnDate.Text = ticket.FlightDate.AddDays(365).ToString();
            }

            // Show discount for flash deals
            if (ticket.isDeal)
            {
                lbl_Discount.Text = "20%";
            }

            // Display total amout with Tax
            lbl_Total.Text = "₱" + (price * passengers).ToString("N");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout checkout = new Checkout(int.Parse(lbl_TotalTickets.Text), _ticket, (int)_price);
            _ticket.ShowCheckout(FindForm(), checkout);
        }

        private void CalculatorFlightDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
