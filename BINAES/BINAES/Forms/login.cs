using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BINAES.Clases;
using BINAES.SQL_Server;

namespace BINAES
{
    public partial class frm_login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pct_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "User")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "User";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.LightGray;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {

            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.LightGray;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string password = Encrypt.GetSHA256(txt_password.Text.Trim());
            using (db_BINAES db = new db_BINAES())
            {
                var lst = from d in db.USER_
                          where d.username == txt_user.Text
                          && d.password == password
                          select d;
                if (lst.Count() > 0)
                {
                    frm_home home = new frm_home(txt_user.Text, txt_password.Text);
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }

        private void lnk_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
