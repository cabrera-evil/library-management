using System.ComponentModel;

namespace BINAES
{
    partial class booking
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_usersDataTableBar = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_usersDataTable = new System.Windows.Forms.Label();
            this.cmb_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_searchBy = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dgv_bookingDataTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_copy = new System.Windows.Forms.TextBox();
            this.lbl_copy = new System.Windows.Forms.Label();
            this.txt_returnTimeStamp = new System.Windows.Forms.TextBox();
            this.lbl_returnTimeStamp = new System.Windows.Forms.Label();
            this.txt_loanTimeStamp = new System.Windows.Forms.TextBox();
            this.lbl_loanTimeStamp = new System.Windows.Forms.Label();
            this.txt_expectedReturnTimeStamp = new System.Windows.Forms.TextBox();
            this.lbl_expectedReturnTimeStamp = new System.Windows.Forms.Label();
            this.txt_timeStamp = new System.Windows.Forms.TextBox();
            this.lbl_timeStamp = new System.Windows.Forms.Label();
            this.txt_expectedLoanTimeStamp = new System.Windows.Forms.TextBox();
            this.lbl_expectedLoanTimeStamp = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_usersDataTableBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookingDataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_usersDataTableBar
            // 
            this.pnl_usersDataTableBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_usersDataTableBar.Controls.Add(this.btn_filter);
            this.pnl_usersDataTableBar.Controls.Add(this.btn_reset);
            this.pnl_usersDataTableBar.Controls.Add(this.lbl_usersDataTable);
            this.pnl_usersDataTableBar.Controls.Add(this.cmb_searchBy);
            this.pnl_usersDataTableBar.Controls.Add(this.txt_search);
            this.pnl_usersDataTableBar.Controls.Add(this.lbl_searchBy);
            this.pnl_usersDataTableBar.Controls.Add(this.lbl_search);
            this.pnl_usersDataTableBar.Controls.Add(this.btn_edit);
            this.pnl_usersDataTableBar.Controls.Add(this.dgv_bookingDataTable);
            this.pnl_usersDataTableBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_usersDataTableBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_usersDataTableBar.Name = "pnl_usersDataTableBar";
            this.pnl_usersDataTableBar.Size = new System.Drawing.Size(687, 680);
            this.pnl_usersDataTableBar.TabIndex = 26;
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
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(409, 51);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(57, 24);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_usersDataTable
            // 
            this.lbl_usersDataTable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usersDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.lbl_usersDataTable.Location = new System.Drawing.Point(23, 20);
            this.lbl_usersDataTable.Name = "lbl_usersDataTable";
            this.lbl_usersDataTable.Size = new System.Drawing.Size(234, 23);
            this.lbl_usersDataTable.TabIndex = 5;
            this.lbl_usersDataTable.Text = "Booking data table";
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
            this.lbl_searchBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchBy.ForeColor = System.Drawing.Color.White;
            this.lbl_searchBy.Location = new System.Drawing.Point(185, 55);
            this.lbl_searchBy.Name = "lbl_searchBy";
            this.lbl_searchBy.Size = new System.Drawing.Size(100, 23);
            this.lbl_searchBy.TabIndex = 6;
            this.lbl_searchBy.Text = "By:";
            // 
            // lbl_search
            // 
            this.lbl_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.White;
            this.lbl_search.Location = new System.Drawing.Point(23, 55);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 23);
            this.lbl_search.TabIndex = 5;
            this.lbl_search.Text = "Search";
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
            this.btn_edit.Location = new System.Drawing.Point(23, 614);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dgv_bookingDataTable
            // 
            this.dgv_bookingDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_bookingDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_bookingDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bookingDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bookingDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bookingDataTable.ColumnHeadersHeight = 30;
            this.dgv_bookingDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_bookingDataTable.EnableHeadersVisualStyles = false;
            this.dgv_bookingDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgv_bookingDataTable.Location = new System.Drawing.Point(23, 81);
            this.dgv_bookingDataTable.Name = "dgv_bookingDataTable";
            this.dgv_bookingDataTable.ReadOnly = true;
            this.dgv_bookingDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bookingDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bookingDataTable.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_bookingDataTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bookingDataTable.Size = new System.Drawing.Size(640, 527);
            this.dgv_bookingDataTable.TabIndex = 0;
            this.dgv_bookingDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bookingDataTable_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.txt_copy);
            this.panel1.Controls.Add(this.lbl_copy);
            this.panel1.Controls.Add(this.txt_returnTimeStamp);
            this.panel1.Controls.Add(this.lbl_returnTimeStamp);
            this.panel1.Controls.Add(this.txt_loanTimeStamp);
            this.panel1.Controls.Add(this.lbl_loanTimeStamp);
            this.panel1.Controls.Add(this.txt_expectedReturnTimeStamp);
            this.panel1.Controls.Add(this.lbl_expectedReturnTimeStamp);
            this.panel1.Controls.Add(this.txt_timeStamp);
            this.panel1.Controls.Add(this.lbl_timeStamp);
            this.panel1.Controls.Add(this.txt_expectedLoanTimeStamp);
            this.panel1.Controls.Add(this.lbl_expectedLoanTimeStamp);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(687, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 680);
            this.panel1.TabIndex = 106;
            // 
            // txt_user
            // 
            this.txt_user.Enabled = false;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(125, 257);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(204, 23);
            this.txt_user.TabIndex = 111;
            // 
            // lbl_user
            // 
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_user.Location = new System.Drawing.Point(24, 257);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 23);
            this.lbl_user.TabIndex = 110;
            this.lbl_user.Text = "id user";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_copy
            // 
            this.txt_copy.Enabled = false;
            this.txt_copy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_copy.Location = new System.Drawing.Point(125, 286);
            this.txt_copy.Multiline = true;
            this.txt_copy.Name = "txt_copy";
            this.txt_copy.Size = new System.Drawing.Size(204, 23);
            this.txt_copy.TabIndex = 109;
            // 
            // lbl_copy
            // 
            this.lbl_copy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copy.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_copy.Location = new System.Drawing.Point(24, 286);
            this.lbl_copy.Name = "lbl_copy";
            this.lbl_copy.Size = new System.Drawing.Size(100, 23);
            this.lbl_copy.TabIndex = 108;
            this.lbl_copy.Text = "id copy";
            this.lbl_copy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_returnTimeStamp
            // 
            this.txt_returnTimeStamp.Enabled = false;
            this.txt_returnTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_returnTimeStamp.Location = new System.Drawing.Point(125, 219);
            this.txt_returnTimeStamp.Multiline = true;
            this.txt_returnTimeStamp.Name = "txt_returnTimeStamp";
            this.txt_returnTimeStamp.Size = new System.Drawing.Size(204, 23);
            this.txt_returnTimeStamp.TabIndex = 107;
            // 
            // lbl_returnTimeStamp
            // 
            this.lbl_returnTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_returnTimeStamp.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_returnTimeStamp.Location = new System.Drawing.Point(24, 213);
            this.lbl_returnTimeStamp.Name = "lbl_returnTimeStamp";
            this.lbl_returnTimeStamp.Size = new System.Drawing.Size(100, 35);
            this.lbl_returnTimeStamp.TabIndex = 106;
            this.lbl_returnTimeStamp.Text = "Return time stamp";
            this.lbl_returnTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_loanTimeStamp
            // 
            this.txt_loanTimeStamp.Enabled = false;
            this.txt_loanTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loanTimeStamp.Location = new System.Drawing.Point(125, 178);
            this.txt_loanTimeStamp.Multiline = true;
            this.txt_loanTimeStamp.Name = "txt_loanTimeStamp";
            this.txt_loanTimeStamp.Size = new System.Drawing.Size(204, 23);
            this.txt_loanTimeStamp.TabIndex = 105;
            // 
            // lbl_loanTimeStamp
            // 
            this.lbl_loanTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loanTimeStamp.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_loanTimeStamp.Location = new System.Drawing.Point(24, 172);
            this.lbl_loanTimeStamp.Name = "lbl_loanTimeStamp";
            this.lbl_loanTimeStamp.Size = new System.Drawing.Size(100, 39);
            this.lbl_loanTimeStamp.TabIndex = 104;
            this.lbl_loanTimeStamp.Text = "Loan time stamp";
            this.lbl_loanTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_expectedReturnTimeStamp
            // 
            this.txt_expectedReturnTimeStamp.Enabled = false;
            this.txt_expectedReturnTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expectedReturnTimeStamp.Location = new System.Drawing.Point(125, 128);
            this.txt_expectedReturnTimeStamp.Multiline = true;
            this.txt_expectedReturnTimeStamp.Name = "txt_expectedReturnTimeStamp";
            this.txt_expectedReturnTimeStamp.Size = new System.Drawing.Size(204, 23);
            this.txt_expectedReturnTimeStamp.TabIndex = 103;
            // 
            // lbl_expectedReturnTimeStamp
            // 
            this.lbl_expectedReturnTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expectedReturnTimeStamp.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_expectedReturnTimeStamp.Location = new System.Drawing.Point(24, 109);
            this.lbl_expectedReturnTimeStamp.Name = "lbl_expectedReturnTimeStamp";
            this.lbl_expectedReturnTimeStamp.Size = new System.Drawing.Size(100, 60);
            this.lbl_expectedReturnTimeStamp.TabIndex = 102;
            this.lbl_expectedReturnTimeStamp.Text = "Expected return time stamp\r\n";
            this.lbl_expectedReturnTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_timeStamp
            // 
            this.txt_timeStamp.Enabled = false;
            this.txt_timeStamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timeStamp.Location = new System.Drawing.Point(125, 20);
            this.txt_timeStamp.Multiline = true;
            this.txt_timeStamp.Name = "txt_timeStamp";
            this.txt_timeStamp.ReadOnly = true;
            this.txt_timeStamp.Size = new System.Drawing.Size(204, 23);
            this.txt_timeStamp.TabIndex = 90;
            // 
            // lbl_timeStamp
            // 
            this.lbl_timeStamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeStamp.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_timeStamp.Location = new System.Drawing.Point(24, 20);
            this.lbl_timeStamp.Name = "lbl_timeStamp";
            this.lbl_timeStamp.Size = new System.Drawing.Size(100, 23);
            this.lbl_timeStamp.TabIndex = 52;
            this.lbl_timeStamp.Text = "Time stamp";
            this.lbl_timeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_expectedLoanTimeStamp
            // 
            this.txt_expectedLoanTimeStamp.Enabled = false;
            this.txt_expectedLoanTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expectedLoanTimeStamp.Location = new System.Drawing.Point(125, 68);
            this.txt_expectedLoanTimeStamp.Multiline = true;
            this.txt_expectedLoanTimeStamp.Name = "txt_expectedLoanTimeStamp";
            this.txt_expectedLoanTimeStamp.Size = new System.Drawing.Size(204, 23);
            this.txt_expectedLoanTimeStamp.TabIndex = 91;
            // 
            // lbl_expectedLoanTimeStamp
            // 
            this.lbl_expectedLoanTimeStamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expectedLoanTimeStamp.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_expectedLoanTimeStamp.Location = new System.Drawing.Point(24, 49);
            this.lbl_expectedLoanTimeStamp.Name = "lbl_expectedLoanTimeStamp";
            this.lbl_expectedLoanTimeStamp.Size = new System.Drawing.Size(100, 60);
            this.lbl_expectedLoanTimeStamp.TabIndex = 38;
            this.lbl_expectedLoanTimeStamp.Text = "Expected loan time stamp";
            this.lbl_expectedLoanTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_cancel.Location = new System.Drawing.Point(24, 376);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(305, 45);
            this.btn_cancel.TabIndex = 101;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btn_save.Location = new System.Drawing.Point(24, 325);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(305, 45);
            this.btn_save.TabIndex = 100;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1040, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_usersDataTableBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_booking";
            this.Text = "frm_booking";
            this.Load += new System.EventHandler(this.frm_booking_Load);
            this.pnl_usersDataTableBar.ResumeLayout(false);
            this.pnl_usersDataTableBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookingDataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox txt_copy;
        private System.Windows.Forms.Label lbl_copy;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_user;

        private System.Windows.Forms.TextBox txt_expectedReturnTimeStamp;
        private System.Windows.Forms.Label lbl_expectedReturnTimeStamp;
        private System.Windows.Forms.TextBox txt_timeStamp;
        private System.Windows.Forms.Label lbl_timeStamp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_expectedLoanTimeStamp;
        private System.Windows.Forms.Label lbl_expectedLoanTimeStamp;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_loanTimeStamp;
        private System.Windows.Forms.Label lbl_loanTimeStamp;
        private System.Windows.Forms.TextBox txt_returnTimeStamp;
        private System.Windows.Forms.Label lbl_returnTimeStamp;

        private System.Windows.Forms.Panel pnl_usersDataTableBar;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_usersDataTable;
        private System.Windows.Forms.ComboBox cmb_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_searchBy;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dgv_bookingDataTable;

        #endregion
    }
}