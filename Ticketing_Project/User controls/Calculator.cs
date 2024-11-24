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
using Ticketing_Project.User_controls;

namespace Ticketing_Project
{
    public partial class Calculator : UserControl
    {
        bool isListGenerated = false;
        Utilities util = new();
        public Calculator()
        {
            InitializeComponent();

            // Limit the minimum flight date
            dtp_FlightDate.MinDate = DateTime.Now;
            // Limit flight reservation for 3years
            dtp_FlightDate.MaxDate = DateTime.Now.AddDays(1000);
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // Check if FROM and DESTINATION is the same
            if (cbb_From.Text == cbb_Destination.Text)
            {
                MessageBox.Show("Invalid: Please choose different destination");
                return;
            }
            // Restrictions
            // Check if every combo box is filled
            var comboBox = this.Controls.OfType<ComboBox>();
            // Hide everything
            foreach (var field in comboBox)
            {
                if (String.IsNullOrEmpty(field.Text))
                {
                    MessageBox.Show("Please complete the following fields to continue.");
                    return;
                }
            }


            // Get the index and use it to get the location object
            int indexFrom = cbb_From.Items.IndexOf(cbb_From.Text);
            int indexDestination = cbb_Destination.Items.IndexOf(cbb_Destination.Text);
            // Store the details in the calculator in object
            Ticket ticket = new Ticket();
            Location loc1 = util.GetLocation(indexFrom);
            Location loc2 = util.GetLocation(indexDestination);

            // LOCATION (FROM)
            ticket.From = loc1.City;
            ticket.FromCountry = loc1.Country;
            ticket.FromCountryCode = loc1.Country;
            // LOCATION (DESTINATION)
            ticket.Destination = loc2.City;
            ticket.DestinationCountry = loc2.Country;
            ticket.DestinationCountryCode = loc2.Country;

            // Flight Details
            int passengers = int.Parse(cbb_NumberOfPassengers.Text);
            ticket.FlightDate = dtp_FlightDate.Value;
            ticket.BoardClass = cbb_BoardClass.Text;
            ticket.TripType = cbb_TripType.Text;
            ticket.Seat = ticket.RandomSeat();
            ticket.Gate = ticket.RandomGate();
            ticket.FlightNumber = ticket.RandomTerminal();



            ticket.Distance = ticket.CalculateDistance(loc1, loc2);
            ticket.Duration = ticket.CalculateDuration(ticket.Distance);
            double price = ticket.GeneratePrice(ticket.Distance, ticket.BoardClass, ticket.TripType);

            CalculatorFlightDetails details = new CalculatorFlightDetails(ticket, passengers, (int)price);

            var form = Application.OpenForms.Cast<Form>().Last();
            util.ShowFlightDetails(form, details);
        }

        private void cbb_From_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isListGenerated)
            {
                // Add the data to the utility
                util.LinkData();
                // Generate all the list
                util.GenerateCityCountryList(cbb_From);
                util.GenerateCityCountryList(cbb_Destination);
                isListGenerated = true;
            }
        }

        private void cbb_Destination_MouseClick(object sender, MouseEventArgs e)
        {
            cbb_From_MouseClick(sender, e);
        }
    }
}
