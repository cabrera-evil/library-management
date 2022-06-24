using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Search
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
            this.rdb_both = new System.Windows.Forms.RadioButton();
            this.pnl_advancedSearch = new System.Windows.Forms.Panel();
            this.rdb_physical = new System.Windows.Forms.RadioButton();
            this.rdb_digital = new System.Windows.Forms.RadioButton();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.btn_search1 = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_search_result = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_advancedSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_search_result)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_both
            // 
            this.rdb_both.AutoSize = true;
            this.rdb_both.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_both.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rdb_both.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_both.Location = new System.Drawing.Point(564, 81);
            this.rdb_both.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_both.Name = "rdb_both";
            this.rdb_both.Size = new System.Drawing.Size(50, 20);
            this.rdb_both.TabIndex = 36;
            this.rdb_both.TabStop = true;
            this.rdb_both.Text = "Both";
            this.rdb_both.UseVisualStyleBackColor = true;
            // 
            // pnl_advancedSearch
            // 
            this.pnl_advancedSearch.Controls.Add(this.rdb_both);
            this.pnl_advancedSearch.Controls.Add(this.rdb_physical);
            this.pnl_advancedSearch.Controls.Add(this.rdb_digital);
            this.pnl_advancedSearch.Controls.Add(this.lbl_warning);
            this.pnl_advancedSearch.Controls.Add(this.btn_search1);
            this.pnl_advancedSearch.Controls.Add(this.lbl_counter);
            this.pnl_advancedSearch.Controls.Add(this.label1);
            this.pnl_advancedSearch.Controls.Add(this.dgv_search_result);
            this.pnl_advancedSearch.Controls.Add(this.txt_search);
            this.pnl_advancedSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_advancedSearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_advancedSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_advancedSearch.Name = "pnl_advancedSearch";
            this.pnl_advancedSearch.Size = new System.Drawing.Size(1040, 611);
            this.pnl_advancedSearch.TabIndex = 1;
            // 
            // rdb_physical
            // 
            this.rdb_physical.AutoSize = true;
            this.rdb_physical.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_physical.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rdb_physical.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_physical.Location = new System.Drawing.Point(469, 81);
            this.rdb_physical.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_physical.Name = "rdb_physical";
            this.rdb_physical.Size = new System.Drawing.Size(94, 20);
            this.rdb_physical.TabIndex = 35;
            this.rdb_physical.TabStop = true;
            this.rdb_physical.Text = "Physical only";
            this.rdb_physical.UseVisualStyleBackColor = true;
            // 
            // rdb_digital
            // 
            this.rdb_digital.AutoSize = true;
            this.rdb_digital.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_digital.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rdb_digital.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_digital.Location = new System.Drawing.Point(379, 81);
            this.rdb_digital.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_digital.Name = "rdb_digital";
            this.rdb_digital.Size = new System.Drawing.Size(84, 20);
            this.rdb_digital.TabIndex = 34;
            this.rdb_digital.TabStop = true;
            this.rdb_digital.Text = "Digital only";
            this.rdb_digital.UseVisualStyleBackColor = true;
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_warning.Location = new System.Drawing.Point(430, 122);
            this.lbl_warning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(173, 17);
            this.lbl_warning.TabIndex = 32;
            this.lbl_warning.Text = "Type a sentence to search...";
            this.lbl_warning.Visible = false;
            // 
            // btn_search1
            // 
            this.btn_search1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.btn_search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_search1.Location = new System.Drawing.Point(874, 45);
            this.btn_search1.Name = "btn_search1";
            this.btn_search1.Size = new System.Drawing.Size(74, 23);
            this.btn_search1.TabIndex = 91;
            this.btn_search1.Text = "Search";
            this.btn_search1.UseVisualStyleBackColor = false;
            this.btn_search1.Click += new System.EventHandler(this.btn_search1_Click);
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_counter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_counter.Location = new System.Drawing.Point(574, 101);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(15, 17);
            this.lbl_counter.TabIndex = 30;
            this.lbl_counter.Text = "0";
            this.lbl_counter.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(430, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total de resultados: ";
            this.label1.Visible = false;
            // 
            // dgv_search_result
            // 
            this.dgv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_result.Location = new System.Drawing.Point(75, 159);
            this.dgv_search_result.Name = "dgv_search_result";
            this.dgv_search_result.RowHeadersWidth = 51;
            this.dgv_search_result.Size = new System.Drawing.Size(873, 389);
            this.dgv_search_result.TabIndex = 92;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.LightGray;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_search.Location = new System.Drawing.Point(75, 45);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(793, 23);
            this.txt_search.TabIndex = 90;
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.Controls.Add(this.pnl_advancedSearch);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(1040, 611);
            this.pnl_advancedSearch.ResumeLayout(false);
            this.pnl_advancedSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_search_result)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton rdb_both;
        private System.Windows.Forms.Panel pnl_advancedSearch;
        private System.Windows.Forms.RadioButton rdb_physical;
        private System.Windows.Forms.RadioButton rdb_digital;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Button btn_search1;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_search_result;
        private System.Windows.Forms.TextBox txt_search;

        #endregion
    }
}