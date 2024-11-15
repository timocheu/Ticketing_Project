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
    public partial class HomePage : Form
    {
        Utilities utility = new Utilities();
        Places places = new Places();

        // List of geocoordinates
        List<Location> data;
        public HomePage()
        {
            InitializeComponent();
            // Initialize data
            data = places.GetLocationList();
        }
    }
}
