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
    public partial class form_Login : Form
    {
        Utilities util = new Utilities();
        public form_Login()
        {
            InitializeComponent();
            util.Change_Font(this);
        }
    }
}
