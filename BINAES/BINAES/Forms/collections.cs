using System;
using System.Windows.Forms;
using BINAES.Clases;
using BINAES.SQL_Server;

namespace BINAES
{
    public partial class frm_collections : Form
    {
        public frm_collections()
        {
            InitializeComponent();
        }

        private void lbl_collectionsDataTable_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (db_BINAES db = new db_BINAES())
            {
                COLLECTION_ collection = new COLLECTION_();
                collection.name_ = txt_name.Text;
                collection.id_type = ((TYPE_)cmb_type.SelectedItem).id;
                collection.id_genre = ((GENRE)cmb_gender.SelectedItem).id;
                
                db.COLLECTION_.Add(collection);
                db.SaveChanges();
                
                /*if (add)
                {
                    db.USER_.Add(collection);
                    db.SaveChanges();
                }
                if (edit)
                {
                    db.Entry(collection).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }*/
            }
            //load_grid();
        }

        private void frm_collections_Load(object sender, EventArgs e)
        {
            collectionsDAO collections = new collectionsDAO();
            //Collections
            cmb_type.DataSource = collections.set_type();
            cmb_type.ValueMember = "id";
            cmb_type.DisplayMember = "type_name_";
            //Genre
            cmb_gender.DataSource = collections.set_genre();
            cmb_gender.ValueMember = "id";
            cmb_gender.DisplayMember = "genre_name";
            //load_grid();
        }
    }
}