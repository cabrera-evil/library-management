namespace BINAES
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pct_qr = new System.Windows.Forms.PictureBox();
            this.pct_user = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_reserves = new System.Windows.Forms.Button();
            this.btn_loans = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_qr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_user)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.pnl_title.Controls.Add(this.btn_minimize);
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(1167, 40);
            this.pnl_title.TabIndex = 0;
            this.pnl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_title_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = global::BINAES.Properties.Resources.Minimize_Icon;
            this.btn_minimize.Location = new System.Drawing.Point(1117, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_minimize.TabIndex = 21;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::BINAES.Properties.Resources.Close_Icon;
            this.btn_close.Location = new System.Drawing.Point(1139, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_close.TabIndex = 20;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.pnl_menu.Controls.Add(this.pct_qr);
            this.pnl_menu.Controls.Add(this.pct_user);
            this.pnl_menu.Controls.Add(this.label2);
            this.pnl_menu.Controls.Add(this.label1);
            this.pnl_menu.Controls.Add(this.lbl_name);
            this.pnl_menu.Controls.Add(this.btn_logout);
            this.pnl_menu.Controls.Add(this.btn_reserves);
            this.pnl_menu.Controls.Add(this.btn_loans);
            this.pnl_menu.Controls.Add(this.btn_edit);
            this.pnl_menu.Controls.Add(this.btn_search);
            this.pnl_menu.Controls.Add(this.btn_home);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 40);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(240, 678);
            this.pnl_menu.TabIndex = 1;
            // 
            // pct_qr
            // 
            this.pct_qr.Location = new System.Drawing.Point(45, 421);
            this.pct_qr.Name = "pct_qr";
            this.pct_qr.Size = new System.Drawing.Size(150, 144);
            this.pct_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_qr.TabIndex = 0;
            this.pct_qr.TabStop = false;
            // 
            // pct_user
            // 
            this.pct_user.Image = global::BINAES.Properties.Resources.BINAES_LOGO_V2;
            this.pct_user.Location = new System.Drawing.Point(7, 6);
            this.pct_user.Name = "pct_user";
            this.pct_user.Size = new System.Drawing.Size(75, 75);
            this.pct_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_user.TabIndex = 8;
            this.pct_user.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(88, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_name.Location = new System.Drawing.Point(88, 6);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(40, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.LightGray;
            this.btn_logout.Location = new System.Drawing.Point(4, 632);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(230, 45);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_reserves
            // 
            this.btn_reserves.FlatAppearance.BorderSize = 0;
            this.btn_reserves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_reserves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_reserves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserves.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserves.ForeColor = System.Drawing.Color.LightGray;
            this.btn_reserves.Location = new System.Drawing.Point(9, 323);
            this.btn_reserves.Name = "btn_reserves";
            this.btn_reserves.Size = new System.Drawing.Size(230, 45);
            this.btn_reserves.TabIndex = 4;
            this.btn_reserves.Text = "Bookings";
            this.btn_reserves.UseVisualStyleBackColor = true;
            this.btn_reserves.Click += new System.EventHandler(this.btn_reserves_Click);
            // 
            // btn_loans
            // 
            this.btn_loans.FlatAppearance.BorderSize = 0;
            this.btn_loans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_loans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_loans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loans.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loans.ForeColor = System.Drawing.Color.LightGray;
            this.btn_loans.Location = new System.Drawing.Point(9, 272);
            this.btn_loans.Name = "btn_loans";
            this.btn_loans.Size = new System.Drawing.Size(230, 45);
            this.btn_loans.TabIndex = 3;
            this.btn_loans.Text = "Loans";
            this.btn_loans.UseVisualStyleBackColor = true;
            this.btn_loans.Click += new System.EventHandler(this.btn_loans_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.LightGray;
            this.btn_edit.Location = new System.Drawing.Point(8, 170);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(230, 45);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit User";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.LightGray;
            this.btn_search.Location = new System.Drawing.Point(9, 221);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(230, 45);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.LightGray;
            this.btn_home.Location = new System.Drawing.Point(7, 119);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(230, 45);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnl_form
            // 
            this.pnl_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_form.Location = new System.Drawing.Point(240, 40);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(927, 678);
            this.pnl_form.TabIndex = 2;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_home";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BINAES - HOME";
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_qr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_loans;
        private System.Windows.Forms.Button btn_reserves;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pct_user;
        private System.Windows.Forms.PictureBox pct_qr;
    }
}