
namespace LibraryManegement.Forms.Reports
{
    partial class ReportsFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsFrom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblReportsList = new System.Windows.Forms.Label();
            this.btnBorrowingReports = new System.Windows.Forms.Button();
            this.btnPenaltyReports = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picboxMax);
            this.panel1.Controls.Add(this.picboxClose);
            this.panel1.Controls.Add(this.lblReportsList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 63);
            this.panel1.TabIndex = 14;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(875, 3);
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
            this.picboxClose.Location = new System.Drawing.Point(940, 3);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblReportsList
            // 
            this.lblReportsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReportsList.AutoSize = true;
            this.lblReportsList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsList.ForeColor = System.Drawing.Color.White;
            this.lblReportsList.Location = new System.Drawing.Point(358, 13);
            this.lblReportsList.Name = "lblReportsList";
            this.lblReportsList.Size = new System.Drawing.Size(278, 37);
            this.lblReportsList.TabIndex = 4;
            this.lblReportsList.Text = "Choose a Report ";
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
            this.btnBorrowingReports.Location = new System.Drawing.Point(211, 142);
            this.btnBorrowingReports.Name = "btnBorrowingReports";
            this.btnBorrowingReports.Size = new System.Drawing.Size(160, 152);
            this.btnBorrowingReports.TabIndex = 28;
            this.btnBorrowingReports.Text = "borrowing reports";
            this.btnBorrowingReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrowingReports.UseVisualStyleBackColor = false;
            this.btnBorrowingReports.Click += new System.EventHandler(this.btnBorrowingReports_Click);
            // 
            // btnPenaltyReports
            // 
            this.btnPenaltyReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnPenaltyReports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPenaltyReports.FlatAppearance.BorderSize = 0;
            this.btnPenaltyReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPenaltyReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenaltyReports.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPenaltyReports.ForeColor = System.Drawing.Color.White;
            this.btnPenaltyReports.Image = ((System.Drawing.Image)(resources.GetObject("btnPenaltyReports.Image")));
            this.btnPenaltyReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPenaltyReports.Location = new System.Drawing.Point(593, 142);
            this.btnPenaltyReports.Name = "btnPenaltyReports";
            this.btnPenaltyReports.Size = new System.Drawing.Size(160, 152);
            this.btnPenaltyReports.TabIndex = 29;
            this.btnPenaltyReports.Text = "Penalty reports";
            this.btnPenaltyReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPenaltyReports.UseVisualStyleBackColor = false;
            this.btnPenaltyReports.Click += new System.EventHandler(this.btnPenaltyReports_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblReportsList;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ReportsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1000, 419);
            this.Controls.Add(this.btnPenaltyReports);
            this.Controls.Add(this.btnBorrowingReports);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsFrom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Label lblReportsList;
        private System.Windows.Forms.Button btnBorrowingReports;
        private System.Windows.Forms.Button btnPenaltyReports;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}