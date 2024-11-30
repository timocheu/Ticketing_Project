namespace Ticketing_Project.User_controls
{
    partial class TicketsOwnedControl
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
            flow_TicketsOwned = new System.Windows.Forms.FlowLayoutPanel();
            lbl_PageTitle = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // flow_TicketsOwned
            // 
            flow_TicketsOwned.AutoScroll = true;
            flow_TicketsOwned.BackColor = System.Drawing.Color.FromArgb(234, 234, 234);
            flow_TicketsOwned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            flow_TicketsOwned.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flow_TicketsOwned.Location = new System.Drawing.Point(75, 73);
            flow_TicketsOwned.Name = "flow_TicketsOwned";
            flow_TicketsOwned.Size = new System.Drawing.Size(825, 576);
            flow_TicketsOwned.TabIndex = 0;
            flow_TicketsOwned.WrapContents = false;
            // 
            // lbl_PageTitle
            // 
            lbl_PageTitle.AutoSize = true;
            lbl_PageTitle.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_PageTitle.Location = new System.Drawing.Point(292, 14);
            lbl_PageTitle.Name = "lbl_PageTitle";
            lbl_PageTitle.Size = new System.Drawing.Size(394, 56);
            lbl_PageTitle.TabIndex = 1;
            lbl_PageTitle.Text = "Currently Owned Ticket";
            // 
            // TicketsOwnedControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = Properties.Resources.TicketsOwnedBackground;
            Controls.Add(flow_TicketsOwned);
            Controls.Add(lbl_PageTitle);
            Name = "TicketsOwnedControl";
            Size = new System.Drawing.Size(989, 649);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flow_TicketsOwned;
        private System.Windows.Forms.Label lbl_PageTitle;
    }
}
