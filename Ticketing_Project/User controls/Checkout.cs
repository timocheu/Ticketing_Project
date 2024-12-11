using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Ticketing_Project.Classes;

namespace Ticketing_Project.User_controls
{
    public partial class Checkout : UserControl
    {

        // Data of flight details
        public Ticket ticket;
        public int passengers;
        public int priceEachPerson;
        TermsAndAgreements terms = new TermsAndAgreements();
        // FALSE = MOBILE PAYMENT, TRUE = CARD PAYMENT
        string paymentMethod = "Mobile";

        public Checkout(int Passengers, Ticket _ticket, int price)
        {
            InitializeComponent();
            // Hide the terms first
            terms.Hide();
            this.Controls.Add(terms);

            // Pass the data
            ticket = _ticket;
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
            lbl_LocationDisplay.Text = _ticket.From;
            lbl_PickUpDateDisplay.Text = _ticket.FlightDate.ToString();

            // BALANCE
            lbl_TripPriceDisplay.Text = "₱" + price.ToString("N");
            lbl_TaxDisplay.Text = "₱" + ((int)tax).ToString("N");

            // CHECK IF TRIPTYPE
            if (_ticket.TripType == "Round Trip")
            {
                lbl_ReturnDateDisplay.Text = ticket.ReturnDate.ToString();
            }
            // Show discount for flash deals
            if (_ticket.isDeal)
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
            // Remove the last textbox
            flow_Passengers.Controls.RemoveAt(flow_Passengers.Controls.Count - 1);
            reCalculateTotal();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_CardPayment_Click(object sender, EventArgs e)
        {
            paymentMethod = "Debit";
            btn_CardPayment.BackgroundImage = Properties.Resources.Card_Payment_Highlight;
            btn_MobilePayment.BackgroundImage = Properties.Resources.Mobile_Payment_Lowlight;
        }
        private void btn_MobilePayment_Click(object sender, EventArgs e)
        {
            paymentMethod = "Mobile";
            btn_MobilePayment.BackgroundImage = Properties.Resources.Mobile_Payment_Highlight;
            btn_CardPayment.BackgroundImage = Properties.Resources.Card_Payment_Lowlight;
        }

        private void reCalculateTotal()
        {
            lbl_TotalTicketDisplay.Text = passengers.ToString();
            lbl_TotalDisplay.Text = "₱" + (passengers * priceEachPerson).ToString("N");
        }
        public void HideCheckoutSectionPanel(object sender, ElapsedEventArgs e)
        {
            // Hide the control
            // Use invoke for safely handling the threads
            this.Invoke(new Action(() =>
            {
                this.Hide();
                pnl_CheckoutSection.Show();
            }));
        }

        public void btn_Proceed_Click(object sender, EventArgs e)
        {
            List<string> Names = new List<string>();
            foreach (Control control in flow_Passengers.Controls)
            {
                // Check if something a textbox missing
                if (control is UserControl userControl)
                {
                    TextBox PassengerInput = userControl.Controls.OfType<TextBox>().FirstOrDefault();
                    if (String.IsNullOrEmpty(PassengerInput.Text))
                    {
                        MessageBox.Show("Please Complete the missing fields.");
                        return;
                    }
                    Names.Add(PassengerInput.Text);
                }
            }
            // Set the data
            terms._names = Names;
            terms._ticket = ticket;
            terms._passengers = passengers;
            terms._priceEachPerson = priceEachPerson;
            terms._paymentMethod = paymentMethod;

            // Hide current panel
            pnl_CheckoutSection.Hide();
            
            // Show terms and agreements
            terms.Show();
        }
    }
}

