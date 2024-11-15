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
            calculator1 = new Calculator();
            pb_DealsBackground = new System.Windows.Forms.PictureBox();
            flow_Deals = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pb_DealsBackground).BeginInit();
            SuspendLayout();
            // 
            // calculator1
            // 
            calculator1.BackColor = System.Drawing.Color.Transparent;
            calculator1.Location = new System.Drawing.Point(25, 19);
            calculator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            calculator1.Name = "calculator1";
            calculator1.Size = new System.Drawing.Size(1003, 178);
            calculator1.TabIndex = 0;
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
            flow_Deals.AutoScroll = true;
            flow_Deals.BackColor = System.Drawing.Color.White;
            flow_Deals.Location = new System.Drawing.Point(72, 280);
            flow_Deals.Name = "flow_Deals";
            flow_Deals.Size = new System.Drawing.Size(916, 400);
            flow_Deals.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(444, 227);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(168, 37);
            label1.TabIndex = 3;
            label1.Text = "Flight Deals";
            // 
            // CalculatorAndFlightDeals
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(label1);
            Controls.Add(flow_Deals);
            Controls.Add(pb_DealsBackground);
            Controls.Add(calculator1);
            Name = "CalculatorAndFlightDeals";
            Size = new System.Drawing.Size(1050, 656);
            ((System.ComponentModel.ISupportInitialize)pb_DealsBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Calculator calculator1;
        private System.Windows.Forms.PictureBox pb_DealsBackground;
        private System.Windows.Forms.FlowLayoutPanel flow_Deals;
        private System.Windows.Forms.Label label1;
    }
}
