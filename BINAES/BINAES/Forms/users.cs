using System;
using System.Linq;
using System.Windows.Forms;
using BINAES.Clases;
using BINAES.SQL_Server;

namespace BINAES
{
    public partial class frm_users : Form
    {
        bool edit = false;
        bool remove = false;
        bool add = false;
        public frm_users()
        {
            InitializeComponent();
        }

        private void edit_data(int id)
        {
            try
            {
                using(db_BINAES db = new db_BINAES())
                {
                    var lst = db.USER_.Where(p => p.id == id).ToList();
                    if(lst.Count > 0)
                    {
                        foreach(USER_ user in lst)
                        {
                            txt_name.Text = user.username.ToString();
                            txt_address.Text = user.user_address;
                            txt_phone.Text = user.phone;
                            txt_email.Text = user.email;
                            txt_password.Text = user.password;
                            ((OCCUPANCY)cmb_occupancy.SelectedItem).id = user.id_occupancy;
                            ((INSTITUTION)cmb_institution.SelectedItem).id = user.id_institution;
                            ((ROLE_)cmb_role.SelectedItem).id = user.id_role;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_data(int id)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    db.USER_.Remove(db.USER_.Single(p => p.id == id));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_users_Load(object sender, System.EventArgs e)
        {
            UserDAO user = new UserDAO();
            //Role
            cmb_role.DataSource = user.set_role();
            cmb_role.ValueMember = "id";
            cmb_role.DisplayMember = "role_type";
            //Occupancy
            cmb_occupancy.DataSource = user.set_occupancy();
            cmb_occupancy.ValueMember = "id";
            cmb_occupancy.DisplayMember = "occupancy_name";
            //Institution
            cmb_institution.DataSource = user.set_institution();
            cmb_institution.ValueMember = "id";
            cmb_institution.DisplayMember = "institution_name";
            //Users
            load_grid();
        }

        private void load_grid()
        {
            UserDAO user = new UserDAO();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    var Lst =
                    dg_usersDataTable.DataSource = user.show_user();
                    dg_usersDataTable.Columns["id"].DisplayIndex = 0;
                    dg_usersDataTable.Columns["username"].DisplayIndex = 1;
                    /*dg_usersDataTable.Columns["Address"].DisplayIndex = 2;
                    dg_usersDataTable.Columns["Phone"].DisplayIndex = 3;
                    dg_usersDataTable.Columns["Email"].DisplayIndex = 4;
                    dg_usersDataTable.Columns["Password"].DisplayIndex = 5;
                    dg_usersDataTable.Columns["Occupation"].DisplayIndex = 6;
                    dg_usersDataTable.Columns["Institution"].DisplayIndex = 7;
                    dg_usersDataTable.Columns["Role"].DisplayIndex = 8;*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            using (db_BINAES db = new db_BINAES())
            {
                USER_ user = new USER_();
                user.username = txt_name.Text;
                user.user_address = txt_address.Text;
                user.phone = txt_phone.Text;
                user.email = txt_email.Text;
                user.password = Encrypt.GetSHA256(txt_password.Text.Trim());
                user.id_occupancy = ((OCCUPANCY)cmb_occupancy.SelectedItem).id;
                user.id_institution = ((INSTITUTION)cmb_institution.SelectedItem).id;
                user.id_role = ((ROLE_)cmb_role.SelectedItem).id;
                if (add)
                {
                    db.USER_.Add(user);
                    db.SaveChanges();
                }
                if (edit)
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void btn_edit_Click(object sender, System.EventArgs e)
        {
            edit = true;
            remove = false;
            add = false;
        }

        private void btn_remove_Click(object sender, System.EventArgs e)
        {
            remove = true;
            edit = false;
            add = false;
        }

        private void btn_insertRows_Click(object sender, System.EventArgs e)
        {
            add = true;
            remove = false;
            edit = false;
        }

        private void dg_usersDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit data
            if (dg_usersDataTable.Columns[e.ColumnIndex].Name == "id")
            {
                USER_ user = new USER_();
                user.id = Convert.ToInt32(dg_usersDataTable.CurrentRow.Cells["id"].Value.ToString());
                if (edit)
                {
                    edit_data(user.id);
                    load_grid();
                    edit = false;
                }
                else if (remove)
                {
                    delete_data(user.id);
                    load_grid();
                    remove = false;
                }
            }
            //Add new data
            if (add)
            {
                load_grid();
                add = false;
            }
        }
    }
}