using System.ComponentModel;

namespace BINAES
{
    partial class frm_loans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loans));
            this.lblregisterLoans = new System.Windows.Forms.Label();
            this.lblNameLoans = new System.Windows.Forms.Label();
            this.lblUserLoans = new System.Windows.Forms.Label();
            this.lblHistoryLoans = new System.Windows.Forms.Label();
            this.txtHistoryLoans = new System.Windows.Forms.TextBox();
            this.grbDateTimeLoans = new System.Windows.Forms.GroupBox();
            this.txtHourLoans = new System.Windows.Forms.TextBox();
            this.dtpDateTimeLoans = new System.Windows.Forms.DateTimePicker();
            this.lblHourLoans = new System.Windows.Forms.Label();
            this.lblDateLoans = new System.Windows.Forms.Label();
            this.grbReturnLoans = new System.Windows.Forms.GroupBox();
            this.txtHourReturnLoans = new System.Windows.Forms.TextBox();
            this.dtpReturnLoans = new System.Windows.Forms.DateTimePicker();
            this.lblHourReturnLoans = new System.Windows.Forms.Label();
            this.lblReturnLoans = new System.Windows.Forms.Label();
            this.btnAcceptLoans = new System.Windows.Forms.Button();
            this.btnCancelLoans = new System.Windows.Forms.Button();
            this.txtNameLoans = new System.Windows.Forms.TextBox();
            this.txtUserLoans = new System.Windows.Forms.TextBox();
            this.grbDateTimeLoans.SuspendLayout();
            this.grbReturnLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblregisterLoans
            // 
            this.lblregisterLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregisterLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblregisterLoans.Location = new System.Drawing.Point(12, 9);
            this.lblregisterLoans.Name = "lblregisterLoans";
            this.lblregisterLoans.Size = new System.Drawing.Size(232, 23);
            this.lblregisterLoans.TabIndex = 0;
            this.lblregisterLoans.Text = "REGISTER OF LOANS:";
            // 
            // lblNameLoans
            // 
            this.lblNameLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblNameLoans.Location = new System.Drawing.Point(12, 48);
            this.lblNameLoans.Name = "lblNameLoans";
            this.lblNameLoans.Size = new System.Drawing.Size(120, 23);
            this.lblNameLoans.TabIndex = 1;
            this.lblNameLoans.Text = "Full name:";
            // 
            // lblUserLoans
            // 
            this.lblUserLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserLoans.Location = new System.Drawing.Point(12, 82);
            this.lblUserLoans.Name = "lblUserLoans";
            this.lblUserLoans.Size = new System.Drawing.Size(120, 23);
            this.lblUserLoans.TabIndex = 2;
            this.lblUserLoans.Text = "Username:";
            // 
            // lblHistoryLoans
            // 
            this.lblHistoryLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblHistoryLoans.Location = new System.Drawing.Point(12, 123);
            this.lblHistoryLoans.Name = "lblHistoryLoans";
            this.lblHistoryLoans.Size = new System.Drawing.Size(182, 30);
            this.lblHistoryLoans.TabIndex = 3;
            this.lblHistoryLoans.Text = "Library Loan history:";
            // 
            // txtHistoryLoans
            // 
            this.txtHistoryLoans.BackColor = System.Drawing.Color.LightGray;
            this.txtHistoryLoans.Location = new System.Drawing.Point(12, 151);
            this.txtHistoryLoans.Multiline = true;
            this.txtHistoryLoans.Name = "txtHistoryLoans";
            this.txtHistoryLoans.Size = new System.Drawing.Size(583, 162);
            this.txtHistoryLoans.TabIndex = 4;
            // 
            // grbDateTimeLoans
            // 
            this.grbDateTimeLoans.Controls.Add(this.txtHourLoans);
            this.grbDateTimeLoans.Controls.Add(this.dtpDateTimeLoans);
            this.grbDateTimeLoans.Controls.Add(this.lblHourLoans);
            this.grbDateTimeLoans.Controls.Add(this.lblDateLoans);
            this.grbDateTimeLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDateTimeLoans.ForeColor = System.Drawing.Color.LightGray;
            this.grbDateTimeLoans.Location = new System.Drawing.Point(623, 48);
            this.grbDateTimeLoans.Name = "grbDateTimeLoans";
            this.grbDateTimeLoans.Size = new System.Drawing.Size(411, 145);
            this.grbDateTimeLoans.TabIndex = 5;
            this.grbDateTimeLoans.TabStop = false;
            this.grbDateTimeLoans.Text = "Date and time:";
            // 
            // txtHourLoans
            // 
            this.txtHourLoans.BackColor = System.Drawing.Color.LightGray;
            this.txtHourLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourLoans.Location = new System.Drawing.Point(64, 69);
            this.txtHourLoans.Name = "txtHourLoans";
            this.txtHourLoans.Size = new System.Drawing.Size(329, 26);
            this.txtHourLoans.TabIndex = 11;
            // 
            // dtpDateTimeLoans
            // 
            this.dtpDateTimeLoans.CalendarFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTimeLoans.Location = new System.Drawing.Point(64, 34);
            this.dtpDateTimeLoans.Name = "dtpDateTimeLoans";
            this.dtpDateTimeLoans.Size = new System.Drawing.Size(329, 26);
            this.dtpDateTimeLoans.TabIndex = 9;
            // 
            // lblHourLoans
            // 
            this.lblHourLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblHourLoans.Location = new System.Drawing.Point(6, 71);
            this.lblHourLoans.Name = "lblHourLoans";
            this.lblHourLoans.Size = new System.Drawing.Size(110, 23);
            this.lblHourLoans.TabIndex = 8;
            this.lblHourLoans.Text = "Hour:";
            // 
            // lblDateLoans
            // 
            this.lblDateLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblDateLoans.Location = new System.Drawing.Point(6, 34);
            this.lblDateLoans.Name = "lblDateLoans";
            this.lblDateLoans.Size = new System.Drawing.Size(110, 23);
            this.lblDateLoans.TabIndex = 7;
            this.lblDateLoans.Text = "Date:";
            // 
            // grbReturnLoans
            // 
            this.grbReturnLoans.Controls.Add(this.txtHourReturnLoans);
            this.grbReturnLoans.Controls.Add(this.dtpReturnLoans);
            this.grbReturnLoans.Controls.Add(this.lblHourReturnLoans);
            this.grbReturnLoans.Controls.Add(this.lblReturnLoans);
            this.grbReturnLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbReturnLoans.ForeColor = System.Drawing.Color.LightGray;
            this.grbReturnLoans.Location = new System.Drawing.Point(623, 222);
            this.grbReturnLoans.Name = "grbReturnLoans";
            this.grbReturnLoans.Size = new System.Drawing.Size(411, 140);
            this.grbReturnLoans.TabIndex = 6;
            this.grbReturnLoans.TabStop = false;
            this.grbReturnLoans.Text = "Return date:";
            // 
            // txtHourReturnLoans
            // 
            this.txtHourReturnLoans.BackColor = System.Drawing.Color.LightGray;
            this.txtHourReturnLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourReturnLoans.Location = new System.Drawing.Point(64, 73);
            this.txtHourReturnLoans.Name = "txtHourReturnLoans";
            this.txtHourReturnLoans.Size = new System.Drawing.Size(329, 26);
            this.txtHourReturnLoans.TabIndex = 12;
            // 
            // dtpReturnLoans
            // 
            this.dtpReturnLoans.CalendarFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnLoans.Location = new System.Drawing.Point(64, 33);
            this.dtpReturnLoans.Name = "dtpReturnLoans";
            this.dtpReturnLoans.Size = new System.Drawing.Size(329, 26);
            this.dtpReturnLoans.TabIndex = 10;
            // 
            // lblHourReturnLoans
            // 
            this.lblHourReturnLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourReturnLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblHourReturnLoans.Location = new System.Drawing.Point(6, 73);
            this.lblHourReturnLoans.Name = "lblHourReturnLoans";
            this.lblHourReturnLoans.Size = new System.Drawing.Size(110, 23);
            this.lblHourReturnLoans.TabIndex = 10;
            this.lblHourReturnLoans.Text = "Hour:";
            // 
            // lblReturnLoans
            // 
            this.lblReturnLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblReturnLoans.Location = new System.Drawing.Point(6, 36);
            this.lblReturnLoans.Name = "lblReturnLoans";
            this.lblReturnLoans.Size = new System.Drawing.Size(110, 23);
            this.lblReturnLoans.TabIndex = 9;
            this.lblReturnLoans.Text = "Date:";
            // 
            // btnAcceptLoans
            // 
            this.btnAcceptLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcceptLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptLoans.Location = new System.Drawing.Point(61, 345);
            this.btnAcceptLoans.Name = "btnAcceptLoans";
            this.btnAcceptLoans.Size = new System.Drawing.Size(133, 40);
            this.btnAcceptLoans.TabIndex = 7;
            this.btnAcceptLoans.Text = "Accept";
            this.btnAcceptLoans.UseVisualStyleBackColor = false;
            // 
            // btnCancelLoans
            // 
            this.btnCancelLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLoans.Location = new System.Drawing.Point(282, 345);
            this.btnCancelLoans.Name = "btnCancelLoans";
            this.btnCancelLoans.Size = new System.Drawing.Size(133, 40);
            this.btnCancelLoans.TabIndex = 8;
            this.btnCancelLoans.Text = "Cancel";
            this.btnCancelLoans.UseVisualStyleBackColor = false;
            // 
            // txtNameLoans
            // 
            this.txtNameLoans.BackColor = System.Drawing.Color.LightGray;
            this.txtNameLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameLoans.Location = new System.Drawing.Point(112, 48);
            this.txtNameLoans.Name = "txtNameLoans";
            this.txtNameLoans.Size = new System.Drawing.Size(483, 26);
            this.txtNameLoans.TabIndex = 9;
            // 
            // txtUserLoans
            // 
            this.txtUserLoans.BackColor = System.Drawing.Color.LightGray;
            this.txtUserLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLoans.Location = new System.Drawing.Point(112, 82);
            this.txtUserLoans.Name = "txtUserLoans";
            this.txtUserLoans.Size = new System.Drawing.Size(483, 26);
            this.txtUserLoans.TabIndex = 10;
            // 
            // frm_loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1046, 414);
            this.Controls.Add(this.txtUserLoans);
            this.Controls.Add(this.txtNameLoans);
            this.Controls.Add(this.btnCancelLoans);
            this.Controls.Add(this.btnAcceptLoans);
            this.Controls.Add(this.grbReturnLoans);
            this.Controls.Add(this.grbDateTimeLoans);
            this.Controls.Add(this.txtHistoryLoans);
            this.Controls.Add(this.lblHistoryLoans);
            this.Controls.Add(this.lblUserLoans);
            this.Controls.Add(this.lblNameLoans);
            this.Controls.Add(this.lblregisterLoans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_loans";
            this.Text = "Loans";
            this.grbDateTimeLoans.ResumeLayout(false);
            this.grbDateTimeLoans.PerformLayout();
            this.grbReturnLoans.ResumeLayout(false);
            this.grbReturnLoans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtHourLoans;

        private System.Windows.Forms.TextBox txtHourReturnLoans;

        private System.Windows.Forms.DateTimePicker dtpDateTimeLoans;

        private System.Windows.Forms.DateTimePicker dtpReturnLoans;

        private System.Windows.Forms.TextBox txtUserLoans;

        private System.Windows.Forms.TextBox txtNameLoans;

        private System.Windows.Forms.Label lblHourReturnLoans;
        private System.Windows.Forms.Label lblReturnLoans;

        private System.Windows.Forms.Button btnCancelLoans;

        private System.Windows.Forms.Button btnAcceptLoans;

        private System.Windows.Forms.Label lblDateLoans;
        private System.Windows.Forms.Label lblHourLoans;

        private System.Windows.Forms.GroupBox grbReturnLoans;

        private System.Windows.Forms.GroupBox grbDateTimeLoans;

        private System.Windows.Forms.Label lblHistoryLoans;
        private System.Windows.Forms.TextBox txtHistoryLoans;

        private System.Windows.Forms.Label lblUserLoans;

        private System.Windows.Forms.Label lblNameLoans;

        private System.Windows.Forms.Label lblregisterLoans;

        #endregion
    }
}