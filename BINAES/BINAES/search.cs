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
    }
}
