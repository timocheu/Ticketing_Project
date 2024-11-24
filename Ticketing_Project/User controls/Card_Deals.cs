using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketing_Project.Classes;
using Ticketing_Project.User_controls;

namespace Ticketing_Project
{
    public partial class CardDeal : UserControl
    {
        Ticket ticket;
        int price;
        public CardDeal(int _price, Ticket _ticket)
        {
            InitializeComponent();
            ticket = _ticket;
            price = _price;
            lbl_From.Text = $"{ticket.From} ({ticket.FromCountryCode})";
            lbl_Destination.Text = $"{ticket.Destination} ({ticket.DestinationCountryCode})";
            lbl_FlightDetails.Text = $"{ticket.FlightDate} • {ticket.Duration} • {ticket.BoardClass}";
            lbl_Price.Text = $"Price: ₱{price.ToString("N")}";
            lbl_TripType.Text = ticket.TripType;
        }

        private void lbl_Destination_Click(object sender, EventArgs e)
        {

        }

        private void btn_BookFlight_Click(object sender, EventArgs e)
        {

            ticket.Seat = ticket.RandomSeat();
            ticket.Gate = ticket.RandomGate();
            ticket.FlightNumber = ticket.RandomTerminal();

            CalculatorFlightDetails details = new CalculatorFlightDetails(ticket, 1, price);

            var form = Application.OpenForms.Cast<Form>().Last();
            ticket.ShowFlightDetails(form, details);
        }
    }
}
