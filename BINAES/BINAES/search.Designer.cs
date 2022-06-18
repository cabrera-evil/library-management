namespace BINAES
{
    partial class frm_search
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
            this.rdb_both = new System.Windows.Forms.RadioButton();
            this.rdb_physical = new System.Windows.Forms.RadioButton();
            this.rdb_digital = new System.Windows.Forms.RadioButton();
            this.btn_advanced_tools = new System.Windows.Forms.Button();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.btn_search1 = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_search_result = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_both
            // 
            this.rdb_both.AutoSize = true;
            this.rdb_both.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_both.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_both.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_both.Location = new System.Drawing.Point(743, 110);
            this.rdb_both.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_both.Name = "rdb_both";
            this.rdb_both.Size = new System.Drawing.Size(58, 21);
            this.rdb_both.TabIndex = 23;
            this.rdb_both.TabStop = true;
            this.rdb_both.Text = "Both";
            this.rdb_both.UseVisualStyleBackColor = true;
            // 
            // rdb_physical
            // 
            this.rdb_physical.AutoSize = true;
            this.rdb_physical.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_physical.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_physical.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_physical.Location = new System.Drawing.Point(616, 110);
            this.rdb_physical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_physical.Name = "rdb_physical";
            this.rdb_physical.Size = new System.Drawing.Size(109, 21);
            this.rdb_physical.TabIndex = 22;
            this.rdb_physical.TabStop = true;
            this.rdb_physical.Text = "Physical only";
            this.rdb_physical.UseVisualStyleBackColor = true;
            // 
            // rdb_digital
            // 
            this.rdb_digital.AutoSize = true;
            this.rdb_digital.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_digital.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_digital.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_digital.Location = new System.Drawing.Point(496, 110);
            this.rdb_digital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_digital.Name = "rdb_digital";
            this.rdb_digital.Size = new System.Drawing.Size(101, 21);
            this.rdb_digital.TabIndex = 21;
            this.rdb_digital.TabStop = true;
            this.rdb_digital.Text = "Digital only";
            this.rdb_digital.UseVisualStyleBackColor = true;
            // 
            // btn_advanced_tools
            // 
            this.btn_advanced_tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_advanced_tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_advanced_tools.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_advanced_tools.Location = new System.Drawing.Point(90, 64);
            this.btn_advanced_tools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_advanced_tools.Name = "btn_advanced_tools";
            this.btn_advanced_tools.Size = new System.Drawing.Size(205, 28);
            this.btn_advanced_tools.TabIndex = 20;
            this.btn_advanced_tools.Text = "Advanced Tools";
            this.btn_advanced_tools.UseVisualStyleBackColor = false;
            this.btn_advanced_tools.Click += new System.EventHandler(this.btn_advanced_tools_Click);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_warning.Location = new System.Drawing.Point(565, 160);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(214, 20);
            this.lbl_warning.TabIndex = 19;
            this.lbl_warning.Text = "Type a sentence to search...";
            this.lbl_warning.Visible = false;
            // 
            // btn_search1
            // 
            this.btn_search1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_search1.Location = new System.Drawing.Point(1155, 65);
            this.btn_search1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search1.Name = "btn_search1";
            this.btn_search1.Size = new System.Drawing.Size(99, 28);
            this.btn_search1.TabIndex = 18;
            this.btn_search1.Text = "Search";
            this.btn_search1.UseVisualStyleBackColor = false;
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_counter.Location = new System.Drawing.Point(756, 134);
            this.lbl_counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(17, 20);
            this.lbl_counter.TabIndex = 17;
            this.lbl_counter.Text = "0";
            this.lbl_counter.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(565, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total de resultados: ";
            this.label1.Visible = false;
            // 
            // dgv_search_result
            // 
            this.dgv_search_result.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_result.Location = new System.Drawing.Point(90, 239);
            this.dgv_search_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_search_result.Name = "dgv_search_result";
            this.dgv_search_result.RowHeadersWidth = 51;
            this.dgv_search_result.Size = new System.Drawing.Size(1164, 488);
            this.dgv_search_result.TabIndex = 15;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.LightGray;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_search.Location = new System.Drawing.Point(303, 65);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(844, 27);
            this.txt_search.TabIndex = 14;
            this.txt_search.Text = "\r\n";
            // 
            // frm_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1365, 789);
            this.Controls.Add(this.rdb_both);
            this.Controls.Add(this.rdb_physical);
            this.Controls.Add(this.rdb_digital);
            this.Controls.Add(this.btn_advanced_tools);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.btn_search1);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_search_result);
            this.Controls.Add(this.txt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_search";
            this.Text = "search";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_both;
        private System.Windows.Forms.RadioButton rdb_physical;
        private System.Windows.Forms.RadioButton rdb_digital;
        private System.Windows.Forms.Button btn_advanced_tools;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Button btn_search1;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_search_result;
        private System.Windows.Forms.TextBox txt_search;
    }
}