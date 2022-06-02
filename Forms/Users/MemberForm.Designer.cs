
namespace LibraryManegement.Forms
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.midPanel = new System.Windows.Forms.Panel();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.lblMemberList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdateMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.btnDeleteMember = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAddMember.ButtonText = "Add New Member";
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
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.midPanel.Controls.Add(this.dataGridViewMember);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 79);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1200, 440);
            this.midPanel.TabIndex = 14;
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.AllowUserToAddRows = false;
            this.dataGridViewMember.AllowUserToDeleteRows = false;
            this.dataGridViewMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMember.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMember.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.ReadOnly = true;
            this.dataGridViewMember.RowHeadersWidth = 51;
            this.dataGridViewMember.RowTemplate.Height = 35;
            this.dataGridViewMember.Size = new System.Drawing.Size(1200, 440);
            this.dataGridViewMember.TabIndex = 1;
            this.dataGridViewMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMember_CellClick);
            // 
            // lblMemberList
            // 
            this.lblMemberList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMemberList.AutoSize = true;
            this.lblMemberList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberList.ForeColor = System.Drawing.Color.White;
            this.lblMemberList.Location = new System.Drawing.Point(500, 21);
            this.lblMemberList.Name = "lblMemberList";
            this.lblMemberList.Size = new System.Drawing.Size(223, 37);
            this.lblMemberList.TabIndex = 4;
            this.lblMemberList.Text = "Members List";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.ActiveBorderThickness = 1;
            this.btnUpdateMember.ActiveCornerRadius = 20;
            this.btnUpdateMember.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateMember.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateMember.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUpdateMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateMember.BackgroundImage")));
            this.btnUpdateMember.ButtonText = "Update Member";
            this.btnUpdateMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateMember.IdleBorderThickness = 1;
            this.btnUpdateMember.IdleCornerRadius = 20;
            this.btnUpdateMember.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateMember.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdateMember.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateMember.Location = new System.Drawing.Point(730, 20);
            this.btnUpdateMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(250, 55);
            this.btnUpdateMember.TabIndex = 3;
            this.btnUpdateMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnUpdateMember, "Select a cell to update");
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Controls.Add(this.lblMemberList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 79);
            this.topPanel.TabIndex = 12;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1078, 12);
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
            // btnDeleteMember
            // 
            this.btnDeleteMember.ActiveBorderThickness = 1;
            this.btnDeleteMember.ActiveCornerRadius = 20;
            this.btnDeleteMember.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteMember.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteMember.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeleteMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteMember.BackgroundImage")));
            this.btnDeleteMember.ButtonText = "Delete Member";
            this.btnDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteMember.IdleBorderThickness = 1;
            this.btnDeleteMember.IdleCornerRadius = 20;
            this.btnDeleteMember.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteMember.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDeleteMember.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteMember.Location = new System.Drawing.Point(220, 20);
            this.btnDeleteMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(250, 55);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnDeleteMember, "Select a cell to delete");
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnDeleteMember);
            this.bottomPanel.Controls.Add(this.btnUpdateMember);
            this.bottomPanel.Controls.Add(this.btnAddMember);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1200, 100);
            this.bottomPanel.TabIndex = 13;
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
            this.bunifuDragControl2.TargetControl = this.lblMemberList;
            this.bunifuDragControl2.Vertical = true;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberForm";
            this.Activated += new System.EventHandler(this.MemberForm_Activated);
            this.midPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnAddMember;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateMember;
        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteMember;
        private System.Windows.Forms.Panel bottomPanel;
        public Bunifu.Framework.UI.BunifuCustomLabel lblMemberList;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}