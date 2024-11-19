namespace Ticketing_Project.User_controls
{
    partial class Checkout
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
            pnl_CheckoutSection = new System.Windows.Forms.Panel();
            btn_Proceed = new System.Windows.Forms.Button();
            btn_Cancel = new System.Windows.Forms.Button();
            btn_MobilePayment = new System.Windows.Forms.Button();
            flow_Checkout = new System.Windows.Forms.FlowLayoutPanel();
            flow_Passengers = new System.Windows.Forms.FlowLayoutPanel();
            uc_PassengerInput = new PassengerTextBox();
            pnl_PassengerOption = new System.Windows.Forms.Panel();
            btn_AddPassenger = new System.Windows.Forms.Button();
            btn_RemovePassenger = new System.Windows.Forms.Button();
            pnl_BookingSummary = new System.Windows.Forms.Panel();
            table_BookingSummary = new System.Windows.Forms.TableLayoutPanel();
            lbl_ReturnDateDisplay = new System.Windows.Forms.Label();
            lbl_PickUpDateDisplay = new System.Windows.Forms.Label();
            lbl_LocationDisplay = new System.Windows.Forms.Label();
            lbl_TotalTicketDisplay = new System.Windows.Forms.Label();
            lbl_TotalTicket = new System.Windows.Forms.Label();
            lbl_Location = new System.Windows.Forms.Label();
            lbl_PickUpDate = new System.Windows.Forms.Label();
            lbl_ReturnDate = new System.Windows.Forms.Label();
            lbl_BookingSummary = new System.Windows.Forms.Label();
            pb_Line = new System.Windows.Forms.PictureBox();
            tlp_TotalTable = new System.Windows.Forms.TableLayoutPanel();
            lbl_TotalDisplay = new System.Windows.Forms.Label();
            lbl_Total = new System.Windows.Forms.Label();
            pb_Line2 = new System.Windows.Forms.PictureBox();
            pb_Line3 = new System.Windows.Forms.PictureBox();
            tlp_PriceTable = new System.Windows.Forms.TableLayoutPanel();
            lbl_TaxDisplay = new System.Windows.Forms.Label();
            lbl_DiscountDisplay = new System.Windows.Forms.Label();
            lbl_TripPriceDisplay = new System.Windows.Forms.Label();
            lbl_TripPrice = new System.Windows.Forms.Label();
            lbl_Discount = new System.Windows.Forms.Label();
            lbl_Tax = new System.Windows.Forms.Label();
            lbl_PriceDetails = new System.Windows.Forms.Label();
            btn_CardPayment = new System.Windows.Forms.Button();
            lbl_Payment = new System.Windows.Forms.Label();
            lbl_SubDescription = new System.Windows.Forms.Label();
            pnl_CheckoutSection.SuspendLayout();
            flow_Checkout.SuspendLayout();
            flow_Passengers.SuspendLayout();
            pnl_PassengerOption.SuspendLayout();
            pnl_BookingSummary.SuspendLayout();
            table_BookingSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Line).BeginInit();
            tlp_TotalTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Line2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Line3).BeginInit();
            tlp_PriceTable.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_CheckoutSection
            // 
            pnl_CheckoutSection.BackColor = System.Drawing.Color.White;
            pnl_CheckoutSection.Controls.Add(btn_Proceed);
            pnl_CheckoutSection.Controls.Add(btn_Cancel);
            pnl_CheckoutSection.Controls.Add(btn_MobilePayment);
            pnl_CheckoutSection.Controls.Add(flow_Checkout);
            pnl_CheckoutSection.Controls.Add(btn_CardPayment);
            pnl_CheckoutSection.Controls.Add(lbl_Payment);
            pnl_CheckoutSection.Controls.Add(lbl_SubDescription);
            pnl_CheckoutSection.Location = new System.Drawing.Point(359, 0);
            pnl_CheckoutSection.Name = "pnl_CheckoutSection";
            pnl_CheckoutSection.Size = new System.Drawing.Size(683, 768);
            pnl_CheckoutSection.TabIndex = 0;
            // 
            // btn_Proceed
            // 
            btn_Proceed.BackColor = System.Drawing.Color.FromArgb(0, 113, 188);
            btn_Proceed.BackgroundImage = Properties.Resources.BorderBackgroundRemoved;
            btn_Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Proceed.FlatAppearance.BorderSize = 0;
            btn_Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Proceed.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Proceed.ForeColor = System.Drawing.Color.White;
            btn_Proceed.Image = Properties.Resources.PaymentBoxRemovedBackground;
            btn_Proceed.Location = new System.Drawing.Point(360, 706);
            btn_Proceed.Name = "btn_Proceed";
            btn_Proceed.Size = new System.Drawing.Size(152, 43);
            btn_Proceed.TabIndex = 14;
            btn_Proceed.Text = "Proceed";
            btn_Proceed.UseVisualStyleBackColor = false;
            btn_Proceed.Click += btn_Proceed_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = System.Drawing.Color.White;
            btn_Cancel.BackgroundImage = Properties.Resources.ButtonBackgroundBorder;
            btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Cancel.Image = Properties.Resources.PaymentBoxRemovedBackground;
            btn_Cancel.Location = new System.Drawing.Point(184, 706);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(152, 41);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_MobilePayment
            // 
            btn_MobilePayment.BackColor = System.Drawing.Color.FromArgb(0, 113, 188);
            btn_MobilePayment.BackgroundImage = Properties.Resources.PaymentBoxRemovedBackground;
            btn_MobilePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_MobilePayment.FlatAppearance.BorderSize = 0;
            btn_MobilePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_MobilePayment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_MobilePayment.ForeColor = System.Drawing.Color.Snow;
            btn_MobilePayment.Location = new System.Drawing.Point(360, 124);
            btn_MobilePayment.Name = "btn_MobilePayment";
            btn_MobilePayment.Size = new System.Drawing.Size(204, 90);
            btn_MobilePayment.TabIndex = 3;
            btn_MobilePayment.Text = "Mobile Payment";
            btn_MobilePayment.UseVisualStyleBackColor = false;
            btn_MobilePayment.Click += btn_MobilePayment_Click;
            // 
            // flow_Checkout
            // 
            flow_Checkout.Anchor = System.Windows.Forms.AnchorStyles.None;
            flow_Checkout.AutoScroll = true;
            flow_Checkout.BackColor = System.Drawing.Color.White;
            flow_Checkout.Controls.Add(flow_Passengers);
            flow_Checkout.Controls.Add(pnl_PassengerOption);
            flow_Checkout.Controls.Add(pnl_BookingSummary);
            flow_Checkout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flow_Checkout.Location = new System.Drawing.Point(111, 220);
            flow_Checkout.Name = "flow_Checkout";
            flow_Checkout.Size = new System.Drawing.Size(510, 489);
            flow_Checkout.TabIndex = 1;
            flow_Checkout.WrapContents = false;
            // 
            // flow_Passengers
            // 
            flow_Passengers.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flow_Passengers.AutoSize = true;
            flow_Passengers.BackColor = System.Drawing.Color.White;
            flow_Passengers.Controls.Add(uc_PassengerInput);
            flow_Passengers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flow_Passengers.Location = new System.Drawing.Point(3, 3);
            flow_Passengers.Name = "flow_Passengers";
            flow_Passengers.Size = new System.Drawing.Size(483, 67);
            flow_Passengers.TabIndex = 2;
            flow_Passengers.WrapContents = false;
            // 
            // uc_PassengerInput
            // 
            uc_PassengerInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            uc_PassengerInput.BackColor = System.Drawing.Color.Transparent;
            uc_PassengerInput.Location = new System.Drawing.Point(3, 3);
            uc_PassengerInput.Name = "uc_PassengerInput";
            uc_PassengerInput.Size = new System.Drawing.Size(477, 61);
            uc_PassengerInput.TabIndex = 0;
            // 
            // pnl_PassengerOption
            // 
            pnl_PassengerOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pnl_PassengerOption.Controls.Add(btn_AddPassenger);
            pnl_PassengerOption.Controls.Add(btn_RemovePassenger);
            pnl_PassengerOption.Location = new System.Drawing.Point(92, 76);
            pnl_PassengerOption.Name = "pnl_PassengerOption";
            pnl_PassengerOption.Size = new System.Drawing.Size(304, 68);
            pnl_PassengerOption.TabIndex = 8;
            // 
            // btn_AddPassenger
            // 
            btn_AddPassenger.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_AddPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_AddPassenger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_AddPassenger.Location = new System.Drawing.Point(26, 3);
            btn_AddPassenger.Name = "btn_AddPassenger";
            btn_AddPassenger.Size = new System.Drawing.Size(125, 35);
            btn_AddPassenger.TabIndex = 6;
            btn_AddPassenger.Text = "+ Add More";
            btn_AddPassenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_AddPassenger.UseVisualStyleBackColor = true;
            btn_AddPassenger.Click += btn_AddPassenger_Click;
            // 
            // btn_RemovePassenger
            // 
            btn_RemovePassenger.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_RemovePassenger.BackColor = System.Drawing.Color.Red;
            btn_RemovePassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_RemovePassenger.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_RemovePassenger.Location = new System.Drawing.Point(161, 3);
            btn_RemovePassenger.Name = "btn_RemovePassenger";
            btn_RemovePassenger.Size = new System.Drawing.Size(109, 35);
            btn_RemovePassenger.TabIndex = 7;
            btn_RemovePassenger.Text = "- Remove";
            btn_RemovePassenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_RemovePassenger.UseVisualStyleBackColor = false;
            btn_RemovePassenger.Click += btn_RemovePassenger_Click;
            // 
            // pnl_BookingSummary
            // 
            pnl_BookingSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnl_BookingSummary.Controls.Add(table_BookingSummary);
            pnl_BookingSummary.Controls.Add(lbl_BookingSummary);
            pnl_BookingSummary.Controls.Add(pb_Line);
            pnl_BookingSummary.Controls.Add(tlp_TotalTable);
            pnl_BookingSummary.Controls.Add(pb_Line2);
            pnl_BookingSummary.Controls.Add(pb_Line3);
            pnl_BookingSummary.Controls.Add(tlp_PriceTable);
            pnl_BookingSummary.Controls.Add(lbl_PriceDetails);
            pnl_BookingSummary.Location = new System.Drawing.Point(7, 150);
            pnl_BookingSummary.Name = "pnl_BookingSummary";
            pnl_BookingSummary.Size = new System.Drawing.Size(475, 363);
            pnl_BookingSummary.TabIndex = 15;
            // 
            // table_BookingSummary
            // 
            table_BookingSummary.ColumnCount = 2;
            table_BookingSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.6844559F));
            table_BookingSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3155441F));
            table_BookingSummary.Controls.Add(lbl_ReturnDateDisplay, 1, 3);
            table_BookingSummary.Controls.Add(lbl_PickUpDateDisplay, 1, 2);
            table_BookingSummary.Controls.Add(lbl_LocationDisplay, 1, 1);
            table_BookingSummary.Controls.Add(lbl_TotalTicketDisplay, 1, 0);
            table_BookingSummary.Controls.Add(lbl_TotalTicket, 0, 0);
            table_BookingSummary.Controls.Add(lbl_Location, 0, 1);
            table_BookingSummary.Controls.Add(lbl_PickUpDate, 0, 2);
            table_BookingSummary.Controls.Add(lbl_ReturnDate, 0, 3);
            table_BookingSummary.Location = new System.Drawing.Point(23, 42);
            table_BookingSummary.Name = "table_BookingSummary";
            table_BookingSummary.RowCount = 4;
            table_BookingSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            table_BookingSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            table_BookingSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            table_BookingSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            table_BookingSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            table_BookingSummary.Size = new System.Drawing.Size(431, 128);
            table_BookingSummary.TabIndex = 9;
            // 
            // lbl_ReturnDateDisplay
            // 
            lbl_ReturnDateDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_ReturnDateDisplay.AutoSize = true;
            lbl_ReturnDateDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ReturnDateDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_ReturnDateDisplay.Location = new System.Drawing.Point(243, 102);
            lbl_ReturnDateDisplay.Name = "lbl_ReturnDateDisplay";
            lbl_ReturnDateDisplay.Size = new System.Drawing.Size(33, 19);
            lbl_ReturnDateDisplay.TabIndex = 7;
            lbl_ReturnDateDisplay.Text = "N/A";
            // 
            // lbl_PickUpDateDisplay
            // 
            lbl_PickUpDateDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_PickUpDateDisplay.AutoSize = true;
            lbl_PickUpDateDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_PickUpDateDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_PickUpDateDisplay.Location = new System.Drawing.Point(243, 70);
            lbl_PickUpDateDisplay.Name = "lbl_PickUpDateDisplay";
            lbl_PickUpDateDisplay.Size = new System.Drawing.Size(33, 19);
            lbl_PickUpDateDisplay.TabIndex = 6;
            lbl_PickUpDateDisplay.Text = "N/A";
            // 
            // lbl_LocationDisplay
            // 
            lbl_LocationDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_LocationDisplay.AutoSize = true;
            lbl_LocationDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_LocationDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_LocationDisplay.Location = new System.Drawing.Point(243, 38);
            lbl_LocationDisplay.Name = "lbl_LocationDisplay";
            lbl_LocationDisplay.Size = new System.Drawing.Size(33, 19);
            lbl_LocationDisplay.TabIndex = 5;
            lbl_LocationDisplay.Text = "N/A";
            // 
            // lbl_TotalTicketDisplay
            // 
            lbl_TotalTicketDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_TotalTicketDisplay.AutoSize = true;
            lbl_TotalTicketDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TotalTicketDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_TotalTicketDisplay.Location = new System.Drawing.Point(243, 6);
            lbl_TotalTicketDisplay.Name = "lbl_TotalTicketDisplay";
            lbl_TotalTicketDisplay.Size = new System.Drawing.Size(33, 19);
            lbl_TotalTicketDisplay.TabIndex = 4;
            lbl_TotalTicketDisplay.Text = "N/A";
            // 
            // lbl_TotalTicket
            // 
            lbl_TotalTicket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_TotalTicket.AutoSize = true;
            lbl_TotalTicket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TotalTicket.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_TotalTicket.Location = new System.Drawing.Point(3, 6);
            lbl_TotalTicket.Name = "lbl_TotalTicket";
            lbl_TotalTicket.Size = new System.Drawing.Size(83, 19);
            lbl_TotalTicket.TabIndex = 0;
            lbl_TotalTicket.Text = "Total Tickets";
            // 
            // lbl_Location
            // 
            lbl_Location.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_Location.AutoSize = true;
            lbl_Location.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Location.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_Location.Location = new System.Drawing.Point(3, 38);
            lbl_Location.Name = "lbl_Location";
            lbl_Location.Size = new System.Drawing.Size(111, 19);
            lbl_Location.TabIndex = 1;
            lbl_Location.Text = "Pick Up Location";
            // 
            // lbl_PickUpDate
            // 
            lbl_PickUpDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_PickUpDate.AutoSize = true;
            lbl_PickUpDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_PickUpDate.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_PickUpDate.Location = new System.Drawing.Point(3, 70);
            lbl_PickUpDate.Name = "lbl_PickUpDate";
            lbl_PickUpDate.Size = new System.Drawing.Size(88, 19);
            lbl_PickUpDate.TabIndex = 2;
            lbl_PickUpDate.Text = "Pick Up Date";
            // 
            // lbl_ReturnDate
            // 
            lbl_ReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_ReturnDate.AutoSize = true;
            lbl_ReturnDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ReturnDate.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_ReturnDate.Location = new System.Drawing.Point(3, 102);
            lbl_ReturnDate.Name = "lbl_ReturnDate";
            lbl_ReturnDate.Size = new System.Drawing.Size(83, 19);
            lbl_ReturnDate.TabIndex = 3;
            lbl_ReturnDate.Text = "Return Date";
            // 
            // lbl_BookingSummary
            // 
            lbl_BookingSummary.AutoSize = true;
            lbl_BookingSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_BookingSummary.Location = new System.Drawing.Point(23, 7);
            lbl_BookingSummary.Name = "lbl_BookingSummary";
            lbl_BookingSummary.Size = new System.Drawing.Size(152, 21);
            lbl_BookingSummary.TabIndex = 7;
            lbl_BookingSummary.Text = "Booking Summary";
            // 
            // pb_Line
            // 
            pb_Line.BackColor = System.Drawing.Color.Gray;
            pb_Line.Location = new System.Drawing.Point(28, 35);
            pb_Line.Name = "pb_Line";
            pb_Line.Size = new System.Drawing.Size(430, 1);
            pb_Line.TabIndex = 8;
            pb_Line.TabStop = false;
            // 
            // tlp_TotalTable
            // 
            tlp_TotalTable.ColumnCount = 2;
            tlp_TotalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.6844559F));
            tlp_TotalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3155441F));
            tlp_TotalTable.Controls.Add(lbl_TotalDisplay, 1, 0);
            tlp_TotalTable.Controls.Add(lbl_Total, 0, 0);
            tlp_TotalTable.Location = new System.Drawing.Point(23, 312);
            tlp_TotalTable.Name = "tlp_TotalTable";
            tlp_TotalTable.RowCount = 1;
            tlp_TotalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_TotalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlp_TotalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlp_TotalTable.Size = new System.Drawing.Size(429, 31);
            tlp_TotalTable.TabIndex = 11;
            // 
            // lbl_TotalDisplay
            // 
            lbl_TotalDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_TotalDisplay.AutoSize = true;
            lbl_TotalDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TotalDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_TotalDisplay.Location = new System.Drawing.Point(241, 5);
            lbl_TotalDisplay.Name = "lbl_TotalDisplay";
            lbl_TotalDisplay.Size = new System.Drawing.Size(40, 21);
            lbl_TotalDisplay.TabIndex = 4;
            lbl_TotalDisplay.Text = "N/A";
            // 
            // lbl_Total
            // 
            lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Total.Location = new System.Drawing.Point(3, 5);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new System.Drawing.Size(48, 21);
            lbl_Total.TabIndex = 13;
            lbl_Total.Text = "Total";
            // 
            // pb_Line2
            // 
            pb_Line2.BackColor = System.Drawing.Color.Gray;
            pb_Line2.Location = new System.Drawing.Point(28, 179);
            pb_Line2.Name = "pb_Line2";
            pb_Line2.Size = new System.Drawing.Size(430, 1);
            pb_Line2.TabIndex = 10;
            pb_Line2.TabStop = false;
            // 
            // pb_Line3
            // 
            pb_Line3.BackColor = System.Drawing.Color.Gray;
            pb_Line3.Location = new System.Drawing.Point(28, 305);
            pb_Line3.Name = "pb_Line3";
            pb_Line3.Size = new System.Drawing.Size(430, 1);
            pb_Line3.TabIndex = 12;
            pb_Line3.TabStop = false;
            // 
            // tlp_PriceTable
            // 
            tlp_PriceTable.ColumnCount = 2;
            tlp_PriceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.6844559F));
            tlp_PriceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3155441F));
            tlp_PriceTable.Controls.Add(lbl_TaxDisplay, 1, 2);
            tlp_PriceTable.Controls.Add(lbl_DiscountDisplay, 1, 1);
            tlp_PriceTable.Controls.Add(lbl_TripPriceDisplay, 1, 0);
            tlp_PriceTable.Controls.Add(lbl_TripPrice, 0, 0);
            tlp_PriceTable.Controls.Add(lbl_Discount, 0, 1);
            tlp_PriceTable.Controls.Add(lbl_Tax, 0, 2);
            tlp_PriceTable.Location = new System.Drawing.Point(23, 211);
            tlp_PriceTable.Name = "tlp_PriceTable";
            tlp_PriceTable.RowCount = 3;
            tlp_PriceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_PriceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_PriceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_PriceTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlp_PriceTable.Size = new System.Drawing.Size(429, 84);
            tlp_PriceTable.TabIndex = 10;
            // 
            // lbl_TaxDisplay
            // 
            lbl_TaxDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_TaxDisplay.AutoSize = true;
            lbl_TaxDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TaxDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_TaxDisplay.Location = new System.Drawing.Point(241, 60);
            lbl_TaxDisplay.Name = "lbl_TaxDisplay";
            lbl_TaxDisplay.Size = new System.Drawing.Size(33, 19);
            lbl_TaxDisplay.TabIndex = 6;
            lbl_TaxDisplay.Text = "N/A";
            // 
            // lbl_DiscountDisplay
            // 
            lbl_DiscountDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_DiscountDisplay.AutoSize = true;
            lbl_DiscountDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_DiscountDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_DiscountDisplay.Location = new System.Drawing.Point(241, 32);
            lbl_DiscountDisplay.Name = "lbl_DiscountDisplay";
            lbl_DiscountDisplay.Size = new System.Drawing.Size(33, 19);
            lbl_DiscountDisplay.TabIndex = 5;
            lbl_DiscountDisplay.Text = "N/A";
            // 
            // lbl_TripPriceDisplay
            // 
            lbl_TripPriceDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_TripPriceDisplay.AutoSize = true;
            lbl_TripPriceDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripPriceDisplay.ForeColor = System.Drawing.Color.Black;
            lbl_TripPriceDisplay.Location = new System.Drawing.Point(241, 4);
            lbl_TripPriceDisplay.Name = "lbl_TripPriceDisplay";
            lbl_TripPriceDisplay.Size = new System.Drawing.Size(33, 19);
            lbl_TripPriceDisplay.TabIndex = 4;
            lbl_TripPriceDisplay.Text = "N/A";
            // 
            // lbl_TripPrice
            // 
            lbl_TripPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_TripPrice.AutoSize = true;
            lbl_TripPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripPrice.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_TripPrice.Location = new System.Drawing.Point(3, 4);
            lbl_TripPrice.Name = "lbl_TripPrice";
            lbl_TripPrice.Size = new System.Drawing.Size(149, 19);
            lbl_TripPrice.TabIndex = 0;
            lbl_TripPrice.Text = "Trip Price (Each Person)";
            // 
            // lbl_Discount
            // 
            lbl_Discount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_Discount.AutoSize = true;
            lbl_Discount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Discount.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_Discount.Location = new System.Drawing.Point(3, 32);
            lbl_Discount.Name = "lbl_Discount";
            lbl_Discount.Size = new System.Drawing.Size(63, 19);
            lbl_Discount.TabIndex = 1;
            lbl_Discount.Text = "Discount";
            // 
            // lbl_Tax
            // 
            lbl_Tax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_Tax.AutoSize = true;
            lbl_Tax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Tax.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            lbl_Tax.Location = new System.Drawing.Point(3, 60);
            lbl_Tax.Name = "lbl_Tax";
            lbl_Tax.Size = new System.Drawing.Size(62, 19);
            lbl_Tax.TabIndex = 2;
            lbl_Tax.Text = "Tax (VAT)";
            // 
            // lbl_PriceDetails
            // 
            lbl_PriceDetails.AutoSize = true;
            lbl_PriceDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_PriceDetails.Location = new System.Drawing.Point(26, 187);
            lbl_PriceDetails.Name = "lbl_PriceDetails";
            lbl_PriceDetails.Size = new System.Drawing.Size(105, 21);
            lbl_PriceDetails.TabIndex = 11;
            lbl_PriceDetails.Text = "Price Details";
            // 
            // btn_CardPayment
            // 
            btn_CardPayment.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btn_CardPayment.BackgroundImage = Properties.Resources.PaymentBoxRemovedBackground;
            btn_CardPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_CardPayment.FlatAppearance.BorderSize = 0;
            btn_CardPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_CardPayment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_CardPayment.Location = new System.Drawing.Point(132, 124);
            btn_CardPayment.Name = "btn_CardPayment";
            btn_CardPayment.Size = new System.Drawing.Size(204, 90);
            btn_CardPayment.TabIndex = 2;
            btn_CardPayment.Text = "Card Payment\r\n";
            btn_CardPayment.UseVisualStyleBackColor = false;
            btn_CardPayment.Click += btn_CardPayment_Click;
            // 
            // lbl_Payment
            // 
            lbl_Payment.AutoSize = true;
            lbl_Payment.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Payment.Location = new System.Drawing.Point(124, 55);
            lbl_Payment.Name = "lbl_Payment";
            lbl_Payment.Size = new System.Drawing.Size(150, 45);
            lbl_Payment.TabIndex = 0;
            lbl_Payment.Text = "Payment";
            lbl_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SubDescription
            // 
            lbl_SubDescription.AutoSize = true;
            lbl_SubDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_SubDescription.Location = new System.Drawing.Point(129, 94);
            lbl_SubDescription.Name = "lbl_SubDescription";
            lbl_SubDescription.Size = new System.Drawing.Size(231, 21);
            lbl_SubDescription.TabIndex = 1;
            lbl_SubDescription.Text = "Choose payment method below";
            // 
            // Checkout
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            Controls.Add(pnl_CheckoutSection);
            Name = "Checkout";
            Size = new System.Drawing.Size(1396, 768);
            pnl_CheckoutSection.ResumeLayout(false);
            pnl_CheckoutSection.PerformLayout();
            flow_Checkout.ResumeLayout(false);
            flow_Checkout.PerformLayout();
            flow_Passengers.ResumeLayout(false);
            pnl_PassengerOption.ResumeLayout(false);
            pnl_BookingSummary.ResumeLayout(false);
            pnl_BookingSummary.PerformLayout();
            table_BookingSummary.ResumeLayout(false);
            table_BookingSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Line).EndInit();
            tlp_TotalTable.ResumeLayout(false);
            tlp_TotalTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Line2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Line3).EndInit();
            tlp_PriceTable.ResumeLayout(false);
            tlp_PriceTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_CheckoutSection;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.Label lbl_SubDescription;
        private System.Windows.Forms.Button btn_CardPayment;
        private System.Windows.Forms.Button btn_MobilePayment;
        private System.Windows.Forms.Label lbl_BookingSummary;
        private System.Windows.Forms.Button btn_AddPassenger;
        private System.Windows.Forms.PictureBox pb_Line;
        private System.Windows.Forms.TableLayoutPanel table_BookingSummary;
        private System.Windows.Forms.Label lbl_TotalTicket;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_PickUpDate;
        private System.Windows.Forms.Label lbl_ReturnDate;
        private System.Windows.Forms.Label lbl_PriceDetails;
        private System.Windows.Forms.TableLayoutPanel tlp_PriceTable;
        private System.Windows.Forms.Label lbl_TripPrice;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Tax;
        private System.Windows.Forms.PictureBox pb_Line2;
        private System.Windows.Forms.Label lbl_ReturnDateDisplay;
        private System.Windows.Forms.Label lbl_PickUpDateDisplay;
        private System.Windows.Forms.Label lbl_LocationDisplay;
        private System.Windows.Forms.Label lbl_TotalTicketDisplay;
        private System.Windows.Forms.TableLayoutPanel tlp_TotalTable;
        private System.Windows.Forms.Label lbl_TotalDisplay;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.PictureBox pb_Line3;
        private System.Windows.Forms.Label lbl_TaxDisplay;
        private System.Windows.Forms.Label lbl_DiscountDisplay;
        private System.Windows.Forms.Label lbl_TripPriceDisplay;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.FlowLayoutPanel flow_Checkout;
        private System.Windows.Forms.FlowLayoutPanel flow_Passengers;
        private PassengerTextBox uc_PassengerInput;
        private System.Windows.Forms.Panel pnl_BookingSummary;
        private System.Windows.Forms.Panel pnl_PassengerOption;
        private System.Windows.Forms.Button btn_RemovePassenger;
    }
}
