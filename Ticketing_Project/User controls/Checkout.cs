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
    public partial class Checkout : UserControl
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void btn_AddPassenger_Click(object sender, EventArgs e)
        {
            PassengerTextBox passengerNew = new PassengerTextBox();
            flow_Passengers.Controls.Add(passengerNew);
        }
    }
}
