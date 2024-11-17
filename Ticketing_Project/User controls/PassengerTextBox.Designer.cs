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
            lbl_Passenger = new System.Windows.Forms.TextBox();
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
            // lbl_Passenger
            // 
            lbl_Passenger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lbl_Passenger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Passenger.Location = new System.Drawing.Point(11, 19);
            lbl_Passenger.Name = "lbl_Passenger";
            lbl_Passenger.PlaceholderText = " Passenger";
            lbl_Passenger.Size = new System.Drawing.Size(420, 25);
            lbl_Passenger.TabIndex = 5;
            // 
            // PassengerTextBox
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(lbl_Passenger);
            Controls.Add(pb_InputPassengerBackground);
            Name = "PassengerTextBox";
            Size = new System.Drawing.Size(442, 65);
            ((System.ComponentModel.ISupportInitialize)pb_InputPassengerBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pb_InputPassengerBackground;
        private System.Windows.Forms.TextBox lbl_Passenger;
    }
}
