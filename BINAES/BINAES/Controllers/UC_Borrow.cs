using System;
using System.Linq;
using System.Windows.Forms;
using BINAES.SQL_Server;

namespace BINAES.UserControls
{
    public partial class UC_Borrow : UserControl
    {
        public UC_Borrow()
        {
            InitializeComponent();
        }

        private void clear_text()
        {
            txt_username.Text = "";
            txt_timestamp.Text = "";
            txt_expected_return.Text = "";
        }

        private void btn_get_Click_1(object sender, EventArgs e)
        {
            txt_timestamp.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            DateTime expected = Convert.ToDateTime(txt_timestamp.Text);
            expected = expected.AddDays(15);
            txt_expected_return.Text = expected.ToString();
        }

        private void btnAcceptLoans_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    LOAN_BOOKING loan = new LOAN_BOOKING();
                    string username = txt_username.Text;
                    var lst = db.USER_.Where(p => p.username == username).ToList();
                    if (lst.Count > 0)
                    {
                        foreach (USER_ user in lst)
                        {
                            loan.id_user = user.id;
                        }
                    }
                    loan.timestamp = Convert.ToDateTime(txt_timestamp.Text);
                    loan.loan_timestamp = null;
                    loan.expected_loan_timestamp = null;
                    loan.return_timestamp = null;
                    loan.expected_return_timestamp = Convert.ToDateTime(txt_expected_return.Text);
                    loan.id_copy = UC_Search.copy_selected;

                    db.LOAN_BOOKING.Add(loan);
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

        private void btnCancelLoans_Click_1(object sender, EventArgs e)
        {
            clear_text();
        }
    }
}