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
        Utilities utility = new Utilities();
        CalculatorAndFlightDeals homePage;
        public HomePage()
        {
            InitializeComponent();
            // Initialize data
        }

        private void btn_NavigationHome_Click(object sender, EventArgs e)
        {
            if (homePage == null)
            {
                homePage = new CalculatorAndFlightDeals();
                this.Controls.Add(homePage);
                homePage.Parent = this.pnl_Content;
                homePage.Location = new Point(0, 95);

                return;
            }

            homePage.Show();
        }

        private void btn_NavigationTicketOwned_Click(object sender, EventArgs e)
        {
            HidePreviousContent();
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
    }
}
