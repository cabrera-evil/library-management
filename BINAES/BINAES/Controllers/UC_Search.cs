using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BINAES.Clases;
using BINAES.SQL_Server;
using BINAES.UserControls;

namespace BINAES.UserControls
{
    public partial class UC_Search : UserControl
    {
        public static int copy_selected; // Este se puede utilizar como referencia para buscar libros en otros user control
        public bool select;
        public UC_Search()
        {
            InitializeComponent();

            // Initial settings
            this.dgv_search_result.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            this.btn_select.Enabled = false;
            lbl_confirmation.Visible = false; 
            lbl_confirmation_2.Visible = false;

            // Initializing combo box
            cmb_format.DropDownStyle = ComboBoxStyle.DropDownList;
            Copy_DAO copy = new Copy_DAO();
            cmb_format.DataSource = copy.get_format();
            cmb_format.ValueMember = "id";
            cmb_format.DisplayMember = "name_";
        }

        private void btn_search1_Click_1(object sender, EventArgs e)
        {
            if (txt_search.Text.Length == 0)
            {
                label1.Visible = false;
                lbl_counter.Visible = false;
                lbl_warning.Visible = true;
                lbl_confirmation.Visible = false;
                lbl_confirmation_2.Visible = false; 
            }
            else if (txt_search.Text.Length > 0)
            {
                int results = 0;
                lbl_confirmation.Visible = false;
                lbl_confirmation_2.Visible = false;
                try
                {
                    // By default, we'll search by partial title
                    Copy_DAO copies = new Copy_DAO();
                    dgv_search_result.DataSource = copies.simpleSearch(txt_search.Text, Convert.ToString(cmb_format.SelectedIndex + 1));
                    dgv_search_result.Columns["AUTHOR"].Visible = false;
                    dgv_search_result.Columns["COLLECTION_"].Visible = false;
                    dgv_search_result.Columns["EDITORIAL"].Visible = false;
                    dgv_search_result.Columns["FORMAT_"].Visible = false;
                    dgv_search_result.Columns["LABEL_"].Visible = false;
                    dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                    dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                    dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                    for (int i = 0; i < dgv_search_result.RowCount; i++)
                    {
                        results++;
                    }
                    lbl_counter.Text = results.ToString();
                    lbl_warning.Visible = false;
                    label1.Visible = true;
                    lbl_counter.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_select_Click_1(object sender, EventArgs e)
        {
            select = true;
            if (dgv_search_result.SelectedCells.Count > 0)
            {
                string text = ""; 
                copy_selected = Convert.ToInt32(this.dgv_search_result.SelectedRows[0].Cells[0].Value);
                if (copy_selected > 0)
                {
                    lbl_confirmation.Visible = true;
                    lbl_confirmation_2.Visible = true;

                    text = "Your selection: " + this.dgv_search_result.SelectedRows[0].Cells[1].Value.ToString();

                    MessageBox.Show(text);
                }
            }
        }

        private void dgv_search_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_select.Enabled = true;
        }

        private void dgv_search_result_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_select.Enabled = true;
        }

        private void dgv_search_result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_select.Enabled = true;
        }
    }
}