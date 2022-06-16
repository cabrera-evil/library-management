namespace BINAES
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilter2 = new System.Windows.Forms.ComboBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(55, 196);
            this.dgvSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowHeadersWidth = 51;
            this.dgvSearchResult.Size = new System.Drawing.Size(840, 386);
            this.dgvSearchResult.TabIndex = 2;
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(55, 76);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(148, 29);
            this.cmbFilter.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(381, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(404, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(392, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total de resultados: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(583, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // cmbFilter2
            // 
            this.cmbFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.cmbFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbFilter2.FormattingEnabled = true;
            this.cmbFilter2.Location = new System.Drawing.Point(211, 76);
            this.cmbFilter2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilter2.Name = "cmbFilter2";
            this.cmbFilter2.Size = new System.Drawing.Size(162, 29);
            this.cmbFilter2.TabIndex = 6;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSearch1.Location = new System.Drawing.Point(793, 76);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(99, 28);
            this.btnSearch1.TabIndex = 7;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1021, 633);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.cmbFilter2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchResult);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.Opacity = 0.9D;
            this.Text = "BINAES-SEARCH";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilter2;
        private System.Windows.Forms.Button btnSearch1;
    }
}