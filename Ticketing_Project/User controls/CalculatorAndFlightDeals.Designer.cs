namespace Ticketing_Project
{
    partial class CalculatorAndFlightDeals
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
            pb_DealsBackground = new System.Windows.Forms.PictureBox();
            flow_Deals = new System.Windows.Forms.FlowLayoutPanel();
            lbl_FlightDeals = new System.Windows.Forms.Label();
            btn_RefreshDeals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pb_DealsBackground).BeginInit();
            SuspendLayout();
            // 
            // pb_DealsBackground
            // 
            pb_DealsBackground.Image = Properties.Resources.FlightDealBackground;
            pb_DealsBackground.Location = new System.Drawing.Point(34, 202);
            pb_DealsBackground.Name = "pb_DealsBackground";
            pb_DealsBackground.Size = new System.Drawing.Size(994, 478);
            pb_DealsBackground.TabIndex = 1;
            pb_DealsBackground.TabStop = false;
            // 
            // flow_Deals
            // 
            flow_Deals.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            flow_Deals.AutoScroll = true;
            flow_Deals.BackColor = System.Drawing.Color.White;
            flow_Deals.Location = new System.Drawing.Point(54, 280);
            flow_Deals.Name = "flow_Deals";
            flow_Deals.Size = new System.Drawing.Size(949, 399);
            flow_Deals.TabIndex = 2;
            // 
            // lbl_FlightDeals
            // 
            lbl_FlightDeals.AutoSize = true;
            lbl_FlightDeals.BackColor = System.Drawing.Color.White;
            lbl_FlightDeals.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_FlightDeals.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_FlightDeals.Location = new System.Drawing.Point(444, 227);
            lbl_FlightDeals.Name = "lbl_FlightDeals";
            lbl_FlightDeals.Size = new System.Drawing.Size(182, 48);
            lbl_FlightDeals.TabIndex = 3;
            lbl_FlightDeals.Text = "Flight Deals";
            // 
            // btn_RefreshDeals
            // 
            btn_RefreshDeals.BackColor = System.Drawing.Color.White;
            btn_RefreshDeals.BackgroundImage = Properties.Resources.loading_arrow;
            btn_RefreshDeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_RefreshDeals.FlatAppearance.BorderSize = 0;
            btn_RefreshDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_RefreshDeals.Location = new System.Drawing.Point(953, 235);
            btn_RefreshDeals.Name = "btn_RefreshDeals";
            btn_RefreshDeals.Size = new System.Drawing.Size(35, 35);
            btn_RefreshDeals.TabIndex = 4;
            btn_RefreshDeals.UseVisualStyleBackColor = false;
            btn_RefreshDeals.Click += btn_RefreshDeals_Click;
            // 
            // CalculatorAndFlightDeals
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(btn_RefreshDeals);
            Controls.Add(lbl_FlightDeals);
            Controls.Add(flow_Deals);
            Controls.Add(pb_DealsBackground);
            Name = "CalculatorAndFlightDeals";
            Size = new System.Drawing.Size(1050, 679);
            ((System.ComponentModel.ISupportInitialize)pb_DealsBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pb_DealsBackground;
        private System.Windows.Forms.FlowLayoutPanel flow_Deals;
        private System.Windows.Forms.Label lbl_FlightDeals;
        private System.Windows.Forms.Button btn_RefreshDeals;
    }
}
