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

namespace BINAES
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
            //Generate QR
            string content = "Douglas Cabrera";
            QRCodeGenerator qr_user = new QRCodeGenerator();
            QRCodeData qr_data = QRCodeGenerator.GenerateQrCode(content, QRCodeGenerator.ECCLevel.H);
            QRCode qr_code = new QRCode(qr_data);

            Bitmap qr_image = qr_code.GetGraphic(5, Color.Black, Color.White, true);
            pct_qr.Image = qr_image;
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

        private void pnl_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
