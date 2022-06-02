
namespace LibraryManegement.Forms
{
    partial class AddRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoleForm));
            this.lblRoleDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxRoleDescription = new System.Windows.Forms.TextBox();
            this.txtboxRoleType = new System.Windows.Forms.TextBox();
            this.lblRoleType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDeleteRole = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdateRole = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddRole = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.dataGridViewRole = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvlRoleList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.midPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoleDescription
            // 
            this.lblRoleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoleDescription.AutoSize = true;
            this.lblRoleDescription.Location = new System.Drawing.Point(22, 139);
            this.lblRoleDescription.Name = "lblRoleDescription";
            this.lblRoleDescription.Size = new System.Drawing.Size(112, 17);
            this.lblRoleDescription.TabIndex = 2;
            this.lblRoleDescription.Text = "Role Description";
            // 
            // txtboxRoleDescription
            // 
            this.txtboxRoleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxRoleDescription.Location = new System.Drawing.Point(37, 176);
            this.txtboxRoleDescription.Multiline = true;
            this.txtboxRoleDescription.Name = "txtboxRoleDescription";
            this.txtboxRoleDescription.Size = new System.Drawing.Size(223, 82);
            this.txtboxRoleDescription.TabIndex = 1;
            // 
            // txtboxRoleType
            // 
            this.txtboxRoleType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxRoleType.Location = new System.Drawing.Point(37, 74);
            this.txtboxRoleType.Name = "txtboxRoleType";
            this.txtboxRoleType.Size = new System.Drawing.Size(223, 22);
            this.txtboxRoleType.TabIndex = 0;
            // 
            // lblRoleType
            // 
            this.lblRoleType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoleType.AutoSize = true;
            this.lblRoleType.Location = new System.Drawing.Point(22, 38);
            this.lblRoleType.Name = "lblRoleType";
            this.lblRoleType.Size = new System.Drawing.Size(73, 17);
            this.lblRoleType.TabIndex = 0;
            this.lblRoleType.Text = "Role Type";
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.ActiveBorderThickness = 1;
            this.btnDeleteRole.ActiveCornerRadius = 20;
            this.btnDeleteRole.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteRole.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteRole.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteRole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeleteRole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRole.BackgroundImage")));
            this.btnDeleteRole.ButtonText = "Delete Role";
            this.btnDeleteRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteRole.IdleBorderThickness = 1;
            this.btnDeleteRole.IdleCornerRadius = 20;
            this.btnDeleteRole.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteRole.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDeleteRole.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteRole.Location = new System.Drawing.Point(237, 28);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(239, 47);
            this.btnDeleteRole.TabIndex = 4;
            this.btnDeleteRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.ActiveBorderThickness = 1;
            this.btnUpdateRole.ActiveCornerRadius = 20;
            this.btnUpdateRole.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateRole.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateRole.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateRole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUpdateRole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateRole.BackgroundImage")));
            this.btnUpdateRole.ButtonText = "Update Role";
            this.btnUpdateRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateRole.IdleBorderThickness = 1;
            this.btnUpdateRole.IdleCornerRadius = 20;
            this.btnUpdateRole.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateRole.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdateRole.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateRole.Location = new System.Drawing.Point(725, 28);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(239, 47);
            this.btnUpdateRole.TabIndex = 3;
            this.btnUpdateRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.ActiveBorderThickness = 1;
            this.btnAddRole.ActiveCornerRadius = 20;
            this.btnAddRole.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddRole.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddRole.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddRole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddRole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRole.BackgroundImage")));
            this.btnAddRole.ButtonText = "Add New Role";
            this.btnAddRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddRole.IdleBorderThickness = 1;
            this.btnAddRole.IdleCornerRadius = 20;
            this.btnAddRole.IdleFillColor = System.Drawing.Color.White;
            this.btnAddRole.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddRole.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddRole.Location = new System.Drawing.Point(481, 28);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(239, 47);
            this.btnAddRole.TabIndex = 2;
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnDeleteRole);
            this.bottomPanel.Controls.Add(this.btnUpdateRole);
            this.bottomPanel.Controls.Add(this.btnAddRole);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1200, 100);
            this.bottomPanel.TabIndex = 4;
            // 
            // dataGridViewRole
            // 
            this.dataGridViewRole.AllowUserToAddRows = false;
            this.dataGridViewRole.AllowUserToDeleteRows = false;
            this.dataGridViewRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRole.EnableHeadersVisualStyles = false;
            this.dataGridViewRole.Location = new System.Drawing.Point(357, 68);
            this.dataGridViewRole.Name = "dataGridViewRole";
            this.dataGridViewRole.ReadOnly = true;
            this.dataGridViewRole.RowHeadersWidth = 51;
            this.dataGridViewRole.RowTemplate.Height = 24;
            this.dataGridViewRole.Size = new System.Drawing.Size(819, 331);
            this.dataGridViewRole.StandardTab = true;
            this.dataGridViewRole.TabIndex = 99;
            this.dataGridViewRole.TabStop = false;
            this.dataGridViewRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRole_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblRoleDescription);
            this.groupBox1.Controls.Add(this.txtboxRoleDescription);
            this.groupBox1.Controls.Add(this.lblRoleType);
            this.groupBox1.Controls.Add(this.txtboxRoleType);
            this.groupBox1.Location = new System.Drawing.Point(42, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 331);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Essential details";
            // 
            // lvlRoleList
            // 
            this.lvlRoleList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvlRoleList.AutoSize = true;
            this.lvlRoleList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlRoleList.ForeColor = System.Drawing.Color.White;
            this.lvlRoleList.Location = new System.Drawing.Point(528, 27);
            this.lvlRoleList.Name = "lvlRoleList";
            this.lvlRoleList.Size = new System.Drawing.Size(145, 37);
            this.lvlRoleList.TabIndex = 4;
            this.lvlRoleList.Text = "Role List";
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.DimGray;
            this.midPanel.Controls.Add(this.dataGridViewRole);
            this.midPanel.Controls.Add(this.groupBox1);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 79);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1200, 540);
            this.midPanel.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Controls.Add(this.lvlRoleList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 79);
            this.topPanel.TabIndex = 3;
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
            this.bunifuDragControl2.TargetControl = this.lvlRoleList;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AddRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoleForm";
            this.Activated += new System.EventHandler(this.AddRoleForm_Activated);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.midPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblRoleDescription;
        private System.Windows.Forms.TextBox txtboxRoleDescription;
        private System.Windows.Forms.TextBox txtboxRoleType;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRoleType;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteRole;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateRole;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddRole;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.DataGridView dataGridViewRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lvlRoleList;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}