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
            pnl_NavigationButtons = new System.Windows.Forms.Panel();
            lbl_btnBookingHistory = new System.Windows.Forms.Label();
            lbl_btnNavTicketsOwned = new System.Windows.Forms.Label();
            lbl_btnNavHome = new System.Windows.Forms.Label();
            pb_Logo = new System.Windows.Forms.PictureBox();
            pnl_Content = new System.Windows.Forms.Panel();
            tbl_Account = new System.Windows.Forms.TableLayoutPanel();
            pb_Account = new System.Windows.Forms.PictureBox();
            lbl_AccountEmail = new System.Windows.Forms.Label();
            pnl_NavigationBar.SuspendLayout();
            pnl_NavigationButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            pnl_Content.SuspendLayout();
            tbl_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Account).BeginInit();
            SuspendLayout();
            // 
            // pnl_NavigationBar
            // 
            pnl_NavigationBar.BackColor = System.Drawing.Color.White;
            pnl_NavigationBar.Controls.Add(pnl_NavigationButtons);
            pnl_NavigationBar.Controls.Add(pb_Logo);
            pnl_NavigationBar.Location = new System.Drawing.Point(0, 0);
            pnl_NavigationBar.Name = "pnl_NavigationBar";
            pnl_NavigationBar.Size = new System.Drawing.Size(332, 768);
            pnl_NavigationBar.TabIndex = 1;
            // 
            // pnl_NavigationButtons
            // 
            pnl_NavigationButtons.BackgroundImage = Properties.Resources.HomePageHighlighted;
            pnl_NavigationButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pnl_NavigationButtons.Controls.Add(lbl_btnBookingHistory);
            pnl_NavigationButtons.Controls.Add(lbl_btnNavTicketsOwned);
            pnl_NavigationButtons.Controls.Add(lbl_btnNavHome);
            pnl_NavigationButtons.Location = new System.Drawing.Point(33, 125);
            pnl_NavigationButtons.Name = "pnl_NavigationButtons";
            pnl_NavigationButtons.Size = new System.Drawing.Size(261, 195);
            pnl_NavigationButtons.TabIndex = 4;
            // 
            // lbl_btnBookingHistory
            // 
            lbl_btnBookingHistory.BackColor = System.Drawing.Color.Transparent;
            lbl_btnBookingHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            lbl_btnBookingHistory.Location = new System.Drawing.Point(6, 124);
            lbl_btnBookingHistory.Name = "lbl_btnBookingHistory";
            lbl_btnBookingHistory.Size = new System.Drawing.Size(241, 49);
            lbl_btnBookingHistory.TabIndex = 7;
            lbl_btnBookingHistory.Click += lbl_btnBookingHistory_Click;
            // 
            // lbl_btnNavTicketsOwned
            // 
            lbl_btnNavTicketsOwned.BackColor = System.Drawing.Color.Transparent;
            lbl_btnNavTicketsOwned.Cursor = System.Windows.Forms.Cursors.Hand;
            lbl_btnNavTicketsOwned.Location = new System.Drawing.Point(6, 68);
            lbl_btnNavTicketsOwned.Name = "lbl_btnNavTicketsOwned";
            lbl_btnNavTicketsOwned.Size = new System.Drawing.Size(241, 49);
            lbl_btnNavTicketsOwned.TabIndex = 6;
            lbl_btnNavTicketsOwned.Click += lbl_btnNavTicketsOwned_Click;
            // 
            // lbl_btnNavHome
            // 
            lbl_btnNavHome.BackColor = System.Drawing.Color.Transparent;
            lbl_btnNavHome.Cursor = System.Windows.Forms.Cursors.Hand;
            lbl_btnNavHome.Location = new System.Drawing.Point(6, 0);
            lbl_btnNavHome.Name = "lbl_btnNavHome";
            lbl_btnNavHome.Size = new System.Drawing.Size(241, 49);
            lbl_btnNavHome.TabIndex = 5;
            lbl_btnNavHome.Click += lbl_btnNavHome_Click;
            // 
            // pb_Logo
            // 
            pb_Logo.BackColor = System.Drawing.Color.Transparent;
            pb_Logo.Image = Properties.Resources.NavigationLogo;
            pb_Logo.Location = new System.Drawing.Point(39, 61);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new System.Drawing.Size(245, 38);
            pb_Logo.TabIndex = 0;
            pb_Logo.TabStop = false;
            // 
            // pnl_Content
            // 
            pnl_Content.BackgroundImage = Properties.Resources.Content_background;
            pnl_Content.Controls.Add(tbl_Account);
            pnl_Content.Location = new System.Drawing.Point(329, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new System.Drawing.Size(1052, 775);
            pnl_Content.TabIndex = 2;
            // 
            // tbl_Account
            // 
            tbl_Account.BackColor = System.Drawing.Color.Transparent;
            tbl_Account.ColumnCount = 2;
            tbl_Account.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.6714554F));
            tbl_Account.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.3285427F));
            tbl_Account.Controls.Add(pb_Account, 1, 0);
            tbl_Account.Controls.Add(lbl_AccountEmail, 0, 0);
            tbl_Account.Location = new System.Drawing.Point(562, 12);
            tbl_Account.Name = "tbl_Account";
            tbl_Account.RowCount = 1;
            tbl_Account.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tbl_Account.Size = new System.Drawing.Size(477, 58);
            tbl_Account.TabIndex = 2;
            // 
            // pb_Account
            // 
            pb_Account.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pb_Account.BackColor = System.Drawing.Color.Transparent;
            pb_Account.Image = Properties.Resources.ic_baseline_account_circle_32x;
            pb_Account.Location = new System.Drawing.Point(383, 3);
            pb_Account.Name = "pb_Account";
            pb_Account.Size = new System.Drawing.Size(91, 52);
            pb_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_Account.TabIndex = 0;
            pb_Account.TabStop = false;
            // 
            // lbl_AccountEmail
            // 
            lbl_AccountEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_AccountEmail.AutoSize = true;
            lbl_AccountEmail.BackColor = System.Drawing.Color.Transparent;
            lbl_AccountEmail.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_AccountEmail.Location = new System.Drawing.Point(309, 0);
            lbl_AccountEmail.Name = "lbl_AccountEmail";
            lbl_AccountEmail.Size = new System.Drawing.Size(68, 58);
            lbl_AccountEmail.TabIndex = 1;
            lbl_AccountEmail.Text = "Email";
            lbl_AccountEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1380, 768);
            Controls.Add(pnl_Content);
            Controls.Add(pnl_NavigationBar);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "HomePage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cloud Express";
            pnl_NavigationBar.ResumeLayout(false);
            pnl_NavigationButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            pnl_Content.ResumeLayout(false);
            tbl_Account.ResumeLayout(false);
            tbl_Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Account).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnl_NavigationBar;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel pnl_NavigationButtons;
        private System.Windows.Forms.Label lbl_AccountEmail;
        private System.Windows.Forms.PictureBox pb_Account;
        private System.Windows.Forms.TableLayoutPanel tbl_Account;
        private System.Windows.Forms.Label lbl_btnNavHome;
        private System.Windows.Forms.Label lbl_btnBookingHistory;
        private System.Windows.Forms.Label lbl_btnNavTicketsOwned;
    }
}