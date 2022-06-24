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
            // abrir formulario para prestar
            Form loans = new frm_loans();
            loans.Show();
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            // abrir formulario para reservar
            Form reservations = new frm_reservations();
            reservations.Show();
        }
    }
}
