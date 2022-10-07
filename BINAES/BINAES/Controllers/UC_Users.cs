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

        private bool editable = false;
        private bool picture_load = false;
        private int selection = 0;


        public UC_Users()
        {
            InitializeComponent();

            cmb_searchBy.Items.Add("id");
            cmb_searchBy.Items.Add("full_name");
            cmb_searchBy.Items.Add("username");
            cmb_searchBy.Items.Add("address_");
            cmb_searchBy.Items.Add("phone");
            cmb_searchBy.Items.Add("email");
        }

        private db_BINAES db = new db_BINAES();
        private void filter(string find, string field)
        {
            dg_usersDataTable.DataSource = db.USER_.SqlQuery("SELECT * FROM USER_ WHERE " + field + " like '%" + find + "%'").ToList();
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
                dg_usersDataTable.DataSource = user.show_user();
                dg_usersDataTable.Columns["ATTENDANCE"].Visible = false;
                dg_usersDataTable.Columns["INSTITUTION"].Visible = false;
                dg_usersDataTable.Columns["LOAN_BOOKING"].Visible = false;
                dg_usersDataTable.Columns["OCCUPANCY"].Visible = false;
                dg_usersDataTable.Columns["ROLE_"].Visible = false;
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

        private void clear_text()
        {
            txt_full_name.Text = "";
            txt_user.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            pb_picture.Image = null;
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

        private void edit_data(int id)
        {
            unlock_controllers();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    var lst = db.USER_.Where(p => p.id == id).ToList();
                    if (lst.Count > 0)
                    {
                        foreach (USER_ user in lst)
                        {
                            txt_full_name.Text = user.full_name.ToString();
                            txt_user.Text = user.username.ToString();
                            txt_address.Text = user.address_;
                            txt_phone.Text = user.phone;
                            txt_email.Text = user.email;
                            txt_password.Text = user.password;
                            ((OCCUPANCY)cmb_occupancy.SelectedItem).id = user.id_occupancy;
                            ((INSTITUTION)cmb_institution.SelectedItem).id = user.id_institution;
                            ((ROLE_)cmb_role.SelectedItem).id = user.id_role;
                            //GET PICTURE
                            if (user.picture != null)
                            {
                                System.IO.MemoryStream picture = new System.IO.MemoryStream(user.picture);
                                pb_picture.Image = System.Drawing.Image.FromStream(picture);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
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
                    db.USER_.Remove(db.USER_.Single(p => p.id == id));
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

        private void btn_insertRows_Click(object sender, EventArgs e)
        {
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {

                    if (!editable)
                    {
                        //ADD NEW DATA
                        USER_ user = new USER_();
                        user.full_name = txt_full_name.Text;
                        user.username = txt_user.Text;
                        user.address_ = txt_address.Text;
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

                        db.USER_.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Data saved successfully");
                    }
                    else
                    {
                        //SAVE EDITED DATA
                        USER_ edit = db.USER_.Find(selection);
                        edit.full_name = txt_full_name.Text;
                        edit.username = txt_user.Text;
                        edit.address_ = txt_address.Text;
                        edit.phone = txt_phone.Text;
                        edit.email = txt_email.Text;
                        edit.password = Encrypt.GetSHA256(txt_password.Text.Trim());
                        edit.id_occupancy = ((OCCUPANCY)cmb_occupancy.SelectedItem).id;
                        edit.id_institution = ((INSTITUTION)cmb_institution.SelectedItem).id;
                        edit.id_role = ((ROLE_)cmb_role.SelectedItem).id;
                        var picture = new System.IO.MemoryStream();
                        if (picture_load)
                        {
                            pb_picture.Image.Save(picture, System.Drawing.Imaging.ImageFormat.Jpeg);
                            edit.picture = picture.GetBuffer();
                        }
                        else
                            edit.picture = null;

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

        private void dg_usersDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_usersDataTable.Columns[e.ColumnIndex].Name == "id")
            {
                selection = Convert.ToInt32(dg_usersDataTable.CurrentRow.Cells["id"].Value.ToString());
            }
        }
    }
}