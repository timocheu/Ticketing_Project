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

namespace Ticketing_Project
{
    public partial class HomePage : Form
    {
        CalculatorAndFlightDeals homePage = new CalculatorAndFlightDeals();
        public HomePage()
        {
            InitializeComponent();

            // Initialize Homepage
            this.Controls.Add(homePage);
            homePage.Parent = pnl_Content;
            homePage.Location = new Point(0, 95);
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
            WhitenNavigationButtons();
            HidePreviousContent();
            HighlightNavigationButton(btn_NavigationTicketOwned);
        }
        private void btn_NavigationBookingHistory_Click(object sender, EventArgs e)
        {
            WhitenNavigationButtons();
            HidePreviousContent();
            HighlightNavigationButton(btn_NavigationBookingHistory);
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

    }
}
