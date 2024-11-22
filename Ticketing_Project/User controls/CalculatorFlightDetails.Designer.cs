namespace Ticketing_Project.User_controls
{
    partial class CalculatorFlightDetails
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
            pnl_FlightDetails = new System.Windows.Forms.Panel();
            btn_Proceed = new System.Windows.Forms.Button();
            btn_Cancel = new System.Windows.Forms.Button();
            tbl_Total = new System.Windows.Forms.TableLayoutPanel();
            lbl_Total = new System.Windows.Forms.Label();
            tbl_PriceDetails = new System.Windows.Forms.TableLayoutPanel();
            lbl_Tax = new System.Windows.Forms.Label();
            lbl_Discount = new System.Windows.Forms.Label();
            lbl_TripPrice = new System.Windows.Forms.Label();
            tbl_Summary = new System.Windows.Forms.TableLayoutPanel();
            lbl_ReturnDate = new System.Windows.Forms.Label();
            lbl_PickUpDate = new System.Windows.Forms.Label();
            lbl_Distance = new System.Windows.Forms.Label();
            lbl_Duration = new System.Windows.Forms.Label();
            lbl_Destination = new System.Windows.Forms.Label();
            lbl_From = new System.Windows.Forms.Label();
            lbl_TotalTickets = new System.Windows.Forms.Label();
            pnl_FlightDetails.SuspendLayout();
            tbl_Total.SuspendLayout();
            tbl_PriceDetails.SuspendLayout();
            tbl_Summary.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_FlightDetails
            // 
            pnl_FlightDetails.BackgroundImage = Properties.Resources.FlightDetailsControl;
            pnl_FlightDetails.Controls.Add(btn_Proceed);
            pnl_FlightDetails.Controls.Add(btn_Cancel);
            pnl_FlightDetails.Controls.Add(tbl_Total);
            pnl_FlightDetails.Controls.Add(tbl_PriceDetails);
            pnl_FlightDetails.Controls.Add(tbl_Summary);
            pnl_FlightDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pnl_FlightDetails.Location = new System.Drawing.Point(430, 0);
            pnl_FlightDetails.Name = "pnl_FlightDetails";
            pnl_FlightDetails.Size = new System.Drawing.Size(683, 768);
            pnl_FlightDetails.TabIndex = 0;
            pnl_FlightDetails.Paint += pnl_FlightDetails_Paint;
            // 
            // btn_Proceed
            // 
            btn_Proceed.BackColor = System.Drawing.Color.FromArgb(0, 113, 188);
            btn_Proceed.BackgroundImage = Properties.Resources.BorderBackgroundRemoved;
            btn_Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Proceed.FlatAppearance.BorderSize = 0;
            btn_Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Proceed.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Proceed.ForeColor = System.Drawing.Color.White;
            btn_Proceed.Image = Properties.Resources.PaymentBoxRemovedBackground;
            btn_Proceed.Location = new System.Drawing.Point(357, 678);
            btn_Proceed.Name = "btn_Proceed";
            btn_Proceed.Size = new System.Drawing.Size(152, 43);
            btn_Proceed.TabIndex = 16;
            btn_Proceed.Text = "Proceed";
            btn_Proceed.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = System.Drawing.Color.White;
            btn_Cancel.BackgroundImage = Properties.Resources.ButtonBackgroundBorder;
            btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Cancel.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Cancel.Image = Properties.Resources.PaymentBoxRemovedBackground;
            btn_Cancel.Location = new System.Drawing.Point(181, 678);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(152, 41);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // tbl_Total
            // 
            tbl_Total.BackColor = System.Drawing.Color.Transparent;
            tbl_Total.ColumnCount = 1;
            tbl_Total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tbl_Total.Controls.Add(lbl_Total, 0, 0);
            tbl_Total.Location = new System.Drawing.Point(337, 586);
            tbl_Total.Name = "tbl_Total";
            tbl_Total.RowCount = 1;
            tbl_Total.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.287344F));
            tbl_Total.Size = new System.Drawing.Size(218, 35);
            tbl_Total.TabIndex = 2;
            // 
            // lbl_Total
            // 
            lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Total.Location = new System.Drawing.Point(163, 0);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_Total.Size = new System.Drawing.Size(52, 35);
            lbl_Total.TabIndex = 1;
            lbl_Total.Text = "N/A";
            lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbl_PriceDetails
            // 
            tbl_PriceDetails.BackColor = System.Drawing.Color.Transparent;
            tbl_PriceDetails.ColumnCount = 1;
            tbl_PriceDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tbl_PriceDetails.Controls.Add(lbl_Tax, 0, 2);
            tbl_PriceDetails.Controls.Add(lbl_Discount, 0, 1);
            tbl_PriceDetails.Controls.Add(lbl_TripPrice, 0, 0);
            tbl_PriceDetails.Location = new System.Drawing.Point(336, 477);
            tbl_PriceDetails.Name = "tbl_PriceDetails";
            tbl_PriceDetails.RowCount = 3;
            tbl_PriceDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.287344F));
            tbl_PriceDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2873478F));
            tbl_PriceDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2873478F));
            tbl_PriceDetails.Size = new System.Drawing.Size(218, 92);
            tbl_PriceDetails.TabIndex = 1;
            // 
            // lbl_Tax
            // 
            lbl_Tax.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_Tax.AutoSize = true;
            lbl_Tax.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Tax.Location = new System.Drawing.Point(177, 67);
            lbl_Tax.Name = "lbl_Tax";
            lbl_Tax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_Tax.Size = new System.Drawing.Size(38, 25);
            lbl_Tax.TabIndex = 3;
            lbl_Tax.Text = "N/A";
            lbl_Tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Discount
            // 
            lbl_Discount.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_Discount.AutoSize = true;
            lbl_Discount.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Discount.Location = new System.Drawing.Point(177, 35);
            lbl_Discount.Name = "lbl_Discount";
            lbl_Discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_Discount.Size = new System.Drawing.Size(38, 25);
            lbl_Discount.TabIndex = 2;
            lbl_Discount.Text = "N/A";
            lbl_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TripPrice
            // 
            lbl_TripPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_TripPrice.AutoSize = true;
            lbl_TripPrice.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripPrice.Location = new System.Drawing.Point(177, 5);
            lbl_TripPrice.Name = "lbl_TripPrice";
            lbl_TripPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_TripPrice.Size = new System.Drawing.Size(38, 25);
            lbl_TripPrice.TabIndex = 1;
            lbl_TripPrice.Text = "N/A";
            lbl_TripPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbl_Summary
            // 
            tbl_Summary.BackColor = System.Drawing.Color.Transparent;
            tbl_Summary.ColumnCount = 1;
            tbl_Summary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tbl_Summary.Controls.Add(lbl_ReturnDate, 0, 6);
            tbl_Summary.Controls.Add(lbl_PickUpDate, 0, 5);
            tbl_Summary.Controls.Add(lbl_Distance, 0, 4);
            tbl_Summary.Controls.Add(lbl_Duration, 0, 3);
            tbl_Summary.Controls.Add(lbl_Destination, 0, 2);
            tbl_Summary.Controls.Add(lbl_From, 0, 1);
            tbl_Summary.Controls.Add(lbl_TotalTickets, 0, 0);
            tbl_Summary.Location = new System.Drawing.Point(337, 223);
            tbl_Summary.Name = "tbl_Summary";
            tbl_Summary.RowCount = 7;
            tbl_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.287344F));
            tbl_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2873478F));
            tbl_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2873478F));
            tbl_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2873478F));
            tbl_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2873478F));
            tbl_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2816334F));
            tbl_Summary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2816334F));
            tbl_Summary.Size = new System.Drawing.Size(218, 208);
            tbl_Summary.TabIndex = 0;
            tbl_Summary.Paint += tableLayoutPanel1_Paint;
            // 
            // lbl_ReturnDate
            // 
            lbl_ReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_ReturnDate.AutoSize = true;
            lbl_ReturnDate.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ReturnDate.Location = new System.Drawing.Point(177, 183);
            lbl_ReturnDate.Name = "lbl_ReturnDate";
            lbl_ReturnDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_ReturnDate.Size = new System.Drawing.Size(38, 25);
            lbl_ReturnDate.TabIndex = 7;
            lbl_ReturnDate.Text = "N/A";
            // 
            // lbl_PickUpDate
            // 
            lbl_PickUpDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_PickUpDate.AutoSize = true;
            lbl_PickUpDate.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_PickUpDate.Location = new System.Drawing.Point(177, 149);
            lbl_PickUpDate.Name = "lbl_PickUpDate";
            lbl_PickUpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_PickUpDate.Size = new System.Drawing.Size(38, 25);
            lbl_PickUpDate.TabIndex = 6;
            lbl_PickUpDate.Text = "N/A";
            lbl_PickUpDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Distance
            // 
            lbl_Distance.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_Distance.AutoSize = true;
            lbl_Distance.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Distance.Location = new System.Drawing.Point(177, 120);
            lbl_Distance.Name = "lbl_Distance";
            lbl_Distance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_Distance.Size = new System.Drawing.Size(38, 25);
            lbl_Distance.TabIndex = 5;
            lbl_Distance.Text = "N/A";
            lbl_Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Duration
            // 
            lbl_Duration.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_Duration.AutoSize = true;
            lbl_Duration.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Duration.Location = new System.Drawing.Point(177, 91);
            lbl_Duration.Name = "lbl_Duration";
            lbl_Duration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_Duration.Size = new System.Drawing.Size(38, 25);
            lbl_Duration.TabIndex = 4;
            lbl_Duration.Text = "N/A";
            lbl_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Destination
            // 
            lbl_Destination.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_Destination.AutoSize = true;
            lbl_Destination.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Destination.Location = new System.Drawing.Point(177, 62);
            lbl_Destination.Name = "lbl_Destination";
            lbl_Destination.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_Destination.Size = new System.Drawing.Size(38, 25);
            lbl_Destination.TabIndex = 3;
            lbl_Destination.Text = "N/A";
            lbl_Destination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_From
            // 
            lbl_From.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_From.AutoSize = true;
            lbl_From.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_From.Location = new System.Drawing.Point(177, 33);
            lbl_From.Name = "lbl_From";
            lbl_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_From.Size = new System.Drawing.Size(38, 25);
            lbl_From.TabIndex = 2;
            lbl_From.Text = "N/A";
            lbl_From.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalTickets
            // 
            lbl_TotalTickets.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_TotalTickets.AutoSize = true;
            lbl_TotalTickets.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TotalTickets.Location = new System.Drawing.Point(177, 4);
            lbl_TotalTickets.Name = "lbl_TotalTickets";
            lbl_TotalTickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lbl_TotalTickets.Size = new System.Drawing.Size(38, 25);
            lbl_TotalTickets.TabIndex = 1;
            lbl_TotalTickets.Text = "N/A";
            lbl_TotalTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorFlightDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            Controls.Add(pnl_FlightDetails);
            Name = "CalculatorFlightDetails";
            Size = new System.Drawing.Size(1396, 768);
            pnl_FlightDetails.ResumeLayout(false);
            tbl_Total.ResumeLayout(false);
            tbl_Total.PerformLayout();
            tbl_PriceDetails.ResumeLayout(false);
            tbl_PriceDetails.PerformLayout();
            tbl_Summary.ResumeLayout(false);
            tbl_Summary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_FlightDetails;
        private System.Windows.Forms.TableLayoutPanel tbl_Summary;
        private System.Windows.Forms.Label lbl_TotalTickets;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_Destination;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_Distance; 
        private System.Windows.Forms.Label lbl_PickUpDate; 
        private System.Windows.Forms.Label lbl_ReturnDate;
        private System.Windows.Forms.TableLayoutPanel tbl_PriceDetails;
        private System.Windows.Forms.Label lbl_Tax;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_TripPrice;
        private System.Windows.Forms.TableLayoutPanel tbl_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
