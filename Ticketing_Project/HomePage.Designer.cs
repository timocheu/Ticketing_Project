namespace Ticketing_Project
{
    partial class HomePage
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
            pnl_NavigationBar = new System.Windows.Forms.Panel();
            btn_NavigationBookingHistory = new System.Windows.Forms.Button();
            btn_NavigationTicketOwned = new System.Windows.Forms.Button();
            btn_NavigationHome = new System.Windows.Forms.Button();
            pb_Logo = new System.Windows.Forms.PictureBox();
            pnl = new System.Windows.Forms.Panel();
            pnl_NavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            SuspendLayout();
            // 
            // pnl_NavigationBar
            // 
            pnl_NavigationBar.BackColor = System.Drawing.Color.White;
            pnl_NavigationBar.Controls.Add(btn_NavigationBookingHistory);
            pnl_NavigationBar.Controls.Add(btn_NavigationTicketOwned);
            pnl_NavigationBar.Controls.Add(btn_NavigationHome);
            pnl_NavigationBar.Controls.Add(pb_Logo);
            pnl_NavigationBar.Location = new System.Drawing.Point(-2, 0);
            pnl_NavigationBar.Name = "pnl_NavigationBar";
            pnl_NavigationBar.Size = new System.Drawing.Size(332, 768);
            pnl_NavigationBar.TabIndex = 1;
            // 
            // btn_NavigationBookingHistory
            // 
            btn_NavigationBookingHistory.BackColor = System.Drawing.Color.White;
            btn_NavigationBookingHistory.BackgroundImage = Properties.Resources.NavigationButtonRem_Background;
            btn_NavigationBookingHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_NavigationBookingHistory.FlatAppearance.BorderSize = 0;
            btn_NavigationBookingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_NavigationBookingHistory.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_NavigationBookingHistory.ForeColor = System.Drawing.Color.Black;
            btn_NavigationBookingHistory.Location = new System.Drawing.Point(39, 264);
            btn_NavigationBookingHistory.Name = "btn_NavigationBookingHistory";
            btn_NavigationBookingHistory.Size = new System.Drawing.Size(245, 50);
            btn_NavigationBookingHistory.TabIndex = 3;
            btn_NavigationBookingHistory.Text = "Booking History";
            btn_NavigationBookingHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_NavigationBookingHistory.UseVisualStyleBackColor = false;
            // 
            // btn_NavigationTicketOwned
            // 
            btn_NavigationTicketOwned.BackColor = System.Drawing.Color.White;
            btn_NavigationTicketOwned.BackgroundImage = Properties.Resources.NavigationButtonRem_Background;
            btn_NavigationTicketOwned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_NavigationTicketOwned.FlatAppearance.BorderSize = 0;
            btn_NavigationTicketOwned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_NavigationTicketOwned.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_NavigationTicketOwned.ForeColor = System.Drawing.Color.Black;
            btn_NavigationTicketOwned.Location = new System.Drawing.Point(39, 196);
            btn_NavigationTicketOwned.Name = "btn_NavigationTicketOwned";
            btn_NavigationTicketOwned.Size = new System.Drawing.Size(245, 50);
            btn_NavigationTicketOwned.TabIndex = 2;
            btn_NavigationTicketOwned.Text = "Tickets Owned";
            btn_NavigationTicketOwned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_NavigationTicketOwned.UseVisualStyleBackColor = false;
            // 
            // btn_NavigationHome
            // 
            btn_NavigationHome.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            btn_NavigationHome.BackgroundImage = Properties.Resources.NavigationButtonRem_Background;
            btn_NavigationHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_NavigationHome.FlatAppearance.BorderSize = 0;
            btn_NavigationHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_NavigationHome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_NavigationHome.ForeColor = System.Drawing.Color.White;
            btn_NavigationHome.Location = new System.Drawing.Point(39, 120);
            btn_NavigationHome.Name = "btn_NavigationHome";
            btn_NavigationHome.Size = new System.Drawing.Size(245, 50);
            btn_NavigationHome.TabIndex = 1;
            btn_NavigationHome.Text = "Home";
            btn_NavigationHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_NavigationHome.UseVisualStyleBackColor = false;
            // 
            // pb_Logo
            // 
            pb_Logo.BackColor = System.Drawing.Color.Transparent;
            pb_Logo.Image = Properties.Resources.NavigationLogo;
            pb_Logo.Location = new System.Drawing.Point(39, 55);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new System.Drawing.Size(245, 38);
            pb_Logo.TabIndex = 0;
            pb_Logo.TabStop = false;
            // 
            // pnl
            // 
            pnl.BackgroundImage = Properties.Resources.Content_background;
            pnl.Location = new System.Drawing.Point(329, 0);
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(1052, 775);
            pnl.TabIndex = 2;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1380, 768);
            Controls.Add(pnl_NavigationBar);
            Controls.Add(pnl);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cloud Express";
            pnl_NavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnl_NavigationBar;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_NavigationHome;
        private System.Windows.Forms.Button btn_NavigationBookingHistory;
        private System.Windows.Forms.Button btn_NavigationTicketOwned;
        private System.Windows.Forms.Panel pnl;
    }
}