namespace Ticketing_Project
{
    partial class form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Login));
            this.pb_LoginSection = new System.Windows.Forms.PictureBox();
            this.pb_LoginBackgroundPhoto = new System.Windows.Forms.PictureBox();
            this.txt_LoginEmail = new System.Windows.Forms.TextBox();
            this.txt_PasswordLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginBackgroundPhoto)).BeginInit();
            this.SuspendLayout();
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
            this.pb_LoginBackgroundPhoto.Image = global::Ticketing_Project.Properties.Resources.Login_Background_Photo;
            this.pb_LoginBackgroundPhoto.Location = new System.Drawing.Point(695, 12);
            this.pb_LoginBackgroundPhoto.Name = "pb_LoginBackgroundPhoto";
            this.pb_LoginBackgroundPhoto.Size = new System.Drawing.Size(663, 729);
            this.pb_LoginBackgroundPhoto.TabIndex = 0;
            this.pb_LoginBackgroundPhoto.TabStop = false;
            // 
            // txt_LoginEmail
            // 
            this.txt_LoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginEmail.Location = new System.Drawing.Point(116, 410);
            this.txt_LoginEmail.Name = "txt_LoginEmail";
            this.txt_LoginEmail.Size = new System.Drawing.Size(446, 29);
            this.txt_LoginEmail.TabIndex = 2;
            this.txt_LoginEmail.Text = "Test123";
            // 
            // txt_PasswordLogin
            // 
            this.txt_PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PasswordLogin.Location = new System.Drawing.Point(115, 498);
            this.txt_PasswordLogin.Name = "txt_PasswordLogin";
            this.txt_PasswordLogin.Size = new System.Drawing.Size(446, 29);
            this.txt_PasswordLogin.TabIndex = 3;
            this.txt_PasswordLogin.Text = "Test123";
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 755);
            this.Controls.Add(this.txt_PasswordLogin);
            this.Controls.Add(this.txt_LoginEmail);
            this.Controls.Add(this.pb_LoginSection);
            this.Controls.Add(this.pb_LoginBackgroundPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Login";
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
    }
}

