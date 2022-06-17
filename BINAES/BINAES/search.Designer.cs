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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnAdvancedTools = new System.Windows.Forms.Button();
            this.rdbDigital = new System.Windows.Forms.RadioButton();
            this.rdbPhysical = new System.Windows.Forms.RadioButton();
            this.rdbBoth = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(44, 184);
            this.dgvSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowHeadersWidth = 51;
            this.dgvSearchResult.Size = new System.Drawing.Size(916, 398);
            this.dgvSearchResult.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(258, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(595, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(404, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total de resultados: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(595, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSearch1.Location = new System.Drawing.Point(861, 75);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(99, 28);
            this.btnSearch1.TabIndex = 7;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.LightGray;
            this.lblWarning.Location = new System.Drawing.Point(404, 160);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(214, 20);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "Type a sentence to search...";
            this.lblWarning.Visible = false;
            // 
            // btnAdvancedTools
            // 
            this.btnAdvancedTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdvancedTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedTools.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAdvancedTools.Location = new System.Drawing.Point(44, 75);
            this.btnAdvancedTools.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdvancedTools.Name = "btnAdvancedTools";
            this.btnAdvancedTools.Size = new System.Drawing.Size(206, 28);
            this.btnAdvancedTools.TabIndex = 10;
            this.btnAdvancedTools.Text = "Advanced Tools";
            this.btnAdvancedTools.UseVisualStyleBackColor = false;
            this.btnAdvancedTools.Click += new System.EventHandler(this.btnAdvancedTools_Click);
            // 
            // rdbDigital
            // 
            this.rdbDigital.AutoSize = true;
            this.rdbDigital.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbDigital.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDigital.ForeColor = System.Drawing.Color.LightGray;
            this.rdbDigital.Location = new System.Drawing.Point(335, 110);
            this.rdbDigital.Name = "rdbDigital";
            this.rdbDigital.Size = new System.Drawing.Size(101, 21);
            this.rdbDigital.TabIndex = 11;
            this.rdbDigital.TabStop = true;
            this.rdbDigital.Text = "Digital only";
            this.rdbDigital.UseVisualStyleBackColor = true;
            // 
            // rdbPhysical
            // 
            this.rdbPhysical.AutoSize = true;
            this.rdbPhysical.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbPhysical.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhysical.ForeColor = System.Drawing.Color.LightGray;
            this.rdbPhysical.Location = new System.Drawing.Point(455, 110);
            this.rdbPhysical.Name = "rdbPhysical";
            this.rdbPhysical.Size = new System.Drawing.Size(109, 21);
            this.rdbPhysical.TabIndex = 12;
            this.rdbPhysical.TabStop = true;
            this.rdbPhysical.Text = "Physical only";
            this.rdbPhysical.UseVisualStyleBackColor = true;
            // 
            // rdbBoth
            // 
            this.rdbBoth.AutoSize = true;
            this.rdbBoth.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbBoth.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBoth.ForeColor = System.Drawing.Color.LightGray;
            this.rdbBoth.Location = new System.Drawing.Point(582, 110);
            this.rdbBoth.Name = "rdbBoth";
            this.rdbBoth.Size = new System.Drawing.Size(58, 21);
            this.rdbBoth.TabIndex = 13;
            this.rdbBoth.TabStop = true;
            this.rdbBoth.Text = "Both";
            this.rdbBoth.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1021, 633);
            this.Controls.Add(this.rdbBoth);
            this.Controls.Add(this.rdbPhysical);
            this.Controls.Add(this.rdbDigital);
            this.Controls.Add(this.btnAdvancedTools);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchResult);
            this.Controls.Add(this.txtSearch);
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnAdvancedTools;
        private System.Windows.Forms.RadioButton rdbDigital;
        private System.Windows.Forms.RadioButton rdbPhysical;
        private System.Windows.Forms.RadioButton rdbBoth;
    }
}