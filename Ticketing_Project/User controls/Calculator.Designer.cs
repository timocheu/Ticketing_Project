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
            cb_BoardClass = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorPeopleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorFromSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorDestination).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorBackground).BeginInit();
            SuspendLayout();
            // 
            // cb_BoardClass
            // 
            cb_BoardClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_BoardClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cb_BoardClass.FormattingEnabled = true;
            cb_BoardClass.Items.AddRange(new object[] { "Economy", "Business Class" });
            cb_BoardClass.Location = new System.Drawing.Point(291, 74);
            cb_BoardClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cb_BoardClass.Name = "cb_BoardClass";
            cb_BoardClass.Size = new System.Drawing.Size(113, 23);
            cb_BoardClass.TabIndex = 2;
            // 
            // cbb_NumberOfPassengers
            // 
            cbb_NumberOfPassengers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_NumberOfPassengers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbb_NumberOfPassengers.FormattingEnabled = true;
            cbb_NumberOfPassengers.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbb_NumberOfPassengers.Location = new System.Drawing.Point(149, 74);
            cbb_NumberOfPassengers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_NumberOfPassengers.Name = "cbb_NumberOfPassengers";
            cbb_NumberOfPassengers.Size = new System.Drawing.Size(133, 23);
            cbb_NumberOfPassengers.TabIndex = 3;
            // 
            // pb_CalculatorPeopleIcon
            // 
            pb_CalculatorPeopleIcon.BackColor = System.Drawing.Color.White;
            pb_CalculatorPeopleIcon.Image = Properties.Resources.ic_baseline_people;
            pb_CalculatorPeopleIcon.Location = new System.Drawing.Point(131, 75);
            pb_CalculatorPeopleIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorPeopleIcon.Name = "pb_CalculatorPeopleIcon";
            pb_CalculatorPeopleIcon.Size = new System.Drawing.Size(15, 13);
            pb_CalculatorPeopleIcon.TabIndex = 4;
            pb_CalculatorPeopleIcon.TabStop = false;
            // 
            // cbb_TripType
            // 
            cbb_TripType.BackColor = System.Drawing.Color.White;
            cbb_TripType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_TripType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbb_TripType.FormattingEnabled = true;
            cbb_TripType.Items.AddRange(new object[] { "One Way", "Round Trip" });
            cbb_TripType.Location = new System.Drawing.Point(27, 74);
            cbb_TripType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_TripType.Name = "cbb_TripType";
            cbb_TripType.Size = new System.Drawing.Size(98, 23);
            cbb_TripType.TabIndex = 5;
            // 
            // pb_CalculatorFromSelection
            // 
            pb_CalculatorFromSelection.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorFromSelection.Image = Properties.Resources.from_box;
            pb_CalculatorFromSelection.Location = new System.Drawing.Point(25, 101);
            pb_CalculatorFromSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorFromSelection.Name = "pb_CalculatorFromSelection";
            pb_CalculatorFromSelection.Size = new System.Drawing.Size(310, 52);
            pb_CalculatorFromSelection.TabIndex = 6;
            pb_CalculatorFromSelection.TabStop = false;
            // 
            // pb_CalculatorDestination
            // 
            pb_CalculatorDestination.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorDestination.Image = Properties.Resources.from_box;
            pb_CalculatorDestination.Location = new System.Drawing.Point(394, 101);
            pb_CalculatorDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorDestination.Name = "pb_CalculatorDestination";
            pb_CalculatorDestination.Size = new System.Drawing.Size(314, 52);
            pb_CalculatorDestination.TabIndex = 7;
            pb_CalculatorDestination.TabStop = false;
            // 
            // pb_CalculatorArrow
            // 
            pb_CalculatorArrow.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorArrow.Image = Properties.Resources.typcn_arrow_up_outline;
            pb_CalculatorArrow.Location = new System.Drawing.Point(355, 113);
            pb_CalculatorArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_CalculatorArrow.Name = "pb_CalculatorArrow";
            pb_CalculatorArrow.Size = new System.Drawing.Size(24, 26);
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
            btn_Calculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Calculate.ForeColor = System.Drawing.Color.White;
            btn_Calculate.Location = new System.Drawing.Point(852, 101);
            btn_Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new System.Drawing.Size(125, 50);
            btn_Calculate.TabIndex = 11;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = false;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // dtp_FlightDate
            // 
            dtp_FlightDate.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dtp_FlightDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtp_FlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_FlightDate.Location = new System.Drawing.Point(720, 113);
            dtp_FlightDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtp_FlightDate.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            dtp_FlightDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            dtp_FlightDate.Name = "dtp_FlightDate";
            dtp_FlightDate.Size = new System.Drawing.Size(123, 32);
            dtp_FlightDate.TabIndex = 12;
            // 
            // cbb_From
            // 
            cbb_From.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbb_From.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbb_From.BackColor = System.Drawing.Color.White;
            cbb_From.CausesValidation = false;
            cbb_From.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbb_From.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbb_From.FormattingEnabled = true;
            cbb_From.IntegralHeight = false;
            cbb_From.ItemHeight = 28;
            cbb_From.Location = new System.Drawing.Point(32, 108);
            cbb_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new System.Drawing.Size(299, 36);
            cbb_From.TabIndex = 15;
            cbb_From.TabStop = false;
            // 
            // cbb_Destination
            // 
            cbb_Destination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            cbb_Destination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbb_Destination.BackColor = System.Drawing.Color.White;
            cbb_Destination.CausesValidation = false;
            cbb_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbb_Destination.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbb_Destination.FormattingEnabled = true;
            cbb_Destination.IntegralHeight = false;
            cbb_Destination.Location = new System.Drawing.Point(407, 108);
            cbb_Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbb_Destination.Name = "cbb_Destination";
            cbb_Destination.Size = new System.Drawing.Size(289, 36);
            cbb_Destination.TabIndex = 16;
            cbb_Destination.TabStop = false;
            // 
            // lbl_TripType
            // 
            lbl_TripType.AutoSize = true;
            lbl_TripType.BackColor = System.Drawing.Color.White;
            lbl_TripType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripType.Location = new System.Drawing.Point(30, 53);
            lbl_TripType.Name = "lbl_TripType";
            lbl_TripType.Size = new System.Drawing.Size(69, 20);
            lbl_TripType.TabIndex = 17;
            lbl_TripType.Text = "Trip Type";
            // 
            // lbl_NumberOfPassenger
            // 
            lbl_NumberOfPassenger.AutoSize = true;
            lbl_NumberOfPassenger.BackColor = System.Drawing.Color.White;
            lbl_NumberOfPassenger.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_NumberOfPassenger.Location = new System.Drawing.Point(149, 53);
            lbl_NumberOfPassenger.Name = "lbl_NumberOfPassenger";
            lbl_NumberOfPassenger.Size = new System.Drawing.Size(93, 20);
            lbl_NumberOfPassenger.TabIndex = 18;
            lbl_NumberOfPassenger.Text = "# Passengers";
            // 
            // lbl_BoardClass
            // 
            lbl_BoardClass.AutoSize = true;
            lbl_BoardClass.BackColor = System.Drawing.Color.White;
            lbl_BoardClass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_BoardClass.Location = new System.Drawing.Point(291, 53);
            lbl_BoardClass.Name = "lbl_BoardClass";
            lbl_BoardClass.Size = new System.Drawing.Size(86, 20);
            lbl_BoardClass.TabIndex = 19;
            lbl_BoardClass.Text = "Board Class";
            // 
            // Calculator
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(lbl_BoardClass);
            Controls.Add(lbl_NumberOfPassenger);
            Controls.Add(lbl_TripType);
            Controls.Add(cbb_Destination);
            Controls.Add(cbb_From);
            Controls.Add(dtp_FlightDate);
            Controls.Add(btn_Calculate);
            Controls.Add(pb_CalculatorArrow);
            Controls.Add(pb_CalculatorDestination);
            Controls.Add(pb_CalculatorFromSelection);
            Controls.Add(cbb_TripType);
            Controls.Add(pb_CalculatorPeopleIcon);
            Controls.Add(cbb_NumberOfPassengers);
            Controls.Add(cb_BoardClass);
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
        private System.Windows.Forms.ComboBox cb_BoardClass;
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
    }
}
