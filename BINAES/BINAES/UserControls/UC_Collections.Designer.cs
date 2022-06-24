using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Collections
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
            this.pnl_collectionsDataTableBar = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cmb_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_searchBy = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_collectionsDataTable = new System.Windows.Forms.Label();
            this.btn_insertRows = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dg_collectionsDataTable = new System.Windows.Forms.DataGridView();
            this.pnl_collectionsDataBar = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.cmb_genre = new System.Windows.Forms.ComboBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_collectionsDataTableBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dg_collectionsDataTable)).BeginInit();
            this.pnl_collectionsDataBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_collectionsDataTableBar
            // 
            this.pnl_collectionsDataTableBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.pnl_collectionsDataTableBar.Controls.Add(this.btn_filter);
            this.pnl_collectionsDataTableBar.Controls.Add(this.btn_reset);
            this.pnl_collectionsDataTableBar.Controls.Add(this.cmb_searchBy);
            this.pnl_collectionsDataTableBar.Controls.Add(this.txt_search);
            this.pnl_collectionsDataTableBar.Controls.Add(this.lbl_searchBy);
            this.pnl_collectionsDataTableBar.Controls.Add(this.lbl_search);
            this.pnl_collectionsDataTableBar.Controls.Add(this.lbl_collectionsDataTable);
            this.pnl_collectionsDataTableBar.Controls.Add(this.btn_insertRows);
            this.pnl_collectionsDataTableBar.Controls.Add(this.btn_remove);
            this.pnl_collectionsDataTableBar.Controls.Add(this.btn_edit);
            this.pnl_collectionsDataTableBar.Controls.Add(this.dg_collectionsDataTable);
            this.pnl_collectionsDataTableBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_collectionsDataTableBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_collectionsDataTableBar.Name = "pnl_collectionsDataTableBar";
            this.pnl_collectionsDataTableBar.Size = new System.Drawing.Size(687, 611);
            this.pnl_collectionsDataTableBar.TabIndex = 22;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_filter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filter.Location = new System.Drawing.Point(343, 52);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(60, 24);
            this.btn_filter.TabIndex = 16;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(409, 52);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(57, 24);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cmb_searchBy
            // 
            this.cmb_searchBy.FormattingEnabled = true;
            this.cmb_searchBy.Location = new System.Drawing.Point(216, 54);
            this.cmb_searchBy.Name = "cmb_searchBy";
            this.cmb_searchBy.Size = new System.Drawing.Size(121, 21);
            this.cmb_searchBy.TabIndex = 14;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(79, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 13;
            // 
            // lbl_searchBy
            // 
            this.lbl_searchBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_searchBy.ForeColor = System.Drawing.Color.White;
            this.lbl_searchBy.Location = new System.Drawing.Point(185, 56);
            this.lbl_searchBy.Name = "lbl_searchBy";
            this.lbl_searchBy.Size = new System.Drawing.Size(100, 23);
            this.lbl_searchBy.TabIndex = 12;
            this.lbl_searchBy.Text = "By:";
            // 
            // lbl_search
            // 
            this.lbl_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_search.ForeColor = System.Drawing.Color.White;
            this.lbl_search.Location = new System.Drawing.Point(23, 56);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 23);
            this.lbl_search.TabIndex = 11;
            this.lbl_search.Text = "Search";
            // 
            // lbl_collectionsDataTable
            // 
            this.lbl_collectionsDataTable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_collectionsDataTable.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.lbl_collectionsDataTable.Location = new System.Drawing.Point(23, 20);
            this.lbl_collectionsDataTable.Name = "lbl_collectionsDataTable";
            this.lbl_collectionsDataTable.Size = new System.Drawing.Size(321, 23);
            this.lbl_collectionsDataTable.TabIndex = 5;
            this.lbl_collectionsDataTable.Text = "Collections data table";
            // 
            // btn_insertRows
            // 
            this.btn_insertRows.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_insertRows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_insertRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_insertRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_insertRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertRows.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_insertRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insertRows.Location = new System.Drawing.Point(486, 548);
            this.btn_insertRows.Name = "btn_insertRows";
            this.btn_insertRows.Size = new System.Drawing.Size(157, 34);
            this.btn_insertRows.TabIndex = 4;
            this.btn_insertRows.Text = "Insert rows";
            this.btn_insertRows.UseVisualStyleBackColor = false;
            this.btn_insertRows.Click += new System.EventHandler(this.btn_insertRows_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(131, 548);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(102, 34);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit.Location = new System.Drawing.Point(23, 548);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // dg_collectionsDataTable
            // 
            this.dg_collectionsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_collectionsDataTable.Location = new System.Drawing.Point(23, 81);
            this.dg_collectionsDataTable.Name = "dg_collectionsDataTable";
            this.dg_collectionsDataTable.Size = new System.Drawing.Size(620, 461);
            this.dg_collectionsDataTable.TabIndex = 0;
            // 
            // pnl_collectionsDataBar
            // 
            this.pnl_collectionsDataBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (42)))), ((int) (((byte) (42)))));
            this.pnl_collectionsDataBar.Controls.Add(this.btn_cancel);
            this.pnl_collectionsDataBar.Controls.Add(this.cmb_type);
            this.pnl_collectionsDataBar.Controls.Add(this.cmb_genre);
            this.pnl_collectionsDataBar.Controls.Add(this.lbl_gender);
            this.pnl_collectionsDataBar.Controls.Add(this.lbl_type);
            this.pnl_collectionsDataBar.Controls.Add(this.txt_name);
            this.pnl_collectionsDataBar.Controls.Add(this.lbl_name);
            this.pnl_collectionsDataBar.Controls.Add(this.btn_save);
            this.pnl_collectionsDataBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_collectionsDataBar.Location = new System.Drawing.Point(686, 0);
            this.pnl_collectionsDataBar.Name = "pnl_collectionsDataBar";
            this.pnl_collectionsDataBar.Size = new System.Drawing.Size(354, 611);
            this.pnl_collectionsDataBar.TabIndex = 24;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(23, 168);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(305, 45);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Enabled = false;
            this.cmb_type.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(124, 48);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(204, 25);
            this.cmb_type.TabIndex = 22;
            // 
            // cmb_genre
            // 
            this.cmb_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_genre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Location = new System.Drawing.Point(124, 77);
            this.cmb_genre.Name = "cmb_genre";
            this.cmb_genre.Size = new System.Drawing.Size(204, 25);
            this.cmb_genre.TabIndex = 21;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_gender.Location = new System.Drawing.Point(23, 77);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 23);
            this.lbl_gender.TabIndex = 6;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_type
            // 
            this.lbl_type.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_type.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_type.Location = new System.Drawing.Point(23, 48);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(100, 23);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Text = "Type";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_name.Location = new System.Drawing.Point(124, 19);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(204, 23);
            this.txt_name.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(23, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 23);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(23, 117);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(305, 45);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // UC_Collections
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnl_collectionsDataBar);
            this.Controls.Add(this.pnl_collectionsDataTableBar);
            this.Name = "UC_Collections";
            this.Size = new System.Drawing.Size(1040, 611);
            this.Load += new System.EventHandler(this.UC_Collections_Load);
            this.pnl_collectionsDataTableBar.ResumeLayout(false);
            this.pnl_collectionsDataTableBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dg_collectionsDataTable)).EndInit();
            this.pnl_collectionsDataBar.ResumeLayout(false);
            this.pnl_collectionsDataBar.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_collectionsDataBar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.ComboBox cmb_genre;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_save;

        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox cmb_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_searchBy;
        private System.Windows.Forms.Label lbl_search;

        private System.Windows.Forms.Panel pnl_collectionsDataTableBar;
        private System.Windows.Forms.Label lbl_collectionsDataTable;
        private System.Windows.Forms.Button btn_insertRows;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dg_collectionsDataTable;

        #endregion
    }
}