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
        readonly public Utilities utility = new Utilities();
        readonly Account dummyAcc = new Account("Timotheo", "tim@gmail.com", "1234");
        
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_LoginEmail.Text == dummyAcc.Email &&
                txt_PasswordLogin.Text == dummyAcc.Password)
            {
                HomePage home = new HomePage(dummyAcc.Email);
                this.Hide();
                home.Show();
            }
            else
            {
                lbl_Incorrect.Show();
            }
        }

        private void cb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPassword.Checked)
            {
                txt_PasswordLogin.PasswordChar = '\0';
                return;
            }

            txt_PasswordLogin.PasswordChar = '*';
        }
    }
} 
