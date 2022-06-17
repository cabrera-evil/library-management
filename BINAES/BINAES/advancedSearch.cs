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
    public partial class frmAdvancedSearch : Form
    {
        public string title;
        public string someWords;
        public string keyWords;
        public string author;
        public bool both;
        public bool digital; 

        public frmAdvancedSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.title = txtTitle.Text; 
            this.someWords = txtSomeWords.Text;
            this.keyWords = txtKeyWords.Text;
            this.author = txtAuthor.Text;
            this.both = rdbBoth.Checked;
            this.digital = rdbDigital.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
