using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BINAES.Clases;
using BINAES.SQL_Server;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Crypto.Tls;

namespace BINAES.UserControls
{
    public partial class UC_Collections : UserControl
    {
        
        private bool editable = false;
        private int selection = 0;
        
        public UC_Collections()
        {
            InitializeComponent();
            
            cmb_searchBy.Items.Add("id");
            cmb_searchBy.Items.Add("name_");
            cmb_searchBy.Items.Add("id_type");
            cmb_searchBy.Items.Add("id_genre");
        }

        private db_BINAES db = new db_BINAES();

        private void filter(string find, string field)
        {
            dg_collectionsDataTable.DataSource = db.COLLECTION_.SqlQuery("SELECT * FROM COLLECTION_ WHERE " + field + " like '%"+find+"%'").ToList();
        }
        
        private void btn_filter_Click(object sender, EventArgs e)
        {
            filter(txt_search.Text, cmb_searchBy.Text);
        }
        
        private void btn_reset_Click(object sender, EventArgs e)
        {
            load_grid();
        }
        
        private void UC_Collections_Load(object sender, EventArgs e)
        {
            collectionsDAO collections = new collectionsDAO();
            //Type
            cmb_type.DataSource = collections.set_type();
            cmb_type.ValueMember = "id";
            cmb_type.DisplayMember = "name_";
            //Genre
            cmb_genre.DataSource = collections.set_genre();
            cmb_genre.ValueMember = "id";
            cmb_genre.DisplayMember = "name_";
            
            load_grid();
        }
        
        private void load_grid()
        {
            collectionsDAO collections = new collectionsDAO();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    dg_collectionsDataTable.DataSource = collections.show_collection();
                    dg_collectionsDataTable.Columns["GENRE"].Visible = false;
                    dg_collectionsDataTable.Columns["TYPE_"].Visible = false;
                    dg_collectionsDataTable.Columns["COPY_"].Visible = false;
                }
                btn_edit.BackColor = Color.FromArgb(38, 109, 83);
                btn_remove.BackColor = Color.FromArgb(38, 109, 83);
                btn_insertRows.BackColor = Color.FromArgb(38, 109, 83);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lock_controllers();
            editable = false;
        }
        
        private void unlock_controllers()
        {
            txt_name.Enabled = true;
            cmb_type.Enabled = true;
            cmb_genre.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
        }

        private void lock_controllers()
        {
            txt_name.Enabled = false;
            cmb_type.Enabled = false;
            cmb_genre.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                   
                    if (!editable)
                    {
                        //ADD NEW DATA
                        COLLECTION_ collection = new COLLECTION_();
                        collection.name_ = txt_name.Text.ToString();
                        collection.id_genre = ((GENRE)cmb_genre.SelectedItem).id;
                        collection.id_type = ((TYPE_)cmb_type.SelectedItem).id;

                        db.COLLECTION_.Add(collection);
                        db.SaveChanges();
                        MessageBox.Show("Data saved successfully");
                    }
                    else
                    {
                        //SAVE EDITED DATA
                        COLLECTION_ edit = db.COLLECTION_.Find(selection);
                        edit.name_ = txt_name.Text;
                        edit.id_type = ((TYPE_)cmb_type.SelectedItem).id;
                        edit.id_genre = ((GENRE)cmb_genre.SelectedItem).id;

                        if (edit != null)
                        {
                            db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Data modified successfully");
                        }
                    }
                }
                load_grid();
                clear_text();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lock_controllers();
            clear_text();
        }
        
        private void clear_text()
        {
            txt_name.Text = "";
        }

        private void btn_insertRows_Click(object sender, EventArgs e)
        {
            unlock_controllers();
            btn_edit.BackColor = Color.FromArgb(38, 109, 83);
            btn_remove.BackColor = Color.FromArgb(38, 109, 83);
            btn_insertRows.BackColor = Color.FromArgb(38, 109, 83);
        }


        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                remove_data(selection);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void remove_data(int id)
        {
            unlock_controllers();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    db.COLLECTION_.Remove(db.COLLECTION_.Single(p => p.id == id));
                    db.SaveChanges();
                    MessageBox.Show("Data deleted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_grid();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                editable = true;
                edit_data(selection);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void edit_data(int id)
        {
            unlock_controllers();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    var lst = db.COLLECTION_.Where(p => p.id == id).ToList();
                    if (lst.Count > 0)
                    {
                        foreach (COLLECTION_ collection in lst)
                        {
                            txt_name.Text = collection.name_.ToString();
                            ((TYPE_)cmb_type.SelectedItem).id = Convert.ToInt32(collection.id_type);
                            ((GENRE)cmb_genre.SelectedItem).id = Convert.ToInt32(collection.id_genre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_collectionsDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_collectionsDataTable.Columns[e.ColumnIndex].Name == "id")
            {
                selection = Convert.ToInt32(dg_collectionsDataTable.CurrentRow.Cells["id"].Value.ToString());
            }
        }
    }
}