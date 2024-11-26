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
        HomePage home;
        // Use the Timers's timer
        System.Timers.Timer incorrectTimer = new System.Timers.Timer(3000);

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_LoginEmail.Text == dummyAcc.Email &&
                txt_PasswordLogin.Text == dummyAcc.Password)
            {
                // Instantiate a new home
                if (home == null)
                {
                    home = new HomePage(this, dummyAcc.Email);
                }

                this.Hide();
                home.Show();
            }
            else
            {
                // Show incorrect
                lbl_Incorrect.Show();
                incorrectTimer.AutoReset = false;
                incorrectTimer.Elapsed += HideLabelIncorrect;
                incorrectTimer.Start();
            }
        }

        private void HideLabelIncorrect(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Hide using invoke for safe threading
            lbl_Incorrect.Invoke(new Action(() => lbl_Incorrect.Hide()));
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

        public void ClearPassword()
        {
            txt_PasswordLogin.Clear();
        }

        private void txt_LoginEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Call login method
            if (e.KeyChar == (char) Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void Txt_PasswordLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Call login method
            if (e.KeyChar == (char) Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
    }
} 
