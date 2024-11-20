namespace Ticketing_Project.User_controls
{
    partial class TicketTemplate
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
            lbl_BrandName = new System.Windows.Forms.Label();
            lbl_BoardingPass = new System.Windows.Forms.Label();
            lbl_BoardingClassBig = new System.Windows.Forms.Label();
            tbl_BoardingPassBig = new System.Windows.Forms.TableLayoutPanel();
            tbl_BoardingPassSmall = new System.Windows.Forms.TableLayoutPanel();
            lbl_BoardingPassSmall = new System.Windows.Forms.Label();
            lbl_BoardingClassSmall = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tbl_BoardingPassBig.SuspendLayout();
            tbl_BoardingPassSmall.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_BrandName
            // 
            lbl_BrandName.AutoSize = true;
            lbl_BrandName.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            lbl_BrandName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_BrandName.ForeColor = System.Drawing.Color.White;
            lbl_BrandName.Location = new System.Drawing.Point(23, 18);
            lbl_BrandName.Name = "lbl_BrandName";
            lbl_BrandName.Size = new System.Drawing.Size(219, 37);
            lbl_BrandName.TabIndex = 0;
            lbl_BrandName.Text = "CLOUD EXPRESS";
            // 
            // lbl_BoardingPass
            // 
            lbl_BoardingPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_BoardingPass.AutoSize = true;
            lbl_BoardingPass.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            lbl_BoardingPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_BoardingPass.ForeColor = System.Drawing.Color.White;
            lbl_BoardingPass.Location = new System.Drawing.Point(6, 0);
            lbl_BoardingPass.Name = "lbl_BoardingPass";
            lbl_BoardingPass.Size = new System.Drawing.Size(142, 30);
            lbl_BoardingPass.TabIndex = 1;
            lbl_BoardingPass.Text = "Boarding Pass";
            // 
            // lbl_BoardingClassBig
            // 
            lbl_BoardingClassBig.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_BoardingClassBig.AutoSize = true;
            lbl_BoardingClassBig.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            lbl_BoardingClassBig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_BoardingClassBig.ForeColor = System.Drawing.Color.White;
            lbl_BoardingClassBig.Location = new System.Drawing.Point(36, 39);
            lbl_BoardingClassBig.Name = "lbl_BoardingClassBig";
            lbl_BoardingClassBig.Size = new System.Drawing.Size(112, 21);
            lbl_BoardingClassBig.TabIndex = 2;
            lbl_BoardingClassBig.Text = "<BoardClass>";
            // 
            // tbl_BoardingPassBig
            // 
            tbl_BoardingPassBig.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            tbl_BoardingPassBig.ColumnCount = 1;
            tbl_BoardingPassBig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tbl_BoardingPassBig.Controls.Add(lbl_BoardingPass, 0, 0);
            tbl_BoardingPassBig.Controls.Add(lbl_BoardingClassBig, 0, 1);
            tbl_BoardingPassBig.Location = new System.Drawing.Point(362, 10);
            tbl_BoardingPassBig.Name = "tbl_BoardingPassBig";
            tbl_BoardingPassBig.RowCount = 2;
            tbl_BoardingPassBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tbl_BoardingPassBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tbl_BoardingPassBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tbl_BoardingPassBig.Size = new System.Drawing.Size(151, 60);
            tbl_BoardingPassBig.TabIndex = 3;
            // 
            // tbl_BoardingPassSmall
            // 
            tbl_BoardingPassSmall.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            tbl_BoardingPassSmall.ColumnCount = 1;
            tbl_BoardingPassSmall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tbl_BoardingPassSmall.Controls.Add(lbl_BoardingPassSmall, 0, 0);
            tbl_BoardingPassSmall.Controls.Add(lbl_BoardingClassSmall, 0, 1);
            tbl_BoardingPassSmall.Location = new System.Drawing.Point(559, 10);
            tbl_BoardingPassSmall.Name = "tbl_BoardingPassSmall";
            tbl_BoardingPassSmall.RowCount = 2;
            tbl_BoardingPassSmall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tbl_BoardingPassSmall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tbl_BoardingPassSmall.Size = new System.Drawing.Size(170, 59);
            tbl_BoardingPassSmall.TabIndex = 4;
            // 
            // lbl_BoardingPassSmall
            // 
            lbl_BoardingPassSmall.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_BoardingPassSmall.AutoSize = true;
            lbl_BoardingPassSmall.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            lbl_BoardingPassSmall.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_BoardingPassSmall.ForeColor = System.Drawing.Color.White;
            lbl_BoardingPassSmall.Location = new System.Drawing.Point(25, 0);
            lbl_BoardingPassSmall.Name = "lbl_BoardingPassSmall";
            lbl_BoardingPassSmall.Size = new System.Drawing.Size(142, 29);
            lbl_BoardingPassSmall.TabIndex = 1;
            lbl_BoardingPassSmall.Text = "Boarding Pass";
            // 
            // lbl_BoardingClassSmall
            // 
            lbl_BoardingClassSmall.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lbl_BoardingClassSmall.AutoSize = true;
            lbl_BoardingClassSmall.BackColor = System.Drawing.Color.FromArgb(0, 119, 182);
            lbl_BoardingClassSmall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_BoardingClassSmall.ForeColor = System.Drawing.Color.White;
            lbl_BoardingClassSmall.Location = new System.Drawing.Point(55, 38);
            lbl_BoardingClassSmall.Name = "lbl_BoardingClassSmall";
            lbl_BoardingClassSmall.Size = new System.Drawing.Size(112, 21);
            lbl_BoardingClassSmall.TabIndex = 2;
            lbl_BoardingClassSmall.Text = "<BoardClass>";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.94801F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.0519886F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanel1.Location = new System.Drawing.Point(23, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.935482F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.064518F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(477, 190);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // TicketTemplate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = Properties.Resources.Ticket_Template_Background;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tbl_BoardingPassSmall);
            Controls.Add(tbl_BoardingPassBig);
            Controls.Add(lbl_BrandName);
            DoubleBuffered = true;
            Name = "TicketTemplate";
            Size = new System.Drawing.Size(737, 309);
            tbl_BoardingPassBig.ResumeLayout(false);
            tbl_BoardingPassBig.PerformLayout();
            tbl_BoardingPassSmall.ResumeLayout(false);
            tbl_BoardingPassSmall.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_BrandName;
        private System.Windows.Forms.Label lbl_BoardingPass;
        private System.Windows.Forms.Label lbl_BoardingClassBig;
        private System.Windows.Forms.TableLayoutPanel tbl_BoardingPassBig;
        private System.Windows.Forms.TableLayoutPanel tbl_BoardingPassSmall;
        private System.Windows.Forms.Label lbl_BoardingPassSmall;
        private System.Windows.Forms.Label lbl_BoardingClassSmall;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
