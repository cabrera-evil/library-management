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
            cmbFilter.DataSource = categoryFilters;
            cmbFilter2.DataSource = searchingFormat; 
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            // Information display
            label1.Visible = true; 
            label2.Visible = true;

            // Searching parameters
            if (cmbFilter2.SelectedIndex == 0) 
            {
                if (cmbFilter.SelectedIndex == 0) // Search by Title
                    MessageBox.Show("Search by title");
                else if (cmbFilter.SelectedIndex == 1) // Search by Key Words
                    MessageBox.Show("Search by key words");
                else if (cmbFilter.SelectedIndex == 2) // Search by Author
                    MessageBox.Show("Search by author");
                else if (cmbFilter.SelectedIndex == 3) // Search by Format
                    MessageBox.Show("Search by format");
            }
            else if (cmbFilter2.SelectedIndex == 1) 
            {
                if (cmbFilter.SelectedIndex == 0) // Search by Title
                    MessageBox.Show("Search by title");
                else if (cmbFilter.SelectedIndex == 1) // Search by Key Words
                    MessageBox.Show("Search by key words");
                else if (cmbFilter.SelectedIndex == 2) // Search by Author
                    MessageBox.Show("Search by author");
                else if (cmbFilter.SelectedIndex == 3) // Search by Format
                    MessageBox.Show("Search by format");
            }            
        }
    }
}
