
namespace LibraryManegement.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblUserList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdateUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.lblActiveUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkboxActivation = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cmbboxUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.midPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Controls.Add(this.lblUserList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1350, 99);
            this.topPanel.TabIndex = 6;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1212, 15);
            this.picboxMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.picboxClose.Location = new System.Drawing.Point(1282, 15);
            this.picboxClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblUserList
            // 
            this.lblUserList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.ForeColor = System.Drawing.Color.White;
            this.lblUserList.Location = new System.Drawing.Point(582, 24);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(179, 46);
            this.lblUserList.TabIndex = 4;
            this.lblUserList.Text = "Uses List";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(9, 68);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.ActiveBorderThickness = 1;
            this.btnUpdateUser.ActiveCornerRadius = 20;
            this.btnUpdateUser.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateUser.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUpdateUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.BackgroundImage")));
            this.btnUpdateUser.ButtonText = "Update User";
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateUser.IdleBorderThickness = 1;
            this.btnUpdateUser.IdleCornerRadius = 20;
            this.btnUpdateUser.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateUser.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdateUser.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateUser.Location = new System.Drawing.Point(546, 25);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(281, 69);
            this.btnUpdateUser.TabIndex = 2;
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnUpdateUser, "Select a user to update");
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnDeleteUser);
            this.bottomPanel.Controls.Add(this.btnUpdateUser);
            this.bottomPanel.Controls.Add(this.btnAddUser);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 649);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1350, 125);
            this.bottomPanel.TabIndex = 7;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.ActiveBorderThickness = 1;
            this.btnDeleteUser.ActiveCornerRadius = 20;
            this.btnDeleteUser.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteUser.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.BackgroundImage")));
            this.btnDeleteUser.ButtonText = "Delete User";
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteUser.IdleBorderThickness = 1;
            this.btnDeleteUser.IdleCornerRadius = 20;
            this.btnDeleteUser.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteUser.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDeleteUser.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteUser.Location = new System.Drawing.Point(255, 25);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(281, 69);
            this.btnDeleteUser.TabIndex = 0;
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteUser.Visible = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click_1);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ActiveBorderThickness = 1;
            this.btnAddUser.ActiveCornerRadius = 20;
            this.btnAddUser.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddUser.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.ButtonText = "Add New User";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Enabled = false;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddUser.IdleBorderThickness = 1;
            this.btnAddUser.IdleCornerRadius = 20;
            this.btnAddUser.IdleFillColor = System.Drawing.Color.White;
            this.btnAddUser.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddUser.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddUser.Location = new System.Drawing.Point(836, 25);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(281, 69);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.Visible = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.CausesValidation = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(533, 121);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(778, 450);
            this.dataGridViewUser.StandardTab = true;
            this.dataGridViewUser.TabIndex = 99;
            this.dataGridViewUser.TabStop = false;
            this.dataGridViewUser.VirtualMode = true;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtboxPassword);
            this.groupBox1.Controls.Add(this.txtboxUserName);
            this.groupBox1.Controls.Add(this.lblActiveUser);
            this.groupBox1.Controls.Add(this.checkboxActivation);
            this.groupBox1.Controls.Add(this.cmbboxUserRole);
            this.groupBox1.Controls.Add(this.lblUserRole);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Essential details";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPassword.BackColor = System.Drawing.Color.Gray;
            this.txtboxPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxPassword.Location = new System.Drawing.Point(154, 141);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(248, 36);
            this.txtboxPassword.TabIndex = 1;
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUserName.BackColor = System.Drawing.Color.Gray;
            this.txtboxUserName.ForeColor = System.Drawing.Color.White;
            this.txtboxUserName.Location = new System.Drawing.Point(154, 68);
            this.txtboxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.Size = new System.Drawing.Size(248, 36);
            this.txtboxUserName.TabIndex = 0;
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveUser.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUser.ForeColor = System.Drawing.Color.White;
            this.lblActiveUser.Location = new System.Drawing.Point(22, 340);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(186, 25);
            this.lblActiveUser.TabIndex = 75;
            this.lblActiveUser.Text = "User Active State";
            // 
            // checkboxActivation
            // 
            this.checkboxActivation.BackColor = System.Drawing.Color.Gray;
            this.checkboxActivation.ChechedOffColor = System.Drawing.Color.Gray;
            this.checkboxActivation.Checked = true;
            this.checkboxActivation.CheckedOnColor = System.Drawing.Color.Gray;
            this.checkboxActivation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxActivation.ForeColor = System.Drawing.Color.White;
            this.checkboxActivation.Location = new System.Drawing.Point(242, 341);
            this.checkboxActivation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkboxActivation.Name = "checkboxActivation";
            this.checkboxActivation.Size = new System.Drawing.Size(20, 20);
            this.checkboxActivation.TabIndex = 3;
            // 
            // cmbboxUserRole
            // 
            this.cmbboxUserRole.AutoCompleteCustomSource.AddRange(new string[] {
            "    "});
            this.cmbboxUserRole.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbboxUserRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbboxUserRole.DisplayMember = "NAME";
            this.cmbboxUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxUserRole.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbboxUserRole.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbboxUserRole.FormattingEnabled = true;
            this.cmbboxUserRole.Location = new System.Drawing.Point(154, 220);
            this.cmbboxUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbboxUserRole.Name = "cmbboxUserRole";
            this.cmbboxUserRole.Size = new System.Drawing.Size(248, 36);
            this.cmbboxUserRole.TabIndex = 2;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRole.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.White;
            this.lblUserRole.Location = new System.Drawing.Point(11, 232);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(110, 25);
            this.lblUserRole.TabIndex = 5;
            this.lblUserRole.Text = "User Role";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(11, 141);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(110, 25);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.midPanel.Controls.Add(this.dataGridViewUser);
            this.midPanel.Controls.Add(this.groupBox1);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 0);
            this.midPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1350, 774);
            this.midPanel.TabIndex = 8;
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1350, 774);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.midPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.midPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserList;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateUser;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel midPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserRole;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPass;
        public System.Windows.Forms.ComboBox cmbboxUserRole;
        private Bunifu.Framework.UI.BunifuCustomLabel lblActiveUser;
        private Bunifu.Framework.UI.BunifuCheckbox checkboxActivation;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}