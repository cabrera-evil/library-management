using System.Windows.Forms;
using BINAES.Clases;

namespace BINAES
{
    public partial class frm_users : Form
    {
        public frm_users()
        {
            InitializeComponent();
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
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            using (db_BINAES db = new db_BINAES())
            {
                USER_ user = new USER_();
                user.username = txt_name.Text;
                user.user_address = txt_address.Text;
                user.phone = txt_phone.Text;
                user.picture = default;
                user.email = txt_email.Text;
                user.password = Encrypt.GetSHA256(txt_password.Text.Trim());
                user.id_occupancy = ((OCCUPANCY)cmb_occupancy.SelectedItem).id;
                user.id_institution = ((INSTITUTION)cmb_institution.SelectedItem).id;
                user.id_role = ((ROLE_)cmb_role.SelectedItem).id;

                db.USER_.Add(user);
                db.SaveChanges();
            }
        }

        private void btn_edit_Click(object sender, System.EventArgs e)
        {
            USER_ user = new USER_();''
        }
    }
}