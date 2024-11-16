using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_Project
{
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
            // Limit the minimum flight date
            dtp_FlightDate.MinDate = DateTime.Now;
            // Limit flight reservation for 3years
            dtp_FlightDate.MaxDate = DateTime.Now.AddDays(1000);
        }
    }
}
