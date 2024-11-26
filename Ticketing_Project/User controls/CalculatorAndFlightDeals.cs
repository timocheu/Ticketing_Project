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
    public partial class CalculatorAndFlightDeals : UserControl
    {
        Utilities util = new Utilities();
        public CalculatorAndFlightDeals()
        {
            InitializeComponent();
            // Link data
            util.LinkData();
            util.GenerateFlashDeals(flow_Deals);
        }

        private void btn_RefreshDeals_Click(object sender, EventArgs e)
        {
            // Clear the last deals then add new
            flow_Deals.Controls.Clear();
            util.GenerateFlashDeals(flow_Deals);
        }
    }
}
