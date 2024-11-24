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

        public HomePage(string Email = "Timotheo@gmail.com")
        {
            InitializeComponent();
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

        public void removeTicket(TicketTemplate ticket)
        {
            data.Remove(ticket);
        }

        private void btn_NavigationHome_Click(object sender, EventArgs e)
        {
            if (homePage.Visible) return;

            WhitenNavigationButtons();
            HighlightNavigationButton(btn_NavigationHome);
            HidePreviousContent();
            homePage.Show();

        }

        private void btn_NavigationTicketOwned_Click(object sender, EventArgs e)
        {
            if (ticketsOwnedControl.Visible) return;

            WhitenNavigationButtons();
            HidePreviousContent();
            HighlightNavigationButton(btn_NavigationTicketOwned);
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
        private void btn_NavigationBookingHistory_Click(object sender, EventArgs e)
        {
            if (receiptControl.Visible) return;

            WhitenNavigationButtons();
            HidePreviousContent();
            HighlightNavigationButton(btn_NavigationBookingHistory);

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
                    receipt.Total.ToString()
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

        private void WhitenNavigationButtons()
        {
            var buttons = pnl_NavigationButtons.Controls.OfType<Button>();
            foreach (var button in buttons)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
            }
        }

        private void HighlightNavigationButton(Button button)
        {
            button.BackColor = Color.FromArgb(0, 119, 182);
            button.ForeColor = Color.White;
        }

        private void pnl_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
