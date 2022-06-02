
namespace LibraryManegement.Forms
{
    partial class StaffWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffWelcomeForm));
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnBorrowingHistory = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnProfileIcon = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.botPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.RightStaffPanel = new System.Windows.Forms.Panel();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnBorrowingReports = new System.Windows.Forms.Button();
            this.btnAuthorsForStaff = new System.Windows.Forms.Button();
            this.btnBooksForStaff = new System.Windows.Forms.Button();
            this.btnPublishersForStaff = new System.Windows.Forms.Button();
            this.btnMemberForStaff = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.botPanel.SuspendLayout();
            this.RightStaffPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.TopPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TopPanel.Controls.Add(this.picboxMax);
            this.TopPanel.Controls.Add(this.picboxClose);
            this.TopPanel.Controls.Add(this.lblName);
            this.TopPanel.Controls.Add(this.lblWelcome);
            this.TopPanel.Controls.Add(this.lblState);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 50);
            this.TopPanel.TabIndex = 18;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1057, 2);
            this.picboxMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxMax.Name = "picboxMax";
            this.picboxMax.Size = new System.Drawing.Size(48, 48);
            this.picboxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxMax.TabIndex = 12;
            this.picboxMax.TabStop = false;
            this.picboxMax.Click += new System.EventHandler(this.picboxMax_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(1113, 2);
            this.picboxClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 11;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(136, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Username";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(420, 12);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(360, 27);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome To the digital Library";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(30, 14);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(75, 25);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Name: ";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LeftPanel.Controls.Add(this.btnBorrowingHistory);
            this.LeftPanel.Controls.Add(this.btnReturnBook);
            this.LeftPanel.Controls.Add(this.btnBorrowBook);
            this.LeftPanel.Controls.Add(this.btnProfileIcon);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 50);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(199, 514);
            this.LeftPanel.TabIndex = 21;
            // 
            // btnBorrowingHistory
            // 
            this.btnBorrowingHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrowingHistory.FlatAppearance.BorderSize = 0;
            this.btnBorrowingHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBorrowingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowingHistory.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowingHistory.ForeColor = System.Drawing.Color.White;
            this.btnBorrowingHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowingHistory.Image")));
            this.btnBorrowingHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowingHistory.Location = new System.Drawing.Point(2, 349);
            this.btnBorrowingHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrowingHistory.Name = "btnBorrowingHistory";
            this.btnBorrowingHistory.Size = new System.Drawing.Size(197, 69);
            this.btnBorrowingHistory.TabIndex = 12;
            this.btnBorrowingHistory.Text = "Borrow History";
            this.btnBorrowingHistory.UseVisualStyleBackColor = false;
            this.btnBorrowingHistory.Click += new System.EventHandler(this.btnBorrowingHistory_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.Image")));
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(0, 266);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(199, 69);
            this.btnReturnBook.TabIndex = 11;
            this.btnReturnBook.Text = "Return a Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrowBook.FlatAppearance.BorderSize = 0;
            this.btnBorrowBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBook.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowBook.Image")));
            this.btnBorrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowBook.Location = new System.Drawing.Point(0, 176);
            this.btnBorrowBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(199, 69);
            this.btnBorrowBook.TabIndex = 10;
            this.btnBorrowBook.Text = "Borrow a Book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
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
            this.btnProfileIcon.Location = new System.Drawing.Point(4, 90);
            this.btnProfileIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfileIcon.Name = "btnProfileIcon";
            this.btnProfileIcon.Size = new System.Drawing.Size(195, 69);
            this.btnProfileIcon.TabIndex = 9;
            this.btnProfileIcon.Text = "Profile";
            this.btnProfileIcon.UseVisualStyleBackColor = false;
            this.btnProfileIcon.Click += new System.EventHandler(this.btnProfileIcon_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblWelcome;
            this.bunifuDragControl1.Vertical = true;
            // 
            // botPanel
            // 
            this.botPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.botPanel.Controls.Add(this.btnLogout);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Location = new System.Drawing.Point(0, 564);
            this.botPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(1200, 55);
            this.botPanel.TabIndex = 19;
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
            this.btnLogout.Location = new System.Drawing.Point(0, 4);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 51);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // RightStaffPanel
            // 
            this.RightStaffPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightStaffPanel.BackColor = System.Drawing.Color.Black;
            this.RightStaffPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightStaffPanel.Controls.Add(this.btnCashier);
            this.RightStaffPanel.Controls.Add(this.btnBorrowingReports);
            this.RightStaffPanel.Controls.Add(this.btnAuthorsForStaff);
            this.RightStaffPanel.Controls.Add(this.btnBooksForStaff);
            this.RightStaffPanel.Controls.Add(this.btnPublishersForStaff);
            this.RightStaffPanel.Controls.Add(this.btnMemberForStaff);
            this.RightStaffPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightStaffPanel.Location = new System.Drawing.Point(197, 50);
            this.RightStaffPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightStaffPanel.Name = "RightStaffPanel";
            this.RightStaffPanel.Size = new System.Drawing.Size(1003, 517);
            this.RightStaffPanel.TabIndex = 22;
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnCashier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCashier.FlatAppearance.BorderSize = 0;
            this.btnCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCashier.ForeColor = System.Drawing.Color.White;
            this.btnCashier.Image = ((System.Drawing.Image)(resources.GetObject("btnCashier.Image")));
            this.btnCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCashier.Location = new System.Drawing.Point(103, 180);
            this.btnCashier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(160, 152);
            this.btnCashier.TabIndex = 23;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Click += new System.EventHandler(this.btnPayment_Click);
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
            this.btnBorrowingReports.Location = new System.Drawing.Point(766, 180);
            this.btnBorrowingReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrowingReports.Name = "btnBorrowingReports";
            this.btnBorrowingReports.Size = new System.Drawing.Size(160, 152);
            this.btnBorrowingReports.TabIndex = 22;
            this.btnBorrowingReports.Text = "Reports";
            this.btnBorrowingReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrowingReports.UseVisualStyleBackColor = false;
            this.btnBorrowingReports.Click += new System.EventHandler(this.btnBorrowingReports_Click);
            // 
            // btnAuthorsForStaff
            // 
            this.btnAuthorsForStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnAuthorsForStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAuthorsForStaff.FlatAppearance.BorderSize = 0;
            this.btnAuthorsForStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAuthorsForStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorsForStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAuthorsForStaff.ForeColor = System.Drawing.Color.White;
            this.btnAuthorsForStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthorsForStaff.Image")));
            this.btnAuthorsForStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuthorsForStaff.Location = new System.Drawing.Point(598, 332);
            this.btnAuthorsForStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAuthorsForStaff.Name = "btnAuthorsForStaff";
            this.btnAuthorsForStaff.Size = new System.Drawing.Size(160, 152);
            this.btnAuthorsForStaff.TabIndex = 21;
            this.btnAuthorsForStaff.Text = "Authors";
            this.btnAuthorsForStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAuthorsForStaff.UseVisualStyleBackColor = false;
            this.btnAuthorsForStaff.Click += new System.EventHandler(this.btnAuthorsForStaff_Click);
            // 
            // btnBooksForStaff
            // 
            this.btnBooksForStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnBooksForStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBooksForStaff.FlatAppearance.BorderSize = 0;
            this.btnBooksForStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBooksForStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooksForStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBooksForStaff.ForeColor = System.Drawing.Color.White;
            this.btnBooksForStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnBooksForStaff.Image")));
            this.btnBooksForStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBooksForStaff.Location = new System.Drawing.Point(296, 332);
            this.btnBooksForStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBooksForStaff.Name = "btnBooksForStaff";
            this.btnBooksForStaff.Size = new System.Drawing.Size(160, 152);
            this.btnBooksForStaff.TabIndex = 19;
            this.btnBooksForStaff.Text = "Books";
            this.btnBooksForStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBooksForStaff.UseVisualStyleBackColor = false;
            this.btnBooksForStaff.Click += new System.EventHandler(this.btnBooksForStaff_Click);
            // 
            // btnPublishersForStaff
            // 
            this.btnPublishersForStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnPublishersForStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPublishersForStaff.FlatAppearance.BorderSize = 0;
            this.btnPublishersForStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPublishersForStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishersForStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPublishersForStaff.ForeColor = System.Drawing.Color.White;
            this.btnPublishersForStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnPublishersForStaff.Image")));
            this.btnPublishersForStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPublishersForStaff.Location = new System.Drawing.Point(598, 31);
            this.btnPublishersForStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPublishersForStaff.Name = "btnPublishersForStaff";
            this.btnPublishersForStaff.Size = new System.Drawing.Size(160, 152);
            this.btnPublishersForStaff.TabIndex = 18;
            this.btnPublishersForStaff.Text = "Publishers";
            this.btnPublishersForStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPublishersForStaff.UseVisualStyleBackColor = false;
            this.btnPublishersForStaff.Click += new System.EventHandler(this.btnPublishersForStaff_Click);
            // 
            // btnMemberForStaff
            // 
            this.btnMemberForStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnMemberForStaff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMemberForStaff.FlatAppearance.BorderSize = 0;
            this.btnMemberForStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMemberForStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberForStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMemberForStaff.ForeColor = System.Drawing.Color.White;
            this.btnMemberForStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberForStaff.Image")));
            this.btnMemberForStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMemberForStaff.Location = new System.Drawing.Point(296, 31);
            this.btnMemberForStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMemberForStaff.Name = "btnMemberForStaff";
            this.btnMemberForStaff.Size = new System.Drawing.Size(160, 152);
            this.btnMemberForStaff.TabIndex = 17;
            this.btnMemberForStaff.Text = "Members";
            this.btnMemberForStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberForStaff.UseVisualStyleBackColor = false;
            this.btnMemberForStaff.Click += new System.EventHandler(this.btnMemberForStaff_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // StaffWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.RightStaffPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffWelcomeForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.botPanel.ResumeLayout(false);
            this.RightStaffPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Panel LeftPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Button btnAuthorsForStaff;
        private System.Windows.Forms.Button btnBooksForStaff;
        private System.Windows.Forms.Button btnPublishersForStaff;
        private System.Windows.Forms.Button btnMemberForStaff;
        private System.Windows.Forms.Button btnBorrowingReports;
        private System.Windows.Forms.Button btnProfileIcon;
        public System.Windows.Forms.Panel RightStaffPanel;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnBorrowingHistory;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCashier;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}