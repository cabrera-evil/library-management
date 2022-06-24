using System;
using System.Windows.Forms;

namespace BINAES.UserControls
{
    public partial class UC_Advanced_Search : UserControl
    {
        public bool full;
        public string title;
        public string someWords;
        public string keyWords;
        public string author;
        public bool both;
        public bool digital;
        
        public UC_Advanced_Search()
        {
            InitializeComponent();
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
        }
    }
}