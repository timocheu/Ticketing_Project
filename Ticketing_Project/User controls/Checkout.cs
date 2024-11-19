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
    public partial class Checkout : UserControl
    {
        int passengers;
        public Checkout(Ticket ticket, int price)
        {
            InitializeComponent();
            passengers = ticket.Passengers;
            double tax = price * .2;
            // Ticket Details
            lbl_TotalTicketDisplay.Text = passengers.ToString();
            lbl_LocationDisplay.Text = ticket.From;
            lbl_PickUpDateDisplay.Text = ticket.FlightDate.ToString();

            if (ticket.TripType == "Round Trip")
            {
                lbl_ReturnDateDisplay.Text = ticket.FlightDate.AddDays(365).ToString();
            }

            lbl_TripPriceDisplay.Text = price.ToString();
            lbl_TaxDisplay.Text = ((int) tax).ToString();
            // Show discount for flash deals
            if (ticket.isDeal)
            {
                lbl_DiscountDisplay.Text = "20%";
            }

            // Display total amout with Tax
            lbl_TotalDisplay.Text = price.ToString();
        }

        private void btn_AddPassenger_Click(object sender, EventArgs e)
        {
            PassengerTextBox passengerNew = new PassengerTextBox();
            flow_Passengers.Controls.Add(passengerNew);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
