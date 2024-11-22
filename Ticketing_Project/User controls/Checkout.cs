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
        // FALSE = MOBILE PAYMENT, TRUE = CARD PAYMENT
        bool paymentMethod = false;

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

            // BALANCE
            lbl_TripPriceDisplay.Text = "₱" + price.ToString("N");
            lbl_TaxDisplay.Text = "₱" + ((int)tax).ToString("N");

            // CHECK IF TRIPTYPE
            if (ticket.TripType == "Round Trip")
            {
                lbl_ReturnDateDisplay.Text = ticket.FlightDate.AddDays(365).ToString();
            }
            // Show discount for flash deals
            if (ticket.isDeal)
            {
                lbl_DiscountDisplay.Text = "20%";
            }

            // Display total amout with Tax
            reCalculateTotal();
        }

        private void btn_AddPassenger_Click(object sender, EventArgs e)
        {
            // Limit passengers to 5
            if (passengers == 5)
            {
                MessageBox.Show("Passenger booking shouldn't exceed 5 people");
                return;
            }

            PassengerTextBox passengerNew = new PassengerTextBox();
            flow_Passengers.Controls.Add(passengerNew);
            passengers++;
            reCalculateTotal();
        }
        private void btn_RemovePassenger_Click(object sender, EventArgs e)
        {
            if (passengers == 1)
            {
                MessageBox.Show("Passenger should be at least 1.");
                return;
            }
            passengers--;
            flow_Passengers.Controls.RemoveAt(0);
            reCalculateTotal();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_CardPayment_Click(object sender, EventArgs e)
        {
            paymentMethod = true;
            btn_CardPayment.BackgroundImage = Properties.Resources.Card_Payment_Highlight;
            btn_MobilePayment.BackgroundImage = Properties.Resources.Mobile_Payment_Lowlight;
        }
        private void btn_MobilePayment_Click(object sender, EventArgs e)
        {
            paymentMethod = false;
            btn_MobilePayment.BackgroundImage = Properties.Resources.Mobile_Payment_Highlight;
            btn_CardPayment.BackgroundImage = Properties.Resources.Card_Payment_Lowlight;
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

        private void reCalculateTotal()
        {
            lbl_TotalTicketDisplay.Text = passengers.ToString();
            lbl_TotalDisplay.Text = "₱" + (passengers * priceEachPerson).ToString("N");
        }

        private void pnl_CheckoutSection_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

