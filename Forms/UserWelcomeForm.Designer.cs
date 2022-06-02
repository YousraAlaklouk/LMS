
namespace LibraryManegement.Forms
{
    partial class UserWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWelcomeForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBorrowingHistory = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnProfileIcon = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 50);
            this.panel1.TabIndex = 1;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1077, 1);
            this.picboxMax.Margin = new System.Windows.Forms.Padding(4);
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
            this.picboxClose.Location = new System.Drawing.Point(1133, 1);
            this.picboxClose.Margin = new System.Windows.Forms.Padding(4);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(121, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 27);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Username";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(370, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(460, 35);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome To The Digital Library";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(29, 14);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(90, 27);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Name: ";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblWelcome;
            this.bunifuDragControl2.Vertical = true;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LeftPanel.Controls.Add(this.btnPayment);
            this.LeftPanel.Controls.Add(this.btnLogout);
            this.LeftPanel.Controls.Add(this.btnBorrowingHistory);
            this.LeftPanel.Controls.Add(this.btnReturnBook);
            this.LeftPanel.Controls.Add(this.btnBorrowBook);
            this.LeftPanel.Controls.Add(this.btnProfileIcon);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 50);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(199, 569);
            this.LeftPanel.TabIndex = 4;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Rockwell Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(4, 339);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(190, 50);
            this.btnPayment.TabIndex = 18;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.button1_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(0, 506);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 50);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnBorrowingHistory.Location = new System.Drawing.Point(4, 272);
            this.btnBorrowingHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrowingHistory.Name = "btnBorrowingHistory";
            this.btnBorrowingHistory.Size = new System.Drawing.Size(190, 50);
            this.btnBorrowingHistory.TabIndex = 16;
            this.btnBorrowingHistory.Text = "Borrow History";
            this.btnBorrowingHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnReturnBook.Location = new System.Drawing.Point(0, 205);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(190, 50);
            this.btnReturnBook.TabIndex = 15;
            this.btnReturnBook.Text = "Return a Book";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnBorrowBook.Location = new System.Drawing.Point(0, 138);
            this.btnBorrowBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(190, 50);
            this.btnBorrowBook.TabIndex = 14;
            this.btnBorrowBook.Text = "Borrow a Book";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnProfileIcon.Location = new System.Drawing.Point(5, 71);
            this.btnProfileIcon.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfileIcon.Name = "btnProfileIcon";
            this.btnProfileIcon.Size = new System.Drawing.Size(190, 50);
            this.btnProfileIcon.TabIndex = 13;
            this.btnProfileIcon.Text = "Pofile";
            this.btnProfileIcon.UseCompatibleTextRendering = true;
            this.btnProfileIcon.UseVisualStyleBackColor = false;
            this.btnProfileIcon.Click += new System.EventHandler(this.btnProfileIcon_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightPanel.BackgroundImage")));
            this.RightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(199, 50);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(1001, 569);
            this.RightPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UserWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWelcomeForm";
            this.Load += new System.EventHandler(this.UserWelcomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblState;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Button btnBorrowingHistory;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnProfileIcon;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPayment;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}