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
        Ticket thisTicket;
        public TicketTemplate(Ticket ticket)
        {
            InitializeComponent();
            thisTicket = ticket;
            lbl_NameOfPassenger.Text = ticket.Owner;
            lbl_From.Text = $"{ticket.From} ({ticket.FromCountry})";
            lbl_Destination.Text = $"{ticket.Destination} ({ticket.DestinationCountry})";
            lbl_Date.Text = ticket.FlightDate.ToShortDateString();
            lbl_Seat.Text = ticket.Seat;
            lbl_FlightDate.Text = "F12";
            lbl_Gate.Text = ticket.Gate;
            lbl_TripType.Text = ticket.TripType;
            lbl_FlightDuration.Text = ticket.Duration;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to proceed the booking cancellation?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                // User clicked OK
                this.Hide();
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Confirm to print the ticket.",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
        }
    }
}
