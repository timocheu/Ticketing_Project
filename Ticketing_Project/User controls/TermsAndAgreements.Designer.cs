namespace Ticketing_Project.User_controls
{
    partial class TermsAndAgreements
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
            btn_ConfirmBooking = new System.Windows.Forms.Button();
            btn_Cancel = new System.Windows.Forms.Button();
            lbl_TermsAndAgreements = new System.Windows.Forms.Label();
            lbl_Description = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_ConfirmBooking
            // 
            btn_ConfirmBooking.BackColor = System.Drawing.Color.FromArgb(0, 113, 188);
            btn_ConfirmBooking.BackgroundImage = Properties.Resources.BorderBackgroundRemoved;
            btn_ConfirmBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_ConfirmBooking.FlatAppearance.BorderSize = 0;
            btn_ConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ConfirmBooking.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_ConfirmBooking.ForeColor = System.Drawing.Color.White;
            btn_ConfirmBooking.Image = Properties.Resources.PaymentBoxRemovedBackground;
            btn_ConfirmBooking.Location = new System.Drawing.Point(311, 189);
            btn_ConfirmBooking.Name = "btn_ConfirmBooking";
            btn_ConfirmBooking.Size = new System.Drawing.Size(152, 43);
            btn_ConfirmBooking.TabIndex = 15;
            btn_ConfirmBooking.Text = "Confirm Booking";
            btn_ConfirmBooking.UseVisualStyleBackColor = false;
            btn_ConfirmBooking.Click += btn_ConfirmBooking_Click;
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
            btn_Cancel.Location = new System.Drawing.Point(141, 189);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(152, 43);
            btn_Cancel.TabIndex = 16;
            btn_Cancel.Text = "Return";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // lbl_TermsAndAgreements
            // 
            lbl_TermsAndAgreements.AutoSize = true;
            lbl_TermsAndAgreements.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TermsAndAgreements.Location = new System.Drawing.Point(38, 38);
            lbl_TermsAndAgreements.Name = "lbl_TermsAndAgreements";
            lbl_TermsAndAgreements.Size = new System.Drawing.Size(255, 36);
            lbl_TermsAndAgreements.TabIndex = 17;
            lbl_TermsAndAgreements.Text = "Terms and agreements";
            // 
            // lbl_Description
            // 
            lbl_Description.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Description.Location = new System.Drawing.Point(38, 83);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new System.Drawing.Size(528, 90);
            lbl_Description.TabIndex = 18;
            lbl_Description.Text = "By submitting payment, you confirm that the details provided are accurate and complete. You agree to pay the amount due in full, including any applicable taxes, fees, and charges.\r\n";
            // 
            // TermsAndAgreements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = Properties.Resources.RectangleTermsAndAgreements;
            Controls.Add(lbl_Description);
            Controls.Add(lbl_TermsAndAgreements);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_ConfirmBooking);
            Name = "TermsAndAgreements";
            Size = new System.Drawing.Size(614, 258);
            Load += TermsAndAgreements_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_ConfirmBooking;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_TermsAndAgreements;
        private System.Windows.Forms.Label lbl_Description;
    }
}
