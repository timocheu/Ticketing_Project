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
    public partial class TicketTemplate : UserControl
    {
        public TicketTemplate(Ticket ticket)
        {
            InitializeComponent();
        }
    }
}
