﻿using System;
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
        public HomePage()
        {
            InitializeComponent();
            uc_CalculatorAndFlightDeals.Parent = pb_ContentBackground;
            uc_CalculatorAndFlightDeals.Location = new Point(0, 90);
        }
    }
}
