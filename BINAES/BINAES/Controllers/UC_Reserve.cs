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
    public partial class UC_Reserve : UserControl
    {
        public UC_Reserve()
        {
            InitializeComponent();
        }
        
        private void clear_text()
        {
            txt_username.Text = "";
            txt_timestamp.Text = "";
        }
        
        private void btn_get_Click(object sender, EventArgs e)
        {
            txt_timestamp.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }


        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime expected = dtp_expected_loan_timestamp.Value;
                expected = expected.AddDays(15);
                using (db_BINAES db = new db_BINAES())
                {
                    LOAN_BOOKING reserve = new LOAN_BOOKING();
                    string username = txt_username.Text;
                    var lst = db.USER_.Where(p => p.username == username).ToList();
                    if (lst.Count > 0)
                    {
                        foreach (USER_ user in lst)
                        {
                            reserve.id_user = user.id;
                        }
                    }
                    reserve.timestamp = Convert.ToDateTime(txt_timestamp.Text);
                    reserve.loan_timestamp = null;
                    reserve.expected_loan_timestamp = dtp_expected_loan_timestamp.Value;
                    reserve.return_timestamp = null;
                    reserve.expected_return_timestamp = expected;
                    reserve.id_copy = UC_Search.copy_selected;

                    db.LOAN_BOOKING.Add(reserve);
                    db.SaveChanges();
                    MessageBox.Show("Data saved successfully");
                    clear_text();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear_text();
        }
    }
}