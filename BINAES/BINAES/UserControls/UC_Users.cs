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
    public partial class UC_Users : UserControl
    {

        bool edit = false;
        bool add = false;
        bool picture_load = false;

        public UC_Users()
        {
            InitializeComponent();

            cmb_searchBy.Items.Add("id");
            cmb_searchBy.Items.Add("username");
            cmb_searchBy.Items.Add("user_address");
            cmb_searchBy.Items.Add("phone");
            cmb_searchBy.Items.Add("email");
        }

        private db_BINAES db = new db_BINAES();
        private void filter(string criterio, string campo)
        {
            dg_usersDataTable.DataSource = db.USER_.SqlQuery("SELECT * FROM USER_ WHERE " + campo + " like '%" + criterio + "%'").ToList();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            filter(txt_search.Text, cmb_searchBy.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dg_usersDataTable.DataSource = db.USER_.ToList();
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            UserDAO user = new UserDAO();
            //Role
            cmb_role.DataSource = user.set_role();
            cmb_role.ValueMember = "id";
            cmb_role.DisplayMember = "type_";
            //Occupancy
            cmb_occupancy.DataSource = user.set_occupancy();
            cmb_occupancy.ValueMember = "id";
            cmb_occupancy.DisplayMember = "name_";
            //Institution
            cmb_institution.DataSource = user.set_institution();
            cmb_institution.ValueMember = "id";
            cmb_institution.DisplayMember = "name_";
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
                    dg_usersDataTable.DataSource = user.show_user();
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
            txt_full_name.Enabled = true;
            txt_user.Enabled = true;
            txt_address.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_password.Enabled = true;
            cmb_occupancy.Enabled = true;
            cmb_institution.Enabled = true;
            cmb_role.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
            btn_picture.Enabled = true;
        }

        private void lock_controllers()
        {
            txt_full_name.Enabled = false;
            txt_user.Enabled = false;
            txt_address.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            txt_password.Enabled = false;
            cmb_occupancy.Enabled = false;
            cmb_institution.Enabled = false;
            cmb_role.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            btn_picture.Enabled = false;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    USER_ user = new USER_();
                    user.full_name = txt_full_name.Text;
                    user.username = txt_user.Text;
                    user.user_address = txt_address.Text;
                    user.phone = txt_phone.Text;
                    user.email = txt_email.Text;
                    user.password = Encrypt.GetSHA256(txt_password.Text.Trim());
                    user.id_occupancy = ((OCCUPANCY)cmb_occupancy.SelectedItem).id;
                    user.id_institution = ((INSTITUTION)cmb_institution.SelectedItem).id;
                    user.id_role = ((ROLE_)cmb_role.SelectedItem).id;
                    var picture = new System.IO.MemoryStream();
                    if (picture_load)
                    {
                        pb_picture.Image.Save(picture, System.Drawing.Imaging.ImageFormat.Jpeg);
                        user.picture = picture.GetBuffer();
                    }
                    else
                        user.picture = null;

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

        private void btn_picture_Click(object sender, EventArgs e)
        {
            var picture = new OpenFileDialog();
            var file = picture.ShowDialog();
            if (file == DialogResult.OK)
            {
                pb_picture.Image = Image.FromFile(picture.FileName);
                picture_load = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lock_controllers();
            txt_full_name.Text = "";
            txt_user.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
        }
    }
}