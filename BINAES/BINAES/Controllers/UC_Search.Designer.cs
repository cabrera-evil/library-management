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
            this.dgv_search_result = new System.Windows.Forms.DataGridView();
            this.pnl_advancedSearch = new System.Windows.Forms.Panel();
            this.btn_select = new System.Windows.Forms.Button();
            this.cmb_format = new System.Windows.Forms.ComboBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.btn_search1 = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.lbl_confirmation_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).BeginInit();
            this.pnl_advancedSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_search_result
            // 
            this.dgv_search_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search_result.Location = new System.Drawing.Point(100, 196);
            this.dgv_search_result.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_search_result.Name = "dgv_search_result";
            this.dgv_search_result.RowHeadersWidth = 51;
            this.dgv_search_result.Size = new System.Drawing.Size(1164, 479);
            this.dgv_search_result.TabIndex = 95;
            this.dgv_search_result.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_result_CellClick);
            this.dgv_search_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_result_CellContentClick);
            this.dgv_search_result.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_result_CellDoubleClick);
            // 
            // pnl_advancedSearch
            // 
            this.pnl_advancedSearch.Controls.Add(this.lbl_confirmation_2);
            this.pnl_advancedSearch.Controls.Add(this.lbl_confirmation);
            this.pnl_advancedSearch.Controls.Add(this.btn_select);
            this.pnl_advancedSearch.Controls.Add(this.cmb_format);
            this.pnl_advancedSearch.Controls.Add(this.lbl_warning);
            this.pnl_advancedSearch.Controls.Add(this.btn_search1);
            this.pnl_advancedSearch.Controls.Add(this.lbl_counter);
            this.pnl_advancedSearch.Controls.Add(this.label1);
            this.pnl_advancedSearch.Controls.Add(this.dgv_search_result);
            this.pnl_advancedSearch.Controls.Add(this.txt_search);
            this.pnl_advancedSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_advancedSearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_advancedSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_advancedSearch.Name = "pnl_advancedSearch";
            this.pnl_advancedSearch.Size = new System.Drawing.Size(1387, 752);
            this.pnl_advancedSearch.TabIndex = 2;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_select.Location = new System.Drawing.Point(1165, 55);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(99, 28);
            this.btn_select.TabIndex = 97;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click_1);
            // 
            // cmb_format
            // 
            this.cmb_format.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_format.FormattingEnabled = true;
            this.cmb_format.Location = new System.Drawing.Point(100, 55);
            this.cmb_format.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_format.Name = "cmb_format";
            this.cmb_format.Size = new System.Drawing.Size(143, 29);
            this.cmb_format.TabIndex = 96;
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warning.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_warning.Location = new System.Drawing.Point(573, 150);
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
            this.btn_search1.Location = new System.Drawing.Point(1059, 55);
            this.btn_search1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search1.Name = "btn_search1";
            this.btn_search1.Size = new System.Drawing.Size(99, 28);
            this.btn_search1.TabIndex = 91;
            this.btn_search1.Text = "Search";
            this.btn_search1.UseVisualStyleBackColor = false;
            this.btn_search1.Click += new System.EventHandler(this.btn_search1_Click_1);
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
            this.label1.Location = new System.Drawing.Point(573, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total de resultados: ";
            this.label1.Visible = false;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.LightGray;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_search.Location = new System.Drawing.Point(251, 55);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(800, 27);
            this.txt_search.TabIndex = 90;
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_confirmation.Location = new System.Drawing.Point(998, 130);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(232, 20);
            this.lbl_confirmation.TabIndex = 98;
            this.lbl_confirmation.Text = "Your selection has been saved";
            this.lbl_confirmation.Visible = false;
            // 
            // lbl_confirmation_2
            // 
            this.lbl_confirmation_2.AutoSize = true;
            this.lbl_confirmation_2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation_2.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_confirmation_2.Location = new System.Drawing.Point(967, 150);
            this.lbl_confirmation_2.Name = "lbl_confirmation_2";
            this.lbl_confirmation_2.Size = new System.Drawing.Size(297, 20);
            this.lbl_confirmation_2.TabIndex = 99;
            this.lbl_confirmation_2.Text = "Proceed to register a loan or a booking";
            this.lbl_confirmation_2.Visible = false;
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnl_advancedSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(1387, 752);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search_result)).EndInit();
            this.pnl_advancedSearch.ResumeLayout(false);
            this.pnl_advancedSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_search_result;
        private System.Windows.Forms.Panel pnl_advancedSearch;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox cmb_format;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Button btn_search1;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_confirmation_2;
        private System.Windows.Forms.Label lbl_confirmation;
    }
}