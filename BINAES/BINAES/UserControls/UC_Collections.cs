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
        
        bool edit = false;
        bool add = false;
        
        public UC_Collections()
        {
            InitializeComponent();

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
            cmb_type.DisplayMember = "type_name_";
            //Genre
            cmb_genre.DataSource = collections.set_genre();
            cmb_genre.ValueMember = "id";
            cmb_genre.DisplayMember = "genre_name";
            
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
                    btn_edit.BackColor = Color.FromArgb(38, 109, 83);
                    btn_remove.BackColor = Color.FromArgb(38, 109, 83);
                    btn_insertRows.BackColor = Color.FromArgb(38, 109, 83);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lock_controllers();
        }
        
        private void unlock_controllers()
        {
            txt_name.Enabled = true;
            cmb_type.Enabled = true;
            cmb_genre.Enabled = true;
        }

        private void lock_controllers()
        {
            txt_name.Enabled = false;
            cmb_type.Enabled = false;
            cmb_genre.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    COLLECTION_ collection = new COLLECTION_();
                    collection.name_ = txt_name.Text;
                    collection.id_type = ((TYPE_)cmb_type.SelectedItem).id;
                    collection.id_genre = ((GENRE)cmb_genre.SelectedItem).id;

                    if (add)
                    {
                        //ADD NEW DATA
                        db.COLLECTION_.Add(collection);
                        db.SaveChanges();
                        MessageBox.Show("Data saved successfully");
                    }
                    if (edit)
                    {
                        //SAVE EDITED DATA
                        db.Entry(collection).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Data modified successfully");
                    }
                }
                load_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_insertRows_Click(object sender, EventArgs e)
        {
            add = true;
            unlock_controllers();
            btn_edit.BackColor = Color.FromArgb(38, 109, 83);
            btn_remove.BackColor = Color.FromArgb(38, 109, 83);
            btn_insertRows.BackColor = Color.FromArgb(38, 109, 83);
        }
    }
}