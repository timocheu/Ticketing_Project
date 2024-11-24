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
            btn_NavigationTicketOwned = new System.Windows.Forms.Button();
            btn_NavigationBookingHistory = new System.Windows.Forms.Button();
            btn_NavigationHome = new System.Windows.Forms.Button();
            pb_Logo = new System.Windows.Forms.PictureBox();
            pnl_Content = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            pb_Account = new System.Windows.Forms.PictureBox();
            lbl_AccountEmail = new System.Windows.Forms.Label();
            pnl_NavigationBar.SuspendLayout();
            pnl_NavigationButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            pnl_Content.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            pnl_NavigationButtons.Controls.Add(btn_NavigationTicketOwned);
            pnl_NavigationButtons.Controls.Add(btn_NavigationBookingHistory);
            pnl_NavigationButtons.Controls.Add(btn_NavigationHome);
            pnl_NavigationButtons.Location = new System.Drawing.Point(33, 125);
            pnl_NavigationButtons.Name = "pnl_NavigationButtons";
            pnl_NavigationButtons.Size = new System.Drawing.Size(266, 217);
            pnl_NavigationButtons.TabIndex = 4;
            // 
            // btn_NavigationTicketOwned
            // 
            btn_NavigationTicketOwned.BackColor = System.Drawing.Color.White;
            btn_NavigationTicketOwned.BackgroundImage = Properties.Resources.NavigationButtonRem_Background;
            btn_NavigationTicketOwned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_NavigationTicketOwned.FlatAppearance.BorderSize = 0;
            btn_NavigationTicketOwned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_NavigationTicketOwned.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_NavigationTicketOwned.ForeColor = System.Drawing.Color.Black;
            btn_NavigationTicketOwned.Location = new System.Drawing.Point(6, 79);
            btn_NavigationTicketOwned.Name = "btn_NavigationTicketOwned";
            btn_NavigationTicketOwned.Size = new System.Drawing.Size(245, 50);
            btn_NavigationTicketOwned.TabIndex = 2;
            btn_NavigationTicketOwned.Text = "Tickets Owned";
            btn_NavigationTicketOwned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_NavigationTicketOwned.UseVisualStyleBackColor = false;
            btn_NavigationTicketOwned.Click += btn_NavigationTicketOwned_Click;
            // 
            // btn_NavigationBookingHistory
            // 
            btn_NavigationBookingHistory.BackColor = System.Drawing.Color.White;
            btn_NavigationBookingHistory.BackgroundImage = Properties.Resources.NavigationButtonRem_Background;
            btn_NavigationBookingHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_NavigationBookingHistory.FlatAppearance.BorderSize = 0;
            btn_NavigationBookingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_NavigationBookingHistory.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_NavigationBookingHistory.ForeColor = System.Drawing.Color.Black;
            btn_NavigationBookingHistory.Location = new System.Drawing.Point(6, 147);
            btn_NavigationBookingHistory.Name = "btn_NavigationBookingHistory";
            btn_NavigationBookingHistory.Size = new System.Drawing.Size(245, 50);
            btn_NavigationBookingHistory.TabIndex = 3;
            btn_NavigationBookingHistory.Text = "Booking History";
            btn_NavigationBookingHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_NavigationBookingHistory.UseVisualStyleBackColor = false;
            btn_NavigationBookingHistory.Click += btn_NavigationBookingHistory_Click;
            // 
            // btn_NavigationHome
            // 
            btn_NavigationHome.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            btn_NavigationHome.BackgroundImage = Properties.Resources.NavigationButtonRem_Background;
            btn_NavigationHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_NavigationHome.FlatAppearance.BorderSize = 0;
            btn_NavigationHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_NavigationHome.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_NavigationHome.ForeColor = System.Drawing.Color.White;
            btn_NavigationHome.Location = new System.Drawing.Point(6, 3);
            btn_NavigationHome.Name = "btn_NavigationHome";
            btn_NavigationHome.Size = new System.Drawing.Size(245, 50);
            btn_NavigationHome.TabIndex = 1;
            btn_NavigationHome.Text = "Home";
            btn_NavigationHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_NavigationHome.UseVisualStyleBackColor = false;
            btn_NavigationHome.Click += btn_NavigationHome_Click;
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
            pnl_Content.Controls.Add(tableLayoutPanel1);
            pnl_Content.Location = new System.Drawing.Point(329, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new System.Drawing.Size(1052, 775);
            pnl_Content.TabIndex = 2;
            pnl_Content.Paint += pnl_Content_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.6714554F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.3285427F));
            tableLayoutPanel1.Controls.Add(pb_Account, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_AccountEmail, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(562, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(477, 58);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Account).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnl_NavigationBar;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_NavigationHome;
        private System.Windows.Forms.Button btn_NavigationBookingHistory;
        private System.Windows.Forms.Button btn_NavigationTicketOwned;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel pnl_NavigationButtons;
        private System.Windows.Forms.Label lbl_AccountEmail;
        private System.Windows.Forms.PictureBox pb_Account;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}