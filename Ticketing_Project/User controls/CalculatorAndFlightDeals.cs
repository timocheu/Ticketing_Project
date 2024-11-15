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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flow_Deals.Controls.Clear();
            util.GenerateFlashDeals(flow_Deals);
        }
    }
}
