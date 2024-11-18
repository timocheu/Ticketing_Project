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
    public partial class Calculator : UserControl
    {
        Utilities util = new();
        public Calculator()
        {
            InitializeComponent();
            // Limit the minimum flight date
            dtp_FlightDate.MinDate = DateTime.Now;
            // Limit flight reservation for 3years
            dtp_FlightDate.MaxDate = DateTime.Now.AddDays(1000);
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.Cast<Form>().Last();
            util.ShowCheckout(form);
        }
    }
}
