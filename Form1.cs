using System;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_To_Order_frm_Click(object sender, EventArgs e)
        {
            Form frmOrder = new frm_Order();
            frmOrder.ShowDialog();
        }
    }
}
