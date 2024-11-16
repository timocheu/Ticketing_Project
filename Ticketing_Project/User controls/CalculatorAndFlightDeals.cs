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
            util.GenerateFlashDeals(flow_Deals);
            util.GenerateCityCountryList(uc_Calculator.cbb_From);
            util.GenerateCityCountryList(uc_Calculator.cbb_Destination);
        }

        private void btn_RefreshDeals_Click(object sender, EventArgs e)
        {
            flow_Deals.Controls.Clear();
            util.GenerateFlashDeals(flow_Deals);
        }
    }
}
