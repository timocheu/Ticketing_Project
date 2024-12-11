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
    public partial class TermsAndAgreements : UserControl
    {
        public List<string> _names { get; set; }
        public Ticket _ticket { get; set; }
        public int _passengers { get; set; }
        public int _priceEachPerson { get; set; }
        public string _paymentMethod { get; set; }
        // Select checkout form, and downcast
        Checkout checkout;
        // Select homepage form, and downcast
        HomePage form;
        public TermsAndAgreements()
        {
            InitializeComponent();
        }

        private void TermsAndAgreements_Load(object sender, EventArgs e)
        {
            // Set the location
            this.Location = new Point(377, 255);
            // Select checkout form, and downcast
            checkout = (Checkout)this.Parent;
            // Select homepage form, and downcast
            form = (HomePage)this.Parent.Parent;
        }

        public void btn_ConfirmBooking_Click(object sender, EventArgs e)
        {
            Ticket blankOwnerTicket = _ticket;

            // seat number
            string seat = blankOwnerTicket.Seat;
            int seatNum = FlightRandomizer.random.Next(1, 50);

            // Add receipt and ticket to the homepage
            foreach (string name in _names)
            {
                // Change the name of ticket
                blankOwnerTicket.Owner = name;
                // Make the seats for multiple passengers consecutive
                blankOwnerTicket.Seat = seat + seatNum.ToString();
                seatNum++;

                TicketTemplate controlTicket = new TicketTemplate(blankOwnerTicket);
                form.addTicket(controlTicket);
            }

            // Create receipt and add data
            Receipt receipt = new Receipt();
            receipt.ReceiptID = FlightRandomizer.random.Next(1, 1000);
            receipt.CreationDate = DateTime.Now;
            receipt.Passengers = _passengers;
            receipt.PaymentMethod = _paymentMethod;
            receipt.TripType = blankOwnerTicket.TripType;
            receipt.Total = _priceEachPerson * _passengers;

            // Add the receipt
            form.addReceipt(receipt);

            // hide this control
            this.Hide();
            checkout.lbl_BookedSuccessfully.Show();

            // Add timer for the booked successfully to show for 1.5s then hide
            System.Timers.Timer timer = new System.Timers.Timer(1500);
            // Repeat only once
            timer.AutoReset = false;
            timer.Elapsed += checkout.HideCheckoutSectionPanel;

            // Start the timer
            timer.Start();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            checkout.pnl_CheckoutSection.Show();
        }
    }
}
