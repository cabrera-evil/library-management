using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BINAES.Clases;
using BINAES.SQL_Server;
using BINAES.UserControls;

namespace BINAES.UserControls
{
    public partial class UC_Advanced_Search : UserControl
    {
        public bool select;
        public UC_Advanced_Search()
        {
            InitializeComponent();
            txt_title.Enabled = false;
            txt_some_words.Enabled = false;

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
        
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            int results = 0;
            bool key_words = false;
            bool author = false;
            lbl_confirmation.Visible = false;
            lbl_confirmation_2.Visible = false;
            txt_author.Enabled = false;
            txt_key_words.Enabled = false; 

            if (rdb_partial.Checked && txt_some_words.Text.Length == 0)
            {
                label7.Visible = false;
                lbl_counter.Visible = false;
                lbl_warning.Visible = true;
            }
            else if (rdb_full.Checked && txt_title.Text.Length == 0) 
            {
                label7.Visible = false;
                lbl_counter.Visible = false;
                lbl_warning.Visible = true;
            }
            // Partial title
            else if (rdb_partial.Checked && txt_some_words.Text.Length > 0)
            {
                try
                {
                    // Searching by partial title, without specifying key words, and author 
                    if (txt_key_words.Text.Length == 0 && txt_author.Text.Length == 0)
                    {
                        Copy_DAO copies = new Copy_DAO();
                        dgv_search_result.DataSource = copies.SearchPartialTitle(txt_some_words.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        
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
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }
                    // Searching by partial title, without specifying key words
                    if (txt_key_words.Text.Length == 0 && txt_author.Text.Length > 0)
                    {
                        author = true;
                        Copy_DAO copies = new Copy_DAO();
                        
                        dgv_search_result.Columns["AUTHOR"].Visible = false;
                        dgv_search_result.Columns["COLLECTION_"].Visible = false;
                        dgv_search_result.Columns["EDITORIAL"].Visible = false;
                        dgv_search_result.Columns["FORMAT_"].Visible = false;
                        dgv_search_result.Columns["LABEL_"].Visible = false;
                        dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                        dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                        dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                        
                        dgv_search_result.DataSource = copies.SearchPartialTitle(txt_some_words.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        for (int i = 0; i < dgv_search_result.RowCount; i++)
                        {
                            results++;
                        }
                        lbl_counter.Text = results.ToString();
                        lbl_warning.Visible = false;
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }
                    // Searching by partial title, without specifying author
                    if (txt_key_words.Text.Length > 0 && txt_author.Text.Length == 0)
                    {
                        key_words = true;
                        Copy_DAO copies = new Copy_DAO();
                        
                        dgv_search_result.Columns["AUTHOR"].Visible = false;
                        dgv_search_result.Columns["COLLECTION_"].Visible = false;
                        dgv_search_result.Columns["EDITORIAL"].Visible = false;
                        dgv_search_result.Columns["FORMAT_"].Visible = false;
                        dgv_search_result.Columns["LABEL_"].Visible = false;
                        dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                        dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                        dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                        
                        dgv_search_result.DataSource = copies.SearchPartialTitle(txt_some_words.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        for (int i = 0; i < dgv_search_result.RowCount; i++)
                        {
                            results++;
                        }
                        lbl_counter.Text = results.ToString();
                        lbl_warning.Visible = false;
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }
                    // Searching by partial title specifying key words and author
                    if (txt_key_words.Text.Length > 0 && txt_author.Text.Length > 0)
                    {
                        key_words = true;
                        author = true;
                        Copy_DAO copies = new Copy_DAO();
                        
                        dgv_search_result.Columns["AUTHOR"].Visible = false;
                        dgv_search_result.Columns["COLLECTION_"].Visible = false;
                        dgv_search_result.Columns["EDITORIAL"].Visible = false;
                        dgv_search_result.Columns["FORMAT_"].Visible = false;
                        dgv_search_result.Columns["LABEL_"].Visible = false;
                        dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                        dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                        dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                        
                        dgv_search_result.DataSource = copies.SearchPartialTitle(txt_some_words.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        for (int i = 0; i < dgv_search_result.RowCount; i++)
                        {
                            results++;
                        }
                        lbl_counter.Text = results.ToString();
                        lbl_warning.Visible = false;
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Full title
            else if (rdb_full.Checked && txt_title.Text.Length > 0)
            {
                try
                {
                    // Searching by full title, without specifying key words, and author 
                    if (txt_key_words.Text.Length == 0 && txt_author.Text.Length == 0)
                    {
                        Copy_DAO copies = new Copy_DAO();
                        
                        dgv_search_result.Columns["AUTHOR"].Visible = false;
                        dgv_search_result.Columns["COLLECTION_"].Visible = false;
                        dgv_search_result.Columns["EDITORIAL"].Visible = false;
                        dgv_search_result.Columns["FORMAT_"].Visible = false;
                        dgv_search_result.Columns["LABEL_"].Visible = false;
                        dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                        dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                        dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                        
                        dgv_search_result.DataSource = copies.SearchFullTitle(txt_title.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        for (int i = 0; i < dgv_search_result.RowCount; i++)
                        {
                            results++;
                        }
                        lbl_counter.Text = results.ToString();
                        lbl_warning.Visible = false;
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }
                    // Searching by full title, without specifying key words
                    if (txt_key_words.Text.Length == 0 && txt_author.Text.Length > 0)
                    {
                        Copy_DAO copies = new Copy_DAO();
                        
                        dgv_search_result.Columns["AUTHOR"].Visible = false;
                        dgv_search_result.Columns["COLLECTION_"].Visible = false;
                        dgv_search_result.Columns["EDITORIAL"].Visible = false;
                        dgv_search_result.Columns["FORMAT_"].Visible = false;
                        dgv_search_result.Columns["LABEL_"].Visible = false;
                        dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                        dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                        dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                        
                        dgv_search_result.DataSource = copies.SearchFullTitle(txt_title.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        for (int i = 0; i < dgv_search_result.RowCount; i++)
                        {
                            results++;
                        }
                        lbl_counter.Text = results.ToString();
                        lbl_warning.Visible = false;
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }
                    // Searching by full title, without specifying author
                    if (txt_key_words.Text.Length > 0 && txt_author.Text.Length == 0)
                    {
                        Copy_DAO copies = new Copy_DAO();
                        
                        dgv_search_result.Columns["AUTHOR"].Visible = false;
                        dgv_search_result.Columns["COLLECTION_"].Visible = false;
                        dgv_search_result.Columns["EDITORIAL"].Visible = false;
                        dgv_search_result.Columns["FORMAT_"].Visible = false;
                        dgv_search_result.Columns["LABEL_"].Visible = false;
                        dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                        dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                        dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                       
                        dgv_search_result.DataSource = copies.SearchFullTitle(txt_title.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        for (int i = 0; i < dgv_search_result.RowCount; i++)
                        {
                            results++;
                        }
                        lbl_counter.Text = results.ToString();
                        lbl_warning.Visible = false;
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }
                    // Searching by full title specifying key words and author
                    if (txt_key_words.Text.Length > 0 && txt_author.Text.Length > 0)
                    {
                        Copy_DAO copies = new Copy_DAO();
                        
                        dgv_search_result.Columns["AUTHOR"].Visible = false;
                        dgv_search_result.Columns["COLLECTION_"].Visible = false;
                        dgv_search_result.Columns["EDITORIAL"].Visible = false;
                        dgv_search_result.Columns["FORMAT_"].Visible = false;
                        dgv_search_result.Columns["LABEL_"].Visible = false;
                        dgv_search_result.Columns["LANGUAGE_"].Visible = false;
                        dgv_search_result.Columns["WORDS_LIST"].Visible = false;
                        dgv_search_result.Columns["LOAN_BOOKING"].Visible = false;
                        
                        dgv_search_result.DataSource = copies.SearchFullTitle(txt_title.Text.Trim(), Convert.ToString(cmb_format.SelectedIndex + 1), key_words, author, txt_key_words.Text.Trim(), txt_author.Text.Trim());
                        for (int i = 0; i < dgv_search_result.RowCount; i++)
                        {
                            results++;
                        }
                        lbl_counter.Text = results.ToString();
                        lbl_warning.Visible = false;
                        label7.Visible = true;
                        lbl_counter.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void rdb_full_CheckedChanged(object sender, EventArgs e)
        {
            txt_title.Enabled = true;
            txt_some_words.Enabled = false;
            txt_some_words.Text = "";
        }

        private void rdb_partial_CheckedChanged(object sender, EventArgs e)
        {
            txt_some_words.Enabled = true;
            txt_title.Enabled = false;
            txt_title.Text = "";
        }

        private void btn_select_Click_1(object sender, EventArgs e)
        {
            if (dgv_search_result.SelectedCells.Count > 0)
            {
                string text = ""; 
                UC_Search.copy_selected = Convert.ToInt32(this.dgv_search_result.SelectedRows[0].Cells[0].Value);
                if (UC_Search.copy_selected > 0)
                {
                    lbl_confirmation.Visible = true;
                    lbl_confirmation_2.Visible = true;
                    text = "Your selection: " + this.dgv_search_result.SelectedRows[0].Cells[1].Value.ToString(); 
                    
                    MessageBox.Show(text); 
                }
            }
        }
        
        private void dgv_search_result_DoubleClick_1(object sender, EventArgs e)
        {
            btn_select.Enabled = true;
        }

        private void dgv_search_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_select.Enabled = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rdb_full.Checked = false;
            rdb_partial.Checked = false;
            txt_title.Enabled = false;
            txt_some_words.Enabled = false; 
            txt_title.Text = "";
            txt_some_words.Text = "";
            txt_key_words.Text = "";
            txt_author.Text = ""; 
            dgv_search_result.DataSource = null;
            lbl_counter.Visible = false;
            label7.Visible = false;
            btn_select.Enabled = false; 
        }
    }
}