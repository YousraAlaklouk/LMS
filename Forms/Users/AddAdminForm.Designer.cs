
namespace LibraryManegement.Forms
{
    partial class AddAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdminForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblAdminList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblActiveUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.checkboxActivation = new Bunifu.Framework.UI.BunifuCheckbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbboxUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rdiobtnFemale = new System.Windows.Forms.RadioButton();
            this.rdiobtnMale = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnAddAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.midPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Controls.Add(this.lblAdminList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1350, 99);
            this.topPanel.TabIndex = 9;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1202, 15);
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
            this.picboxClose.Location = new System.Drawing.Point(1275, 15);
            this.picboxClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblAdminList
            // 
            this.lblAdminList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminList.AutoSize = true;
            this.lblAdminList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminList.ForeColor = System.Drawing.Color.White;
            this.lblAdminList.Location = new System.Drawing.Point(562, 34);
            this.lblAdminList.Name = "lblAdminList";
            this.lblAdminList.Size = new System.Drawing.Size(231, 46);
            this.lblAdminList.TabIndex = 4;
            this.lblAdminList.Text = "Add Admin";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPassword.BackColor = System.Drawing.Color.Gray;
            this.txtboxPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxPassword.Location = new System.Drawing.Point(155, 220);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(248, 36);
            this.txtboxPassword.TabIndex = 2;
            // 
            // txtboxName
            // 
            this.txtboxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxName.BackColor = System.Drawing.Color.Gray;
            this.txtboxName.ForeColor = System.Drawing.Color.White;
            this.txtboxName.Location = new System.Drawing.Point(155, 71);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(248, 36);
            this.txtboxName.TabIndex = 0;
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
            this.lblActiveUser.Location = new System.Drawing.Point(46, 438);
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
            this.checkboxActivation.Location = new System.Drawing.Point(263, 439);
            this.checkboxActivation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkboxActivation.Name = "checkboxActivation";
            this.checkboxActivation.Size = new System.Drawing.Size(20, 20);
            this.checkboxActivation.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkboxActivation, "IF User is unactive will not be able to login");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cmbboxUserRole);
            this.groupBox1.Controls.Add(this.lblUserRole);
            this.groupBox1.Controls.Add(this.rdiobtnFemale);
            this.groupBox1.Controls.Add(this.rdiobtnMale);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.txtboxUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.txtboxPassword);
            this.groupBox1.Controls.Add(this.txtboxName);
            this.groupBox1.Controls.Add(this.lblActiveUser);
            this.groupBox1.Controls.Add(this.checkboxActivation);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(224, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 506);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Essential details";
            // 
            // cmbboxUserRole
            // 
            this.cmbboxUserRole.AutoCompleteCustomSource.AddRange(new string[] {
            "    "});
            this.cmbboxUserRole.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbboxUserRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbboxUserRole.DisplayMember = "NAME";
            this.cmbboxUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxUserRole.Enabled = false;
            this.cmbboxUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbboxUserRole.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbboxUserRole.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbboxUserRole.FormattingEnabled = true;
            this.cmbboxUserRole.Location = new System.Drawing.Point(155, 298);
            this.cmbboxUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbboxUserRole.Name = "cmbboxUserRole";
            this.cmbboxUserRole.Size = new System.Drawing.Size(248, 36);
            this.cmbboxUserRole.TabIndex = 3;
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
            this.lblUserRole.Location = new System.Drawing.Point(17, 302);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(110, 25);
            this.lblUserRole.TabIndex = 80;
            this.lblUserRole.Text = "User Role";
            // 
            // rdiobtnFemale
            // 
            this.rdiobtnFemale.AutoSize = true;
            this.rdiobtnFemale.Location = new System.Drawing.Point(288, 371);
            this.rdiobtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdiobtnFemale.Name = "rdiobtnFemale";
            this.rdiobtnFemale.Size = new System.Drawing.Size(123, 34);
            this.rdiobtnFemale.TabIndex = 5;
            this.rdiobtnFemale.TabStop = true;
            this.rdiobtnFemale.Text = "Female";
            this.rdiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdiobtnMale
            // 
            this.rdiobtnMale.AutoSize = true;
            this.rdiobtnMale.Location = new System.Drawing.Point(171, 371);
            this.rdiobtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdiobtnMale.Name = "rdiobtnMale";
            this.rdiobtnMale.Size = new System.Drawing.Size(98, 34);
            this.rdiobtnMale.TabIndex = 4;
            this.rdiobtnMale.TabStop = true;
            this.rdiobtnMale.Text = "Male";
            this.rdiobtnMale.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(29, 378);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(98, 25);
            this.bunifuCustomLabel5.TabIndex = 80;
            this.bunifuCustomLabel5.Text = "Gender:";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUsername.BackColor = System.Drawing.Color.Gray;
            this.txtboxUsername.ForeColor = System.Drawing.Color.White;
            this.txtboxUsername.Location = new System.Drawing.Point(155, 146);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(248, 36);
            this.txtboxUsername.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtboxUsername, "Will be Used To Login Can\'t be Duplicated");
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 154);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 25);
            this.lblUsername.TabIndex = 78;
            this.lblUsername.Text = "Username";
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
            this.lblPass.Location = new System.Drawing.Point(12, 228);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(110, 25);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(9, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Admin Name";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnAddAdmin);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 649);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1350, 125);
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
            this.btnAddAdmin.ButtonText = "ADD";
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddAdmin.IdleBorderThickness = 1;
            this.btnAddAdmin.IdleCornerRadius = 20;
            this.btnAddAdmin.IdleFillColor = System.Drawing.Color.White;
            this.btnAddAdmin.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddAdmin.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddAdmin.Location = new System.Drawing.Point(549, 21);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(252, 69);
            this.btnAddAdmin.TabIndex = 0;
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.midPanel.Controls.Add(this.groupBox2);
            this.midPanel.Controls.Add(this.groupBox1);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 0);
            this.midPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1350, 774);
            this.midPanel.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.txtboxDescription);
            this.groupBox2.Controls.Add(this.txtboxEmail);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.txtboxAddress);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(666, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(460, 506);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(25, 331);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(130, 25);
            this.lblDescription.TabIndex = 77;
            this.lblDescription.Text = "Description";
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxDescription.BackColor = System.Drawing.Color.Gray;
            this.txtboxDescription.ForeColor = System.Drawing.Color.White;
            this.txtboxDescription.Location = new System.Drawing.Point(29, 378);
            this.txtboxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxDescription.Multiline = true;
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(379, 99);
            this.txtboxDescription.TabIndex = 2;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxEmail.BackColor = System.Drawing.Color.Gray;
            this.txtboxEmail.ForeColor = System.Drawing.Color.White;
            this.txtboxEmail.Location = new System.Drawing.Point(160, 79);
            this.txtboxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(248, 36);
            this.txtboxEmail.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(25, 159);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxAddress.BackColor = System.Drawing.Color.Gray;
            this.txtboxAddress.ForeColor = System.Drawing.Color.White;
            this.txtboxAddress.Location = new System.Drawing.Point(29, 215);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(379, 99);
            this.txtboxAddress.TabIndex = 1;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(25, 79);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 25);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Email";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.Teal;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
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
            this.bunifuDragControl2.TargetControl = this.lblAdminList;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AddAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 774);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.midPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAdminfrom";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.midPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAdminList;
        private Bunifu.Framework.UI.BunifuCustomLabel lblActiveUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        public System.Windows.Forms.ComboBox cmbboxUserRole;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserRole;
        public System.Windows.Forms.TextBox txtboxPassword;
        public System.Windows.Forms.TextBox txtboxName;
        public Bunifu.Framework.UI.BunifuCheckbox checkboxActivation;
        public System.Windows.Forms.TextBox txtboxEmail;
        public System.Windows.Forms.TextBox txtboxAddress;
        public System.Windows.Forms.TextBox txtboxUsername;
        public System.Windows.Forms.RadioButton rdiobtnFemale;
        public System.Windows.Forms.RadioButton rdiobtnMale;
        public System.Windows.Forms.TextBox txtboxDescription;
        public Bunifu.Framework.UI.BunifuThinButton2 btnAddAdmin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}