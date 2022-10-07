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
    public partial class UC_Celebrations : UserControl
    {
        
        private bool editable = false;
        private bool picture_load = false;
        private int selection = 0;
        
        public UC_Celebrations()
        {
            InitializeComponent();

            cmb_searchBy.Items.Add("id");
            cmb_searchBy.Items.Add("title");
            cmb_searchBy.Items.Add("attendance");
        }
        
        private db_BINAES db = new db_BINAES();
        private void filter(string find, string field)
        {
            dg_eventsDataTable.DataSource = db.CELEBRATION.SqlQuery("SELECT * FROM CELEBRATION WHERE " + field + " like '%" + find + "%'").ToList();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            filter(txt_search.Text, cmb_searchBy.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dg_eventsDataTable.DataSource = db.CELEBRATION.ToList();
        }


        private void UC_Celebrations_Load(object sender, EventArgs e)
        {
            load_grid();
        }
        
        private void load_grid()
        {
            celebrationDAO celebration = new celebrationDAO();
            try
            {
                dg_eventsDataTable.DataSource = celebration.show_celebration();
                dg_eventsDataTable.Columns["ACTIVITY"].Visible = false;
                dg_eventsDataTable.Columns["GOAL"].Visible = false;
                btn_edit.BackColor = Color.FromArgb(38, 109, 83);
                btn_remove.BackColor = Color.FromArgb(38, 109, 83);
                btn_insertRows.BackColor = Color.FromArgb(38, 109, 83);
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
            txt_title.Text = "";
            txt_objectives.Text = "";
            txt_numberAttendees.Text = "";
            
        }

        private void unlock_controllers()
        {
            txt_title.Enabled = true;
            txt_objectives.Enabled = true;
            txt_numberAttendees.Enabled = true;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;
            dtp_startDate.Enabled = true;
            dtp_endDate.Enabled = true;
            btn_picture.Enabled = true;
        }

        private void lock_controllers()
        {
            txt_title.Enabled = false;
            txt_objectives.Enabled = false;
            txt_numberAttendees.Enabled = false;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            dtp_startDate.Enabled = false;
            dtp_endDate.Enabled = false;
            btn_picture.Enabled = false;
            pb_picture.Image = null;
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
                        CELEBRATION celebration = new CELEBRATION();
                        GOAL goal = new GOAL();
                        celebration.title = txt_title.Text;
                        goal.name_ = txt_objectives.Text;
                        goal.id_celebration = celebration.id;
                        celebration.attendance = Convert.ToInt32(txt_numberAttendees.Text);
                        celebration.beginning_date = dtp_startDate.Value;
                        celebration.finishing_date = dtp_endDate.Value;
                        var picture = new System.IO.MemoryStream();
                        if (picture_load)
                        {
                            pb_picture.Image.Save(picture, System.Drawing.Imaging.ImageFormat.Jpeg);
                            celebration.picture = picture.GetBuffer();
                        }
                        else
                            celebration.picture = null;

                        db.CELEBRATION.Add(celebration);
                        db.GOAL.Add(goal);
                        db.SaveChanges();
                        MessageBox.Show("Data saved successfully");
                    }
                    else
                    {
                        //SAVE EDITED DATA
                        CELEBRATION edit = db.CELEBRATION.Find(selection);
                        edit.title = txt_title.Text;
                        edit.attendance = Convert.ToInt32(txt_numberAttendees.Text);
                        edit.beginning_date = dtp_startDate.Value;
                        edit.finishing_date = dtp_endDate.Value;
                        var picture = new System.IO.MemoryStream();
                        if (picture_load)
                        {
                            pb_picture.Image.Save(picture, System.Drawing.Imaging.ImageFormat.Jpeg);
                            edit.picture = picture.GetBuffer();
                        }
                        else
                            edit.picture = null;

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
        
        private void edit_data(int id)
        {
            unlock_controllers();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    var lst = db.CELEBRATION.Where(p => p.id == id).ToList();
                    if (lst.Count > 0)
                    {
                        foreach (CELEBRATION celebration in lst)
                        {
                            txt_title.Text = celebration.title.ToString();
                            txt_objectives.Enabled = false;
                            txt_objectives.Text = "Can't add or edit the objectives";
                            txt_numberAttendees.Text = celebration.attendance.ToString();
                            dtp_startDate.Value = Convert.ToDateTime(celebration.beginning_date);
                            dtp_endDate.Value = Convert.ToDateTime(celebration.finishing_date);
                            //GET PICTURE
                            if (celebration.picture != null)
                            {
                                System.IO.MemoryStream picture = new System.IO.MemoryStream(celebration.picture);
                                pb_picture.Image = System.Drawing.Image.FromStream(picture);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void remove_data(int id)
        {
            unlock_controllers();
            try
            {
                using (db_BINAES db = new db_BINAES())
                {
                    db.CELEBRATION.Remove(db.CELEBRATION.Single(p => p.id == id));
                    db.SaveChanges();
                    MessageBox.Show("Data deleted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_grid();
        }


        private void btn_insertRows_Click(object sender, EventArgs e)
        {
            unlock_controllers();
            btn_edit.BackColor = Color.FromArgb(38, 109, 83);
            btn_remove.BackColor = Color.FromArgb(38, 109, 83);
            btn_insertRows.BackColor = Color.FromArgb(38, 109, 83);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                remove_data(selection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_eventsDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_eventsDataTable.Columns[e.ColumnIndex].Name == "id")
            {
                selection = Convert.ToInt32(dg_eventsDataTable.CurrentRow.Cells["id"].Value.ToString());
            }
        }

        private void btn_picture_Click(object sender, EventArgs e)
        {
            var picture = new OpenFileDialog();
            var file = picture.ShowDialog();
            if (file == DialogResult.OK)
            {
                pb_picture.Image = Image.FromFile(picture.FileName);
                picture_load = true;
            }
        }
    }
}