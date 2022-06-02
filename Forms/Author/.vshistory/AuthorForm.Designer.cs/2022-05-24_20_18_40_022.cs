
namespace LibraryManegement
{
    partial class AuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblAuthorList = new System.Windows.Forms.Label();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnDeleteAuthor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdateAuthor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddAuthor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.midPanel = new System.Windows.Forms.Panel();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAuthorEmail = new System.Windows.Forms.Label();
            this.lblAuthorNationality = new System.Windows.Forms.Label();
            this.txtboxAuthorEmail = new System.Windows.Forms.TextBox();
            this.txtboxAuthorNationality = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAuthorSurname = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtboxAuthorSurname = new System.Windows.Forms.TextBox();
            this.txtboxAuthorName = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.lblAuthorList);
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 79);
            this.topPanel.TabIndex = 0;
            // 
            // lblAuthorList
            // 
            this.lblAuthorList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAuthorList.AutoSize = true;
            this.lblAuthorList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorList.ForeColor = System.Drawing.Color.White;
            this.lblAuthorList.Location = new System.Drawing.Point(508, 22);
            this.lblAuthorList.Name = "lblAuthorList";
            this.lblAuthorList.Size = new System.Drawing.Size(219, 46);
            this.lblAuthorList.TabIndex = 6;
            this.lblAuthorList.Text = "Author List";
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1077, 16);
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
            this.picboxClose.Location = new System.Drawing.Point(1140, 16);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnDeleteAuthor);
            this.bottomPanel.Controls.Add(this.btnUpdateAuthor);
            this.bottomPanel.Controls.Add(this.btnAddAuthor);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1200, 100);
            this.bottomPanel.TabIndex = 1;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.ActiveBorderThickness = 1;
            this.btnDeleteAuthor.ActiveCornerRadius = 20;
            this.btnDeleteAuthor.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteAuthor.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteAuthor.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeleteAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAuthor.BackgroundImage")));
            this.btnDeleteAuthor.ButtonText = "Delete Author";
            this.btnDeleteAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAuthor.IdleBorderThickness = 1;
            this.btnDeleteAuthor.IdleCornerRadius = 20;
            this.btnDeleteAuthor.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteAuthor.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAuthor.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(289, 34);
            this.btnDeleteAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(202, 41);
            this.btnDeleteAuthor.TabIndex = 1;
            this.btnDeleteAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnDeleteAuthor, "select an author to delete");
            this.btnDeleteAuthor.Click += new System.EventHandler(this.deleteAuthor_clicker);
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.ActiveBorderThickness = 1;
            this.btnUpdateAuthor.ActiveCornerRadius = 20;
            this.btnUpdateAuthor.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateAuthor.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateAuthor.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUpdateAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAuthor.BackgroundImage")));
            this.btnUpdateAuthor.ButtonText = "Update Author";
            this.btnUpdateAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAuthor.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAuthor.IdleBorderThickness = 1;
            this.btnUpdateAuthor.IdleCornerRadius = 20;
            this.btnUpdateAuthor.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateAuthor.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAuthor.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAuthor.Location = new System.Drawing.Point(709, 34);
            this.btnUpdateAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(202, 41);
            this.btnUpdateAuthor.TabIndex = 2;
            this.btnUpdateAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnUpdateAuthor, "Choose an author to update");
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.ActiveBorderThickness = 1;
            this.btnAddAuthor.ActiveCornerRadius = 20;
            this.btnAddAuthor.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddAuthor.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddAuthor.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAuthor.BackgroundImage")));
            this.btnAddAuthor.ButtonText = "Add new Author";
            this.btnAddAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddAuthor.IdleBorderThickness = 1;
            this.btnAddAuthor.IdleCornerRadius = 20;
            this.btnAddAuthor.IdleFillColor = System.Drawing.Color.White;
            this.btnAddAuthor.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddAuthor.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddAuthor.Location = new System.Drawing.Point(499, 34);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(202, 41);
            this.btnAddAuthor.TabIndex = 0;
            this.btnAddAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.DimGray;
            this.midPanel.Controls.Add(this.dataGridViewAuthor);
            this.midPanel.Controls.Add(this.groupBox2);
            this.midPanel.Controls.Add(this.groupBox1);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 79);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1200, 440);
            this.midPanel.TabIndex = 2;
            this.midPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.midPanel_Paint);
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.AllowUserToAddRows = false;
            this.dataGridViewAuthor.AllowUserToDeleteRows = false;
            this.dataGridViewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuthor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAuthor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAuthor.CausesValidation = false;
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAuthor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(546, 26);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.ReadOnly = true;
            this.dataGridViewAuthor.RowHeadersWidth = 51;
            this.dataGridViewAuthor.RowTemplate.Height = 24;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(642, 366);
            this.dataGridViewAuthor.StandardTab = true;
            this.dataGridViewAuthor.TabIndex = 101;
            this.dataGridViewAuthor.TabStop = false;
            this.dataGridViewAuthor.VirtualMode = true;
            this.dataGridViewAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAuthor_CellClick);
            this.dataGridViewAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAuthor_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.lblAuthorEmail);
            this.groupBox2.Controls.Add(this.lblAuthorNationality);
            this.groupBox2.Controls.Add(this.txtboxAuthorEmail);
            this.groupBox2.Controls.Add(this.txtboxAuthorNationality);
            this.groupBox2.Location = new System.Drawing.Point(266, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 251);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra details";
            // 
            // lblAuthorEmail
            // 
            this.lblAuthorEmail.AutoSize = true;
            this.lblAuthorEmail.Location = new System.Drawing.Point(11, 140);
            this.lblAuthorEmail.Name = "lblAuthorEmail";
            this.lblAuthorEmail.Size = new System.Drawing.Size(141, 23);
            this.lblAuthorEmail.TabIndex = 5;
            this.lblAuthorEmail.Text = "Author Email:";
            // 
            // lblAuthorNationality
            // 
            this.lblAuthorNationality.AutoSize = true;
            this.lblAuthorNationality.Location = new System.Drawing.Point(11, 38);
            this.lblAuthorNationality.Name = "lblAuthorNationality";
            this.lblAuthorNationality.Size = new System.Drawing.Size(190, 23);
            this.lblAuthorNationality.TabIndex = 4;
            this.lblAuthorNationality.Text = "Author Nationality:";
            // 
            // txtboxAuthorEmail
            // 
            this.txtboxAuthorEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxAuthorEmail.Location = new System.Drawing.Point(53, 163);
            this.txtboxAuthorEmail.Name = "txtboxAuthorEmail";
            this.txtboxAuthorEmail.Size = new System.Drawing.Size(158, 31);
            this.txtboxAuthorEmail.TabIndex = 3;
            // 
            // txtboxAuthorNationality
            // 
            this.txtboxAuthorNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxAuthorNationality.Location = new System.Drawing.Point(53, 61);
            this.txtboxAuthorNationality.Name = "txtboxAuthorNationality";
            this.txtboxAuthorNationality.Size = new System.Drawing.Size(158, 31);
            this.txtboxAuthorNationality.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblAuthorSurname);
            this.groupBox1.Controls.Add(this.lblAuthorName);
            this.groupBox1.Controls.Add(this.txtboxAuthorSurname);
            this.groupBox1.Controls.Add(this.txtboxAuthorName);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Essential details";
            // 
            // lblAuthorSurname
            // 
            this.lblAuthorSurname.AutoSize = true;
            this.lblAuthorSurname.Location = new System.Drawing.Point(22, 130);
            this.lblAuthorSurname.Name = "lblAuthorSurname";
            this.lblAuthorSurname.Size = new System.Drawing.Size(172, 23);
            this.lblAuthorSurname.TabIndex = 7;
            this.lblAuthorSurname.Text = "Author Surname:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(22, 38);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(143, 23);
            this.lblAuthorName.TabIndex = 6;
            this.lblAuthorName.Text = "Author Name:";
            // 
            // txtboxAuthorSurname
            // 
            this.txtboxAuthorSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxAuthorSurname.Location = new System.Drawing.Point(37, 163);
            this.txtboxAuthorSurname.Name = "txtboxAuthorSurname";
            this.txtboxAuthorSurname.Size = new System.Drawing.Size(158, 31);
            this.txtboxAuthorSurname.TabIndex = 1;
            // 
            // txtboxAuthorName
            // 
            this.txtboxAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxAuthorName.Location = new System.Drawing.Point(37, 74);
            this.txtboxAuthorName.Name = "txtboxAuthorName";
            this.txtboxAuthorName.Size = new System.Drawing.Size(158, 31);
            this.txtboxAuthorName.TabIndex = 0;
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
            this.bunifuDragControl2.TargetControl = this.lblAuthorList;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAuthorForm";
            this.Activated += new System.EventHandler(this.AddAuthorForm_Activated);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.midPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxAuthorSurname;
        private System.Windows.Forms.TextBox txtboxAuthorName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAuthor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteAuthor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateAuthor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxAuthorEmail;
        private System.Windows.Forms.TextBox txtboxAuthorNationality;
        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Label lblAuthorNationality;
        private System.Windows.Forms.Label lblAuthorEmail;
        private System.Windows.Forms.Label lblAuthorList;
        private System.Windows.Forms.Label lblAuthorSurname;
        private System.Windows.Forms.Label lblAuthorName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}