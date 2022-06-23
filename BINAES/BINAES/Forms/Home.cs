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
using System.Drawing.Drawing2D;
using QRCoder;
using BINAES.Clases;
using BINAES.SQL_Server;

namespace BINAES
{
    public partial class frm_home : Form
    {
        private string username;
        private string password;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frm_home(string username, string password)
        {
            this.username = username;
            this.password = password;

            InitializeComponent();
            open_form<frm_welcome>();
            QRGenerator();
        }

        public void QRGenerator()
        {
            //Generate QR
            string content = username;
            QRCodeData qr_data = QRCodeGenerator.GenerateQrCode(content, QRCodeGenerator.ECCLevel.H);
            QRCode qr_code = new QRCode(qr_data);

            Bitmap qr_image = qr_code.GetGraphic(5, Color.Black, Color.White, true);
            pct_qr.Image = qr_image;
        }

        public void open_form<selected_form>() where selected_form : Form, new()
        {
            Form myForm;
            myForm = pnl_form.Controls.OfType<selected_form>().FirstOrDefault();
            if (myForm == null)
            {
                myForm = new selected_form();
                myForm.TopLevel = false;
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Dock = DockStyle.Fill;
                pnl_form.Controls.Add(myForm);
                pnl_form.Tag = myForm;
                myForm.Show();
                myForm.BringToFront();
            }
            else
            {
                myForm.BringToFront();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            open_form<frm_welcome>();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            open_form<frm_search>();
        }

        private void btn_loans_Click(object sender, EventArgs e)
        {
           open_form<frm_users>();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            open_form<frm_collections>();
        }

        private void btn_management_Click(object sender, EventArgs e)
        {
            open_form<Frm_homeManagement>();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            lbl_name.Text = username;
            using(db_BINAES db = new db_BINAES())
            {
                var lst = from d in db.USER_
                          where d.username == username
                          && d.password == password
                          select d;
                //MessageBox.Show(user.email);
                if (lst.Count() > 0)
                {
                    //lbl_email.Text = ;
                    //lbl_role.Text = user.id_role.ToString();
                }
            }
        }
    }
}
