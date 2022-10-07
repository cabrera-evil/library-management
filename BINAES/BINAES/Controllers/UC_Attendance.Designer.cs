using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Attendance
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
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_entrance = new System.Windows.Forms.TextBox();
            this.lbl_entrance = new System.Windows.Forms.Label();
            this.btn_get_entrance = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.tmr_reservation = new System.Windows.Forms.Timer(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_userName
            // 
            this.lbl_userName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.lbl_userName.Location = new System.Drawing.Point(334, 151);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(321, 23);
            this.lbl_userName.TabIndex = 4;
            this.lbl_userName.Text = "Username";
            this.lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(382, 186);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(228, 23);
            this.txt_username.TabIndex = 1;
            // 
            // txt_entrance
            // 
            this.txt_entrance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entrance.Location = new System.Drawing.Point(382, 276);
            this.txt_entrance.Multiline = true;
            this.txt_entrance.Name = "txt_entrance";
            this.txt_entrance.ReadOnly = true;
            this.txt_entrance.Size = new System.Drawing.Size(228, 23);
            this.txt_entrance.TabIndex = 93;
            // 
            // lbl_entrance
            // 
            this.lbl_entrance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.lbl_entrance.Location = new System.Drawing.Point(334, 241);
            this.lbl_entrance.Name = "lbl_entrance";
            this.lbl_entrance.Size = new System.Drawing.Size(321, 23);
            this.lbl_entrance.TabIndex = 92;
            this.lbl_entrance.Text = "Entrance Date";
            this.lbl_entrance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_get_entrance
            // 
            this.btn_get_entrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_get_entrance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_get_entrance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_get_entrance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_get_entrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_entrance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_entrance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_get_entrance.Location = new System.Drawing.Point(625, 275);
            this.btn_get_entrance.Name = "btn_get_entrance";
            this.btn_get_entrance.Size = new System.Drawing.Size(49, 24);
            this.btn_get_entrance.TabIndex = 2;
            this.btn_get_entrance.Text = "Get";
            this.btn_get_entrance.UseVisualStyleBackColor = false;
            this.btn_get_entrance.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(83)))));
            this.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_register.Location = new System.Drawing.Point(382, 324);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(228, 45);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
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
            this.btn_cancel.Location = new System.Drawing.Point(382, 375);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(228, 45);
            this.btn_cancel.TabIndex = 94;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // UC_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_get_entrance);
            this.Controls.Add(this.txt_entrance);
            this.Controls.Add(this.lbl_entrance);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_userName);
            this.Name = "UC_Attendance";
            this.Size = new System.Drawing.Size(1040, 611);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txt_entrance;
        private System.Windows.Forms.Label lbl_entrance;
        private System.Windows.Forms.Button btn_get_entrance;
        private System.Windows.Forms.Button btn_register;

        private System.Windows.Forms.TextBox txt_username;

        private System.Windows.Forms.Label lbl_userName;

        #endregion

        private System.Windows.Forms.Timer tmr_reservation;
        private System.Windows.Forms.Button btn_cancel;
    }
}