using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BINAES.Clases;
using BINAES.SQL_Server;

namespace BINAES.UserControls
{
    public partial class UC_Users : UserControl
    {
        
        bool edit = false;
        bool add = false;
        
        public UC_Users()
        {
            InitializeComponent();
        }

        private void UC_Users_Load(object sender, EventArgs e)
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
                btn_edit.BackColor = Color.FromArgb(38, 109, 83);
                btn_remove.BackColor = Color.FromArgb(38, 109, 83);
                btn_insertRows.BackColor = Color.FromArgb(38, 109, 83);
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
            txt_address.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_password.Enabled = true;
            cmb_occupancy.Enabled = true;
            cmb_institution.Enabled = true;
            cmb_role.Enabled = true;
        }

        private void lock_controllers()
        {
            txt_name.Enabled = false;
            txt_address.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            txt_password.Enabled = false;
            cmb_occupancy.Enabled = false;
            cmb_institution.Enabled = false;
            cmb_role.Enabled = false;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
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
                        //ADD NEW DATA
                        db.USER_.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Data saved successfully");
                    }
                    if (edit)
                    {
                        //SAVE EDITED DATA
                        db.Entry(user).State = System.Data.Entity.EntityState.Modified;
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