using BINAES.SQL_Server;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BINAES.UserControls
{
    public partial class UC_Attendance : UserControl
    {
        public UC_Attendance()
        {
            InitializeComponent();
        }

        private void clear_text()
        {
            txt_username.Text = "";
            txt_entrance.Text = "";
        }

        private void btn_get_Click(object sender, System.EventArgs e)
        {
             txt_entrance.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void btn_register_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    ATTENDANCE attendance = new ATTENDANCE();
                    string username = txt_username.Text;
                    var lst = db.USER_.Where(p => p.username == username).ToList();
                    if (lst.Count > 0)
                    {
                        foreach (USER_ user in lst)
                        {
                            attendance.id_user = user.id;
                        }
                    }
                    attendance.entrance_date = Convert.ToDateTime(txt_entrance.Text);
                    
                    db.ATTENDANCE.Add(attendance);
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