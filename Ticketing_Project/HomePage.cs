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
    public partial class HomePage : Form
    {
        // LoginForm
        Form_Login LoginForm;
        // Controls
        CalculatorAndFlightDeals homePage = new CalculatorAndFlightDeals();
        TicketsOwnedControl ticketsOwnedControl = new TicketsOwnedControl();
        ReceiptControl receiptControl = new ReceiptControl();
        bool isTicketAdded = false;
        bool isReceiptAdded = false;

        // Data for informations
        List<TicketTemplate> data = new List<TicketTemplate>();
        List<Receipt> receipts = new List<Receipt>();
        string accEmail;

        public HomePage(Form_Login _LoginForm, string Email = "Timotheo@gmail.com")

        {
            InitializeComponent();
            // Keep track of last form
            LoginForm = _LoginForm;

            ticketsOwnedControl.Hide();
            receiptControl.Hide();
            accEmail = Email;
            lbl_AccountEmail.Text = Email;

            // Initialize Homepage
            this.Controls.Add(homePage);
            homePage.Parent = pnl_Content;
            homePage.Location = new Point(0, 95);
        }
        public void addReceipt(Receipt _receipt)
        {
            receipts.Add(_receipt);
        }

        public void addTicket(TicketTemplate ticket)
        {
            data.Add(ticket);
        }

        private void lbl_btnNavHome_Click(object sender, EventArgs e)
        {
            // stop reloading if the control is visibile
            if (homePage.Visible) return;

            HidePreviousContent();
            // Change the background
            pnl_NavigationButtons.BackgroundImage = Properties.Resources.HomePageHighlighted;
            homePage.Show();
        }

        private void lbl_btnNavTicketsOwned_Click(object sender, EventArgs e)
        {
            if (ticketsOwnedControl.Visible) return;

            HidePreviousContent();
            // Change the background
            pnl_NavigationButtons.BackgroundImage = Properties.Resources.TicketsOwnedHighLighted;

            if (!isTicketAdded)
            {
                pnl_Content.Controls.Add(ticketsOwnedControl);
                ticketsOwnedControl.Location = new Point(30, 125);
                isTicketAdded = true;
            }

            ticketsOwnedControl.Show();
            ticketsOwnedControl.flow_TicketsOwned.Controls.Clear();
            foreach (TicketTemplate ticket in data)
            {
                ticketsOwnedControl.flow_TicketsOwned.Controls.Add(ticket);
            }
        }

        private void lbl_btnBookingHistory_Click(object sender, EventArgs e)
        {
            if (receiptControl.Visible) return;

            HidePreviousContent();
            // Change the background
            pnl_NavigationButtons.BackgroundImage = Properties.Resources.BookingHistoryHighlighted;

            if (!isReceiptAdded)
            {
                pnl_Content.Controls.Add(receiptControl);
                receiptControl.Location = new Point(0, 100);
                isReceiptAdded = true;
            }

            receiptControl.Show();
            receiptControl.dgv_Receipts.Rows.Clear();
            // Add all information in gridview
            foreach (Receipt receipt in receipts)
            {
                // Add in rows
                receiptControl.dgv_Receipts.Rows.Add(
                    receipt.ReceiptID,
                    receipt.CreationDate.ToString(),
                    accEmail,
                    receipt.PaymentMethod,
                    receipt.TripType,
                    receipt.Passengers,
                    "₱" + receipt.Total.ToString("N")
                );
            }
        }

        private void HidePreviousContent()
        {
            // Get all child of content
            var children = pnl_Content.Controls.OfType<UserControl>();
            // Hide everything
            foreach (var child in children)
            {
                child.Hide();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.ClearPassword();
            LoginForm.Show();
        }
    }
}
