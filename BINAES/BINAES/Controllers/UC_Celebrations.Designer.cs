using System.ComponentModel;

namespace BINAES.UserControls
{
    partial class UC_Celebrations
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
            this.pnl_eventsDataBar = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grp_eventDate = new System.Windows.Forms.GroupBox();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.grp_eventTime = new System.Windows.Forms.GroupBox();
            this.dtp_endTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.dtp_startTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.txt_numberAttendees = new System.Windows.Forms.TextBox();
            this.lbl_numberAttendees = new System.Windows.Forms.Label();
            this.txt_objectives = new System.Windows.Forms.TextBox();
            this.lbl_objectives = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_eventsDataTableBar = new System.Windows.Forms.Panel();
            this.lbl_eventTableData = new System.Windows.Forms.Label();
            this.btn_insertRows = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dg_eventsDataTable = new System.Windows.Forms.DataGridView();
            this.pnl_eventsDataBar.SuspendLayout();
            this.grp_eventDate.SuspendLayout();
            this.grp_eventTime.SuspendLayout();
            this.pnl_eventsDataTableBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dg_eventsDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_eventsDataBar
            // 
            this.pnl_eventsDataBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (42)))), ((int) (((byte) (42)))));
            this.pnl_eventsDataBar.Controls.Add(this.btn_cancel);
            this.pnl_eventsDataBar.Controls.Add(this.grp_eventDate);
            this.pnl_eventsDataBar.Controls.Add(this.grp_eventTime);
            this.pnl_eventsDataBar.Controls.Add(this.txt_numberAttendees);
            this.pnl_eventsDataBar.Controls.Add(this.lbl_numberAttendees);
            this.pnl_eventsDataBar.Controls.Add(this.txt_objectives);
            this.pnl_eventsDataBar.Controls.Add(this.lbl_objectives);
            this.pnl_eventsDataBar.Controls.Add(this.txt_title);
            this.pnl_eventsDataBar.Controls.Add(this.lbl_title);
            this.pnl_eventsDataBar.Controls.Add(this.btn_save);
            this.pnl_eventsDataBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_eventsDataBar.Location = new System.Drawing.Point(687, 0);
            this.pnl_eventsDataBar.Name = "pnl_eventsDataBar";
            this.pnl_eventsDataBar.Size = new System.Drawing.Size(353, 611);
            this.pnl_eventsDataBar.TabIndex = 23;
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
            this.btn_cancel.Location = new System.Drawing.Point(19, 407);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(305, 45);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // grp_eventDate
            // 
            this.grp_eventDate.Controls.Add(this.dtp_endDate);
            this.grp_eventDate.Controls.Add(this.lbl_endDate);
            this.grp_eventDate.Controls.Add(this.dtp_startDate);
            this.grp_eventDate.Controls.Add(this.lbl_startDate);
            this.grp_eventDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grp_eventDate.ForeColor = System.Drawing.Color.White;
            this.grp_eventDate.Location = new System.Drawing.Point(19, 244);
            this.grp_eventDate.Name = "grp_eventDate";
            this.grp_eventDate.Size = new System.Drawing.Size(309, 97);
            this.grp_eventDate.TabIndex = 13;
            this.grp_eventDate.TabStop = false;
            this.grp_eventDate.Text = "Event date";
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endDate.Location = new System.Drawing.Point(204, 41);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(90, 22);
            this.dtp_endDate.TabIndex = 15;
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.Location = new System.Drawing.Point(169, 39);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(38, 23);
            this.lbl_endDate.TabIndex = 3;
            this.lbl_endDate.Text = "End:";
            this.lbl_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startDate.Location = new System.Drawing.Point(54, 42);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(90, 22);
            this.dtp_startDate.TabIndex = 14;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.Location = new System.Drawing.Point(15, 41);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(42, 23);
            this.lbl_startDate.TabIndex = 2;
            this.lbl_startDate.Text = "Start:";
            this.lbl_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_eventTime
            // 
            this.grp_eventTime.Controls.Add(this.dtp_endTime);
            this.grp_eventTime.Controls.Add(this.lbl_endTime);
            this.grp_eventTime.Controls.Add(this.dtp_startTime);
            this.grp_eventTime.Controls.Add(this.lbl_startTime);
            this.grp_eventTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grp_eventTime.ForeColor = System.Drawing.Color.White;
            this.grp_eventTime.Location = new System.Drawing.Point(19, 132);
            this.grp_eventTime.Name = "grp_eventTime";
            this.grp_eventTime.Size = new System.Drawing.Size(309, 97);
            this.grp_eventTime.TabIndex = 12;
            this.grp_eventTime.TabStop = false;
            this.grp_eventTime.Text = "Event time";
            // 
            // dtp_endTime
            // 
            this.dtp_endTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_endTime.Location = new System.Drawing.Point(204, 40);
            this.dtp_endTime.Name = "dtp_endTime";
            this.dtp_endTime.Size = new System.Drawing.Size(90, 22);
            this.dtp_endTime.TabIndex = 17;
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.Location = new System.Drawing.Point(165, 39);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(42, 23);
            this.lbl_endTime.TabIndex = 1;
            this.lbl_endTime.Text = "End:";
            this.lbl_endTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_startTime
            // 
            this.dtp_startTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtp_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_startTime.Location = new System.Drawing.Point(54, 40);
            this.dtp_startTime.Name = "dtp_startTime";
            this.dtp_startTime.Size = new System.Drawing.Size(90, 22);
            this.dtp_startTime.TabIndex = 16;
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.Location = new System.Drawing.Point(15, 39);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(42, 23);
            this.lbl_startTime.TabIndex = 0;
            this.lbl_startTime.Text = "Start:";
            this.lbl_startTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_numberAttendees
            // 
            this.txt_numberAttendees.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_numberAttendees.Location = new System.Drawing.Point(124, 77);
            this.txt_numberAttendees.Multiline = true;
            this.txt_numberAttendees.Name = "txt_numberAttendees";
            this.txt_numberAttendees.Size = new System.Drawing.Size(204, 23);
            this.txt_numberAttendees.TabIndex = 9;
            // 
            // lbl_numberAttendees
            // 
            this.lbl_numberAttendees.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_numberAttendees.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_numberAttendees.Location = new System.Drawing.Point(23, 71);
            this.lbl_numberAttendees.Name = "lbl_numberAttendees";
            this.lbl_numberAttendees.Size = new System.Drawing.Size(100, 35);
            this.lbl_numberAttendees.TabIndex = 6;
            this.lbl_numberAttendees.Text = "Number of attendees";
            this.lbl_numberAttendees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_objectives
            // 
            this.txt_objectives.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_objectives.Location = new System.Drawing.Point(124, 48);
            this.txt_objectives.Multiline = true;
            this.txt_objectives.Name = "txt_objectives";
            this.txt_objectives.Size = new System.Drawing.Size(204, 23);
            this.txt_objectives.TabIndex = 5;
            // 
            // lbl_objectives
            // 
            this.lbl_objectives.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_objectives.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_objectives.Location = new System.Drawing.Point(23, 48);
            this.lbl_objectives.Name = "lbl_objectives";
            this.lbl_objectives.Size = new System.Drawing.Size(100, 23);
            this.lbl_objectives.TabIndex = 4;
            this.lbl_objectives.Text = "Objectives";
            this.lbl_objectives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_title.Location = new System.Drawing.Point(124, 19);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(204, 23);
            this.txt_title.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_title.Location = new System.Drawing.Point(23, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(100, 23);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_save.Location = new System.Drawing.Point(19, 356);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(305, 45);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // pnl_eventsDataTableBar
            // 
            this.pnl_eventsDataTableBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.pnl_eventsDataTableBar.Controls.Add(this.lbl_eventTableData);
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_insertRows);
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_remove);
            this.pnl_eventsDataTableBar.Controls.Add(this.btn_edit);
            this.pnl_eventsDataTableBar.Controls.Add(this.dg_eventsDataTable);
            this.pnl_eventsDataTableBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_eventsDataTableBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_eventsDataTableBar.Name = "pnl_eventsDataTableBar";
            this.pnl_eventsDataTableBar.Size = new System.Drawing.Size(687, 611);
            this.pnl_eventsDataTableBar.TabIndex = 22;
            // 
            // lbl_eventTableData
            // 
            this.lbl_eventTableData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_eventTableData.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (38)))), ((int) (((byte) (109)))), ((int) (((byte) (83)))));
            this.lbl_eventTableData.Location = new System.Drawing.Point(23, 20);
            this.lbl_eventTableData.Name = "lbl_eventTableData";
            this.lbl_eventTableData.Size = new System.Drawing.Size(277, 23);
            this.lbl_eventTableData.TabIndex = 12;
            this.lbl_eventTableData.Text = "Celebrations data table";
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
            this.btn_insertRows.Location = new System.Drawing.Point(486, 549);
            this.btn_insertRows.Name = "btn_insertRows";
            this.btn_insertRows.Size = new System.Drawing.Size(157, 34);
            this.btn_insertRows.TabIndex = 4;
            this.btn_insertRows.Text = "Insert rows";
            this.btn_insertRows.UseVisualStyleBackColor = false;
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
            this.btn_remove.Location = new System.Drawing.Point(131, 549);
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
            this.btn_edit.Location = new System.Drawing.Point(23, 549);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // dg_eventsDataTable
            // 
            this.dg_eventsDataTable.Location = new System.Drawing.Point(23, 46);
            this.dg_eventsDataTable.Name = "dg_eventsDataTable";
            this.dg_eventsDataTable.Size = new System.Drawing.Size(620, 487);
            this.dg_eventsDataTable.TabIndex = 13;
            // 
            // UC_Celebrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnl_eventsDataBar);
            this.Controls.Add(this.pnl_eventsDataTableBar);
            this.Name = "UC_Celebrations";
            this.Size = new System.Drawing.Size(1040, 611);
            this.pnl_eventsDataBar.ResumeLayout(false);
            this.pnl_eventsDataBar.PerformLayout();
            this.grp_eventDate.ResumeLayout(false);
            this.grp_eventTime.ResumeLayout(false);
            this.pnl_eventsDataTableBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dg_eventsDataTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.Panel pnl_eventsDataBar;
        private System.Windows.Forms.GroupBox grp_eventDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.GroupBox grp_eventTime;
        private System.Windows.Forms.DateTimePicker dtp_endTime;
        private System.Windows.Forms.Label lbl_endTime;
        private System.Windows.Forms.DateTimePicker dtp_startTime;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.TextBox txt_numberAttendees;
        private System.Windows.Forms.Label lbl_numberAttendees;
        private System.Windows.Forms.TextBox txt_objectives;
        private System.Windows.Forms.Label lbl_objectives;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_eventsDataTableBar;
        private System.Windows.Forms.Label lbl_eventTableData;
        private System.Windows.Forms.Button btn_insertRows;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dg_eventsDataTable;

        #endregion
    }
}