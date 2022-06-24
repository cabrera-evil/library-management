using System.ComponentModel;

namespace BINAES
{
    partial class Management
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
            this.pnl_optionsManagement = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_containerManagement = new System.Windows.Forms.Panel();
            this.pnl_options = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_celebrations = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_collections = new System.Windows.Forms.Button();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_optionsManagement.SuspendLayout();
            this.pnl_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_optionsManagement
            // 
            this.pnl_optionsManagement.Controls.Add(this.button3);
            this.pnl_optionsManagement.Controls.Add(this.button2);
            this.pnl_optionsManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_optionsManagement.Location = new System.Drawing.Point(0, 0);
            this.pnl_optionsManagement.Name = "pnl_optionsManagement";
            this.pnl_optionsManagement.Size = new System.Drawing.Size(1040, 69);
            this.pnl_optionsManagement.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnl_containerManagement
            // 
            this.pnl_containerManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_containerManagement.Location = new System.Drawing.Point(0, 69);
            this.pnl_containerManagement.Name = "pnl_containerManagement";
            this.pnl_containerManagement.Size = new System.Drawing.Size(1040, 611);
            this.pnl_containerManagement.TabIndex = 1;
            // 
            // pnl_options
            // 
            this.pnl_options.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (44)))), ((int) (((byte) (44)))));
            this.pnl_options.Controls.Add(this.lbl_title);
            this.pnl_options.Controls.Add(this.btn_celebrations);
            this.pnl_options.Controls.Add(this.btn_users);
            this.pnl_options.Controls.Add(this.btn_collections);
            this.pnl_options.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_options.Location = new System.Drawing.Point(0, 0);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(1040, 69);
            this.pnl_options.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.lbl_title.Location = new System.Drawing.Point(707, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(321, 23);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Title";
            // 
            // btn_celebrations
            // 
            this.btn_celebrations.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_celebrations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_celebrations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_celebrations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_celebrations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_celebrations.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_celebrations.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_celebrations.Location = new System.Drawing.Point(204, 12);
            this.btn_celebrations.Name = "btn_celebrations";
            this.btn_celebrations.Size = new System.Drawing.Size(160, 42);
            this.btn_celebrations.TabIndex = 2;
            this.btn_celebrations.Text = "Celebrations";
            this.btn_celebrations.UseVisualStyleBackColor = false;
            this.btn_celebrations.Click += new System.EventHandler(this.btn_celebrations_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_users.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_users.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_users.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_users.Location = new System.Drawing.Point(383, 12);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(160, 42);
            this.btn_users.TabIndex = 1;
            this.btn_users.Text = "Users";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_collections
            // 
            this.btn_collections.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.btn_collections.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_collections.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_collections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (101)))), ((int) (((byte) (154)))), ((int) (((byte) (140)))));
            this.btn_collections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_collections.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_collections.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_collections.Location = new System.Drawing.Point(28, 12);
            this.btn_collections.Name = "btn_collections";
            this.btn_collections.Size = new System.Drawing.Size(160, 42);
            this.btn_collections.TabIndex = 1;
            this.btn_collections.Text = "Collections";
            this.btn_collections.UseVisualStyleBackColor = false;
            this.btn_collections.Click += new System.EventHandler(this.btn_collections_Click);
            // 
            // pnl_container
            // 
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 69);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1040, 611);
            this.pnl_container.TabIndex = 4;
            // 
            // Frm_homeManagement
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1040, 680);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Frm_homeManagement";
            this.pnl_optionsManagement.ResumeLayout(false);
            this.pnl_options.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_collections;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_celebrations;

        private System.Windows.Forms.Panel pnl_options;
        private System.Windows.Forms.Panel pnl_container;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Panel pnl_containerManagement;

        private System.Windows.Forms.Panel pnl_optionsManagement;

        #endregion

        private System.Windows.Forms.Label lbl_title;
    }
}