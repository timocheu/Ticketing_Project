using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_Project.User_controls
{
    public partial class ReceiptControl : UserControl
    {
        public ReceiptControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReceiptControl_Load(object sender, EventArgs e)
        {
            dgv_Receipts.Rows.Add(1, "Tim", "Test");
        }
    }
}
