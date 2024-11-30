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
    // Class for Downlaoding
    public static class DownloadExtensions
    {
        public static Bitmap CaptureToImage(this Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            return bitmap;
        }
    }
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
            lbl_Gate.Text = ticket.Gate;
            lbl_FlightNumber.Text = ticket.FlightNumber;
            lbl_TripType.Text = ticket.TripType;
            lbl_FlightDuration.Text = ticket.Duration;

            // Add the return date if 
            if (ticket.TripType == "Round Trip")
            {
                lbl_ReturnDate.Text = ticket.ReturnDate.ToShortDateString();
            }
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
                "Confirm to download the ticket.",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (res == DialogResult.OK)
            {
                // Hide button for capcturing
                btn_Cancel.Hide();
                btn_Print.Hide();
                // Capture
                Bitmap ticket = this.CaptureToImage();
                string filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\{thisTicket.Owner}_{thisTicket.DestinationCountryCode}.png";
                ticket.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                // Reshow buttons
                btn_Cancel.Show();
                btn_Print.Show();
                MessageBox.Show("Downloaded!");
            }
        }
    }
}
