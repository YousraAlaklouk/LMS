
namespace LibraryManegement.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.midPanel = new System.Windows.Forms.Panel();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.btnDeleteAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdateAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnAddAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblUserList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.midPanel.Controls.Add(this.dataGridViewAdmin);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 79);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1200, 440);
            this.midPanel.TabIndex = 11;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdmin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 35;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(1200, 440);
            this.dataGridViewAdmin.TabIndex = 1;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.ActiveBorderThickness = 1;
            this.btnDeleteAdmin.ActiveCornerRadius = 20;
            this.btnDeleteAdmin.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteAdmin.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeleteAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAdmin.BackgroundImage")));
            this.btnDeleteAdmin.ButtonText = "Delete admin";
            this.btnDeleteAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAdmin.IdleBorderThickness = 1;
            this.btnDeleteAdmin.IdleCornerRadius = 20;
            this.btnDeleteAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteAdmin.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAdmin.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(220, 20);
            this.btnDeleteAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(250, 55);
            this.btnDeleteAdmin.TabIndex = 1;
            this.btnDeleteAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnDeleteAdmin, "Select A cell to delete");
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.ActiveBorderThickness = 1;
            this.btnUpdateAdmin.ActiveCornerRadius = 20;
            this.btnUpdateAdmin.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateAdmin.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUpdateAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAdmin.BackgroundImage")));
            this.btnUpdateAdmin.ButtonText = "Update Admin";
            this.btnUpdateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAdmin.IdleBorderThickness = 1;
            this.btnUpdateAdmin.IdleCornerRadius = 20;
            this.btnUpdateAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAdmin.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(730, 20);
            this.btnUpdateAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(250, 55);
            this.btnUpdateAdmin.TabIndex = 2;
            this.btnUpdateAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnUpdateAdmin, "Select a cell to update");
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnDeleteAdmin);
            this.bottomPanel.Controls.Add(this.btnUpdateAdmin);
            this.bottomPanel.Controls.Add(this.btnAddAdmin);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1200, 100);
            this.bottomPanel.TabIndex = 10;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.ActiveBorderThickness = 1;
            this.btnAddAdmin.ActiveCornerRadius = 20;
            this.btnAddAdmin.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddAdmin.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAdmin.BackgroundImage")));
            this.btnAddAdmin.ButtonText = "Add New Admin";
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddAdmin.IdleBorderThickness = 1;
            this.btnAddAdmin.IdleCornerRadius = 20;
            this.btnAddAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnAddAdmin.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddAdmin.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddAdmin.Location = new System.Drawing.Point(474, 20);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(250, 55);
            this.btnAddAdmin.TabIndex = 0;
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblUserList
            // 
            this.lblUserList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.ForeColor = System.Drawing.Color.White;
            this.lblUserList.Location = new System.Drawing.Point(500, 27);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(194, 37);
            this.lblUserList.TabIndex = 4;
            this.lblUserList.Text = "Admins List";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Controls.Add(this.lblUserList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 79);
            this.topPanel.TabIndex = 1;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1079, 12);
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
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.IsBalloon = true;
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
            this.bunifuDragControl2.TargetControl = this.lblUserList;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminForm";
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.midPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel midPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteAdmin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateAdmin;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAdmin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserList;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}