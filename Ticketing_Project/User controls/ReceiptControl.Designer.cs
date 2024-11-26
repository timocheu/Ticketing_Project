namespace Ticketing_Project.User_controls
{
    partial class ReceiptControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv_Receipts = new System.Windows.Forms.DataGridView();
            ReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TripType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Passengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Receipts).BeginInit();
            SuspendLayout();
            // 
            // dgv_Receipts
            // 
            dgv_Receipts.AllowUserToAddRows = false;
            dgv_Receipts.AllowUserToDeleteRows = false;
            dgv_Receipts.AllowUserToOrderColumns = true;
            dgv_Receipts.AllowUserToResizeColumns = false;
            dgv_Receipts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv_Receipts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Receipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Receipts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Receipts.BackgroundColor = System.Drawing.Color.White;
            dgv_Receipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_Receipts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgv_Receipts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_Receipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Receipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Receipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ReceiptID, CreationDate, Email, PaymentMethod, TripType, Passengers, Total });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv_Receipts.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Receipts.GridColor = System.Drawing.Color.Black;
            dgv_Receipts.Location = new System.Drawing.Point(30, 28);
            dgv_Receipts.Name = "dgv_Receipts";
            dgv_Receipts.ReadOnly = true;
            dgv_Receipts.RowHeadersVisible = false;
            dgv_Receipts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Receipts.RowTemplate.Height = 25;
            dgv_Receipts.Size = new System.Drawing.Size(989, 637);
            dgv_Receipts.TabIndex = 0;
            dgv_Receipts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ReceiptID
            // 
            ReceiptID.HeaderText = "Receipt ID";
            ReceiptID.Name = "ReceiptID";
            ReceiptID.ReadOnly = true;
            // 
            // CreationDate
            // 
            CreationDate.HeaderText = "Creation Date";
            CreationDate.Name = "CreationDate";
            CreationDate.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            PaymentMethod.HeaderText = "Payment Method";
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.ReadOnly = true;
            // 
            // TripType
            // 
            TripType.HeaderText = "Trip Type";
            TripType.Name = "TripType";
            TripType.ReadOnly = true;
            // 
            // Passengers
            // 
            Passengers.HeaderText = "No. of Tickets";
            Passengers.Name = "Passengers";
            Passengers.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // ReceiptControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(dgv_Receipts);
            Name = "ReceiptControl";
            Size = new System.Drawing.Size(1050, 668);
            Load += ReceiptControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Receipts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_Receipts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passengers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
