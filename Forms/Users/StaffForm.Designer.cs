
namespace LibraryManegement.Forms
{
    partial class StaffForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.btnAddMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.midPanel = new System.Windows.Forms.Panel();
            this.lblStaffList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdatestaff = new Bunifu.Framework.UI.BunifuThinButton2();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.btnDeleteStaff = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.midPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AllowUserToAddRows = false;
            this.dataGridViewStaff.AllowUserToDeleteRows = false;
            this.dataGridViewStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStaff.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStaff.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.ReadOnly = true;
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 35;
            this.dataGridViewStaff.Size = new System.Drawing.Size(1200, 440);
            this.dataGridViewStaff.TabIndex = 1;
            this.dataGridViewStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellClick);
            // 
            // btnAddMember
            // 
            this.btnAddMember.ActiveBorderThickness = 1;
            this.btnAddMember.ActiveCornerRadius = 20;
            this.btnAddMember.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddMember.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddMember.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMember.BackgroundImage")));
            this.btnAddMember.ButtonText = "Add New staff";
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddMember.IdleBorderThickness = 1;
            this.btnAddMember.IdleCornerRadius = 20;
            this.btnAddMember.IdleFillColor = System.Drawing.Color.White;
            this.btnAddMember.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddMember.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddMember.Location = new System.Drawing.Point(474, 20);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(250, 55);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.midPanel.Controls.Add(this.dataGridViewStaff);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 79);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1200, 440);
            this.midPanel.TabIndex = 17;
            // 
            // lblStaffList
            // 
            this.lblStaffList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStaffList.AutoSize = true;
            this.lblStaffList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffList.ForeColor = System.Drawing.Color.White;
            this.lblStaffList.Location = new System.Drawing.Point(529, 27);
            this.lblStaffList.Name = "lblStaffList";
            this.lblStaffList.Size = new System.Drawing.Size(143, 37);
            this.lblStaffList.TabIndex = 4;
            this.lblStaffList.Text = "Staff List";
            // 
            // btnUpdatestaff
            // 
            this.btnUpdatestaff.ActiveBorderThickness = 1;
            this.btnUpdatestaff.ActiveCornerRadius = 20;
            this.btnUpdatestaff.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatestaff.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdatestaff.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatestaff.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdatestaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUpdatestaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatestaff.BackgroundImage")));
            this.btnUpdatestaff.ButtonText = "Update staff";
            this.btnUpdatestaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatestaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatestaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatestaff.IdleBorderThickness = 1;
            this.btnUpdatestaff.IdleCornerRadius = 20;
            this.btnUpdatestaff.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdatestaff.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdatestaff.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatestaff.Location = new System.Drawing.Point(730, 20);
            this.btnUpdatestaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatestaff.Name = "btnUpdatestaff";
            this.btnUpdatestaff.Size = new System.Drawing.Size(250, 55);
            this.btnUpdatestaff.TabIndex = 3;
            this.btnUpdatestaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnUpdatestaff, "Select a cell to update");
            this.btnUpdatestaff.Click += new System.EventHandler(this.btnUpdatestaff_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Controls.Add(this.lblStaffList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 79);
            this.topPanel.TabIndex = 15;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1077, 12);
            this.picboxMax.Name = "picboxMax";
            this.picboxMax.Size = new System.Drawing.Size(48, 48);
            this.picboxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxMax.TabIndex = 14;
            this.picboxMax.TabStop = false;
            this.picboxMax.Click += new System.EventHandler(this.picboxMax_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(1140, 12);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.ActiveBorderThickness = 1;
            this.btnDeleteStaff.ActiveCornerRadius = 20;
            this.btnDeleteStaff.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteStaff.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteStaff.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteStaff.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeleteStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStaff.BackgroundImage")));
            this.btnDeleteStaff.ButtonText = "Delete Staff";
            this.btnDeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteStaff.IdleBorderThickness = 1;
            this.btnDeleteStaff.IdleCornerRadius = 20;
            this.btnDeleteStaff.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteStaff.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDeleteStaff.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteStaff.Location = new System.Drawing.Point(220, 20);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(250, 55);
            this.btnDeleteStaff.TabIndex = 4;
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnDeleteStaff, "Select a cell to delete");
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnDeleteStaff);
            this.bottomPanel.Controls.Add(this.btnUpdatestaff);
            this.bottomPanel.Controls.Add(this.btnAddMember);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1200, 100);
            this.bottomPanel.TabIndex = 16;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblStaffList;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.Activated += new System.EventHandler(this.StaffForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.midPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddMember;
        private System.Windows.Forms.Panel midPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStaffList;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdatestaff;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteStaff;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}