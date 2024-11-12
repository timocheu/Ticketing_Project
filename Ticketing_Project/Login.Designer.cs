namespace Ticketing_Project
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            txt_LoginEmail = new System.Windows.Forms.TextBox();
            txt_PasswordLogin = new System.Windows.Forms.TextBox();
            lbl_ForgotPassword = new System.Windows.Forms.Label();
            cb_ShowPassword = new System.Windows.Forms.CheckBox();
            btn_Login = new System.Windows.Forms.Button();
            pb_LoginSection = new System.Windows.Forms.PictureBox();
            pb_LoginBackgroundPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_LoginSection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_LoginBackgroundPhoto).BeginInit();
            SuspendLayout();
            // 
            // txt_LoginEmail
            // 
            txt_LoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_LoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_LoginEmail.ForeColor = System.Drawing.Color.Black;
            txt_LoginEmail.Location = new System.Drawing.Point(153, 583);
            txt_LoginEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txt_LoginEmail.Name = "txt_LoginEmail";
            txt_LoginEmail.PlaceholderText = "timzoiechandy@gmail.com";
            txt_LoginEmail.Size = new System.Drawing.Size(507, 25);
            txt_LoginEmail.TabIndex = 1;
            // 
            // txt_PasswordLogin
            // 
            txt_PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_PasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            txt_PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_PasswordLogin.ForeColor = System.Drawing.Color.Black;
            txt_PasswordLogin.Location = new System.Drawing.Point(153, 700);
            txt_PasswordLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txt_PasswordLogin.Name = "txt_PasswordLogin";
            txt_PasswordLogin.PlaceholderText = "at least 8 characters";
            txt_PasswordLogin.Size = new System.Drawing.Size(507, 25);
            txt_PasswordLogin.TabIndex = 2;
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            lbl_ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(6, 90, 216);
            lbl_ForgotPassword.Location = new System.Drawing.Point(493, 756);
            lbl_ForgotPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new System.Drawing.Size(188, 26);
            lbl_ForgotPassword.TabIndex = 4;
            lbl_ForgotPassword.Text = "Forgot Password?";
            // 
            // cb_ShowPassword
            // 
            cb_ShowPassword.AutoSize = true;
            cb_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cb_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_ShowPassword.Location = new System.Drawing.Point(138, 751);
            cb_ShowPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            cb_ShowPassword.Name = "cb_ShowPassword";
            cb_ShowPassword.Size = new System.Drawing.Size(187, 30);
            cb_ShowPassword.TabIndex = 3;
            cb_ShowPassword.Text = "Show Password";
            cb_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = System.Drawing.Color.FromArgb(6, 90, 216);
            btn_Login.BackgroundImage = Properties.Resources.LoginBarRemovedBackground;
            btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Login.ForeColor = System.Drawing.Color.White;
            btn_Login.Location = new System.Drawing.Point(138, 829);
            btn_Login.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new System.Drawing.Size(535, 59);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Log In";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pb_LoginSection
            // 
            pb_LoginSection.Image = Properties.Resources.Login_Section;
            pb_LoginSection.Location = new System.Drawing.Point(136, 244);
            pb_LoginSection.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            pb_LoginSection.Name = "pb_LoginSection";
            pb_LoginSection.Size = new System.Drawing.Size(546, 521);
            pb_LoginSection.TabIndex = 1;
            pb_LoginSection.TabStop = false;
            // 
            // pb_LoginBackgroundPhoto
            // 
            pb_LoginBackgroundPhoto.BackColor = System.Drawing.Color.Transparent;
            pb_LoginBackgroundPhoto.Image = Properties.Resources.Login_Background_Photo1;
            pb_LoginBackgroundPhoto.Location = new System.Drawing.Point(801, 16);
            pb_LoginBackgroundPhoto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            pb_LoginBackgroundPhoto.Name = "pb_LoginBackgroundPhoto";
            pb_LoginBackgroundPhoto.Size = new System.Drawing.Size(761, 989);
            pb_LoginBackgroundPhoto.TabIndex = 0;
            pb_LoginBackgroundPhoto.TabStop = false;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1577, 1008);
            Controls.Add(cb_ShowPassword);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(btn_Login);
            Controls.Add(txt_PasswordLogin);
            Controls.Add(txt_LoginEmail);
            Controls.Add(pb_LoginSection);
            Controls.Add(pb_LoginBackgroundPhoto);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "Form_Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cloud Express";
            ((System.ComponentModel.ISupportInitialize)pb_LoginSection).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_LoginBackgroundPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pb_LoginBackgroundPhoto;
        private System.Windows.Forms.PictureBox pb_LoginSection;
        private System.Windows.Forms.TextBox txt_LoginEmail;
        private System.Windows.Forms.TextBox txt_PasswordLogin;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_ForgotPassword;
        private System.Windows.Forms.CheckBox cb_ShowPassword;
    }
}

