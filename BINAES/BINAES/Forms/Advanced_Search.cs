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
    public partial class frm_advanced_search : Form
    {
        public bool full; 
        public string title;
        public string someWords;
        public string keyWords;
        public string author;
        public bool both;
        public bool digital;
        public frm_advanced_search()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); 
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.full = rdb_full.Checked; 
            this.title = txt_title.Text;
            this.someWords = txt_some_words.Text;
            this.keyWords = txt_key_words.Text;
            this.author = txt_author.Text;
            this.both = rdb_both.Checked;
            this.digital = rdb_digital.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
