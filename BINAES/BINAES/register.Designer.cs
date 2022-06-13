namespace BINAES
{
    partial class frm_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_register));
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.cmb_occupation = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_addres = new System.Windows.Forms.TextBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.lnk_login = new System.Windows.Forms.LinkLabel();
            this.lbl_register = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.cmb_institution = new System.Windows.Forms.ComboBox();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.LightGray;
            this.txt_password.Location = new System.Drawing.Point(276, 295);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(480, 20);
            this.txt_password.TabIndex = 15;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_left.Controls.Add(this.pct_logo);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(250, 543);
            this.pnl_left.TabIndex = 12;
            // 
            // pct_logo
            // 
            this.pct_logo.Image = global::BINAES.Properties.Resources.BINAES_LOGO;
            this.pct_logo.Location = new System.Drawing.Point(0, 0);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(250, 543);
            this.pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_logo.TabIndex = 8;
            this.pct_logo.TabStop = false;
            this.pct_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pct_logo_MouseDown);
            // 
            // cmb_occupation
            // 
            this.cmb_occupation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmb_occupation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_occupation.ForeColor = System.Drawing.Color.LightGray;
            this.cmb_occupation.FormattingEnabled = true;
            this.cmb_occupation.Location = new System.Drawing.Point(276, 340);
            this.cmb_occupation.Name = "cmb_occupation";
            this.cmb_occupation.Size = new System.Drawing.Size(480, 29);
            this.cmb_occupation.TabIndex = 23;
            this.cmb_occupation.Text = "Occupation";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.LightGray;
            this.txt_email.Location = new System.Drawing.Point(276, 248);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(480, 20);
            this.txt_email.TabIndex = 22;
            this.txt_email.Text = "Email";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.LightGray;
            this.txt_phone.Location = new System.Drawing.Point(276, 201);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(480, 20);
            this.txt_phone.TabIndex = 21;
            this.txt_phone.Text = "Phone";
            this.txt_phone.Enter += new System.EventHandler(this.txt_phone_Enter);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // txt_addres
            // 
            this.txt_addres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_addres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_addres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addres.ForeColor = System.Drawing.Color.LightGray;
            this.txt_addres.Location = new System.Drawing.Point(276, 152);
            this.txt_addres.Name = "txt_addres";
            this.txt_addres.Size = new System.Drawing.Size(480, 20);
            this.txt_addres.TabIndex = 20;
            this.txt_addres.Text = "Addres";
            this.txt_addres.Enter += new System.EventHandler(this.txt_addres_Enter);
            this.txt_addres.Leave += new System.EventHandler(this.txt_addres_Leave);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = global::BINAES.Properties.Resources.Minimize_Icon;
            this.btn_minimize.Location = new System.Drawing.Point(736, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(16, 16);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_minimize.TabIndex = 19;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::BINAES.Properties.Resources.Close_Icon;
            this.btn_close.Location = new System.Drawing.Point(758, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_close.TabIndex = 18;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lnk_login
            // 
            this.lnk_login.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lnk_login.AutoSize = true;
            this.lnk_login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_login.LinkColor = System.Drawing.Color.LightGray;
            this.lnk_login.Location = new System.Drawing.Point(439, 502);
            this.lnk_login.Name = "lnk_login";
            this.lnk_login.Size = new System.Drawing.Size(160, 17);
            this.lnk_login.TabIndex = 13;
            this.lnk_login.TabStop = true;
            this.lnk_login.Text = "Already have an account";
            this.lnk_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_login_LinkClicked);
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_register.Location = new System.Drawing.Point(480, 25);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(83, 21);
            this.lbl_register.TabIndex = 17;
            this.lbl_register.Text = "REGISTER";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.ForeColor = System.Drawing.Color.LightGray;
            this.btn_register.Location = new System.Drawing.Point(276, 446);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(480, 40);
            this.btn_register.TabIndex = 16;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.LightGray;
            this.txt_user.Location = new System.Drawing.Point(276, 110);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(480, 20);
            this.txt_user.TabIndex = 14;
            this.txt_user.Text = "User";
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // cmb_institution
            // 
            this.cmb_institution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmb_institution.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_institution.ForeColor = System.Drawing.Color.LightGray;
            this.cmb_institution.FormattingEnabled = true;
            this.cmb_institution.Location = new System.Drawing.Point(276, 389);
            this.cmb_institution.Name = "cmb_institution";
            this.cmb_institution.Size = new System.Drawing.Size(480, 29);
            this.cmb_institution.TabIndex = 24;
            this.cmb_institution.Text = "Institution";
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 543);
            this.Controls.Add(this.cmb_institution);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.cmb_occupation);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_addres);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lnk_login);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_register";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES - REGISTER";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_register_MouseDown);
            this.pnl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.ComboBox cmb_occupation;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_addres;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.LinkLabel lnk_login;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.ComboBox cmb_institution;
    }
}