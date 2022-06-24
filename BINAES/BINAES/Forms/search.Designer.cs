using System.ComponentModel;

namespace BINAES
{
    partial class search
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_options = new System.Windows.Forms.Panel();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_advancedSearch = new System.Windows.Forms.Button();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_options
            // 
            this.pnl_options.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (44)))), ((int) (((byte) (44)))));
            this.pnl_options.Controls.Add(this.btn_borrow);
            this.pnl_options.Controls.Add(this.btn_search);
            this.pnl_options.Controls.Add(this.btn_reserve);
            this.pnl_options.Controls.Add(this.btn_advancedSearch);
            this.pnl_options.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_options.Location = new System.Drawing.Point(0, 0);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(1040, 69);
            this.pnl_options.TabIndex = 0;
            // 
            // btn_borrow
            // 
            this.btn_borrow.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_borrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_borrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_borrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_borrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_borrow.Location = new System.Drawing.Point(553, 12);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(160, 42);
            this.btn_borrow.TabIndex = 5;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(28, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(160, 42);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_reserve
            // 
            this.btn_reserve.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_reserve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reserve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_reserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reserve.Location = new System.Drawing.Point(378, 12);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(160, 42);
            this.btn_reserve.TabIndex = 4;
            this.btn_reserve.Text = "Reserve";
            this.btn_reserve.UseVisualStyleBackColor = false;
            // 
            // btn_advancedSearch
            // 
            this.btn_advancedSearch.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_advancedSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_advancedSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_advancedSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_advancedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_advancedSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_advancedSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_advancedSearch.Location = new System.Drawing.Point(203, 12);
            this.btn_advancedSearch.Name = "btn_advancedSearch";
            this.btn_advancedSearch.Size = new System.Drawing.Size(160, 42);
            this.btn_advancedSearch.TabIndex = 3;
            this.btn_advancedSearch.Text = "Advanced search";
            this.btn_advancedSearch.UseVisualStyleBackColor = false;
            this.btn_advancedSearch.Click += new System.EventHandler(this.btn_advancedSearch_Click);
            // 
            // pnl_container
            // 
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 69);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1040, 611);
            this.pnl_container.TabIndex = 1;
            // 
            // frm_homeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1040, 680);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_homeSearch";
            this.Text = "frm_homeSearch";
            this.pnl_options.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_container;

        private System.Windows.Forms.Button btn_advancedSearch;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_borrow;

        private System.Windows.Forms.Button btn_search;

        private System.Windows.Forms.Panel pnl_options;

        #endregion
    }
}