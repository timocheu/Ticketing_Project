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
            this.txt_LoginEmail = new System.Windows.Forms.TextBox();
            this.txt_PasswordLogin = new System.Windows.Forms.TextBox();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.cb_ShowPassword = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pb_LoginSection = new System.Windows.Forms.PictureBox();
            this.pb_LoginBackgroundPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginBackgroundPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_LoginEmail
            // 
            this.txt_LoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_LoginEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_LoginEmail.Location = new System.Drawing.Point(116, 412);
            this.txt_LoginEmail.Name = "txt_LoginEmail";
            this.txt_LoginEmail.Size = new System.Drawing.Size(446, 20);
            this.txt_LoginEmail.TabIndex = 1;
            this.txt_LoginEmail.Text = "timzoiechandy@gmail.com";
            // 
            // txt_PasswordLogin
            // 
            this.txt_PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_PasswordLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_PasswordLogin.Location = new System.Drawing.Point(115, 501);
            this.txt_PasswordLogin.Name = "txt_PasswordLogin";
            this.txt_PasswordLogin.Size = new System.Drawing.Size(446, 20);
            this.txt_PasswordLogin.TabIndex = 2;
            this.txt_PasswordLogin.Text = "at least 8 characters";
            // 
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.AutoSize = true;
            this.lbl_ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(90)))), ((int)(((byte)(216)))));
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(408, 547);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(156, 22);
            this.lbl_ForgotPassword.TabIndex = 4;
            this.lbl_ForgotPassword.Text = "Forgot Password?";
            // 
            // cb_ShowPassword
            // 
            this.cb_ShowPassword.AutoSize = true;
            this.cb_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cb_ShowPassword.Location = new System.Drawing.Point(102, 544);
            this.cb_ShowPassword.Name = "cb_ShowPassword";
            this.cb_ShowPassword.Size = new System.Drawing.Size(155, 26);
            this.cb_ShowPassword.TabIndex = 3;
            this.cb_ShowPassword.Text = "Show Password";
            this.cb_ShowPassword.UseVisualStyleBackColor = true;
            this.cb_ShowPassword.CheckedChanged += new System.EventHandler(this.cb_ShowPassword_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(90)))), ((int)(((byte)(216)))));
            this.btn_Login.BackgroundImage = global::Ticketing_Project.Properties.Resources.LoginBarRemovedBackground;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(102, 610);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(468, 39);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Log In";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // pb_LoginSection
            // 
            this.pb_LoginSection.Image = global::Ticketing_Project.Properties.Resources.Login_Section;
            this.pb_LoginSection.Location = new System.Drawing.Point(102, 159);
            this.pb_LoginSection.Name = "pb_LoginSection";
            this.pb_LoginSection.Size = new System.Drawing.Size(472, 382);
            this.pb_LoginSection.TabIndex = 1;
            this.pb_LoginSection.TabStop = false;
            // 
            // pb_LoginBackgroundPhoto
            // 
            this.pb_LoginBackgroundPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pb_LoginBackgroundPhoto.Image = global::Ticketing_Project.Properties.Resources.Login_Background_Photo1;
            this.pb_LoginBackgroundPhoto.Location = new System.Drawing.Point(695, 14);
            this.pb_LoginBackgroundPhoto.Name = "pb_LoginBackgroundPhoto";
            this.pb_LoginBackgroundPhoto.Size = new System.Drawing.Size(663, 729);
            this.pb_LoginBackgroundPhoto.TabIndex = 0;
            this.pb_LoginBackgroundPhoto.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 755);
            this.Controls.Add(this.cb_ShowPassword);
            this.Controls.Add(this.lbl_ForgotPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PasswordLogin);
            this.Controls.Add(this.txt_LoginEmail);
            this.Controls.Add(this.pb_LoginSection);
            this.Controls.Add(this.pb_LoginBackgroundPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Express";
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginBackgroundPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

