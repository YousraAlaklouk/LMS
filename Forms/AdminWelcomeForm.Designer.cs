
namespace LibraryManegement
{
    partial class AdminWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWelcomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.RightAdminPanel = new System.Windows.Forms.Panel();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBorrowingReports = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnProfileIcon = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.RightAdminPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.picboxMax);
            this.panel1.Controls.Add(this.picboxClose);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 50);
            this.panel1.TabIndex = 0;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1076, 3);
            this.picboxMax.Name = "picboxMax";
            this.picboxMax.Size = new System.Drawing.Size(48, 44);
            this.picboxMax.TabIndex = 12;
            this.picboxMax.TabStop = false;
            this.picboxMax.Click += new System.EventHandler(this.picboxMax_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(1140, 3);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 44);
            this.picboxClose.TabIndex = 11;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(97, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Username";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(420, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(360, 27);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome To the digital Library";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(27, 13);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(74, 22);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Name: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 564);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 55);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 50);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // RightAdminPanel
            // 
            this.RightAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightAdminPanel.BackColor = System.Drawing.Color.Black;
            this.RightAdminPanel.Controls.Add(this.btnAdmins);
            this.RightAdminPanel.Controls.Add(this.btnStaff);
            this.RightAdminPanel.Controls.Add(this.btnRoles);
            this.RightAdminPanel.Controls.Add(this.btnUsers);
            this.RightAdminPanel.Controls.Add(this.btnBorrowingReports);
            this.RightAdminPanel.Controls.Add(this.btnAuthors);
            this.RightAdminPanel.Controls.Add(this.btnBooks);
            this.RightAdminPanel.Controls.Add(this.btnPublishers);
            this.RightAdminPanel.Controls.Add(this.btnMembers);
            this.RightAdminPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightAdminPanel.Location = new System.Drawing.Point(197, 50);
            this.RightAdminPanel.Name = "RightAdminPanel";
            this.RightAdminPanel.Size = new System.Drawing.Size(1003, 517);
            this.RightAdminPanel.TabIndex = 2;
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnAdmins.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAdmins.ForeColor = System.Drawing.Color.White;
            this.btnAdmins.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmins.Image")));
            this.btnAdmins.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmins.Location = new System.Drawing.Point(217, 13);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(160, 152);
            this.btnAdmins.TabIndex = 31;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStaff.Location = new System.Drawing.Point(644, 13);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(160, 152);
            this.btnStaff.TabIndex = 30;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnRoles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRoles.Location = new System.Drawing.Point(217, 180);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(160, 152);
            this.btnRoles.TabIndex = 29;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(644, 180);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(160, 152);
            this.btnUsers.TabIndex = 28;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBorrowingReports
            // 
            this.btnBorrowingReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnBorrowingReports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrowingReports.FlatAppearance.BorderSize = 0;
            this.btnBorrowingReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBorrowingReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowingReports.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBorrowingReports.ForeColor = System.Drawing.Color.White;
            this.btnBorrowingReports.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowingReports.Image")));
            this.btnBorrowingReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrowingReports.Location = new System.Drawing.Point(430, 180);
            this.btnBorrowingReports.Name = "btnBorrowingReports";
            this.btnBorrowingReports.Size = new System.Drawing.Size(160, 152);
            this.btnBorrowingReports.TabIndex = 27;
            this.btnBorrowingReports.Text = "Reports";
            this.btnBorrowingReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrowingReports.UseVisualStyleBackColor = false;
            this.btnBorrowingReports.Click += new System.EventHandler(this.btnBorrowingReports_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnAuthors.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAuthors.FlatAppearance.BorderSize = 0;
            this.btnAuthors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthors.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAuthors.ForeColor = System.Drawing.Color.White;
            this.btnAuthors.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthors.Image")));
            this.btnAuthors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuthors.Location = new System.Drawing.Point(430, 347);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(160, 152);
            this.btnAuthors.TabIndex = 26;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBooks.Location = new System.Drawing.Point(217, 347);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(160, 152);
            this.btnBooks.TabIndex = 25;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnPublishers
            // 
            this.btnPublishers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnPublishers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPublishers.FlatAppearance.BorderSize = 0;
            this.btnPublishers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPublishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishers.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPublishers.ForeColor = System.Drawing.Color.White;
            this.btnPublishers.Image = ((System.Drawing.Image)(resources.GetObject("btnPublishers.Image")));
            this.btnPublishers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPublishers.Location = new System.Drawing.Point(644, 347);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(160, 152);
            this.btnPublishers.TabIndex = 24;
            this.btnPublishers.Text = "Publishers";
            this.btnPublishers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPublishers.UseVisualStyleBackColor = false;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMembers.Location = new System.Drawing.Point(430, 13);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(160, 152);
            this.btnMembers.TabIndex = 23;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblWelcome;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LeftPanel.Controls.Add(this.btnProfileIcon);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 50);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(199, 514);
            this.LeftPanel.TabIndex = 4;
            // 
            // btnProfileIcon
            // 
            this.btnProfileIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnProfileIcon.FlatAppearance.BorderSize = 0;
            this.btnProfileIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnProfileIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileIcon.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileIcon.ForeColor = System.Drawing.Color.White;
            this.btnProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnProfileIcon.Image")));
            this.btnProfileIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileIcon.Location = new System.Drawing.Point(3, 115);
            this.btnProfileIcon.Name = "btnProfileIcon";
            this.btnProfileIcon.Size = new System.Drawing.Size(190, 50);
            this.btnProfileIcon.TabIndex = 10;
            this.btnProfileIcon.Text = "Profile";
            this.btnProfileIcon.UseVisualStyleBackColor = false;
            this.btnProfileIcon.Click += new System.EventHandler(this.btnProfileIcon_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AdminWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightAdminPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.RightAdminPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWelcome;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label lblState;
        public System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel LeftPanel;
        public System.Windows.Forms.Panel RightAdminPanel;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Button btnProfileIcon;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBorrowingReports;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnPublishers;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAdmins;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

