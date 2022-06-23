using System;
using System.Windows.Forms;
using BINAES.UserControls;

namespace BINAES
{
    public partial class Frm_homeManagement : Form
    {
        public Frm_homeManagement()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_container.Controls.Clear();
            pnl_container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        
        private void btn_celebrations_Click(object sender, EventArgs e)
        {
            UC_Collections uc = new UC_Collections();
            addUserControl(uc);
        }

        private void btn_collections_Click(object sender, EventArgs e)
        {
            UC_Celebrations uc = new UC_Celebrations();
            addUserControl(uc);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            UC_Users uc = new UC_Users();
            addUserControl(uc);
        }
    }
}