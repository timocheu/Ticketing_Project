using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_Project.User_controls
{
    public partial class PassengerTextBox : UserControl
    {
        public PassengerTextBox()
        {
            InitializeComponent();
        }

        private void txt_Passenger_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow alphabet
            // Char 8 is the ascii number of backspace
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
