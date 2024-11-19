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


            var form = Application.OpenForms.Cast<Form>().Last();
            // Store the details in the calculator in object
            Ticket ticket = new Ticket();

            ticket.From = cbb_From.Text;
            ticket.Destination = cbb_Destination.Text;
            // Get the index and use it to get the location object
            int indexFrom = cbb_From.Items.IndexOf(cbb_From.Text);
            int indexDestination = cbb_Destination.Items.IndexOf(cbb_Destination.Text);

            // Flight Details
            ticket.FlightDate = dtp_FlightDate.Value;
            ticket.BoardClass = cbb_BoardClass.Text;
            ticket.TripType = cbb_TripType.Text;
            ticket.Passengers = int.Parse(cbb_NumberOfPassengers.Text);

            double distance = ticket.CalculateDistance(ticket.GetLocation(indexFrom), ticket.GetLocation(indexDestination));
            ticket.Duration = ticket.CalculateDuration(distance);

            Checkout checkout = new Checkout(ticket, (int) ticket.GeneratePrice(distance, ticket.BoardClass, ticket.TripType));
            util.ShowCheckout(form, checkout);
        }
    }
}
