using System;
using System.Windows.Forms;
using BINAES.UserControls;

namespace BINAES
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_container.Controls.Clear();
            pnl_container.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            /*
            // abrir formulario para prestar
            Form loans = new loans();
            loans.Show();
            */
=======
            UC_Search UC = new UC_Search();
            addUserControl(UC);
>>>>>>> cbfaf574a902eaa0ec23ac1a68c2cc1726f3ccaa
        }

        private void btn_advancedSearch_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            /*
            // abrir formulario para reservar
            Form reservations = new reservations();
            reservations.Show();
            */
=======
            UC_Advanced_Search uc = new UC_Advanced_Search();
            addUserControl(uc);
>>>>>>> cbfaf574a902eaa0ec23ac1a68c2cc1726f3ccaa
        }
    }
}