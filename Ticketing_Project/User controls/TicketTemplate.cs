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
    public partial class TicketTemplate : UserControl
    {
        public TicketTemplate(Ticket ticket)
        {
            InitializeComponent();
            lbl_NameOfPassenger.Text = ticket.Owner;
            lbl_From.Text = $"{ticket.From} ({ticket.FromCountry})";
            lbl_Destination.Text = $"{ticket.Destination} ({ticket.Destination})";
            lbl_Date.Text = ticket.FlightDate.ToShortDateString();
            lbl_Seat.Text = ticket.Seat;
            lbl_FlightDate.Text = "F12";
            lbl_Gate.Text = ticket.Gate;
            lbl_TripType.Text = ticket.TripType;
            lbl_FlightDuration.Text = ticket.Duration;
        }
    }
}
