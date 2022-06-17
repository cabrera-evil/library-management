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
    public partial class frmSearch : Form
    {
        // ComboBox Data Sources
        string[] categoryFilters = new string[] { "Title", "Key words", "Author", "Format" };
        string[] searchingFormat = new string[] { "Some words", "Full entence" };
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            //cmbFilter.DataSource = categoryFilters;
            //cmbFilter2.DataSource = searchingFormat; 
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {

                label1.Visible = false;
                label2.Visible = false;
                lblWarning.Visible = true;
            }
            else if (txtSearch.Text.Length > 0)
            {
                // Information display
                label1.Visible = true;
                label2.Visible = true;
                lblWarning.Visible = false;

                // Search default parameters
                // Both format: physical and digital
                // Search by some words
                // Not search by author
            } 
        }

        private void btnAdvancedTools_Click(object sender, EventArgs e)
        {
            using (frmAdvancedSearch window = new frmAdvancedSearch())
            {
                window.ShowDialog();
                // Depending on DialogResult we will create a specific query for it or execute a default search

            }
        }
    }
}