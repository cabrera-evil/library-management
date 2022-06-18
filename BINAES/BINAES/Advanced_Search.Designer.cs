namespace BINAES
{
    partial class frm_advanced_search
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
            this.grpFormat = new System.Windows.Forms.GroupBox();
            this.rdbBoth = new System.Windows.Forms.RadioButton();
            this.rdbPhysical = new System.Windows.Forms.RadioButton();
            this.rdbDigital = new System.Windows.Forms.RadioButton();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSomeWords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFormat
            // 
            this.grpFormat.Controls.Add(this.rdbBoth);
            this.grpFormat.Controls.Add(this.rdbPhysical);
            this.grpFormat.Controls.Add(this.rdbDigital);
            this.grpFormat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.grpFormat.ForeColor = System.Drawing.Color.LightGray;
            this.grpFormat.Location = new System.Drawing.Point(334, 371);
            this.grpFormat.Margin = new System.Windows.Forms.Padding(2);
            this.grpFormat.Name = "grpFormat";
            this.grpFormat.Padding = new System.Windows.Forms.Padding(2);
            this.grpFormat.Size = new System.Drawing.Size(336, 81);
            this.grpFormat.TabIndex = 21;
            this.grpFormat.TabStop = false;
            this.grpFormat.Text = "Format";
            // 
            // rdbBoth
            // 
            this.rdbBoth.AutoSize = true;
            this.rdbBoth.Location = new System.Drawing.Point(237, 35);
            this.rdbBoth.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBoth.Name = "rdbBoth";
            this.rdbBoth.Size = new System.Drawing.Size(55, 21);
            this.rdbBoth.TabIndex = 2;
            this.rdbBoth.TabStop = true;
            this.rdbBoth.Text = "Both";
            this.rdbBoth.UseVisualStyleBackColor = true;
            // 
            // rdbPhysical
            // 
            this.rdbPhysical.AutoSize = true;
            this.rdbPhysical.Location = new System.Drawing.Point(118, 35);
            this.rdbPhysical.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPhysical.Name = "rdbPhysical";
            this.rdbPhysical.Size = new System.Drawing.Size(76, 21);
            this.rdbPhysical.TabIndex = 1;
            this.rdbPhysical.TabStop = true;
            this.rdbPhysical.Text = "Physical";
            this.rdbPhysical.UseVisualStyleBackColor = true;
            // 
            // rdbDigital
            // 
            this.rdbDigital.AutoSize = true;
            this.rdbDigital.Location = new System.Drawing.Point(16, 35);
            this.rdbDigital.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDigital.Name = "rdbDigital";
            this.rdbDigital.Size = new System.Drawing.Size(68, 21);
            this.rdbDigital.TabIndex = 0;
            this.rdbDigital.TabStop = true;
            this.rdbDigital.Text = "Digital";
            this.rdbDigital.UseVisualStyleBackColor = true;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.LightGray;
            this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAuthor.Location = new System.Drawing.Point(334, 322);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(337, 23);
            this.txtAuthor.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(331, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Wrote by";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.BackColor = System.Drawing.Color.LightGray;
            this.txtKeyWords.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKeyWords.Location = new System.Drawing.Point(334, 263);
            this.txtKeyWords.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(337, 23);
            this.txtKeyWords.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(331, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "The following key words";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSomeWords
            // 
            this.txtSomeWords.BackColor = System.Drawing.Color.LightGray;
            this.txtSomeWords.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSomeWords.Location = new System.Drawing.Point(334, 201);
            this.txtSomeWords.Margin = new System.Windows.Forms.Padding(2);
            this.txtSomeWords.Name = "txtSomeWords";
            this.txtSomeWords.Size = new System.Drawing.Size(337, 23);
            this.txtSomeWords.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(331, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Including the following words";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.LightGray;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTitle.Location = new System.Drawing.Point(334, 145);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(337, 23);
            this.txtTitle.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(331, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Full title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(450, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search by...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(396, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSearch.Location = new System.Drawing.Point(522, 481);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // frm_advanced_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1024, 641);
            this.Controls.Add(this.grpFormat);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKeyWords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSomeWords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_advanced_search";
            this.Text = "Advanced_Search";
            this.grpFormat.ResumeLayout(false);
            this.grpFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFormat;
        private System.Windows.Forms.RadioButton rdbBoth;
        private System.Windows.Forms.RadioButton rdbPhysical;
        private System.Windows.Forms.RadioButton rdbDigital;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSomeWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
    }
}