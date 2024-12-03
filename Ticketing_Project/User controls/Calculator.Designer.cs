namespace Ticketing_Project
{
    partial class Calculator
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
            cbb_BoardClass = new System.Windows.Forms.ComboBox();
            cbb_NumberOfPassengers = new System.Windows.Forms.ComboBox();
            pb_CalculatorPeopleIcon = new System.Windows.Forms.PictureBox();
            cbb_TripType = new System.Windows.Forms.ComboBox();
            pb_CalculatorFromSelection = new System.Windows.Forms.PictureBox();
            pb_CalculatorDestination = new System.Windows.Forms.PictureBox();
            pb_CalculatorArrow = new System.Windows.Forms.PictureBox();
            pb_CalculatorBackground = new System.Windows.Forms.PictureBox();
            btn_Calculate = new System.Windows.Forms.Button();
            dtp_FlightDate = new System.Windows.Forms.DateTimePicker();
            cbb_From = new System.Windows.Forms.ComboBox();
            cbb_Destination = new System.Windows.Forms.ComboBox();
            lbl_TripType = new System.Windows.Forms.Label();
            lbl_NumberOfPassenger = new System.Windows.Forms.Label();
            lbl_BoardClass = new System.Windows.Forms.Label();
            dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            lbl_FlightDate = new System.Windows.Forms.Label();
            lbl_ReturnDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorPeopleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorFromSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorDestination).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorBackground).BeginInit();
            SuspendLayout();
            // 
            // cbb_BoardClass
            // 
            cbb_BoardClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_BoardClass.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbb_BoardClass.FormattingEnabled = true;
            cbb_BoardClass.Items.AddRange(new object[] { "Economy", "Business Class" });
            cbb_BoardClass.Location = new System.Drawing.Point(320, 57);
            cbb_BoardClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_BoardClass.Name = "cbb_BoardClass";
            cbb_BoardClass.Size = new System.Drawing.Size(131, 30);
            cbb_BoardClass.TabIndex = 3;
            // 
            // cbb_NumberOfPassengers
            // 
            cbb_NumberOfPassengers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_NumberOfPassengers.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbb_NumberOfPassengers.FormattingEnabled = true;
            cbb_NumberOfPassengers.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbb_NumberOfPassengers.Location = new System.Drawing.Point(178, 57);
            cbb_NumberOfPassengers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_NumberOfPassengers.Name = "cbb_NumberOfPassengers";
            cbb_NumberOfPassengers.Size = new System.Drawing.Size(133, 30);
            cbb_NumberOfPassengers.TabIndex = 2;
            // 
            // pb_CalculatorPeopleIcon
            // 
            pb_CalculatorPeopleIcon.BackColor = System.Drawing.Color.White;
            pb_CalculatorPeopleIcon.Image = Properties.Resources.ic_baseline_people;
            pb_CalculatorPeopleIcon.Location = new System.Drawing.Point(146, 60);
            pb_CalculatorPeopleIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorPeopleIcon.Name = "pb_CalculatorPeopleIcon";
            pb_CalculatorPeopleIcon.Size = new System.Drawing.Size(30, 26);
            pb_CalculatorPeopleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_CalculatorPeopleIcon.TabIndex = 4;
            pb_CalculatorPeopleIcon.TabStop = false;
            // 
            // cbb_TripType
            // 
            cbb_TripType.BackColor = System.Drawing.Color.White;
            cbb_TripType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_TripType.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbb_TripType.FormattingEnabled = true;
            cbb_TripType.Items.AddRange(new object[] { "One Way", "Round Trip" });
            cbb_TripType.Location = new System.Drawing.Point(41, 57);
            cbb_TripType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_TripType.Name = "cbb_TripType";
            cbb_TripType.Size = new System.Drawing.Size(98, 30);
            cbb_TripType.TabIndex = 1;
            cbb_TripType.SelectedIndexChanged += cbb_TripType_SelectedIndexChanged;
            // 
            // pb_CalculatorFromSelection
            // 
            pb_CalculatorFromSelection.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorFromSelection.BackgroundImage = Properties.Resources.from_box;
            pb_CalculatorFromSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pb_CalculatorFromSelection.Location = new System.Drawing.Point(41, 102);
            pb_CalculatorFromSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorFromSelection.Name = "pb_CalculatorFromSelection";
            pb_CalculatorFromSelection.Size = new System.Drawing.Size(375, 50);
            pb_CalculatorFromSelection.TabIndex = 6;
            pb_CalculatorFromSelection.TabStop = false;
            // 
            // pb_CalculatorDestination
            // 
            pb_CalculatorDestination.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorDestination.BackgroundImage = Properties.Resources.from_box;
            pb_CalculatorDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pb_CalculatorDestination.Location = new System.Drawing.Point(471, 102);
            pb_CalculatorDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorDestination.Name = "pb_CalculatorDestination";
            pb_CalculatorDestination.Size = new System.Drawing.Size(375, 50);
            pb_CalculatorDestination.TabIndex = 7;
            pb_CalculatorDestination.TabStop = false;
            // 
            // pb_CalculatorArrow
            // 
            pb_CalculatorArrow.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorArrow.Image = Properties.Resources.typcn_arrow_up_outline;
            pb_CalculatorArrow.Location = new System.Drawing.Point(427, 113);
            pb_CalculatorArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorArrow.Name = "pb_CalculatorArrow";
            pb_CalculatorArrow.Size = new System.Drawing.Size(33, 30);
            pb_CalculatorArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_CalculatorArrow.TabIndex = 8;
            pb_CalculatorArrow.TabStop = false;
            // 
            // pb_CalculatorBackground
            // 
            pb_CalculatorBackground.BackColor = System.Drawing.Color.Transparent;
            pb_CalculatorBackground.Image = Properties.Resources.Flight_Calculator1;
            pb_CalculatorBackground.Location = new System.Drawing.Point(15, 12);
            pb_CalculatorBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorBackground.Name = "pb_CalculatorBackground";
            pb_CalculatorBackground.Size = new System.Drawing.Size(988, 155);
            pb_CalculatorBackground.TabIndex = 10;
            pb_CalculatorBackground.TabStop = false;
            // 
            // btn_Calculate
            // 
            btn_Calculate.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            btn_Calculate.BackgroundImage = Properties.Resources.CalcutorButtonRemovedBackground;
            btn_Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_Calculate.FlatAppearance.BorderSize = 0;
            btn_Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 93, 142);
            btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Calculate.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Calculate.ForeColor = System.Drawing.Color.White;
            btn_Calculate.Location = new System.Drawing.Point(852, 101);
            btn_Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new System.Drawing.Size(125, 50);
            btn_Calculate.TabIndex = 7;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = false;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // dtp_FlightDate
            // 
            dtp_FlightDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dtp_FlightDate.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtp_FlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_FlightDate.Location = new System.Drawing.Point(460, 57);
            dtp_FlightDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtp_FlightDate.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            dtp_FlightDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            dtp_FlightDate.Name = "dtp_FlightDate";
            dtp_FlightDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dtp_FlightDate.Size = new System.Drawing.Size(121, 35);
            dtp_FlightDate.TabIndex = 6;
            dtp_FlightDate.Value = new System.DateTime(2024, 11, 23, 21, 20, 48, 0);
            dtp_FlightDate.ValueChanged += dtp_FlightDate_ValueChanged;
            // 
            // cbb_From
            // 
            cbb_From.BackColor = System.Drawing.Color.White;
            cbb_From.CausesValidation = false;
            cbb_From.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbb_From.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbb_From.FormattingEnabled = true;
            cbb_From.IntegralHeight = false;
            cbb_From.ItemHeight = 34;
            cbb_From.Location = new System.Drawing.Point(51, 106);
            cbb_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new System.Drawing.Size(355, 42);
            cbb_From.TabIndex = 4;
            cbb_From.MouseClick += cbb_From_MouseClick;
            // 
            // cbb_Destination
            // 
            cbb_Destination.BackColor = System.Drawing.Color.White;
            cbb_Destination.CausesValidation = false;
            cbb_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbb_Destination.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbb_Destination.FormattingEnabled = true;
            cbb_Destination.IntegralHeight = false;
            cbb_Destination.Location = new System.Drawing.Point(480, 106);
            cbb_Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_Destination.Name = "cbb_Destination";
            cbb_Destination.Size = new System.Drawing.Size(355, 42);
            cbb_Destination.TabIndex = 5;
            cbb_Destination.MouseClick += cbb_Destination_MouseClick;
            // 
            // lbl_TripType
            // 
            lbl_TripType.AutoSize = true;
            lbl_TripType.BackColor = System.Drawing.Color.White;
            lbl_TripType.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripType.Location = new System.Drawing.Point(41, 33);
            lbl_TripType.Name = "lbl_TripType";
            lbl_TripType.Size = new System.Drawing.Size(79, 26);
            lbl_TripType.TabIndex = 20;
            lbl_TripType.Text = "Trip Type";
            // 
            // lbl_NumberOfPassenger
            // 
            lbl_NumberOfPassenger.AutoSize = true;
            lbl_NumberOfPassenger.BackColor = System.Drawing.Color.White;
            lbl_NumberOfPassenger.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_NumberOfPassenger.Location = new System.Drawing.Point(175, 33);
            lbl_NumberOfPassenger.Name = "lbl_NumberOfPassenger";
            lbl_NumberOfPassenger.Size = new System.Drawing.Size(107, 25);
            lbl_NumberOfPassenger.TabIndex = 20;
            lbl_NumberOfPassenger.Text = "# Passengers";
            lbl_NumberOfPassenger.UseCompatibleTextRendering = true;
            // 
            // lbl_BoardClass
            // 
            lbl_BoardClass.AutoSize = true;
            lbl_BoardClass.BackColor = System.Drawing.Color.White;
            lbl_BoardClass.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_BoardClass.Location = new System.Drawing.Point(317, 33);
            lbl_BoardClass.Name = "lbl_BoardClass";
            lbl_BoardClass.Size = new System.Drawing.Size(103, 26);
            lbl_BoardClass.TabIndex = 20;
            lbl_BoardClass.Text = "Board Class";
            // 
            // dtp_ReturnDate
            // 
            dtp_ReturnDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dtp_ReturnDate.Enabled = false;
            dtp_ReturnDate.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtp_ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_ReturnDate.Location = new System.Drawing.Point(587, 57);
            dtp_ReturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtp_ReturnDate.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            dtp_ReturnDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            dtp_ReturnDate.Name = "dtp_ReturnDate";
            dtp_ReturnDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dtp_ReturnDate.Size = new System.Drawing.Size(121, 35);
            dtp_ReturnDate.TabIndex = 21;
            dtp_ReturnDate.Value = new System.DateTime(2024, 11, 23, 21, 20, 48, 0);
            // 
            // lbl_FlightDate
            // 
            lbl_FlightDate.AutoSize = true;
            lbl_FlightDate.BackColor = System.Drawing.Color.White;
            lbl_FlightDate.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_FlightDate.Location = new System.Drawing.Point(457, 33);
            lbl_FlightDate.Name = "lbl_FlightDate";
            lbl_FlightDate.Size = new System.Drawing.Size(92, 26);
            lbl_FlightDate.TabIndex = 22;
            lbl_FlightDate.Text = "Flight Date";
            // 
            // lbl_ReturnDate
            // 
            lbl_ReturnDate.AutoSize = true;
            lbl_ReturnDate.BackColor = System.Drawing.Color.White;
            lbl_ReturnDate.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_ReturnDate.Location = new System.Drawing.Point(587, 33);
            lbl_ReturnDate.Name = "lbl_ReturnDate";
            lbl_ReturnDate.Size = new System.Drawing.Size(100, 26);
            lbl_ReturnDate.TabIndex = 23;
            lbl_ReturnDate.Text = "Return Date";
            // 
            // Calculator
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(dtp_ReturnDate);
            Controls.Add(lbl_ReturnDate);
            Controls.Add(dtp_FlightDate);
            Controls.Add(lbl_FlightDate);
            Controls.Add(cbb_TripType);
            Controls.Add(cbb_NumberOfPassengers);
            Controls.Add(cbb_BoardClass);
            Controls.Add(lbl_BoardClass);
            Controls.Add(lbl_NumberOfPassenger);
            Controls.Add(lbl_TripType);
            Controls.Add(cbb_Destination);
            Controls.Add(cbb_From);
            Controls.Add(btn_Calculate);
            Controls.Add(pb_CalculatorArrow);
            Controls.Add(pb_CalculatorDestination);
            Controls.Add(pb_CalculatorFromSelection);
            Controls.Add(pb_CalculatorPeopleIcon);
            Controls.Add(pb_CalculatorBackground);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Calculator";
            Size = new System.Drawing.Size(1003, 169);
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorPeopleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorFromSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorDestination).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_BoardClass;
        private System.Windows.Forms.ComboBox cbb_NumberOfPassengers;
        private System.Windows.Forms.PictureBox pb_CalculatorPeopleIcon;
        private System.Windows.Forms.ComboBox cbb_TripType;
        private System.Windows.Forms.PictureBox pb_CalculatorFromSelection;
        private System.Windows.Forms.PictureBox pb_CalculatorDestination;
        private System.Windows.Forms.PictureBox pb_CalculatorArrow;
        private System.Windows.Forms.PictureBox pb_CalculatorBackground;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.DateTimePicker dtp_FlightDate;
        private System.Windows.Forms.Label lbl_TripType;
        private System.Windows.Forms.Label lbl_NumberOfPassenger;
        private System.Windows.Forms.Label lbl_BoardClass;
        public System.Windows.Forms.ComboBox cbb_From;
        public System.Windows.Forms.ComboBox cbb_Destination;
        private System.Windows.Forms.DateTimePicker dtp_ReturnDate;
        private System.Windows.Forms.Label lbl_FlightDate;
        private System.Windows.Forms.Label lbl_ReturnDate;
    }
}
