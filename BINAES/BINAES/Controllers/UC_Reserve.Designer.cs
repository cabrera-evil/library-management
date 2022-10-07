using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Reserve
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
            this.components = new System.ComponentModel.Container();
            this.lbl_expected_loan = new System.Windows.Forms.Label();
            this.lblregisterLoans = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.grbDateTimeLoans = new System.Windows.Forms.GroupBox();
            this.dtp_expected_loan_timestamp = new System.Windows.Forms.DateTimePicker();
            this.btn_get = new System.Windows.Forms.Button();
            this.txt_timestamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateLoans = new System.Windows.Forms.Label();
            this.lblUserLoans = new System.Windows.Forms.Label();
            this.tmr_reservation = new System.Windows.Forms.Timer(this.components);
            this.grbDateTimeLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_expected_loan
            // 
            this.lbl_expected_loan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expected_loan.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_expected_loan.Location = new System.Drawing.Point(4, 66);
            this.lbl_expected_loan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_expected_loan.Name = "lbl_expected_loan";
            this.lbl_expected_loan.Size = new System.Drawing.Size(135, 19);
            this.lbl_expected_loan.TabIndex = 8;
            this.lbl_expected_loan.Text = "Expected Loan:";
            // 
            // lblregisterLoans
            // 
            this.lblregisterLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregisterLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblregisterLoans.Location = new System.Drawing.Point(443, 150);
            this.lblregisterLoans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblregisterLoans.Name = "lblregisterLoans";
            this.lblregisterLoans.Size = new System.Drawing.Size(143, 19);
            this.lblregisterLoans.TabIndex = 22;
            this.lblregisterLoans.Text = "REGISTER OF LOANS:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(548, 418);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 32);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.Location = new System.Drawing.Point(382, 418);
            this.btn_accept.Margin = new System.Windows.Forms.Padding(2);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(100, 32);
            this.btn_accept.TabIndex = 25;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.LightGray;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(382, 200);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(357, 22);
            this.txt_username.TabIndex = 27;
            // 
            // grbDateTimeLoans
            // 
            this.grbDateTimeLoans.Controls.Add(this.dtp_expected_loan_timestamp);
            this.grbDateTimeLoans.Controls.Add(this.btn_get);
            this.grbDateTimeLoans.Controls.Add(this.txt_timestamp);
            this.grbDateTimeLoans.Controls.Add(this.label1);
            this.grbDateTimeLoans.Controls.Add(this.lbl_expected_loan);
            this.grbDateTimeLoans.Controls.Add(this.lblDateLoans);
            this.grbDateTimeLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDateTimeLoans.ForeColor = System.Drawing.Color.LightGray;
            this.grbDateTimeLoans.Location = new System.Drawing.Point(292, 264);
            this.grbDateTimeLoans.Margin = new System.Windows.Forms.Padding(2);
            this.grbDateTimeLoans.Name = "grbDateTimeLoans";
            this.grbDateTimeLoans.Padding = new System.Windows.Forms.Padding(2);
            this.grbDateTimeLoans.Size = new System.Drawing.Size(460, 107);
            this.grbDateTimeLoans.TabIndex = 24;
            this.grbDateTimeLoans.TabStop = false;
            this.grbDateTimeLoans.Text = "Date and time:";
            // 
            // dtp_expected_loan_timestamp
            // 
            this.dtp_expected_loan_timestamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_expected_loan_timestamp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expected_loan_timestamp.Location = new System.Drawing.Point(141, 66);
            this.dtp_expected_loan_timestamp.Name = "dtp_expected_loan_timestamp";
            this.dtp_expected_loan_timestamp.Size = new System.Drawing.Size(248, 22);
            this.dtp_expected_loan_timestamp.TabIndex = 28;
            // 
            // btn_get
            // 
            this.btn_get.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(401, 22);
            this.btn_get.Margin = new System.Windows.Forms.Padding(2);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(46, 28);
            this.btn_get.TabIndex = 27;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = false;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // txt_timestamp
            // 
            this.txt_timestamp.BackColor = System.Drawing.Color.LightGray;
            this.txt_timestamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timestamp.Location = new System.Drawing.Point(141, 25);
            this.txt_timestamp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timestamp.Name = "txt_timestamp";
            this.txt_timestamp.Size = new System.Drawing.Size(248, 22);
            this.txt_timestamp.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date:";
            // 
            // lblDateLoans
            // 
            this.lblDateLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblDateLoans.Location = new System.Drawing.Point(4, 28);
            this.lblDateLoans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateLoans.Name = "lblDateLoans";
            this.lblDateLoans.Size = new System.Drawing.Size(82, 19);
            this.lblDateLoans.TabIndex = 7;
            // 
            // lblUserLoans
            // 
            this.lblUserLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserLoans.Location = new System.Drawing.Point(292, 201);
            this.lblUserLoans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserLoans.Name = "lblUserLoans";
            this.lblUserLoans.Size = new System.Drawing.Size(90, 19);
            this.lblUserLoans.TabIndex = 23;
            this.lblUserLoans.Text = "Username:";
            // 
            // UC_Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblregisterLoans);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.grbDateTimeLoans);
            this.Controls.Add(this.lblUserLoans);
            this.Name = "UC_Reserve";
            this.Size = new System.Drawing.Size(1040, 611);
            this.grbDateTimeLoans.ResumeLayout(false);
            this.grbDateTimeLoans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_expected_loan;
        private System.Windows.Forms.Label lblregisterLoans;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.GroupBox grbDateTimeLoans;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.TextBox txt_timestamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateLoans;
        private System.Windows.Forms.Label lblUserLoans;
        private System.Windows.Forms.Timer tmr_reservation;
        private System.Windows.Forms.DateTimePicker dtp_expected_loan_timestamp;
    }
}