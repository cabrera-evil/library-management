using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Borrow
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
            this.grbDateTimeLoans = new System.Windows.Forms.GroupBox();
            this.txt_expected_return = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.txt_timestamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_expected_return = new System.Windows.Forms.Label();
            this.lblDateLoans = new System.Windows.Forms.Label();
            this.lblregisterLoans = new System.Windows.Forms.Label();
            this.btnCancelLoans = new System.Windows.Forms.Button();
            this.btnAcceptLoans = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lblUserLoans = new System.Windows.Forms.Label();
            this.tmr_reservation = new System.Windows.Forms.Timer(this.components);
            this.grbDateTimeLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDateTimeLoans
            // 
            this.grbDateTimeLoans.Controls.Add(this.txt_expected_return);
            this.grbDateTimeLoans.Controls.Add(this.btn_get);
            this.grbDateTimeLoans.Controls.Add(this.txt_timestamp);
            this.grbDateTimeLoans.Controls.Add(this.label1);
            this.grbDateTimeLoans.Controls.Add(this.lbl_expected_return);
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
            // txt_expected_return
            // 
            this.txt_expected_return.BackColor = System.Drawing.Color.LightGray;
            this.txt_expected_return.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expected_return.Location = new System.Drawing.Point(141, 63);
            this.txt_expected_return.Margin = new System.Windows.Forms.Padding(2);
            this.txt_expected_return.Name = "txt_expected_return";
            this.txt_expected_return.ReadOnly = true;
            this.txt_expected_return.Size = new System.Drawing.Size(248, 22);
            this.txt_expected_return.TabIndex = 28;
            // 
            // btn_get
            // 
            this.btn_get.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(401, 20);
            this.btn_get.Margin = new System.Windows.Forms.Padding(2);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(46, 32);
            this.btn_get.TabIndex = 27;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = false;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click_1);
            // 
            // txt_timestamp
            // 
            this.txt_timestamp.BackColor = System.Drawing.Color.LightGray;
            this.txt_timestamp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timestamp.Location = new System.Drawing.Point(141, 25);
            this.txt_timestamp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timestamp.Name = "txt_timestamp";
            this.txt_timestamp.ReadOnly = true;
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
            // lbl_expected_return
            // 
            this.lbl_expected_return.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expected_return.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_expected_return.Location = new System.Drawing.Point(4, 66);
            this.lbl_expected_return.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_expected_return.Name = "lbl_expected_return";
            this.lbl_expected_return.Size = new System.Drawing.Size(135, 19);
            this.lbl_expected_return.TabIndex = 8;
            this.lbl_expected_return.Text = "Expected Return:";
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
            // lblregisterLoans
            // 
            this.lblregisterLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregisterLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblregisterLoans.Location = new System.Drawing.Point(459, 160);
            this.lblregisterLoans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblregisterLoans.Name = "lblregisterLoans";
            this.lblregisterLoans.Size = new System.Drawing.Size(174, 19);
            this.lblregisterLoans.TabIndex = 22;
            this.lblregisterLoans.Text = "REGISTER OF LOANS:";
            // 
            // btnCancelLoans
            // 
            this.btnCancelLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLoans.Location = new System.Drawing.Point(548, 418);
            this.btnCancelLoans.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelLoans.Name = "btnCancelLoans";
            this.btnCancelLoans.Size = new System.Drawing.Size(100, 32);
            this.btnCancelLoans.TabIndex = 26;
            this.btnCancelLoans.Text = "Cancel";
            this.btnCancelLoans.UseVisualStyleBackColor = false;
            this.btnCancelLoans.Click += new System.EventHandler(this.btnCancelLoans_Click_1);
            // 
            // btnAcceptLoans
            // 
            this.btnAcceptLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcceptLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptLoans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptLoans.Location = new System.Drawing.Point(382, 418);
            this.btnAcceptLoans.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptLoans.Name = "btnAcceptLoans";
            this.btnAcceptLoans.Size = new System.Drawing.Size(100, 32);
            this.btnAcceptLoans.TabIndex = 25;
            this.btnAcceptLoans.Text = "Accept";
            this.btnAcceptLoans.UseVisualStyleBackColor = false;
            this.btnAcceptLoans.Click += new System.EventHandler(this.btnAcceptLoans_Click_1);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.LightGray;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(382, 200);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(344, 22);
            this.txt_username.TabIndex = 27;
            // 
            // lblUserLoans
            // 
            this.lblUserLoans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoans.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserLoans.Location = new System.Drawing.Point(288, 200);
            this.lblUserLoans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserLoans.Name = "lblUserLoans";
            this.lblUserLoans.Size = new System.Drawing.Size(90, 19);
            this.lblUserLoans.TabIndex = 23;
            this.lblUserLoans.Text = "Username:";
            // 
            // UC_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.grbDateTimeLoans);
            this.Controls.Add(this.lblregisterLoans);
            this.Controls.Add(this.btnCancelLoans);
            this.Controls.Add(this.btnAcceptLoans);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lblUserLoans);
            this.Name = "UC_Borrow";
            this.Size = new System.Drawing.Size(1040, 611);
            this.grbDateTimeLoans.ResumeLayout(false);
            this.grbDateTimeLoans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDateTimeLoans;
        private System.Windows.Forms.TextBox txt_expected_return;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.TextBox txt_timestamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_expected_return;
        private System.Windows.Forms.Label lblDateLoans;
        private System.Windows.Forms.Label lblregisterLoans;
        private System.Windows.Forms.Button btnCancelLoans;
        private System.Windows.Forms.Button btnAcceptLoans;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lblUserLoans;
        private System.Windows.Forms.Timer tmr_reservation;
    }
}