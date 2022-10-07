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
            this.lbl_warning = new System.Windows.Forms.Label();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_format = new System.Windows.Forms.ComboBox();
            this.dgv_search_result = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_some_words = new System.Windows.Forms.TextBox();
            this.rdb_partial = new System.Windows.Forms.RadioButton();
            this.rdb_full = new System.Windows.Forms.RadioButton();
            this.grp_title = new System.Windows.Forms.GroupBox();
            this.txt_key_words = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_confirmation_2 = new System.Windows.Forms.Label();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).BeginInit();
            this.grp_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_warning.Location = new System.Drawing.Point(167, 596);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(214, 20);
            this.lbl_warning.TabIndex = 128;
            this.lbl_warning.Text = "Type a sentence to search...";
            this.lbl_warning.Visible = false;
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_counter.Location = new System.Drawing.Point(359, 570);
            this.lbl_counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(17, 20);
            this.lbl_counter.TabIndex = 127;
            this.lbl_counter.Text = "0";
            this.lbl_counter.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(167, 570);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 126;
            this.label7.Text = "Total de resultados: ";
            this.label7.Visible = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_select.Location = new System.Drawing.Point(405, 668);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(99, 28);
            this.btn_select.TabIndex = 125;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(40, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 124;
            this.label6.Text = "Format";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_format
            // 
            this.cmb_format.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_format.FormattingEnabled = true;
            this.cmb_format.Location = new System.Drawing.Point(145, 219);
            this.cmb_format.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_format.Name = "cmb_format";
            this.cmb_format.Size = new System.Drawing.Size(143, 29);
            this.cmb_format.TabIndex = 123;
            // 
            // dgv_search_result
            // 
            this.dgv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_result.Location = new System.Drawing.Point(556, 111);
            this.dgv_search_result.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_search_result.Name = "dgv_search_result";
            this.dgv_search_result.RowHeadersWidth = 51;
            this.dgv_search_result.Size = new System.Drawing.Size(792, 586);
            this.dgv_search_result.TabIndex = 122;
            this.dgv_search_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_result_CellContentClick);
            this.dgv_search_result.DoubleClick += new System.EventHandler(this.dgv_search_result_DoubleClick_1);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_reset.Location = new System.Drawing.Point(44, 668);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(107, 28);
            this.btn_reset.TabIndex = 121;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.Color.LightGray;
            this.txt_author.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_author.Location = new System.Drawing.Point(44, 521);
            this.txt_author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(460, 27);
            this.txt_author.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(43, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 114;
            this.label5.Text = "Wrote by";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(43, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 21);
            this.label4.TabIndex = 113;
            this.label4.Text = "The following key words";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(43, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 112;
            this.label3.Text = "The following partial title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.LightGray;
            this.txt_title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_title.Location = new System.Drawing.Point(44, 303);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(460, 27);
            this.txt_title.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(212, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 110;
            this.label1.Text = "Search by...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_search.Location = new System.Drawing.Point(225, 668);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(107, 28);
            this.btn_search.TabIndex = 120;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // txt_some_words
            // 
            this.txt_some_words.BackColor = System.Drawing.Color.LightGray;
            this.txt_some_words.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_some_words.Location = new System.Drawing.Point(44, 372);
            this.txt_some_words.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_some_words.Name = "txt_some_words";
            this.txt_some_words.Size = new System.Drawing.Size(460, 27);
            this.txt_some_words.TabIndex = 117;
            // 
            // rdb_partial
            // 
            this.rdb_partial.AutoSize = true;
            this.rdb_partial.Location = new System.Drawing.Point(252, 36);
            this.rdb_partial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_partial.Name = "rdb_partial";
            this.rdb_partial.Size = new System.Drawing.Size(120, 25);
            this.rdb_partial.TabIndex = 92;
            this.rdb_partial.TabStop = true;
            this.rdb_partial.Text = "Partial Title";
            this.rdb_partial.UseVisualStyleBackColor = true;
            this.rdb_partial.CheckedChanged += new System.EventHandler(this.rdb_partial_CheckedChanged);
            // 
            // rdb_full
            // 
            this.rdb_full.AutoSize = true;
            this.rdb_full.Location = new System.Drawing.Point(83, 36);
            this.rdb_full.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_full.Name = "rdb_full";
            this.rdb_full.Size = new System.Drawing.Size(92, 25);
            this.rdb_full.TabIndex = 91;
            this.rdb_full.TabStop = true;
            this.rdb_full.Text = "Full Title";
            this.rdb_full.UseVisualStyleBackColor = true;
            this.rdb_full.CheckedChanged += new System.EventHandler(this.rdb_full_CheckedChanged);
            // 
            // grp_title
            // 
            this.grp_title.Controls.Add(this.rdb_partial);
            this.grp_title.Controls.Add(this.rdb_full);
            this.grp_title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.grp_title.ForeColor = System.Drawing.Color.LightGray;
            this.grp_title.Location = new System.Drawing.Point(44, 111);
            this.grp_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_title.Name = "grp_title";
            this.grp_title.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_title.Size = new System.Drawing.Size(460, 82);
            this.grp_title.TabIndex = 115;
            this.grp_title.TabStop = false;
            this.grp_title.Text = "Title";
            // 
            // txt_key_words
            // 
            this.txt_key_words.BackColor = System.Drawing.Color.LightGray;
            this.txt_key_words.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_key_words.Location = new System.Drawing.Point(44, 448);
            this.txt_key_words.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_key_words.Name = "txt_key_words";
            this.txt_key_words.Size = new System.Drawing.Size(460, 27);
            this.txt_key_words.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(43, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 111;
            this.label2.Text = "Full title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_confirmation_2
            // 
            this.lbl_confirmation_2.AutoSize = true;
            this.lbl_confirmation_2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation_2.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_confirmation_2.Location = new System.Drawing.Point(1036, 74);
            this.lbl_confirmation_2.Name = "lbl_confirmation_2";
            this.lbl_confirmation_2.Size = new System.Drawing.Size(297, 20);
            this.lbl_confirmation_2.TabIndex = 130;
            this.lbl_confirmation_2.Text = "Proceed to register a loan or a booking";
            this.lbl_confirmation_2.Visible = false;
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_confirmation.Location = new System.Drawing.Point(1067, 54);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(232, 20);
            this.lbl_confirmation.TabIndex = 129;
            this.lbl_confirmation.Text = "Your selection has been saved";
            this.lbl_confirmation.Visible = false;
            // 
            // UC_Advanced_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbl_confirmation_2);
            this.Controls.Add(this.lbl_confirmation);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_format);
            this.Controls.Add(this.dgv_search_result);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_some_words);
            this.Controls.Add(this.grp_title);
            this.Controls.Add(this.txt_key_words);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Advanced_Search";
            this.Size = new System.Drawing.Size(1387, 752);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).EndInit();
            this.grp_title.ResumeLayout(false);
            this.grp_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_format;
        private System.Windows.Forms.DataGridView dgv_search_result;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_some_words;
        private System.Windows.Forms.RadioButton rdb_partial;
        private System.Windows.Forms.RadioButton rdb_full;
        private System.Windows.Forms.GroupBox grp_title;
        private System.Windows.Forms.TextBox txt_key_words;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_confirmation_2;
        private System.Windows.Forms.Label lbl_confirmation;
    }
}