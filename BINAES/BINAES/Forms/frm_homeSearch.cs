﻿using System;
using System.Windows.Forms;
using BINAES.UserControls;

namespace BINAES
{
    public partial class frm_homeSearch : Form
    {
        public frm_homeSearch()
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
            UC_Search UC = new UC_Search();
            addUserControl(UC);
        }

        private void btn_advancedSearch_Click(object sender, EventArgs e)
        {
            UC_Advanced_Search uc = new UC_Advanced_Search();
            addUserControl(uc);
        }
    }
}