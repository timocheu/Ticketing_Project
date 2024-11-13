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
    public partial class Form_Login : Form
    {
        readonly public Utilities util = new Utilities();
        readonly Account dummyAcc = new Account("Timotheo", "tim@gmail.com", "1234");
        public Form_Login()
        {
            InitializeComponent();
            util.Change_Font(this);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_LoginEmail.Text == dummyAcc.Email &&
                txt_PasswordLogin.Text == dummyAcc.Password)
            {
                HomePage home = new HomePage(dummyAcc, util);
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Incorrect credentials");
            }
        }
    }
} 
