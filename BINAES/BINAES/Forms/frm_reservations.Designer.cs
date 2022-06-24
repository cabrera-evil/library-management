using System.ComponentModel;

namespace BINAES
{
    partial class frm_reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reservations));
            this.lblRegisterOfReservations = new System.Windows.Forms.Label();
            this.lblNamereservat = new System.Windows.Forms.Label();
            this.lblUserReservat = new System.Windows.Forms.Label();
            this.txtUserReservat = new System.Windows.Forms.TextBox();
            this.txtNameReservat = new System.Windows.Forms.TextBox();
            this.grbReturnReservat = new System.Windows.Forms.GroupBox();
            this.txtHourrReturnReservations = new System.Windows.Forms.TextBox();
            this.dtpReturnReservations = new System.Windows.Forms.DateTimePicker();
            this.lblHourReturnReservat = new System.Windows.Forms.Label();
            this.lblReturnReservations = new System.Windows.Forms.Label();
            this.grbDateTimeReservat = new System.Windows.Forms.GroupBox();
            this.txtHourReservations = new System.Windows.Forms.TextBox();
            this.dtpDateReturnReservations = new System.Windows.Forms.DateTimePicker();
            this.lblDateReturnReservati = new System.Windows.Forms.Label();
            this.dtpDateTimeReservations = new System.Windows.Forms.DateTimePicker();
            this.lblHourReservati = new System.Windows.Forms.Label();
            this.lblDateReservati = new System.Windows.Forms.Label();
            this.btnCancelReservations = new System.Windows.Forms.Button();
            this.btnAcceptReservations = new System.Windows.Forms.Button();
            this.grbReturnReservat.SuspendLayout();
            this.grbDateTimeReservat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegisterOfReservations
            // 
            this.lblRegisterOfReservations.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterOfReservations.ForeColor = System.Drawing.Color.LightGray;
            this.lblRegisterOfReservations.Location = new System.Drawing.Point(374, 24);
            this.lblRegisterOfReservations.Name = "lblRegisterOfReservations";
            this.lblRegisterOfReservations.Size = new System.Drawing.Size(371, 23);
            this.lblRegisterOfReservations.TabIndex = 1;
            this.lblRegisterOfReservations.Text = "REGISTER OF RESERVATIONS";
            // 
            // lblNamereservat
            // 
            this.lblNamereservat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamereservat.ForeColor = System.Drawing.Color.LightGray;
            this.lblNamereservat.Location = new System.Drawing.Point(199, 63);
            this.lblNamereservat.Name = "lblNamereservat";
            this.lblNamereservat.Size = new System.Drawing.Size(120, 23);
            this.lblNamereservat.TabIndex = 2;
            this.lblNamereservat.Text = "Full name:";
            // 
            // lblUserReservat
            // 
            this.lblUserReservat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserReservat.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserReservat.Location = new System.Drawing.Point(199, 99);
            this.lblUserReservat.Name = "lblUserReservat";
            this.lblUserReservat.Size = new System.Drawing.Size(120, 23);
            this.lblUserReservat.TabIndex = 3;
            this.lblUserReservat.Text = "Username:";
            // 
            // txtUserReservat
            // 
            this.txtUserReservat.BackColor = System.Drawing.Color.LightGray;
            this.txtUserReservat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserReservat.Location = new System.Drawing.Point(307, 95);
            this.txtUserReservat.Name = "txtUserReservat";
            this.txtUserReservat.Size = new System.Drawing.Size(483, 26);
            this.txtUserReservat.TabIndex = 12;
            // 
            // txtNameReservat
            // 
            this.txtNameReservat.BackColor = System.Drawing.Color.LightGray;
            this.txtNameReservat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameReservat.Location = new System.Drawing.Point(307, 63);
            this.txtNameReservat.Name = "txtNameReservat";
            this.txtNameReservat.Size = new System.Drawing.Size(483, 26);
            this.txtNameReservat.TabIndex = 11;
            // 
            // grbReturnReservat
            // 
            this.grbReturnReservat.Controls.Add(this.txtHourrReturnReservations);
            this.grbReturnReservat.Controls.Add(this.dtpReturnReservations);
            this.grbReturnReservat.Controls.Add(this.lblHourReturnReservat);
            this.grbReturnReservat.Controls.Add(this.lblReturnReservations);
            this.grbReturnReservat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbReturnReservat.ForeColor = System.Drawing.Color.LightGray;
            this.grbReturnReservat.Location = new System.Drawing.Point(528, 161);
            this.grbReturnReservat.Name = "grbReturnReservat";
            this.grbReturnReservat.Size = new System.Drawing.Size(450, 140);
            this.grbReturnReservat.TabIndex = 14;
            this.grbReturnReservat.TabStop = false;
            this.grbReturnReservat.Text = "Return date:";
            // 
            // txtHourrReturnReservations
            // 
            this.txtHourrReturnReservations.BackColor = System.Drawing.Color.LightGray;
            this.txtHourrReturnReservations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourrReturnReservations.Location = new System.Drawing.Point(64, 73);
            this.txtHourrReturnReservations.Name = "txtHourrReturnReservations";
            this.txtHourrReturnReservations.Size = new System.Drawing.Size(359, 26);
            this.txtHourrReturnReservations.TabIndex = 18;
            // 
            // dtpReturnReservations
            // 
            this.dtpReturnReservations.CalendarFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnReservations.Location = new System.Drawing.Point(64, 33);
            this.dtpReturnReservations.Name = "dtpReturnReservations";
            this.dtpReturnReservations.Size = new System.Drawing.Size(359, 26);
            this.dtpReturnReservations.TabIndex = 10;
            // 
            // lblHourReturnReservat
            // 
            this.lblHourReturnReservat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourReturnReservat.ForeColor = System.Drawing.Color.LightGray;
            this.lblHourReturnReservat.Location = new System.Drawing.Point(6, 73);
            this.lblHourReturnReservat.Name = "lblHourReturnReservat";
            this.lblHourReturnReservat.Size = new System.Drawing.Size(110, 23);
            this.lblHourReturnReservat.TabIndex = 10;
            this.lblHourReturnReservat.Text = "Hour:";
            // 
            // lblReturnReservations
            // 
            this.lblReturnReservations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnReservations.ForeColor = System.Drawing.Color.LightGray;
            this.lblReturnReservations.Location = new System.Drawing.Point(6, 36);
            this.lblReturnReservations.Name = "lblReturnReservations";
            this.lblReturnReservations.Size = new System.Drawing.Size(110, 23);
            this.lblReturnReservations.TabIndex = 9;
            this.lblReturnReservations.Text = "Date:";
            // 
            // grbDateTimeReservat
            // 
            this.grbDateTimeReservat.Controls.Add(this.txtHourReservations);
            this.grbDateTimeReservat.Controls.Add(this.dtpDateReturnReservations);
            this.grbDateTimeReservat.Controls.Add(this.lblDateReturnReservati);
            this.grbDateTimeReservat.Controls.Add(this.dtpDateTimeReservations);
            this.grbDateTimeReservat.Controls.Add(this.lblHourReservati);
            this.grbDateTimeReservat.Controls.Add(this.lblDateReservati);
            this.grbDateTimeReservat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDateTimeReservat.ForeColor = System.Drawing.Color.LightGray;
            this.grbDateTimeReservat.Location = new System.Drawing.Point(28, 161);
            this.grbDateTimeReservat.Name = "grbDateTimeReservat";
            this.grbDateTimeReservat.Size = new System.Drawing.Size(445, 145);
            this.grbDateTimeReservat.TabIndex = 13;
            this.grbDateTimeReservat.TabStop = false;
            this.grbDateTimeReservat.Text = "Date and time:";
            // 
            // txtHourReservations
            // 
            this.txtHourReservations.BackColor = System.Drawing.Color.LightGray;
            this.txtHourReservations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourReservations.Location = new System.Drawing.Point(88, 71);
            this.txtHourReservations.Name = "txtHourReservations";
            this.txtHourReservations.Size = new System.Drawing.Size(324, 26);
            this.txtHourReservations.TabIndex = 17;
            // 
            // dtpDateReturnReservations
            // 
            this.dtpDateReturnReservations.CalendarFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateReturnReservations.Location = new System.Drawing.Point(88, 104);
            this.dtpDateReturnReservations.Name = "dtpDateReturnReservations";
            this.dtpDateReturnReservations.Size = new System.Drawing.Size(324, 26);
            this.dtpDateReturnReservations.TabIndex = 11;
            // 
            // lblDateReturnReservati
            // 
            this.lblDateReturnReservati.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturnReservati.ForeColor = System.Drawing.Color.LightGray;
            this.lblDateReturnReservati.Location = new System.Drawing.Point(6, 104);
            this.lblDateReturnReservati.Name = "lblDateReturnReservati";
            this.lblDateReturnReservati.Size = new System.Drawing.Size(110, 23);
            this.lblDateReturnReservati.TabIndex = 10;
            this.lblDateReturnReservati.Text = "Date:";
            // 
            // dtpDateTimeReservations
            // 
            this.dtpDateTimeReservations.CalendarFont = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTimeReservations.Location = new System.Drawing.Point(88, 34);
            this.dtpDateTimeReservations.Name = "dtpDateTimeReservations";
            this.dtpDateTimeReservations.Size = new System.Drawing.Size(324, 26);
            this.dtpDateTimeReservations.TabIndex = 9;
            // 
            // lblHourReservati
            // 
            this.lblHourReservati.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourReservati.ForeColor = System.Drawing.Color.LightGray;
            this.lblHourReservati.Location = new System.Drawing.Point(6, 71);
            this.lblHourReservati.Name = "lblHourReservati";
            this.lblHourReservati.Size = new System.Drawing.Size(110, 23);
            this.lblHourReservati.TabIndex = 8;
            this.lblHourReservati.Text = "Hour:";
            // 
            // lblDateReservati
            // 
            this.lblDateReservati.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReservati.ForeColor = System.Drawing.Color.LightGray;
            this.lblDateReservati.Location = new System.Drawing.Point(6, 34);
            this.lblDateReservati.Name = "lblDateReservati";
            this.lblDateReservati.Size = new System.Drawing.Size(110, 23);
            this.lblDateReservati.TabIndex = 7;
            this.lblDateReservati.Text = "Date:";
            // 
            // btnCancelReservations
            // 
            this.btnCancelReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservations.Location = new System.Drawing.Point(528, 339);
            this.btnCancelReservations.Name = "btnCancelReservations";
            this.btnCancelReservations.Size = new System.Drawing.Size(133, 40);
            this.btnCancelReservations.TabIndex = 16;
            this.btnCancelReservations.Text = "Cancel";
            this.btnCancelReservations.UseVisualStyleBackColor = false;
            // 
            // btnAcceptReservations
            // 
            this.btnAcceptReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcceptReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptReservations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptReservations.Location = new System.Drawing.Point(307, 339);
            this.btnAcceptReservations.Name = "btnAcceptReservations";
            this.btnAcceptReservations.Size = new System.Drawing.Size(133, 40);
            this.btnAcceptReservations.TabIndex = 15;
            this.btnAcceptReservations.Text = "Accept";
            this.btnAcceptReservations.UseVisualStyleBackColor = false;
            // 
            // frm_reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1006, 414);
            this.Controls.Add(this.btnCancelReservations);
            this.Controls.Add(this.btnAcceptReservations);
            this.Controls.Add(this.grbReturnReservat);
            this.Controls.Add(this.grbDateTimeReservat);
            this.Controls.Add(this.txtUserReservat);
            this.Controls.Add(this.txtNameReservat);
            this.Controls.Add(this.lblUserReservat);
            this.Controls.Add(this.lblNamereservat);
            this.Controls.Add(this.lblRegisterOfReservations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_reservations";
            this.Text = "Reservations";
            this.grbReturnReservat.ResumeLayout(false);
            this.grbReturnReservat.PerformLayout();
            this.grbDateTimeReservat.ResumeLayout(false);
            this.grbDateTimeReservat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtHourReservations;
        private System.Windows.Forms.TextBox txtHourrReturnReservations;

        private System.Windows.Forms.DateTimePicker dtpDateReturnReservations;
        private System.Windows.Forms.Label lblDateReturnReservati;

        private System.Windows.Forms.Button btnCancelReservations;
        private System.Windows.Forms.Button btnAcceptReservations;

        private System.Windows.Forms.GroupBox grbReturnReservat;
        private System.Windows.Forms.DateTimePicker dtpReturnReservations;
        private System.Windows.Forms.Label lblHourReturnReservat;
        private System.Windows.Forms.Label lblReturnReservations;
        private System.Windows.Forms.GroupBox grbDateTimeReservat;
        private System.Windows.Forms.DateTimePicker dtpDateTimeReservations;
        private System.Windows.Forms.Label lblHourReservati;
        private System.Windows.Forms.Label lblDateReservati;

        private System.Windows.Forms.TextBox txtUserReservat;
        private System.Windows.Forms.TextBox txtNameReservat;

        private System.Windows.Forms.Label lblUserReservat;

        private System.Windows.Forms.Label lblNamereservat;

        private System.Windows.Forms.Label lblRegisterOfReservations;

        #endregion
    }
}