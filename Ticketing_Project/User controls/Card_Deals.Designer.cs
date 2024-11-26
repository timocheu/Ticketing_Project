namespace Ticketing_Project
{
    partial class CardDeal
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
            table_FlightDetails = new System.Windows.Forms.TableLayoutPanel();
            lbl_FlightDetails = new System.Windows.Forms.Label();
            table_FromToDestination = new System.Windows.Forms.TableLayoutPanel();
            lbl_From = new System.Windows.Forms.Label();
            lbl_Destination = new System.Windows.Forms.Label();
            pnl_Arrow = new System.Windows.Forms.Panel();
            lbl_TripType = new System.Windows.Forms.Label();
            lbl_Price = new System.Windows.Forms.Label();
            btn_BookFlight = new System.Windows.Forms.Button();
            pnl_CardDeals.SuspendLayout();
            table_FlightDetails.SuspendLayout();
            table_FromToDestination.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_CardDeals
            // 
            pnl_CardDeals.BackgroundImage = Properties.Resources.CardDealsBackground;
            pnl_CardDeals.Controls.Add(pnl_Logo);
            pnl_CardDeals.Controls.Add(table_FlightDetails);
            pnl_CardDeals.Controls.Add(table_FromToDestination);
            pnl_CardDeals.Controls.Add(lbl_TripType);
            pnl_CardDeals.Controls.Add(lbl_Price);
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
            // table_FlightDetails
            // 
            table_FlightDetails.ColumnCount = 1;
            table_FlightDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            table_FlightDetails.Controls.Add(lbl_FlightDetails, 0, 0);
            table_FlightDetails.Location = new System.Drawing.Point(18, 53);
            table_FlightDetails.Name = "table_FlightDetails";
            table_FlightDetails.RowCount = 1;
            table_FlightDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            table_FlightDetails.Size = new System.Drawing.Size(418, 30);
            table_FlightDetails.TabIndex = 11;
            // 
            // lbl_FlightDetails
            // 
            lbl_FlightDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lbl_FlightDetails.AutoSize = true;
            lbl_FlightDetails.BackColor = System.Drawing.Color.Transparent;
            lbl_FlightDetails.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_FlightDetails.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_FlightDetails.Location = new System.Drawing.Point(23, 0);
            lbl_FlightDetails.Name = "lbl_FlightDetails";
            lbl_FlightDetails.Size = new System.Drawing.Size(371, 30);
            lbl_FlightDetails.TabIndex = 4;
            lbl_FlightDetails.Text = "(Day), Month • (Estimated Flight Time) • Class Type";
            lbl_FlightDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table_FromToDestination
            // 
            table_FromToDestination.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            table_FromToDestination.ColumnCount = 3;
            table_FromToDestination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0620537F));
            table_FromToDestination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.398568F));
            table_FromToDestination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.53938F));
            table_FromToDestination.Controls.Add(lbl_From, 0, 0);
            table_FromToDestination.Controls.Add(lbl_Destination, 2, 0);
            table_FromToDestination.Controls.Add(pnl_Arrow, 1, 0);
            table_FromToDestination.Location = new System.Drawing.Point(17, 23);
            table_FromToDestination.Name = "table_FromToDestination";
            table_FromToDestination.RowCount = 1;
            table_FromToDestination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            table_FromToDestination.Size = new System.Drawing.Size(419, 33);
            table_FromToDestination.TabIndex = 10;
            // 
            // lbl_From
            // 
            lbl_From.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_From.AutoSize = true;
            lbl_From.BackColor = System.Drawing.Color.Transparent;
            lbl_From.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_From.Location = new System.Drawing.Point(103, 0);
            lbl_From.Name = "lbl_From";
            lbl_From.Size = new System.Drawing.Size(87, 33);
            lbl_From.TabIndex = 1;
            lbl_From.Text = "<From>";
            lbl_From.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Destination
            // 
            lbl_Destination.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_Destination.AutoSize = true;
            lbl_Destination.BackColor = System.Drawing.Color.Transparent;
            lbl_Destination.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Destination.Location = new System.Drawing.Point(227, 0);
            lbl_Destination.Name = "lbl_Destination";
            lbl_Destination.Size = new System.Drawing.Size(148, 33);
            lbl_Destination.TabIndex = 2;
            lbl_Destination.Text = "<Destination>";
            lbl_Destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Arrow
            // 
            pnl_Arrow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            pnl_Arrow.BackColor = System.Drawing.Color.Transparent;
            pnl_Arrow.BackgroundImage = Properties.Resources.typcn_arrow_up_outline1;
            pnl_Arrow.ForeColor = System.Drawing.Color.Transparent;
            pnl_Arrow.Location = new System.Drawing.Point(196, 6);
            pnl_Arrow.Name = "pnl_Arrow";
            pnl_Arrow.Size = new System.Drawing.Size(25, 24);
            pnl_Arrow.TabIndex = 7;
            // 
            // lbl_TripType
            // 
            lbl_TripType.AutoSize = true;
            lbl_TripType.BackColor = System.Drawing.Color.Transparent;
            lbl_TripType.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripType.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_TripType.Location = new System.Drawing.Point(18, 139);
            lbl_TripType.Name = "lbl_TripType";
            lbl_TripType.Size = new System.Drawing.Size(78, 23);
            lbl_TripType.TabIndex = 2;
            lbl_TripType.Text = "Round Trip";
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.BackColor = System.Drawing.Color.Transparent;
            lbl_Price.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Price.ForeColor = System.Drawing.Color.FromArgb(0, 119, 182);
            lbl_Price.Location = new System.Drawing.Point(17, 113);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new System.Drawing.Size(147, 34);
            lbl_Price.TabIndex = 6;
            lbl_Price.Text = "Price: ₱10,230";
            // 
            // btn_BookFlight
            // 
            btn_BookFlight.BackColor = System.Drawing.Color.FromArgb(3, 4, 94);
            btn_BookFlight.BackgroundImage = Properties.Resources.button_for_book_flight1;
            btn_BookFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_BookFlight.FlatAppearance.BorderSize = 0;
            btn_BookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_BookFlight.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_BookFlight.ForeColor = System.Drawing.Color.White;
            btn_BookFlight.Location = new System.Drawing.Point(309, 109);
            btn_BookFlight.Name = "btn_BookFlight";
            btn_BookFlight.Size = new System.Drawing.Size(127, 52);
            btn_BookFlight.TabIndex = 0;
            btn_BookFlight.Text = " Book Flight";
            btn_BookFlight.UseVisualStyleBackColor = false;
            btn_BookFlight.Click += btn_BookFlight_Click;
            // 
            // CardDeal
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(pnl_CardDeals);
            Name = "CardDeal";
            Size = new System.Drawing.Size(445, 169);
            pnl_CardDeals.ResumeLayout(false);
            pnl_CardDeals.PerformLayout();
            table_FlightDetails.ResumeLayout(false);
            table_FlightDetails.PerformLayout();
            table_FromToDestination.ResumeLayout(false);
            table_FromToDestination.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_CardDeals;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_Destination;
        private System.Windows.Forms.Label lbl_FlightDetails;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_TripType;
        private System.Windows.Forms.Panel pnl_Arrow;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Button btn_BookFlight;
        private System.Windows.Forms.TableLayoutPanel table_FromToDestination;
        private System.Windows.Forms.TableLayoutPanel table_FlightDetails;
    }
}
