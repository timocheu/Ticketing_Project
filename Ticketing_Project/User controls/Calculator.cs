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
        List<string> locations;
        public Calculator()
        {
            InitializeComponent();

            // Limit the minimum flight date
            dtp_FlightDate.MinDate = DateTime.Now;
            dtp_ReturnDate.MinDate = dtp_FlightDate.Value.AddDays(14);
            // Limit flight reservation for 3years
            dtp_FlightDate.MaxDate = DateTime.Now.AddDays(1000);
            dtp_FlightDate.MaxDate = DateTime.Now.AddDays(1000);
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // Restrictions
            // Check if every combo box is filled
            var comboBox = this.Controls.OfType<ComboBox>();
            // Hide everything
            foreach (var field in comboBox)
            {
                if (String.IsNullOrEmpty(field.Text))
                {
                    ErrMessage("Please complete the following fields to continue.");
                    return;
                }
            }

            // Get the index and use it to get the location object
            int indexFrom = locations.IndexOf(cbb_From.Text);
            int indexDestination = locations.IndexOf(cbb_Destination.Text);

            if (indexFrom == -1 && indexDestination == -1)
            {
                ErrMessage("Both locations doesn't exist.");
                return;
            }
            else if (indexDestination == -1)
            {
                ErrMessage("The desination doesn't exist.");
                return;
            }
            else if (indexFrom == -1)
            {
                ErrMessage("The from or current location doesn't exist.");
                return;
            }

            // Check if FROM and DESTINATION is the same
            if (cbb_From.Text == cbb_Destination.Text)
            {
                ErrMessage("Invalid: Please choose different destination");
                return;
            }

            // Store the details in the calculator in object
            Ticket ticket = new Ticket();
            Location loc1 = Places.AllLocation[indexFrom];
            Location loc2 = Places.AllLocation[indexDestination];

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
            ticket.ReturnDate = dtp_ReturnDate.Value;
            ticket.BoardClass = cbb_BoardClass.Text;
            ticket.TripType = cbb_TripType.Text;
            ticket.Seat = FlightRandomizer.RandomSeat();
            ticket.Gate = FlightRandomizer.RandomGate();
            ticket.FlightNumber = FlightRandomizer.RandomTerminal();



            ticket.Distance = FlightMath.CalculateDistance(loc1, loc2);
            ticket.Duration = FlightMath.CalculateDuration(ticket.Distance);
            double price = FlightMath.CalculatePrice(ticket.Distance, ticket.BoardClass, ticket.TripType);

            CalculatorFlightDetails details = new CalculatorFlightDetails(ticket, passengers, (int)price);

            var form = Application.OpenForms.Cast<Form>().Last();
            Utilities.ShowFlightDetails(form, details);
        }

        private void cbb_From_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isListGenerated)
            {
                // Generate all the list
                locations = Utilities.GenerateCityCountryList();

                // Add the locations as a datasource
                cbb_From.DataSource = new List<string>(locations);
                cbb_Destination.DataSource = new List<string>(locations);
                // Clear text
                cbb_From.Text = "";
                cbb_Destination.Text = "";

                // For filtering
                cbb_From.TextUpdate += Cbb_From_TextUpdate;
                cbb_Destination.TextUpdate += Cbb_Destination_TextUpdate;

                isListGenerated = true;
            }

        }

        private void Cbb_Destination_TextUpdate(object sender, EventArgs e)
        {
            Filter(cbb_Destination);
        }

        private void Cbb_From_TextUpdate(object sender, EventArgs e)
        {
            Filter(cbb_From);
        }

        private void cbb_Destination_MouseClick(object sender, MouseEventArgs e)
        {
            cbb_From_MouseClick(sender, e);
        }

        private void cbb_TripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TripType.SelectedIndex == 1)
            {
                dtp_ReturnDate.Enabled = true;
            }
            else
            {
                dtp_ReturnDate.Enabled = false;
            }
        }

        // Method for filtering the locations
        private void Filter(ComboBox box)
        {
            string currentText = box.Text;

            List<string> filteredLocation = locations
                .Where(item => item.IndexOf(currentText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (filteredLocation.Count == 0)
            {
                return;
            }
            // Update the list
            box.DataSource = filteredLocation;
            // Keep the text
            box.Text = currentText;
            box.SelectionStart = currentText.Length;
            box.SelectionLength = 0;

            // Cursor countermeasure due to flickering when typing in combo box
            if (!box.DroppedDown)
            {
                box.DroppedDown = true;
            }
            Cursor.Current = Cursors.Default;
        }

        private void dtp_FlightDate_ValueChanged(object sender, EventArgs e)
        {
            // Minimum return date of 2 weeks
            dtp_ReturnDate.MinDate = dtp_FlightDate.Value.AddDays(14);
        }

        private void ErrMessage(string err)
        {
            MessageBox.Show(
                err,
                "Invalid Selection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        private void cbb_From_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow alphabet
            // Char 8 is the ascii number of backspace
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cbb_Destination_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow alphabet
            // Char 8 is the ascii number of backspace
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
