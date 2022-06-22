using System;
using System.Windows.Forms;
using BINAES.SQL_Server;

namespace BINAES
{
    public partial class frm_events : Form
    {
        public frm_events()
        {
            InitializeComponent();
        }

        private void dtp_endDate_ValueChanged(object sender, EventArgs e)
        {
            
        }


        private void dtp_startTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (db_BINAES db = new db_BINAES())
            {
                CELEBRATION celebration = new CELEBRATION();
                celebration.title = txt_title.Text;
                //falta el de objetivos
                //Falta la imagen
                celebration.attendance = Convert.ToInt32(txt_numberAttendees.Text);
                celebration.beginning_hour = Convert.ToDateTime(dtp_startTime.Format == DateTimePickerFormat.Time);
                celebration.finishing_hour = Convert.ToDateTime(dtp_endTime.Format == DateTimePickerFormat.Time);
                celebration.beginning_date = Convert.ToDateTime(dtp_startDate.Format == DateTimePickerFormat.Short);
                celebration.finishing_date = Convert.ToDateTime(dtp_endDate.Format == DateTimePickerFormat.Short);
                
                db.CELEBRATION.Add(celebration);
                db.SaveChanges();
                
                /*if (add)
                {
                    db.USER_.Add(collection);
                    db.SaveChanges();
                }
                if (edit)
                {
                    db.Entry(collection).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }*/
            }
            //load_grid();

        }
    }
}