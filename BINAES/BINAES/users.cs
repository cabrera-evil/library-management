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
            cmb_occupation.DataSource = user.set_occupancy();
            cmb_occupation.ValueMember = "id";
            cmb_occupation.DisplayMember = "occupancy_name";
            //Institution
            cmb_institution.DataSource = user.set_institution();
            cmb_institution.ValueMember = "id";
            cmb_institution.DisplayMember = "institution_name";
        }
    }
}