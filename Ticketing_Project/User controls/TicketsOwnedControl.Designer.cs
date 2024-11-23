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
            SuspendLayout();
            // 
            // flow_TicketsOwned
            // 
            flow_TicketsOwned.AutoScroll = true;
            flow_TicketsOwned.BackColor = System.Drawing.Color.White;
            flow_TicketsOwned.Location = new System.Drawing.Point(135, 83);
            flow_TicketsOwned.Name = "flow_TicketsOwned";
            flow_TicketsOwned.Size = new System.Drawing.Size(738, 566);
            flow_TicketsOwned.TabIndex = 0;
            // 
            // TicketsOwnedControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = Properties.Resources.FlightDealsBackground;
            Controls.Add(flow_TicketsOwned);
            Name = "TicketsOwnedControl";
            Size = new System.Drawing.Size(989, 649);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_TicketsOwned;
    }
}
