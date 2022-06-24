using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Advanced_Search
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
            this.pnl_advanced_search = new System.Windows.Forms.Panel();
            this.rdb_partial = new System.Windows.Forms.RadioButton();
            this.grp_title = new System.Windows.Forms.GroupBox();
            this.rdb_full = new System.Windows.Forms.RadioButton();
            this.grp_format = new System.Windows.Forms.GroupBox();
            this.rdb_both = new System.Windows.Forms.RadioButton();
            this.rdb_physical = new System.Windows.Forms.RadioButton();
            this.rdb_digital = new System.Windows.Forms.RadioButton();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_key_words = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_some_words = new System.Windows.Forms.TextBox();
            this.pnl_advanced_search.SuspendLayout();
            this.grp_title.SuspendLayout();
            this.grp_format.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_advanced_search
            // 
            this.pnl_advanced_search.Controls.Add(this.grp_title);
            this.pnl_advanced_search.Controls.Add(this.grp_format);
            this.pnl_advanced_search.Controls.Add(this.txt_author);
            this.pnl_advanced_search.Controls.Add(this.label5);
            this.pnl_advanced_search.Controls.Add(this.txt_key_words);
            this.pnl_advanced_search.Controls.Add(this.label4);
            this.pnl_advanced_search.Controls.Add(this.label3);
            this.pnl_advanced_search.Controls.Add(this.txt_title);
            this.pnl_advanced_search.Controls.Add(this.label2);
            this.pnl_advanced_search.Controls.Add(this.label1);
            this.pnl_advanced_search.Controls.Add(this.btn_cancel);
            this.pnl_advanced_search.Controls.Add(this.btn_search);
            this.pnl_advanced_search.Controls.Add(this.txt_some_words);
            this.pnl_advanced_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_advanced_search.Location = new System.Drawing.Point(0, 0);
            this.pnl_advanced_search.Name = "pnl_advanced_search";
            this.pnl_advanced_search.Size = new System.Drawing.Size(1365, 789);
            this.pnl_advanced_search.TabIndex = 0;
            // 
            // rdb_partial
            // 
            this.rdb_partial.AutoSize = true;
            this.rdb_partial.Location = new System.Drawing.Point(383, 37);
            this.rdb_partial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_partial.Name = "rdb_partial";
            this.rdb_partial.Size = new System.Drawing.Size(120, 25);
            this.rdb_partial.TabIndex = 1;
            this.rdb_partial.TabStop = true;
            this.rdb_partial.Text = "Partial Title";
            this.rdb_partial.UseVisualStyleBackColor = true;
            // 
            // grp_title
            // 
            this.grp_title.Controls.Add(this.rdb_partial);
            this.grp_title.Controls.Add(this.rdb_full);
            this.grp_title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.grp_title.ForeColor = System.Drawing.Color.LightGray;
            this.grp_title.Location = new System.Drawing.Point(390, 130);
            this.grp_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_title.Name = "grp_title";
            this.grp_title.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_title.Size = new System.Drawing.Size(589, 83);
            this.grp_title.TabIndex = 37;
            this.grp_title.TabStop = false;
            this.grp_title.Text = "Title";
            // 
            // rdb_full
            // 
            this.rdb_full.AutoSize = true;
            this.rdb_full.Location = new System.Drawing.Point(101, 37);
            this.rdb_full.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_full.Name = "rdb_full";
            this.rdb_full.Size = new System.Drawing.Size(92, 25);
            this.rdb_full.TabIndex = 0;
            this.rdb_full.TabStop = true;
            this.rdb_full.Text = "Full Title";
            this.rdb_full.UseVisualStyleBackColor = true;
            // 
            // grp_format
            // 
            this.grp_format.Controls.Add(this.rdb_both);
            this.grp_format.Controls.Add(this.rdb_physical);
            this.grp_format.Controls.Add(this.rdb_digital);
            this.grp_format.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.grp_format.ForeColor = System.Drawing.Color.LightGray;
            this.grp_format.Location = new System.Drawing.Point(390, 548);
            this.grp_format.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_format.Name = "grp_format";
            this.grp_format.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_format.Size = new System.Drawing.Size(589, 100);
            this.grp_format.TabIndex = 34;
            this.grp_format.TabStop = false;
            this.grp_format.Text = "Format";
            // 
            // rdb_both
            // 
            this.rdb_both.AutoSize = true;
            this.rdb_both.Location = new System.Drawing.Point(397, 41);
            this.rdb_both.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_both.Name = "rdb_both";
            this.rdb_both.Size = new System.Drawing.Size(69, 25);
            this.rdb_both.TabIndex = 2;
            this.rdb_both.TabStop = true;
            this.rdb_both.Text = "Both";
            this.rdb_both.UseVisualStyleBackColor = true;
            // 
            // rdb_physical
            // 
            this.rdb_physical.AutoSize = true;
            this.rdb_physical.Location = new System.Drawing.Point(237, 41);
            this.rdb_physical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_physical.Name = "rdb_physical";
            this.rdb_physical.Size = new System.Drawing.Size(95, 25);
            this.rdb_physical.TabIndex = 1;
            this.rdb_physical.TabStop = true;
            this.rdb_physical.Text = "Physical";
            this.rdb_physical.UseVisualStyleBackColor = true;
            // 
            // rdb_digital
            // 
            this.rdb_digital.AutoSize = true;
            this.rdb_digital.Location = new System.Drawing.Point(101, 41);
            this.rdb_digital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_digital.Name = "rdb_digital";
            this.rdb_digital.Size = new System.Drawing.Size(83, 25);
            this.rdb_digital.TabIndex = 0;
            this.rdb_digital.TabStop = true;
            this.rdb_digital.Text = "Digital";
            this.rdb_digital.UseVisualStyleBackColor = true;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.LightGray;
            this.txt_author.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_author.Location = new System.Drawing.Point(390, 488);
            this.txt_author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(589, 27);
            this.txt_author.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(386, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Wrote by";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_key_words
            // 
            this.txt_key_words.BackColor = System.Drawing.Color.LightGray;
            this.txt_key_words.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_key_words.Location = new System.Drawing.Point(390, 415);
            this.txt_key_words.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_key_words.Name = "txt_key_words";
            this.txt_key_words.Size = new System.Drawing.Size(589, 27);
            this.txt_key_words.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(386, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "The following key words";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(386, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "The following partial title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.LightGray;
            this.txt_title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_title.Location = new System.Drawing.Point(390, 270);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(589, 27);
            this.txt_title.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(386, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Full title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(633, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search by...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_cancel.Location = new System.Drawing.Point(542, 683);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 28);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_search.Location = new System.Drawing.Point(710, 683);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 28);
            this.btn_search.TabIndex = 35;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_some_words
            // 
            this.txt_some_words.BackColor = System.Drawing.Color.LightGray;
            this.txt_some_words.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_some_words.Location = new System.Drawing.Point(390, 339);
            this.txt_some_words.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_some_words.Name = "txt_some_words";
            this.txt_some_words.Size = new System.Drawing.Size(589, 27);
            this.txt_some_words.TabIndex = 29;
            // 
            // UC_Advanced_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_advanced_search);
            this.Name = "UC_Advanced_Search";
            this.Size = new System.Drawing.Size(1365, 789);
            this.pnl_advanced_search.ResumeLayout(false);
            this.pnl_advanced_search.PerformLayout();
            this.grp_title.ResumeLayout(false);
            this.grp_title.PerformLayout();
            this.grp_format.ResumeLayout(false);
            this.grp_format.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnl_advanced_search;

        #endregion

        private System.Windows.Forms.GroupBox grp_title;
        private System.Windows.Forms.RadioButton rdb_partial;
        private System.Windows.Forms.RadioButton rdb_full;
        private System.Windows.Forms.GroupBox grp_format;
        private System.Windows.Forms.RadioButton rdb_both;
        private System.Windows.Forms.RadioButton rdb_physical;
        private System.Windows.Forms.RadioButton rdb_digital;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_key_words;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_some_words;
    }
}