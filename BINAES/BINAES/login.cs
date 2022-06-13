﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BINAES.Resources;

namespace BINAES
{
    public partial class frm_login : Form
    {
        string chain = db.connection_chain;
        public frm_login()
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
            MessageBox.Show("Connection: " + chain);
            frm_home home = new frm_home();
            this.Hide();
            home.ShowDialog();
            this.Show();
        }

        private void lnk_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_register register = new frm_register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}