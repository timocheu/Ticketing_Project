using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketing_Project.Classes;

namespace Ticketing_Project
{
    public partial class Form_Login : Form
    {
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
            if (!IsValidEmail(txt_LoginEmail.Text)) 
            {
                lbl_Incorrect.Text = "Please enter a valid email";
                TimerIncorrect();
                return;
            } 


            if (txt_LoginEmail.Text != dummyAcc.Email && txt_PasswordLogin.Text != dummyAcc.Password)
            {
                lbl_Incorrect.Text = "Incorrect Email and Password";
                TimerIncorrect();
                return;
            }
            else if (txt_PasswordLogin.Text != dummyAcc.Password)
            {
                lbl_Incorrect.Text = "Incorrect Password";
                TimerIncorrect();
                return;
            }
            else if (txt_LoginEmail.Text != dummyAcc.Email)
            {
                lbl_Incorrect.Text = "Incorrect Email";
                TimerIncorrect(); 
                return;
            }

            // Instantiate a new home
            if (home == null)
            {
                home = new HomePage(this, dummyAcc.Email);
            }

            this.Hide();
            home.Show();
        }

        public static bool IsValidEmail(string email)
        {
            if (!MailAddress.TryCreate(email, out var mailAddress))
                return false;

            // And if you want to be more strict:
            var hostParts = mailAddress.Host.Split('.');
            if (hostParts.Length == 1)
                return false; // No dot.
            if (hostParts.Any(p => p == string.Empty))
                return false; // Double dot.
            if (hostParts[^1].Length < 2)
                return false; // TLD only one letter.

            if (mailAddress.User.Contains(' '))
                return false;
            if (mailAddress.User.Split('.').Any(p => p == string.Empty))
                return false; // Double dot or dot at end of user part.

            return true;
        }

        private void TimerIncorrect()
        {
            // Show incorrect
            lbl_Incorrect.Show();
            incorrectTimer.AutoReset = false;
            incorrectTimer.Elapsed += HideLabelIncorrect;
            incorrectTimer.Start();
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
