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
            txt_CalculatorFrom = new System.Windows.Forms.TextBox();
            txt_CalculatorDestination = new System.Windows.Forms.TextBox();
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
            cb_BoardClass.Location = new System.Drawing.Point(338, 55);
            cb_BoardClass.Name = "cb_BoardClass";
            cb_BoardClass.Size = new System.Drawing.Size(129, 28);
            cb_BoardClass.TabIndex = 2;
            cb_BoardClass.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbb_NumberOfPassengers
            // 
            cbb_NumberOfPassengers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_NumberOfPassengers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbb_NumberOfPassengers.FormattingEnabled = true;
            cbb_NumberOfPassengers.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbb_NumberOfPassengers.Location = new System.Drawing.Point(176, 55);
            cbb_NumberOfPassengers.Name = "cbb_NumberOfPassengers";
            cbb_NumberOfPassengers.Size = new System.Drawing.Size(151, 28);
            cbb_NumberOfPassengers.TabIndex = 3;
            // 
            // pb_CalculatorPeopleIcon
            // 
            pb_CalculatorPeopleIcon.BackColor = System.Drawing.Color.White;
            pb_CalculatorPeopleIcon.Image = Properties.Resources.ic_baseline_people;
            pb_CalculatorPeopleIcon.Location = new System.Drawing.Point(155, 60);
            pb_CalculatorPeopleIcon.Name = "pb_CalculatorPeopleIcon";
            pb_CalculatorPeopleIcon.Size = new System.Drawing.Size(17, 17);
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
            cbb_TripType.Location = new System.Drawing.Point(37, 55);
            cbb_TripType.Name = "cbb_TripType";
            cbb_TripType.Size = new System.Drawing.Size(112, 28);
            cbb_TripType.TabIndex = 5;
            cbb_TripType.SelectedIndexChanged += cb_CalculatorWay_SelectedIndexChanged;
            // 
            // pb_CalculatorFromSelection
            // 
            pb_CalculatorFromSelection.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorFromSelection.Image = Properties.Resources.From_Selection;
            pb_CalculatorFromSelection.Location = new System.Drawing.Point(34, 90);
            pb_CalculatorFromSelection.Name = "pb_CalculatorFromSelection";
            pb_CalculatorFromSelection.Size = new System.Drawing.Size(310, 50);
            pb_CalculatorFromSelection.TabIndex = 6;
            pb_CalculatorFromSelection.TabStop = false;
            // 
            // pb_CalculatorDestination
            // 
            pb_CalculatorDestination.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorDestination.Image = Properties.Resources.From_Selection;
            pb_CalculatorDestination.Location = new System.Drawing.Point(383, 90);
            pb_CalculatorDestination.Name = "pb_CalculatorDestination";
            pb_CalculatorDestination.Size = new System.Drawing.Size(310, 50);
            pb_CalculatorDestination.TabIndex = 7;
            pb_CalculatorDestination.TabStop = false;
            // 
            // pb_CalculatorArrow
            // 
            pb_CalculatorArrow.BackColor = System.Drawing.SystemColors.Window;
            pb_CalculatorArrow.Image = Properties.Resources.typcn_arrow_up_outline;
            pb_CalculatorArrow.Location = new System.Drawing.Point(351, 106);
            pb_CalculatorArrow.Name = "pb_CalculatorArrow";
            pb_CalculatorArrow.Size = new System.Drawing.Size(24, 24);
            pb_CalculatorArrow.TabIndex = 8;
            pb_CalculatorArrow.TabStop = false;
            // 
            // pb_CalculatorBackground
            // 
            pb_CalculatorBackground.Image = Properties.Resources.Flight_Calculator1;
            pb_CalculatorBackground.Location = new System.Drawing.Point(9, 16);
            pb_CalculatorBackground.Name = "pb_CalculatorBackground";
            pb_CalculatorBackground.Size = new System.Drawing.Size(983, 163);
            pb_CalculatorBackground.TabIndex = 10;
            pb_CalculatorBackground.TabStop = false;
            pb_CalculatorBackground.Click += pb_CalculatorBackground_Click_1;
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
            btn_Calculate.Location = new System.Drawing.Point(848, 88);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new System.Drawing.Size(125, 50);
            btn_Calculate.TabIndex = 11;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = false;
            // 
            // dtp_FlightDate
            // 
            dtp_FlightDate.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dtp_FlightDate.Enabled = false;
            dtp_FlightDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtp_FlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_FlightDate.Location = new System.Drawing.Point(702, 97);
            dtp_FlightDate.Name = "dtp_FlightDate";
            dtp_FlightDate.Size = new System.Drawing.Size(140, 38);
            dtp_FlightDate.TabIndex = 12;
            // 
            // txt_CalculatorFrom
            // 
            txt_CalculatorFrom.BackColor = System.Drawing.SystemColors.Window;
            txt_CalculatorFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_CalculatorFrom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_CalculatorFrom.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            txt_CalculatorFrom.Location = new System.Drawing.Point(47, 95);
            txt_CalculatorFrom.Name = "txt_CalculatorFrom";
            txt_CalculatorFrom.ReadOnly = true;
            txt_CalculatorFrom.Size = new System.Drawing.Size(56, 19);
            txt_CalculatorFrom.TabIndex = 13;
            txt_CalculatorFrom.Text = "From";
            // 
            // txt_CalculatorDestination
            // 
            txt_CalculatorDestination.BackColor = System.Drawing.SystemColors.Window;
            txt_CalculatorDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_CalculatorDestination.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_CalculatorDestination.ForeColor = System.Drawing.Color.FromArgb(176, 176, 176);
            txt_CalculatorDestination.Location = new System.Drawing.Point(396, 96);
            txt_CalculatorDestination.Name = "txt_CalculatorDestination";
            txt_CalculatorDestination.ReadOnly = true;
            txt_CalculatorDestination.Size = new System.Drawing.Size(56, 19);
            txt_CalculatorDestination.TabIndex = 14;
            txt_CalculatorDestination.Text = "To";
            // 
            // cbb_From
            // 
            cbb_From.BackColor = System.Drawing.Color.White;
            cbb_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_From.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbb_From.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbb_From.FormattingEnabled = true;
            cbb_From.Location = new System.Drawing.Point(47, 94);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new System.Drawing.Size(290, 43);
            cbb_From.TabIndex = 15;
            // 
            // cbb_Destination
            // 
            cbb_Destination.BackColor = System.Drawing.Color.White;
            cbb_Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbb_Destination.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbb_Destination.FormattingEnabled = true;
            cbb_Destination.Location = new System.Drawing.Point(394, 93);
            cbb_Destination.Name = "cbb_Destination";
            cbb_Destination.Size = new System.Drawing.Size(290, 43);
            cbb_Destination.TabIndex = 16;
            // 
            // lbl_TripType
            // 
            lbl_TripType.AutoSize = true;
            lbl_TripType.BackColor = System.Drawing.Color.White;
            lbl_TripType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TripType.Location = new System.Drawing.Point(40, 26);
            lbl_TripType.Name = "lbl_TripType";
            lbl_TripType.Size = new System.Drawing.Size(82, 25);
            lbl_TripType.TabIndex = 17;
            lbl_TripType.Text = "Trip Type";
            // 
            // lbl_NumberOfPassenger
            // 
            lbl_NumberOfPassenger.AutoSize = true;
            lbl_NumberOfPassenger.BackColor = System.Drawing.Color.White;
            lbl_NumberOfPassenger.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_NumberOfPassenger.Location = new System.Drawing.Point(176, 27);
            lbl_NumberOfPassenger.Name = "lbl_NumberOfPassenger";
            lbl_NumberOfPassenger.Size = new System.Drawing.Size(115, 25);
            lbl_NumberOfPassenger.TabIndex = 18;
            lbl_NumberOfPassenger.Text = "# Passengers";
            // 
            // lbl_BoardClass
            // 
            lbl_BoardClass.AutoSize = true;
            lbl_BoardClass.BackColor = System.Drawing.Color.White;
            lbl_BoardClass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_BoardClass.Location = new System.Drawing.Point(341, 28);
            lbl_BoardClass.Name = "lbl_BoardClass";
            lbl_BoardClass.Size = new System.Drawing.Size(104, 25);
            lbl_BoardClass.TabIndex = 19;
            lbl_BoardClass.Text = "Board Class";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(lbl_BoardClass);
            Controls.Add(lbl_NumberOfPassenger);
            Controls.Add(lbl_TripType);
            Controls.Add(cbb_Destination);
            Controls.Add(cbb_From);
            Controls.Add(txt_CalculatorDestination);
            Controls.Add(txt_CalculatorFrom);
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
            Name = "Calculator";
            Size = new System.Drawing.Size(1000, 183);
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorPeopleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorFromSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorDestination).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CalculatorBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pb_CalculatorClass;
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
        private System.Windows.Forms.TextBox txt_CalculatorFrom;
        private System.Windows.Forms.TextBox txt_CalculatorDestination;
        private System.Windows.Forms.ComboBox cbb_From;
        private System.Windows.Forms.ComboBox cbb_Destination;
        private System.Windows.Forms.Label lbl_TripType;
        private System.Windows.Forms.Label lbl_NumberOfPassenger;
        private System.Windows.Forms.Label lbl_BoardClass;
    }
}
