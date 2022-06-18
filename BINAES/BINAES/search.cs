using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES
{
    public partial class frm_search : Form
    {
        public frm_search()
        {
            InitializeComponent();
        }

        private void btn_advanced_tools_Click(object sender, EventArgs e)
        {
            using (frm_advanced_search window = new frm_advanced_search())
            {
                window.ShowDialog();
            }
        }

        private void btn_search1_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length == 0)
            {
                label1.Visible = false;
                lbl_counter.Visible = false;
                lbl_warning.Visible = true;
            }
            else if (txt_search.Text.Length > 0) 
            {
                lbl_warning.Visible = false;
                label1.Visible = true;
                lbl_counter.Visible = true; 
            }
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are looking wether your selection is available or not"); 
            // Search in the Data Base whther it is available or not
            // If so, open the Borrowing module. If not, tell the user
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            // Open module for booking
        }
    }
}
