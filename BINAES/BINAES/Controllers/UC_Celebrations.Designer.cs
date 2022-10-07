using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Celebrations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_eventsDataBar = new System.Windows.Forms.Panel();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.btn_picture = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grp_eventDate = new System.Windows.Forms.GroupBox();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.txt_numberAttendees = new System.Windows.Forms.TextBox();
            this.lbl_numberAttendees = new System.Windows.Forms.Label();
            this.txt_objectives = new System.Windows.Forms.TextBox();
            this.lbl_objectives = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_eventsDataTableBar = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cmb_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_searchBy = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_eventTableData = new System.Windows.Forms.Label();
            this.btn_insertRows = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dg_eventsDataTable = new System.Windows.Forms.DataGridView();
            this.pnl_eventsDataBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.grp_eventDate.SuspendLayout();
            this.pnl_eventsDataTableBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_eventsDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_eventsDataBar
            // 
            this.pnl_eventsDataBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnl_eventsDataBar.Controls.Add(this.pb_picture);
            this.pnl_eventsDataBar.Controls.Add(this.btn_picture);
            this.pnl_eventsDataBar.Controls.Add(this.btn_cancel);
            this.pnl_eventsDataBar.Controls.Add(this.grp_eventDate);
            this.pnl_eventsDataBar.Controls.Add(this.txt_numberAttendees);
            this.pnl_eventsDataBar.Controls.Add(this.lbl_numberAttendees);
            this.pnl_eventsDataBar.Controls.Add(this.txt_objectives);
            this.pnl_eventsDataBar.Controls.Add(this.lbl_objectives);
            this.pnl_eventsDataBar.Controls.Add(this.txt_title);
            this.pnl_eventsDataBar.Controls.Add(this.lbl_title);
            this.pnl_eventsDataBar.Controls.Add(this.btn_save);
            this.pnl_eventsDataBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_eventsDataBar.Location = new System.Drawing.Point(687, 0);
            this.pnl_eventsDataBar.Name = "pnl_eventsDataBar";
            this.pnl_eventsDataBar.Size = new System.Drawing.Size(353, 611);
            this.pnl_eventsDataBar.TabIndex = 23;
            // 
            // pb_picture
            // 
            this.pb_picture.Location = new System.Drawing.Point(19, 221);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(309, 211);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_picture.TabIndex = 100;
            this.pb_picture.TabStop = false;
            // 
            // btn_picture
            // 
            this.btn_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_picture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_picture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_picture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_picture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_picture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_picture.Location = new System.Drawing.Point(19, 438);
            this.btn_picture.Name = "btn_picture";
            this.btn_picture.Size = new System.Drawing.Size(305, 45);
            this.btn_picture.TabIndex = 101;
            this.btn_picture.Text = "Select Picture";
            this.btn_picture.UseVisualStyleBackColor = false;
            this.btn_picture.Click += new System.EventHandler(this.btn_picture_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(19, 540);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(305, 45);
            this.btn_cancel.TabIndex = 97;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // grp_eventDate
            // 
            this.grp_eventDate.Controls.Add(this.dtp_endDate);
            this.grp_eventDate.Controls.Add(this.lbl_endDate);
            this.grp_eventDate.Controls.Add(this.dtp_startDate);
            this.grp_eventDate.Controls.Add(this.lbl_startDate);
            this.grp_eventDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_eventDate.ForeColor = System.Drawing.Color.White;
            this.grp_eventDate.Location = new System.Drawing.Point(19, 118);
            this.grp_eventDate.Name = "grp_eventDate";
            this.grp_eventDate.Size = new System.Drawing.Size(309, 97);
            this.grp_eventDate.TabIndex = 95;
            this.grp_eventDate.TabStop = false;
            this.grp_eventDate.Text = "Event date";
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endDate.Location = new System.Drawing.Point(204, 41);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(90, 22);
            this.dtp_endDate.TabIndex = 15;
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.Location = new System.Drawing.Point(169, 39);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(38, 23);
            this.lbl_endDate.TabIndex = 3;
            this.lbl_endDate.Text = "End:";
            this.lbl_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startDate.Location = new System.Drawing.Point(54, 42);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(90, 22);
            this.dtp_startDate.TabIndex = 14;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.Location = new System.Drawing.Point(15, 41);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(42, 23);
            this.lbl_startDate.TabIndex = 2;
            this.lbl_startDate.Text = "Start:";
            this.lbl_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_numberAttendees
            // 
            this.txt_numberAttendees.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberAttendees.Location = new System.Drawing.Point(124, 77);
            this.txt_numberAttendees.Multiline = true;
            this.txt_numberAttendees.Name = "txt_numberAttendees";
            this.txt_numberAttendees.Size = new System.Drawing.Size(204, 23);
            this.txt_numberAttendees.TabIndex = 93;
            // 
            // lbl_numberAttendees
            // 
            this.lbl_numberAttendees.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numberAttendees.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_numberAttendees.Location = new System.Drawing.Point(23, 71);
            this.lbl_numberAttendees.Name = "lbl_numberAttendees";
            this.lbl_numberAttendees.Size = new System.Drawing.Size(100, 35);
            this.lbl_numberAttendees.TabIndex = 6;
            this.lbl_numberAttendees.Text = "Number of attendees";
            this.lbl_numberAttendees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_objectives
            // 
            this.txt_objectives.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_objectives.Location = new System.Drawing.Point(124, 48);
            this.txt_objectives.Multiline = true;
            this.txt_objectives.Name = "txt_objectives";
            this.txt_objectives.Size = new System.Drawing.Size(204, 23);
            this.txt_objectives.TabIndex = 92;
            // 
            // lbl_objectives
            // 
            this.lbl_objectives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objectives.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_objectives.Location = new System.Drawing.Point(23, 48);
            this.lbl_objectives.Name = "lbl_objectives";
            this.lbl_objectives.Size = new System.Drawing.Size(100, 23);
            this.lbl_objectives.TabIndex = 4;
            this.lbl_objectives.Text = "Objectives";
            this.lbl_objectives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(124, 19);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(204, 23);
            this.txt_title.TabIndex = 90;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_title.Location = new System.Drawing.Point(23, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(100, 23);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(19, 489);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(305, 45);
            this.btn_save.TabIndex = 96;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_eventsDataTableBar
            // 
            this.pnl_eventsDataTableBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_filter);
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_reset);
            this.pnl_eventsDataTableBar.Controls.Add(this.cmb_searchBy);
            this.pnl_eventsDataTableBar.Controls.Add(this.txt_search);
            this.pnl_eventsDataTableBar.Controls.Add(this.lbl_searchBy);
            this.pnl_eventsDataTableBar.Controls.Add(this.lbl_search);
            this.pnl_eventsDataTableBar.Controls.Add(this.lbl_eventTableData);
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_insertRows);
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_remove);
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_edit);
            this.pnl_eventsDataTableBar.Controls.Add(this.dg_eventsDataTable);
            this.pnl_eventsDataTableBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_eventsDataTableBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_eventsDataTableBar.Name = "pnl_eventsDataTableBar";
            this.pnl_eventsDataTableBar.Size = new System.Drawing.Size(688, 611);
            this.pnl_eventsDataTableBar.TabIndex = 22;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_filter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filter.Location = new System.Drawing.Point(342, 52);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(60, 24);
            this.btn_filter.TabIndex = 19;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(408, 52);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(57, 24);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cmb_searchBy
            // 
            this.cmb_searchBy.FormattingEnabled = true;
            this.cmb_searchBy.Location = new System.Drawing.Point(215, 54);
            this.cmb_searchBy.Name = "cmb_searchBy";
            this.cmb_searchBy.Size = new System.Drawing.Size(121, 21);
            this.cmb_searchBy.TabIndex = 17;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(78, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 16;
            // 
            // lbl_searchBy
            // 
            this.lbl_searchBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchBy.ForeColor = System.Drawing.Color.White;
            this.lbl_searchBy.Location = new System.Drawing.Point(184, 56);
            this.lbl_searchBy.Name = "lbl_searchBy";
            this.lbl_searchBy.Size = new System.Drawing.Size(100, 23);
            this.lbl_searchBy.TabIndex = 15;
            this.lbl_searchBy.Text = "By:";
            // 
            // lbl_search
            // 
            this.lbl_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.White;
            this.lbl_search.Location = new System.Drawing.Point(22, 56);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 23);
            this.lbl_search.TabIndex = 14;
            this.lbl_search.Text = "Search";
            // 
            // lbl_eventTableData
            // 
            this.lbl_eventTableData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventTableData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.lbl_eventTableData.Location = new System.Drawing.Point(23, 20);
            this.lbl_eventTableData.Name = "lbl_eventTableData";
            this.lbl_eventTableData.Size = new System.Drawing.Size(277, 23);
            this.lbl_eventTableData.TabIndex = 12;
            this.lbl_eventTableData.Text = "Celebrations data table";
            // 
            // btn_insertRows
            // 
            this.btn_insertRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_insertRows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_insertRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_insertRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_insertRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertRows.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insertRows.Location = new System.Drawing.Point(506, 548);
            this.btn_insertRows.Name = "btn_insertRows";
            this.btn_insertRows.Size = new System.Drawing.Size(157, 34);
            this.btn_insertRows.TabIndex = 4;
            this.btn_insertRows.Text = "Insert rows";
            this.btn_insertRows.UseVisualStyleBackColor = false;
            this.btn_insertRows.Click += new System.EventHandler(this.btn_insertRows_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(131, 549);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(102, 34);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(23, 549);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dg_eventsDataTable
            // 
            this.dg_eventsDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_eventsDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_eventsDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_eventsDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_eventsDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_eventsDataTable.ColumnHeadersHeight = 30;
            this.dg_eventsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_eventsDataTable.EnableHeadersVisualStyles = false;
            this.dg_eventsDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dg_eventsDataTable.Location = new System.Drawing.Point(23, 81);
            this.dg_eventsDataTable.Name = "dg_eventsDataTable";
            this.dg_eventsDataTable.ReadOnly = true;
            this.dg_eventsDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_eventsDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_eventsDataTable.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dg_eventsDataTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_eventsDataTable.Size = new System.Drawing.Size(640, 461);
            this.dg_eventsDataTable.TabIndex = 13;
            this.dg_eventsDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_eventsDataTable_CellClick);
            // 
            // UC_Celebrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnl_eventsDataBar);
            this.Controls.Add(this.pnl_eventsDataTableBar);
            this.Name = "UC_Celebrations";
            this.Size = new System.Drawing.Size(1040, 611);
            this.Load += new System.EventHandler(this.UC_Celebrations_Load);
            this.pnl_eventsDataBar.ResumeLayout(false);
            this.pnl_eventsDataBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.grp_eventDate.ResumeLayout(false);
            this.pnl_eventsDataTableBar.ResumeLayout(false);
            this.pnl_eventsDataTableBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_eventsDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox cmb_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_searchBy;
        private System.Windows.Forms.Label lbl_search;

        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.Panel pnl_eventsDataBar;
        private System.Windows.Forms.GroupBox grp_eventDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.TextBox txt_numberAttendees;
        private System.Windows.Forms.Label lbl_numberAttendees;
        private System.Windows.Forms.TextBox txt_objectives;
        private System.Windows.Forms.Label lbl_objectives;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_eventsDataTableBar;
        private System.Windows.Forms.Label lbl_eventTableData;
        private System.Windows.Forms.Button btn_insertRows;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dg_eventsDataTable;

        #endregion

        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Button btn_picture;
    }
}