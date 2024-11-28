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
            lbl_Incorrect = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pb_LoginSection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_LoginBackgroundPhoto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_LoginEmail
            // 
            txt_LoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_LoginEmail.Font = new System.Drawing.Font("Poppins", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_LoginEmail.ForeColor = System.Drawing.Color.Black;
            txt_LoginEmail.Location = new System.Drawing.Point(131, 436);
            txt_LoginEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_LoginEmail.Name = "txt_LoginEmail";
            txt_LoginEmail.PlaceholderText = "timzoiechandy@gmail.com";
            txt_LoginEmail.Size = new System.Drawing.Size(444, 27);
            txt_LoginEmail.TabIndex = 1;
            txt_LoginEmail.KeyPress += txt_LoginEmail_KeyPress;
            // 
            // txt_PasswordLogin
            // 
            txt_PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_PasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            txt_PasswordLogin.Font = new System.Drawing.Font("Poppins", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_PasswordLogin.ForeColor = System.Drawing.Color.Black;
            txt_PasswordLogin.Location = new System.Drawing.Point(131, 524);
            txt_PasswordLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_PasswordLogin.Name = "txt_PasswordLogin";
            txt_PasswordLogin.PasswordChar = '*';
            txt_PasswordLogin.PlaceholderText = "at least 8 characters";
            txt_PasswordLogin.Size = new System.Drawing.Size(444, 27);
            txt_PasswordLogin.TabIndex = 2;
            txt_PasswordLogin.KeyPress += Txt_PasswordLogin_KeyPress;
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            lbl_ForgotPassword.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(6, 90, 216);
            lbl_ForgotPassword.Location = new System.Drawing.Point(418, 567);
            lbl_ForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new System.Drawing.Size(173, 31);
            lbl_ForgotPassword.TabIndex = 4;
            lbl_ForgotPassword.Text = "Forgot Password?";
            // 
            // cb_ShowPassword
            // 
            cb_ShowPassword.AutoSize = true;
            cb_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cb_ShowPassword.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_ShowPassword.Location = new System.Drawing.Point(121, 563);
            cb_ShowPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cb_ShowPassword.Name = "cb_ShowPassword";
            cb_ShowPassword.Size = new System.Drawing.Size(171, 35);
            cb_ShowPassword.TabIndex = 3;
            cb_ShowPassword.Text = "Show Password";
            cb_ShowPassword.UseVisualStyleBackColor = true;
            cb_ShowPassword.CheckedChanged += cb_ShowPassword_CheckedChanged;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = System.Drawing.Color.FromArgb(6, 90, 216);
            btn_Login.BackgroundImage = Properties.Resources.LoginBarRemovedBackground;
            btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Login.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Login.ForeColor = System.Drawing.Color.White;
            btn_Login.Location = new System.Drawing.Point(121, 622);
            btn_Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new System.Drawing.Size(468, 44);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Log In";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pb_LoginSection
            // 
            pb_LoginSection.Image = Properties.Resources.Login_Section;
            pb_LoginSection.Location = new System.Drawing.Point(119, 183);
            pb_LoginSection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pb_LoginSection.Name = "pb_LoginSection";
            pb_LoginSection.Size = new System.Drawing.Size(478, 391);
            pb_LoginSection.TabIndex = 1;
            pb_LoginSection.TabStop = false;
            // 
            // pb_LoginBackgroundPhoto
            // 
            pb_LoginBackgroundPhoto.BackColor = System.Drawing.Color.Transparent;
            pb_LoginBackgroundPhoto.Image = Properties.Resources.Login_Background_Photo1;
            pb_LoginBackgroundPhoto.Location = new System.Drawing.Point(700, 19);
            pb_LoginBackgroundPhoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pb_LoginBackgroundPhoto.Name = "pb_LoginBackgroundPhoto";
            pb_LoginBackgroundPhoto.Size = new System.Drawing.Size(666, 742);
            pb_LoginBackgroundPhoto.TabIndex = 0;
            pb_LoginBackgroundPhoto.TabStop = false;
            // 
            // lbl_Incorrect
            // 
            lbl_Incorrect.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_Incorrect.AutoSize = true;
            lbl_Incorrect.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Incorrect.ForeColor = System.Drawing.Color.Red;
            lbl_Incorrect.Location = new System.Drawing.Point(3, 1);
            lbl_Incorrect.Name = "lbl_Incorrect";
            lbl_Incorrect.Size = new System.Drawing.Size(268, 28);
            lbl_Incorrect.TabIndex = 6;
            lbl_Incorrect.Text = "Incorrect Email or Password";
            lbl_Incorrect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            lbl_Incorrect.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbl_Incorrect, 0, 0);
            tableLayoutPanel1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tableLayoutPanel1.Location = new System.Drawing.Point(212, 397);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(274, 30);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1380, 768);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(cb_ShowPassword);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(btn_Login);
            Controls.Add(txt_PasswordLogin);
            Controls.Add(txt_LoginEmail);
            Controls.Add(pb_LoginSection);
            Controls.Add(pb_LoginBackgroundPhoto);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form_Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cloud Express";
            ((System.ComponentModel.ISupportInitialize)pb_LoginSection).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_LoginBackgroundPhoto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label lbl_Incorrect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

