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
            this.rdbBoth = new System.Windows.Forms.RadioButton();
            this.rdbPhysical = new System.Windows.Forms.RadioButton();
            this.rdbDigital = new System.Windows.Forms.RadioButton();
            this.btnAdvancedTools = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbBoth
            // 
            this.rdbBoth.AutoSize = true;
            this.rdbBoth.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbBoth.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBoth.ForeColor = System.Drawing.Color.LightGray;
            this.rdbBoth.Location = new System.Drawing.Point(557, 133);
            this.rdbBoth.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBoth.Name = "rdbBoth";
            this.rdbBoth.Size = new System.Drawing.Size(49, 20);
            this.rdbBoth.TabIndex = 23;
            this.rdbBoth.TabStop = true;
            this.rdbBoth.Text = "Both";
            this.rdbBoth.UseVisualStyleBackColor = true;
            // 
            // rdbPhysical
            // 
            this.rdbPhysical.AutoSize = true;
            this.rdbPhysical.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbPhysical.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhysical.ForeColor = System.Drawing.Color.LightGray;
            this.rdbPhysical.Location = new System.Drawing.Point(462, 133);
            this.rdbPhysical.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPhysical.Name = "rdbPhysical";
            this.rdbPhysical.Size = new System.Drawing.Size(93, 20);
            this.rdbPhysical.TabIndex = 22;
            this.rdbPhysical.TabStop = true;
            this.rdbPhysical.Text = "Physical only";
            this.rdbPhysical.UseVisualStyleBackColor = true;
            // 
            // rdbDigital
            // 
            this.rdbDigital.AutoSize = true;
            this.rdbDigital.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbDigital.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDigital.ForeColor = System.Drawing.Color.LightGray;
            this.rdbDigital.Location = new System.Drawing.Point(372, 133);
            this.rdbDigital.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDigital.Name = "rdbDigital";
            this.rdbDigital.Size = new System.Drawing.Size(83, 20);
            this.rdbDigital.TabIndex = 21;
            this.rdbDigital.TabStop = true;
            this.rdbDigital.Text = "Digital only";
            this.rdbDigital.UseVisualStyleBackColor = true;
            // 
            // btnAdvancedTools
            // 
            this.btnAdvancedTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdvancedTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedTools.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAdvancedTools.Location = new System.Drawing.Point(154, 105);
            this.btnAdvancedTools.Name = "btnAdvancedTools";
            this.btnAdvancedTools.Size = new System.Drawing.Size(154, 23);
            this.btnAdvancedTools.TabIndex = 20;
            this.btnAdvancedTools.Text = "Advanced Tools";
            this.btnAdvancedTools.UseVisualStyleBackColor = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.LightGray;
            this.lblWarning.Location = new System.Drawing.Point(424, 174);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(173, 17);
            this.lblWarning.TabIndex = 19;
            this.lblWarning.Text = "Type a sentence to search...";
            this.lblWarning.Visible = false;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSearch1.Location = new System.Drawing.Point(767, 105);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(74, 23);
            this.btnSearch1.TabIndex = 18;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(567, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(424, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total de resultados: ";
            this.label1.Visible = false;
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(154, 194);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowHeadersWidth = 51;
            this.dgvSearchResult.Size = new System.Drawing.Size(687, 323);
            this.dgvSearchResult.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(315, 106);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(447, 23);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Text = "\r\n";
            // 
            // frm_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1024, 641);
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
            this.Name = "frm_search";
            this.Text = "search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbBoth;
        private System.Windows.Forms.RadioButton rdbPhysical;
        private System.Windows.Forms.RadioButton rdbDigital;
        private System.Windows.Forms.Button btnAdvancedTools;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.TextBox txtSearch;
    }
}