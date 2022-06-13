using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BINAES
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lnk_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
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

        private void txt_addres_Enter(object sender, EventArgs e)
        {
            if (txt_addres.Text == "Addres")
            {
                txt_addres.Text = "";
                txt_addres.ForeColor = Color.LightGray;
            }
        }

        private void txt_addres_Leave(object sender, EventArgs e)
        {
            if (txt_addres.Text == "")
            {
                txt_addres.Text = "Addres";
                txt_addres.ForeColor = Color.LightGray;
            }
        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            if (txt_phone.Text == "Phone")
            {
                txt_phone.Text = "";
                txt_phone.ForeColor = Color.LightGray;
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                txt_phone.Text = "Phone";
                txt_phone.ForeColor = Color.LightGray;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.LightGray;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
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

        private void frm_register_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pct_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
