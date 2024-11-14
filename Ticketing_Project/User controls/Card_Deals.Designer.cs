namespace Ticketing_Project
{
    partial class Card_Deals
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_CardDeals = new System.Windows.Forms.Panel();
            pnl_Logo = new System.Windows.Forms.Panel();
            pnl_Arrow = new System.Windows.Forms.Panel();
            lbl_TripType = new System.Windows.Forms.Label();
            lbl_Price = new System.Windows.Forms.Label();
            lbl_FlightDescription = new System.Windows.Forms.Label();
            lbl_CardDestination = new System.Windows.Forms.Label();
            lbl_From = new System.Windows.Forms.Label();
            btn_BookFlight = new System.Windows.Forms.Button();
            pnl_CardDeals.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_CardDeals
            // 
            pnl_CardDeals.BackgroundImage = Properties.Resources.CardDealsBackground;
            pnl_CardDeals.Controls.Add(pnl_Logo);
            pnl_CardDeals.Controls.Add(pnl_Arrow);
            pnl_CardDeals.Controls.Add(lbl_TripType);
            pnl_CardDeals.Controls.Add(lbl_Price);
            pnl_CardDeals.Controls.Add(lbl_FlightDescription);
            pnl_CardDeals.Controls.Add(lbl_CardDestination);
            pnl_CardDeals.Controls.Add(lbl_From);
            pnl_CardDeals.Controls.Add(btn_BookFlight);
            pnl_CardDeals.Location = new System.Drawing.Point(-1, -2);
            pnl_CardDeals.Name = "pnl_CardDeals";
            pnl_CardDeals.Size = new System.Drawing.Size(445, 170);
            pnl_CardDeals.TabIndex = 0;
            // 
            // pnl_Logo
            // 
            pnl_Logo.BackColor = System.Drawing.Color.Transparent;
            pnl_Logo.BackgroundImage = Properties.Resources.Brand_Leftside_Logo;
            pnl_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pnl_Logo.Location = new System.Drawing.Point(183, 82);
            pnl_Logo.Name = "pnl_Logo";
            pnl_Logo.Size = new System.Drawing.Size(81, 20);
            pnl_Logo.TabIndex = 8;
            // 
            // pnl_Arrow
            // 
            pnl_Arrow.BackColor = System.Drawing.Color.Transparent;
            pnl_Arrow.BackgroundImage = Properties.Resources.typcn_arrow_up_outline1;
            pnl_Arrow.ForeColor = System.Drawing.Color.Transparent;
            pnl_Arrow.Location = new System.Drawing.Point(206, 25);
            pnl_Arrow.Name = "pnl_Arrow";
            pnl_Arrow.Size = new System.Drawing.Size(26, 24);
            pnl_Arrow.TabIndex = 7;
            // 
            // lbl_TripType
            // 
            lbl_TripType.AutoSize = true;
            lbl_TripType.BackColor = System.Drawing.Color.Transparent;
            lbl_TripType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripType.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_TripType.Location = new System.Drawing.Point(18, 139);
            lbl_TripType.Name = "lbl_TripType";
            lbl_TripType.Size = new System.Drawing.Size(74, 16);
            lbl_TripType.TabIndex = 2;
            lbl_TripType.Text = "Round Trip";
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.BackColor = System.Drawing.Color.Transparent;
            lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Price.ForeColor = System.Drawing.Color.FromArgb(0, 119, 182);
            lbl_Price.Location = new System.Drawing.Point(17, 116);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new System.Drawing.Size(145, 24);
            lbl_Price.TabIndex = 6;
            lbl_Price.Text = "Price: ₱10,230";
            // 
            // lbl_FlightDescription
            // 
            lbl_FlightDescription.AutoSize = true;
            lbl_FlightDescription.BackColor = System.Drawing.Color.Transparent;
            lbl_FlightDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_FlightDescription.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_FlightDescription.Location = new System.Drawing.Point(45, 55);
            lbl_FlightDescription.Name = "lbl_FlightDescription";
            lbl_FlightDescription.Size = new System.Drawing.Size(372, 20);
            lbl_FlightDescription.TabIndex = 4;
            lbl_FlightDescription.Text = "(Day), Month • (Estimated Flight Time) • Class Type";
            // 
            // lbl_CardDestination
            // 
            lbl_CardDestination.AutoSize = true;
            lbl_CardDestination.BackColor = System.Drawing.Color.Transparent;
            lbl_CardDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_CardDestination.Location = new System.Drawing.Point(260, 25);
            lbl_CardDestination.Name = "lbl_CardDestination";
            lbl_CardDestination.Size = new System.Drawing.Size(59, 24);
            lbl_CardDestination.TabIndex = 2;
            lbl_CardDestination.Text = "<TO>";
            // 
            // lbl_From
            // 
            lbl_From.AutoSize = true;
            lbl_From.BackColor = System.Drawing.Color.Transparent;
            lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_From.Location = new System.Drawing.Point(100, 25);
            lbl_From.Name = "lbl_From";
            lbl_From.Size = new System.Drawing.Size(88, 24);
            lbl_From.TabIndex = 1;
            lbl_From.Text = "<FROM>";
            lbl_From.Click += lbl_From_Click;
            // 
            // btn_BookFlight
            // 
            btn_BookFlight.BackColor = System.Drawing.Color.FromArgb(3, 4, 94);
            btn_BookFlight.BackgroundImage = Properties.Resources.button_for_book_flight1;
            btn_BookFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_BookFlight.FlatAppearance.BorderSize = 0;
            btn_BookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_BookFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_BookFlight.ForeColor = System.Drawing.Color.White;
            btn_BookFlight.Location = new System.Drawing.Point(309, 109);
            btn_BookFlight.Name = "btn_BookFlight";
            btn_BookFlight.Size = new System.Drawing.Size(127, 52);
            btn_BookFlight.TabIndex = 0;
            btn_BookFlight.Text = " Book Flight";
            btn_BookFlight.UseVisualStyleBackColor = false;
            // 
            // Card_Deals
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(pnl_CardDeals);
            Name = "Card_Deals";
            Size = new System.Drawing.Size(445, 168);
            pnl_CardDeals.ResumeLayout(false);
            pnl_CardDeals.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_CardDeals;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_CardDestination;
        private System.Windows.Forms.Label lbl_FlightDescription;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_TripType;
        private System.Windows.Forms.Panel pnl_Arrow;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Button btn_BookFlight;
    }
}
