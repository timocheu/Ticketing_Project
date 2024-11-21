namespace Ticketing_Project.User_controls
{
    partial class PassengerTextBox
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
            pb_InputPassengerBackground = new System.Windows.Forms.PictureBox();
            txt_Passenger = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pb_InputPassengerBackground).BeginInit();
            SuspendLayout();
            // 
            // pb_InputPassengerBackground
            // 
            pb_InputPassengerBackground.Image = Properties.Resources.InputPassengerBackground;
            pb_InputPassengerBackground.Location = new System.Drawing.Point(4, 5);
            pb_InputPassengerBackground.Name = "pb_InputPassengerBackground";
            pb_InputPassengerBackground.Size = new System.Drawing.Size(437, 55);
            pb_InputPassengerBackground.TabIndex = 0;
            pb_InputPassengerBackground.TabStop = false;
            // 
            // txt_Passenger
            // 
            txt_Passenger.BackColor = System.Drawing.Color.White;
            txt_Passenger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_Passenger.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Passenger.Location = new System.Drawing.Point(11, 16);
            txt_Passenger.MaxLength = 20;
            txt_Passenger.Name = "txt_Passenger";
            txt_Passenger.PlaceholderText = " Passenger";
            txt_Passenger.Size = new System.Drawing.Size(420, 28);
            txt_Passenger.TabIndex = 5;
            // 
            // PassengerTextBox
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(txt_Passenger);
            Controls.Add(pb_InputPassengerBackground);
            Name = "PassengerTextBox";
            Size = new System.Drawing.Size(442, 65);
            ((System.ComponentModel.ISupportInitialize)pb_InputPassengerBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pb_InputPassengerBackground;
        public System.Windows.Forms.TextBox txt_Passenger;
    }
}
