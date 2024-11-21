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

namespace Ticketing_Project
{
    public partial class CardDeal : UserControl
    {
        public CardDeal(int price, Ticket ticket)
        {
            InitializeComponent();
            lbl_From.Text = $"{ticket.From} ({ticket.FromCountryCode})";
            lbl_Destination.Text = $"{ticket.Destination} ({ticket.DestinationCountryCode})";
            lbl_FlightDetails.Text = $"{ticket.FlightDate} • {ticket.Duration} • {ticket.BoardClass}";
            lbl_Price.Text = $"Price: ₱{price.ToString()}";
            lbl_TripType.Text = ticket.TripType;
        }

        private void lbl_Destination_Click(object sender, EventArgs e)
        {

        }
    }
}
