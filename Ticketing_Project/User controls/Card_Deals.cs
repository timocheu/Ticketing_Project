using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_Project
{
    public partial class CardDeal : UserControl
    {
        public CardDeal(int price, string tripType, string from, string destination, string flightDate, string flightDuration, string boardClass)
        {
            lbl_From.Text = from;
            lbl_Destination.Text = destination;
            lbl_Destination.Text = $"{flightDate} • {flightDuration} • {boardClass}";
            lbl_Price.Text = $"Price: ₱{price.ToString()}";
            lbl_TripType.Text = tripType;
            InitializeComponent();
        }
    }
}
