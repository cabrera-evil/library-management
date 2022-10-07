using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BINAES.Clases;
using BINAES.SQL_Server;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Crypto.Tls;

namespace BINAES
{
    public partial class booking : Form
    {

        private bool editable = false;
        private int selection = 0;

        public booking()
        {
            InitializeComponent();

            dgv_bookingDataTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

            cmb_searchBy.Items.Add("id");
            cmb_searchBy.Items.Add("id_user");
            cmb_searchBy.Items.Add("id_copy");
        }


        private db_BINAES db = new db_BINAES();
        private void filter(string find, string field)
        {
            dgv_bookingDataTable.DataSource = db.LOAN_BOOKING.SqlQuery("SELECT * FROM LOAN_BOOKING WHERE " + field + " like '%" + find + "%'").ToList();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            filter(txt_search.Text, cmb_searchBy.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dgv_bookingDataTable.DataSource = db.LOAN_BOOKING.ToList();
        }


        private void frm_booking_Load(object sender, EventArgs e)
        {
            loan_bookingDAO bookingDao = new loan_bookingDAO();
            load_grid();
        }

        private void load_grid()
        {
            loan_bookingDAO bookingDao = new loan_bookingDAO();
            try
            {
                dgv_bookingDataTable.DataSource = bookingDao.loan_booking();
                dgv_bookingDataTable.Columns["COPY_"].Visible = false;
                dgv_bookingDataTable.Columns["USER_"].Visible = false;
                btn_edit.BackColor = Color.FromArgb(38, 109, 83);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lock_controllers();
            editable = false;
        }

        private void clear_text()
        {
            txt_timeStamp.Text = "";
            txt_expectedLoanTimeStamp.Text = "";
            txt_expectedReturnTimeStamp.Text = "";
            txt_loanTimeStamp.Text = "";
            txt_returnTimeStamp.Text = "";
            txt_user.Text = "";
            txt_copy.Text = "";
        }

        private void unlock_controllers()
        {
            txt_timeStamp.Enabled = true;
            txt_expectedLoanTimeStamp.Enabled = true;
            txt_expectedReturnTimeStamp.Enabled = true;
            txt_loanTimeStamp.Enabled = true;
            txt_returnTimeStamp.Enabled = true;
            txt_user.Enabled = true;
            txt_copy.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
        }

        private void lock_controllers()
        {
            txt_timeStamp.Enabled = false;
            txt_expectedLoanTimeStamp.Enabled = false;
            txt_expectedReturnTimeStamp.Enabled = false;
            txt_loanTimeStamp.Enabled = false;
            txt_returnTimeStamp.Enabled = false;
            txt_user.Enabled = false;
            txt_copy.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
        }

        private void edit_data(int id)
        {
            unlock_controllers();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    var lst = db.LOAN_BOOKING.Where(p => p.id == id).ToList();
                    if (lst.Count > 0)
                    {
                        foreach (LOAN_BOOKING booking in lst)
                        {
                            txt_timeStamp.Text = booking.timestamp.ToString();
                            txt_expectedLoanTimeStamp.Text = booking.expected_loan_timestamp.ToString();
                            txt_expectedReturnTimeStamp.Text = booking.expected_return_timestamp.ToString();
                            txt_loanTimeStamp.Text = booking.loan_timestamp.ToString();
                            txt_returnTimeStamp.Text = booking.return_timestamp.ToString();
                            txt_user.Text = booking.id_user.ToString();
                            txt_copy.Text = booking.id_copy.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (db_BINAES db = new db_BINAES())
                {

                    if (!editable)
                    {
                        //ADD NEW DATA
                        LOAN_BOOKING booking = new LOAN_BOOKING();
                        booking.timestamp = Convert.ToDateTime(txt_timeStamp.Text);
                        booking.expected_loan_timestamp = Convert.ToDateTime(txt_expectedLoanTimeStamp);
                        booking.expected_return_timestamp = Convert.ToDateTime(txt_expectedReturnTimeStamp.Text);
                        booking.loan_timestamp = Convert.ToDateTime(txt_loanTimeStamp.Text);
                        booking.return_timestamp = Convert.ToDateTime(txt_returnTimeStamp.Text);
                        booking.id_user = Convert.ToInt32(txt_user.Text);
                        booking.id_copy = Convert.ToInt32(txt_copy.Text);

                        db.LOAN_BOOKING.Add(booking);
                        db.SaveChanges();
                        MessageBox.Show("Data saved successfully");
                    }
                    else
                    {
                        //SAVE EDITED DATA
                        LOAN_BOOKING edit = db.LOAN_BOOKING.Find(selection);
                        edit.timestamp = Convert.ToDateTime(txt_timeStamp.Text);
                        edit.expected_loan_timestamp = Convert.ToDateTime(txt_expectedLoanTimeStamp.Text);
                        edit.expected_return_timestamp = Convert.ToDateTime(txt_expectedReturnTimeStamp.Text);
                        edit.loan_timestamp = Convert.ToDateTime(txt_loanTimeStamp.Text);
                        edit.return_timestamp = Convert.ToDateTime(txt_returnTimeStamp.Text);
                        edit.id_user = Convert.ToInt32(txt_user.Text);
                        edit.id_copy = Convert.ToInt32(txt_copy.Text);

                        if (edit != null)
                        {
                            db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Data modified successfully");
                        }
                    }
                }
                load_grid();
                clear_text();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lock_controllers();
            clear_text();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                editable = true;
                edit_data(selection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_bookingDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bookingDataTable.Columns[e.ColumnIndex].Name == "id")
            {
                selection = Convert.ToInt32(dgv_bookingDataTable.CurrentRow.Cells["id"].Value.ToString());
            }
        }
    }
}