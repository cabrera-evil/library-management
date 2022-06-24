using System;
using System.Windows.Forms;
using BINAES.UserControls;

namespace BINAES
{
    public partial class management : Form
    {
        public management()
        {
            InitializeComponent();

            lbl_title.Text = "";
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_container.Controls.Clear();
            pnl_container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        
        private void btn_collections_Click(object sender, EventArgs e)
        {
            UC_Collections uc = new UC_Collections();
            lbl_title.Text = "Add collection";
            addUserControl(uc);
        }

        private void btn_celebrations_Click(object sender, EventArgs e)
        {
            UC_Celebrations uc = new UC_Celebrations();
            lbl_title.Text = "Add celebration";
            addUserControl(uc);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            UC_Users uc = new UC_Users();
            lbl_title.Text = "Add user";
            addUserControl(uc);
        }
    }
}