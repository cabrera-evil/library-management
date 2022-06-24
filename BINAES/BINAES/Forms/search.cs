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

namespace BINAES
{
    public partial class frm_search : Form
    {
        public frm_search()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_advanced_search.Controls.Clear(); 
            pnl_advanced_search.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_advanced_tools_Click_1(object sender, EventArgs e)
        {
            UC_Advanced_Search panel = new UC_Advanced_Search();
            addUserControl(panel);
            /*
            using (frm_advanced_search window = new frm_advanced_search())
            {
                window.ShowDialog();
                if (window.DialogResult == DialogResult.OK)
                {
                    // Searching by full title
                    if (window.title.Length > 0 && window.keyWords.Length > 0 && window.author.Length > 0 && window.both == true)
                    {
                    }
                    else if (window.title.Length > 0 && window.keyWords.Length > 0 && window.author.Length > 0 && window.digital == true)
                    {
                    }
                    // Searching by partial title

                }
            }*/
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

                // By default, we'll search by title name
                if (rdb_digital.Checked == true)
                {
                    using (db_BINAES db = new db_BINAES())
                    {
                        var list = from d in db.COPY_
                                   where d.name_ == txt_search.Text
                                   && d.id_format == 1
                                   select d;
                        if (list.Count() > 0)
                        {
                            dgv_search_result.DataSource = list;
                            dgv_search_result.Show();
                            lbl_counter.Text = Convert.ToString(list.Count());
                        }
                    }
                }
                else if (rdb_physical.Checked == true)
                {
                    using (db_BINAES db = new db_BINAES())
                    {
                        var list = from d in db.COPY_
                                   where d.name_ == txt_search.Text
                                   && d.id_format == 2
                                   select d;
                        if (list.Count() > 0)
                        {
                            dgv_search_result.DataSource = list;
                            dgv_search_result.Show();
                            lbl_counter.Text = Convert.ToString(list.Count());
                        }
                    }
                }
                else if (rdb_both.Checked == true)
                {
                    using (db_BINAES db = new db_BINAES())
                    {
                        var list = from d in db.COPY_
                                   where d.name_ == txt_search.Text
                                   select d;
                        if (list.Count() > 0)
                        {
                            dgv_search_result.DataSource = list;
                            dgv_search_result.Show();
                            lbl_counter.Text = Convert.ToString(list.Count());
                        }
                    }
                }
            }
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            // si el item seleccionado por el usuario no se ha prestado, entonces será enabled
            // de lo contrario, solo el botón de reservar estará habilitado
            // abrir formulario para prestar
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            // abrir formulario para reservar
        }
    }
}
