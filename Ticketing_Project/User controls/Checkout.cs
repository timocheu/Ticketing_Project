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
        int priceEachPerson;

        public Checkout(int Passengers, Ticket ticket, int price)
        {
            InitializeComponent();
            passengers = Passengers;
            priceEachPerson = price;
            double tax = price * .2;

            for (int i = 0; i < passengers - 1; i++)
            {
                PassengerTextBox passengerNew = new PassengerTextBox();
                flow_Passengers.Controls.Add(passengerNew);
            }
            // Ticket Details
            lbl_TotalTicketDisplay.Text = passengers.ToString();
            lbl_LocationDisplay.Text = ticket.From;
            lbl_PickUpDateDisplay.Text = ticket.FlightDate.ToString();
            if (ticket.TripType == "Round Trip")
            {
                lbl_ReturnDateDisplay.Text = ticket.FlightDate.AddDays(365).ToString();
            }

            lbl_TripPriceDisplay.Text = $"₱{price}";
            lbl_TaxDisplay.Text = $"₱{(int)tax}";
            // Show discount for flash deals
            if (ticket.isDeal)
            {
                lbl_DiscountDisplay.Text = "20%";
            }

            // Display total amout with Tax
            lbl_TotalDisplay.Text = $"₱{price * passengers}";
        }

        private void btn_AddPassenger_Click(object sender, EventArgs e)
        {
            PassengerTextBox passengerNew = new PassengerTextBox();
            flow_Passengers.Controls.Add(passengerNew);
            passengers++;
            lbl_TotalTicketDisplay.Text = passengers.ToString();
            lbl_TotalDisplay.Text = (passengers * priceEachPerson).ToString();
        }
        private void btn_RemovePassenger_Click(object sender, EventArgs e)
        {
            if (passengers == 1)
            {
                MessageBox.Show("Passenger should be at least 1.");
                return;
            }

            passengers--;
            lbl_TotalTicketDisplay.Text = passengers.ToString();
            lbl_TotalDisplay.Text = (passengers * priceEachPerson).ToString();
            flow_Passengers.Controls.RemoveAt(0);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_CardPayment_Click(object sender, EventArgs e)
        {
            WhitenNavigationButtons(btn_MobilePayment);
            HighlightNavigationButton(btn_CardPayment);
        }
        private void btn_MobilePayment_Click(object sender, EventArgs e)
        {
            WhitenNavigationButtons(btn_CardPayment);
            HighlightNavigationButton(btn_MobilePayment);
        }

        private void WhitenNavigationButtons(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void HighlightNavigationButton(Button button)
        {
            button.BackColor = Color.FromArgb(0, 119, 182);
            button.ForeColor = Color.White;
        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {
            foreach (Control control in flow_Passengers.Controls)
            {
                if (control is UserControl userControl)
                {
                    TextBox PassengerInput = userControl.Controls.OfType<TextBox>().FirstOrDefault();
                    if (String.IsNullOrEmpty(PassengerInput.Text))
                    {
                        MessageBox.Show("Please Complete the missing fields.");
                        return;
                    }
                }
            }
        }
    }
}

