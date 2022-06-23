﻿using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Users
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_userDataBar = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.lbl_roll = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.cmb_institution = new System.Windows.Forms.ComboBox();
            this.lbl_institution = new System.Windows.Forms.Label();
            this.cmb_occupancy = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_occupation = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_addUser = new System.Windows.Forms.Label();
            this.lbl_usersDataTable = new System.Windows.Forms.Label();
            this.pnl_usersDataTableBar = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cmb_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_searchBy = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_insertRows = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dg_usersDataTable = new System.Windows.Forms.DataGridView();
            this.pnl_userDataBar.SuspendLayout();
            this.pnl_usersDataTableBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dg_usersDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_userDataBar
            // 
            this.pnl_userDataBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (42)))), ((int) (((byte) (42)))));
            this.pnl_userDataBar.Controls.Add(this.btn_cancel);
            this.pnl_userDataBar.Controls.Add(this.cmb_role);
            this.pnl_userDataBar.Controls.Add(this.lbl_roll);
            this.pnl_userDataBar.Controls.Add(this.txt_email);
            this.pnl_userDataBar.Controls.Add(this.lbl_email);
            this.pnl_userDataBar.Controls.Add(this.txt_password);
            this.pnl_userDataBar.Controls.Add(this.lbl_password);
            this.pnl_userDataBar.Controls.Add(this.txt_phone);
            this.pnl_userDataBar.Controls.Add(this.lbl_phoneNumber);
            this.pnl_userDataBar.Controls.Add(this.cmb_institution);
            this.pnl_userDataBar.Controls.Add(this.lbl_institution);
            this.pnl_userDataBar.Controls.Add(this.cmb_occupancy);
            this.pnl_userDataBar.Controls.Add(this.txt_address);
            this.pnl_userDataBar.Controls.Add(this.lbl_address);
            this.pnl_userDataBar.Controls.Add(this.lbl_occupation);
            this.pnl_userDataBar.Controls.Add(this.txt_name);
            this.pnl_userDataBar.Controls.Add(this.lbl_name);
            this.pnl_userDataBar.Controls.Add(this.btn_save);
            this.pnl_userDataBar.Controls.Add(this.lbl_addUser);
            this.pnl_userDataBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_userDataBar.Location = new System.Drawing.Point(685, 0);
            this.pnl_userDataBar.Name = "pnl_userDataBar";
            this.pnl_userDataBar.Size = new System.Drawing.Size(355, 611);
            this.pnl_userDataBar.TabIndex = 25;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(24, 358);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(305, 45);
            this.btn_cancel.TabIndex = 30;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // cmb_role
            // 
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.Enabled = false;
            this.cmb_role.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(125, 268);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(204, 25);
            this.cmb_role.TabIndex = 7;
            // 
            // lbl_roll
            // 
            this.lbl_roll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_roll.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_roll.Location = new System.Drawing.Point(24, 268);
            this.lbl_roll.Name = "lbl_roll";
            this.lbl_roll.Size = new System.Drawing.Size(100, 23);
            this.lbl_roll.TabIndex = 29;
            this.lbl_roll.Text = "Role";
            this.lbl_roll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_email.Location = new System.Drawing.Point(125, 148);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(204, 23);
            this.txt_email.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_email.Location = new System.Drawing.Point(24, 148);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(100, 23);
            this.lbl_email.TabIndex = 27;
            this.lbl_email.Text = "Email";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_password.Location = new System.Drawing.Point(125, 177);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(204, 23);
            this.txt_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_password.Location = new System.Drawing.Point(24, 177);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(100, 23);
            this.lbl_password.TabIndex = 25;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_phone
            // 
            this.txt_phone.Enabled = false;
            this.txt_phone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_phone.Location = new System.Drawing.Point(125, 119);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(204, 23);
            this.txt_phone.TabIndex = 2;
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_phoneNumber.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(24, 111);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(100, 38);
            this.lbl_phoneNumber.TabIndex = 23;
            this.lbl_phoneNumber.Text = "Phone";
            this.lbl_phoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_institution
            // 
            this.cmb_institution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_institution.Enabled = false;
            this.cmb_institution.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmb_institution.FormattingEnabled = true;
            this.cmb_institution.Location = new System.Drawing.Point(125, 237);
            this.cmb_institution.Name = "cmb_institution";
            this.cmb_institution.Size = new System.Drawing.Size(204, 25);
            this.cmb_institution.TabIndex = 6;
            // 
            // lbl_institution
            // 
            this.lbl_institution.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_institution.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_institution.Location = new System.Drawing.Point(24, 237);
            this.lbl_institution.Name = "lbl_institution";
            this.lbl_institution.Size = new System.Drawing.Size(100, 23);
            this.lbl_institution.TabIndex = 21;
            this.lbl_institution.Text = "Institution";
            this.lbl_institution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_occupancy
            // 
            this.cmb_occupancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_occupancy.Enabled = false;
            this.cmb_occupancy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmb_occupancy.FormattingEnabled = true;
            this.cmb_occupancy.Location = new System.Drawing.Point(125, 206);
            this.cmb_occupancy.Name = "cmb_occupancy";
            this.cmb_occupancy.Size = new System.Drawing.Size(204, 25);
            this.cmb_occupancy.TabIndex = 5;
            // 
            // txt_address
            // 
            this.txt_address.Enabled = false;
            this.txt_address.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_address.Location = new System.Drawing.Point(125, 90);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(204, 23);
            this.txt_address.TabIndex = 1;
            // 
            // lbl_address
            // 
            this.lbl_address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_address.Location = new System.Drawing.Point(24, 90);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(100, 23);
            this.lbl_address.TabIndex = 6;
            this.lbl_address.Text = "Direction";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_occupation
            // 
            this.lbl_occupation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_occupation.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_occupation.Location = new System.Drawing.Point(24, 206);
            this.lbl_occupation.Name = "lbl_occupation";
            this.lbl_occupation.Size = new System.Drawing.Size(100, 23);
            this.lbl_occupation.TabIndex = 4;
            this.lbl_occupation.Text = "Occupancy";
            this.lbl_occupation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_name.Location = new System.Drawing.Point(125, 61);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(204, 23);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(24, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 23);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(24, 307);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(305, 45);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.lbl_addUser.Location = new System.Drawing.Point(24, 20);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(321, 23);
            this.lbl_addUser.TabIndex = 0;
            this.lbl_addUser.Text = "Add user";
            // 
            // lbl_usersDataTable
            // 
            this.lbl_usersDataTable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_usersDataTable.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.lbl_usersDataTable.Location = new System.Drawing.Point(23, 20);
            this.lbl_usersDataTable.Name = "lbl_usersDataTable";
            this.lbl_usersDataTable.Size = new System.Drawing.Size(234, 23);
            this.lbl_usersDataTable.TabIndex = 5;
            this.lbl_usersDataTable.Text = "Users data table";
            // 
            // pnl_usersDataTableBar
            // 
            this.pnl_usersDataTableBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.pnl_usersDataTableBar.Controls.Add(this.btn_filter);
            this.pnl_usersDataTableBar.Controls.Add(this.btn_reset);
            this.pnl_usersDataTableBar.Controls.Add(this.lbl_usersDataTable);
            this.pnl_usersDataTableBar.Controls.Add(this.cmb_searchBy);
            this.pnl_usersDataTableBar.Controls.Add(this.txt_search);
            this.pnl_usersDataTableBar.Controls.Add(this.lbl_searchBy);
            this.pnl_usersDataTableBar.Controls.Add(this.lbl_search);
            this.pnl_usersDataTableBar.Controls.Add(this.btn_insertRows);
            this.pnl_usersDataTableBar.Controls.Add(this.btn_remove);
            this.pnl_usersDataTableBar.Controls.Add(this.btn_edit);
            this.pnl_usersDataTableBar.Controls.Add(this.dg_usersDataTable);
            this.pnl_usersDataTableBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_usersDataTableBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_usersDataTableBar.Name = "pnl_usersDataTableBar";
            this.pnl_usersDataTableBar.Size = new System.Drawing.Size(687, 611);
            this.pnl_usersDataTableBar.TabIndex = 24;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_filter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filter.Location = new System.Drawing.Point(343, 51);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(60, 24);
            this.btn_filter.TabIndex = 10;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(409, 51);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(57, 24);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cmb_searchBy
            // 
            this.cmb_searchBy.FormattingEnabled = true;
            this.cmb_searchBy.Location = new System.Drawing.Point(216, 53);
            this.cmb_searchBy.Name = "cmb_searchBy";
            this.cmb_searchBy.Size = new System.Drawing.Size(121, 21);
            this.cmb_searchBy.TabIndex = 8;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(79, 54);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 7;
            // 
            // lbl_searchBy
            // 
            this.lbl_searchBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_searchBy.ForeColor = System.Drawing.Color.White;
            this.lbl_searchBy.Location = new System.Drawing.Point(185, 55);
            this.lbl_searchBy.Name = "lbl_searchBy";
            this.lbl_searchBy.Size = new System.Drawing.Size(100, 23);
            this.lbl_searchBy.TabIndex = 6;
            this.lbl_searchBy.Text = "By:";
            // 
            // lbl_search
            // 
            this.lbl_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_search.ForeColor = System.Drawing.Color.White;
            this.lbl_search.Location = new System.Drawing.Point(23, 55);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 23);
            this.lbl_search.TabIndex = 5;
            this.lbl_search.Text = "Search";
            // 
            // btn_insertRows
            // 
            this.btn_insertRows.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_insertRows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_insertRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_insertRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_insertRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertRows.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_insertRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insertRows.Location = new System.Drawing.Point(486, 548);
            this.btn_insertRows.Name = "btn_insertRows";
            this.btn_insertRows.Size = new System.Drawing.Size(157, 34);
            this.btn_insertRows.TabIndex = 4;
            this.btn_insertRows.Text = "Insert rows";
            this.btn_insertRows.UseVisualStyleBackColor = false;
            this.btn_insertRows.Click += new System.EventHandler(this.btn_insertRows_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(131, 548);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(102, 34);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(23, 548);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // dg_usersDataTable
            // 
            this.dg_usersDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_usersDataTable.Location = new System.Drawing.Point(23, 81);
            this.dg_usersDataTable.Name = "dg_usersDataTable";
            this.dg_usersDataTable.ReadOnly = true;
            this.dg_usersDataTable.Size = new System.Drawing.Size(620, 461);
            this.dg_usersDataTable.TabIndex = 0;
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnl_userDataBar);
            this.Controls.Add(this.pnl_usersDataTableBar);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1040, 611);
            this.Load += new System.EventHandler(this.UC_Users_Load);
            this.pnl_userDataBar.ResumeLayout(false);
            this.pnl_userDataBar.PerformLayout();
            this.pnl_usersDataTableBar.ResumeLayout(false);
            this.pnl_usersDataTableBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dg_usersDataTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_filter;

        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_searchBy;

        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.Panel pnl_userDataBar;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label lbl_roll;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.ComboBox cmb_institution;
        private System.Windows.Forms.Label lbl_institution;
        private System.Windows.Forms.ComboBox cmb_occupancy;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_occupation;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.Panel pnl_usersDataTableBar;
        private System.Windows.Forms.Label lbl_usersDataTable;
        private System.Windows.Forms.Button btn_insertRows;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dg_usersDataTable;

        #endregion
    }
}