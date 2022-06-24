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
            this.pnl_advanced_search = new System.Windows.Forms.Panel();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_reserve = new System.Windows.Forms.Button();
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
            this.pnl_advanced_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_advanced_search
            // 
            this.pnl_advanced_search.Controls.Add(this.btn_borrow);
            this.pnl_advanced_search.Controls.Add(this.btn_reserve);
            this.pnl_advanced_search.Controls.Add(this.rdb_both);
            this.pnl_advanced_search.Controls.Add(this.rdb_physical);
            this.pnl_advanced_search.Controls.Add(this.rdb_digital);
            this.pnl_advanced_search.Controls.Add(this.btn_advanced_tools);
            this.pnl_advanced_search.Controls.Add(this.lbl_warning);
            this.pnl_advanced_search.Controls.Add(this.btn_search1);
            this.pnl_advanced_search.Controls.Add(this.lbl_counter);
            this.pnl_advanced_search.Controls.Add(this.label1);
            this.pnl_advanced_search.Controls.Add(this.dgv_search_result);
            this.pnl_advanced_search.Controls.Add(this.txt_search);
            this.pnl_advanced_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_advanced_search.Location = new System.Drawing.Point(0, 0);
            this.pnl_advanced_search.Name = "pnl_advanced_search";
            this.pnl_advanced_search.Size = new System.Drawing.Size(1365, 789);
            this.pnl_advanced_search.TabIndex = 0;
            // 
            // btn_borrow
            // 
            this.btn_borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrow.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_borrow.Location = new System.Drawing.Point(752, 706);
            this.btn_borrow.Margin = new System.Windows.Forms.Padding(4);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(167, 28);
            this.btn_borrow.TabIndex = 38;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = false;
            // 
            // btn_reserve
            // 
            this.btn_reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserve.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_reserve.Location = new System.Drawing.Point(461, 706);
            this.btn_reserve.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(167, 28);
            this.btn_reserve.TabIndex = 37;
            this.btn_reserve.Text = "Reserve";
            this.btn_reserve.UseVisualStyleBackColor = false;
            // 
            // rdb_both
            // 
            this.rdb_both.AutoSize = true;
            this.rdb_both.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_both.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_both.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_both.Location = new System.Drawing.Point(752, 100);
            this.rdb_both.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_both.Name = "rdb_both";
            this.rdb_both.Size = new System.Drawing.Size(58, 21);
            this.rdb_both.TabIndex = 36;
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
            this.rdb_physical.Location = new System.Drawing.Point(625, 100);
            this.rdb_physical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_physical.Name = "rdb_physical";
            this.rdb_physical.Size = new System.Drawing.Size(109, 21);
            this.rdb_physical.TabIndex = 35;
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
            this.rdb_digital.Location = new System.Drawing.Point(505, 100);
            this.rdb_digital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_digital.Name = "rdb_digital";
            this.rdb_digital.Size = new System.Drawing.Size(101, 21);
            this.rdb_digital.TabIndex = 34;
            this.rdb_digital.TabStop = true;
            this.rdb_digital.Text = "Digital only";
            this.rdb_digital.UseVisualStyleBackColor = true;
            // 
            // btn_advanced_tools
            // 
            this.btn_advanced_tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_advanced_tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_advanced_tools.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_advanced_tools.Location = new System.Drawing.Point(100, 54);
            this.btn_advanced_tools.Margin = new System.Windows.Forms.Padding(4);
            this.btn_advanced_tools.Name = "btn_advanced_tools";
            this.btn_advanced_tools.Size = new System.Drawing.Size(205, 28);
            this.btn_advanced_tools.TabIndex = 33;
            this.btn_advanced_tools.Text = "Advanced Tools";
            this.btn_advanced_tools.UseVisualStyleBackColor = false;
            this.btn_advanced_tools.Click += new System.EventHandler(this.btn_advanced_tools_Click_1);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_warning.Location = new System.Drawing.Point(574, 150);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(214, 20);
            this.lbl_warning.TabIndex = 32;
            this.lbl_warning.Text = "Type a sentence to search...";
            this.lbl_warning.Visible = false;
            // 
            // btn_search1
            // 
            this.btn_search1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_search1.Location = new System.Drawing.Point(1164, 55);
            this.btn_search1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search1.Name = "btn_search1";
            this.btn_search1.Size = new System.Drawing.Size(99, 28);
            this.btn_search1.TabIndex = 31;
            this.btn_search1.Text = "Search";
            this.btn_search1.UseVisualStyleBackColor = false;
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_counter.Location = new System.Drawing.Point(765, 124);
            this.lbl_counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(17, 20);
            this.lbl_counter.TabIndex = 30;
            this.lbl_counter.Text = "0";
            this.lbl_counter.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(574, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total de resultados: ";
            this.label1.Visible = false;
            // 
            // dgv_search_result
            // 
            this.dgv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_result.Location = new System.Drawing.Point(100, 192);
            this.dgv_search_result.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_search_result.Name = "dgv_search_result";
            this.dgv_search_result.RowHeadersWidth = 51;
            this.dgv_search_result.Size = new System.Drawing.Size(1164, 479);
            this.dgv_search_result.TabIndex = 28;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.LightGray;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_search.Location = new System.Drawing.Point(312, 55);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(844, 27);
            this.txt_search.TabIndex = 27;
            // 
            // frm_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1365, 789);
            this.Controls.Add(this.pnl_advanced_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_search";
            this.Text = "search";
            this.pnl_advanced_search.ResumeLayout(false);
            this.pnl_advanced_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_reserve;
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

        private System.Windows.Forms.Panel pnl_advanced_search;

        #endregion
    }
}