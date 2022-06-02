
namespace LibraryManegement
{
    partial class PublisherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblPublisherList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnUpdatePublisher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeletePublisher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddPublisher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.midPanel = new System.Windows.Forms.Panel();
            this.dataGridViewPublisher = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPublisherAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxPublisherAddress = new System.Windows.Forms.TextBox();
            this.lblPublisherYearOfFoundation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxpublisherYearOffoundation = new System.Windows.Forms.TextBox();
            this.grpboxEssentialDetails = new System.Windows.Forms.GroupBox();
            this.lblPublisherName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPublisherEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxPublisherName = new System.Windows.Forms.TextBox();
            this.txtboxPublisherEmail = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublisher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpboxEssentialDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.picboxMax);
            this.topPanel.Controls.Add(this.picboxClose);
            this.topPanel.Controls.Add(this.lblPublisherList);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 79);
            this.topPanel.TabIndex = 2;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1082, 12);
            this.picboxMax.Name = "picboxMax";
            this.picboxMax.Size = new System.Drawing.Size(50, 50);
            this.picboxMax.TabIndex = 10;
            this.picboxMax.TabStop = false;
            this.picboxMax.Click += new System.EventHandler(this.picboxMax_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(1138, 12);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(50, 50);
            this.picboxClose.TabIndex = 9;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblPublisherList
            // 
            this.lblPublisherList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPublisherList.AutoSize = true;
            this.lblPublisherList.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherList.ForeColor = System.Drawing.Color.White;
            this.lblPublisherList.Location = new System.Drawing.Point(492, 9);
            this.lblPublisherList.Name = "lblPublisherList";
            this.lblPublisherList.Size = new System.Drawing.Size(223, 37);
            this.lblPublisherList.TabIndex = 4;
            this.lblPublisherList.Text = "Publisher List";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bottomPanel.Controls.Add(this.btnUpdatePublisher);
            this.bottomPanel.Controls.Add(this.btnDeletePublisher);
            this.bottomPanel.Controls.Add(this.btnAddPublisher);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1200, 100);
            this.bottomPanel.TabIndex = 1;
            // 
            // btnUpdatePublisher
            // 
            this.btnUpdatePublisher.ActiveBorderThickness = 1;
            this.btnUpdatePublisher.ActiveCornerRadius = 20;
            this.btnUpdatePublisher.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatePublisher.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdatePublisher.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdatePublisher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdatePublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUpdatePublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePublisher.BackgroundImage")));
            this.btnUpdatePublisher.ButtonText = "Update Publisher";
            this.btnUpdatePublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePublisher.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatePublisher.IdleBorderThickness = 1;
            this.btnUpdatePublisher.IdleCornerRadius = 20;
            this.btnUpdatePublisher.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdatePublisher.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnUpdatePublisher.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatePublisher.Location = new System.Drawing.Point(709, 28);
            this.btnUpdatePublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatePublisher.Name = "btnUpdatePublisher";
            this.btnUpdatePublisher.Size = new System.Drawing.Size(202, 41);
            this.btnUpdatePublisher.TabIndex = 2;
            this.btnUpdatePublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnUpdatePublisher, "Select a publicher to update");
            this.btnUpdatePublisher.Click += new System.EventHandler(this.btnUpdatePublisher_Click);
            // 
            // btnDeletePublisher
            // 
            this.btnDeletePublisher.ActiveBorderThickness = 1;
            this.btnDeletePublisher.ActiveCornerRadius = 20;
            this.btnDeletePublisher.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeletePublisher.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeletePublisher.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeletePublisher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletePublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeletePublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePublisher.BackgroundImage")));
            this.btnDeletePublisher.ButtonText = "Delete Publisher";
            this.btnDeletePublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePublisher.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDeletePublisher.IdleBorderThickness = 1;
            this.btnDeletePublisher.IdleCornerRadius = 20;
            this.btnDeletePublisher.IdleFillColor = System.Drawing.Color.White;
            this.btnDeletePublisher.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnDeletePublisher.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnDeletePublisher.Location = new System.Drawing.Point(289, 28);
            this.btnDeletePublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePublisher.Name = "btnDeletePublisher";
            this.btnDeletePublisher.Size = new System.Drawing.Size(202, 41);
            this.btnDeletePublisher.TabIndex = 1;
            this.btnDeletePublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnDeletePublisher, "Select a publisher to delete");
            this.btnDeletePublisher.Click += new System.EventHandler(this.btnDeletePublisher_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.ActiveBorderThickness = 1;
            this.btnAddPublisher.ActiveCornerRadius = 20;
            this.btnAddPublisher.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddPublisher.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddPublisher.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddPublisher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddPublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPublisher.BackgroundImage")));
            this.btnAddPublisher.ButtonText = "Add new Publisher";
            this.btnAddPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublisher.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddPublisher.IdleBorderThickness = 1;
            this.btnAddPublisher.IdleCornerRadius = 20;
            this.btnAddPublisher.IdleFillColor = System.Drawing.Color.White;
            this.btnAddPublisher.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddPublisher.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddPublisher.Location = new System.Drawing.Point(499, 28);
            this.btnAddPublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(202, 41);
            this.btnAddPublisher.TabIndex = 0;
            this.btnAddPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.DimGray;
            this.midPanel.Controls.Add(this.dataGridViewPublisher);
            this.midPanel.Controls.Add(this.groupBox2);
            this.midPanel.Controls.Add(this.grpboxEssentialDetails);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 0);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1200, 619);
            this.midPanel.TabIndex = 2;
            // 
            // dataGridViewPublisher
            // 
            this.dataGridViewPublisher.AllowUserToAddRows = false;
            this.dataGridViewPublisher.AllowUserToDeleteRows = false;
            this.dataGridViewPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPublisher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPublisher.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPublisher.CausesValidation = false;
            this.dataGridViewPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPublisher.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPublisher.Location = new System.Drawing.Point(536, 107);
            this.dataGridViewPublisher.Name = "dataGridViewPublisher";
            this.dataGridViewPublisher.ReadOnly = true;
            this.dataGridViewPublisher.RowHeadersWidth = 51;
            this.dataGridViewPublisher.RowTemplate.Height = 24;
            this.dataGridViewPublisher.Size = new System.Drawing.Size(642, 366);
            this.dataGridViewPublisher.StandardTab = true;
            this.dataGridViewPublisher.TabIndex = 100;
            this.dataGridViewPublisher.TabStop = false;
            this.dataGridViewPublisher.VirtualMode = true;
            this.dataGridViewPublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPublisher_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.lblPublisherAddress);
            this.groupBox2.Controls.Add(this.txtboxPublisherAddress);
            this.groupBox2.Controls.Add(this.lblPublisherYearOfFoundation);
            this.groupBox2.Controls.Add(this.txtboxpublisherYearOffoundation);
            this.groupBox2.Location = new System.Drawing.Point(261, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 265);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra Details";
            // 
            // lblPublisherAddress
            // 
            this.lblPublisherAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublisherAddress.AutoSize = true;
            this.lblPublisherAddress.Location = new System.Drawing.Point(22, 139);
            this.lblPublisherAddress.Name = "lblPublisherAddress";
            this.lblPublisherAddress.Size = new System.Drawing.Size(87, 22);
            this.lblPublisherAddress.TabIndex = 2;
            this.lblPublisherAddress.Text = "Address";
            // 
            // txtboxPublisherAddress
            // 
            this.txtboxPublisherAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPublisherAddress.Location = new System.Drawing.Point(37, 176);
            this.txtboxPublisherAddress.Name = "txtboxPublisherAddress";
            this.txtboxPublisherAddress.Size = new System.Drawing.Size(179, 31);
            this.txtboxPublisherAddress.TabIndex = 3;
            // 
            // lblPublisherYearOfFoundation
            // 
            this.lblPublisherYearOfFoundation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublisherYearOfFoundation.AutoSize = true;
            this.lblPublisherYearOfFoundation.Location = new System.Drawing.Point(22, 38);
            this.lblPublisherYearOfFoundation.Name = "lblPublisherYearOfFoundation";
            this.lblPublisherYearOfFoundation.Size = new System.Drawing.Size(182, 22);
            this.lblPublisherYearOfFoundation.TabIndex = 0;
            this.lblPublisherYearOfFoundation.Text = "Year of Foundation";
            // 
            // txtboxpublisherYearOffoundation
            // 
            this.txtboxpublisherYearOffoundation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxpublisherYearOffoundation.Location = new System.Drawing.Point(37, 74);
            this.txtboxpublisherYearOffoundation.Name = "txtboxpublisherYearOffoundation";
            this.txtboxpublisherYearOffoundation.Size = new System.Drawing.Size(179, 31);
            this.txtboxpublisherYearOffoundation.TabIndex = 2;
            this.txtboxpublisherYearOffoundation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxpublisherYearOffoundation_KeyPress);
            // 
            // grpboxEssentialDetails
            // 
            this.grpboxEssentialDetails.BackColor = System.Drawing.Color.White;
            this.grpboxEssentialDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpboxEssentialDetails.Controls.Add(this.lblPublisherName);
            this.grpboxEssentialDetails.Controls.Add(this.lblPublisherEmail);
            this.grpboxEssentialDetails.Controls.Add(this.txtboxPublisherName);
            this.grpboxEssentialDetails.Controls.Add(this.txtboxPublisherEmail);
            this.grpboxEssentialDetails.Location = new System.Drawing.Point(27, 107);
            this.grpboxEssentialDetails.Name = "grpboxEssentialDetails";
            this.grpboxEssentialDetails.Size = new System.Drawing.Size(236, 265);
            this.grpboxEssentialDetails.TabIndex = 0;
            this.grpboxEssentialDetails.TabStop = false;
            this.grpboxEssentialDetails.Text = "Essential Details";
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(22, 38);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(160, 22);
            this.lblPublisherName.TabIndex = 0;
            this.lblPublisherName.Text = "Publisher Name:";
            // 
            // lblPublisherEmail
            // 
            this.lblPublisherEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublisherEmail.AutoSize = true;
            this.lblPublisherEmail.Location = new System.Drawing.Point(22, 139);
            this.lblPublisherEmail.Name = "lblPublisherEmail";
            this.lblPublisherEmail.Size = new System.Drawing.Size(63, 22);
            this.lblPublisherEmail.TabIndex = 2;
            this.lblPublisherEmail.Text = "Email";
            // 
            // txtboxPublisherName
            // 
            this.txtboxPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPublisherName.Location = new System.Drawing.Point(37, 74);
            this.txtboxPublisherName.Name = "txtboxPublisherName";
            this.txtboxPublisherName.Size = new System.Drawing.Size(164, 31);
            this.txtboxPublisherName.TabIndex = 0;
            // 
            // txtboxPublisherEmail
            // 
            this.txtboxPublisherEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPublisherEmail.Location = new System.Drawing.Point(37, 176);
            this.txtboxPublisherEmail.Name = "txtboxPublisherEmail";
            this.txtboxPublisherEmail.Size = new System.Drawing.Size(164, 31);
            this.txtboxPublisherEmail.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblPublisherList;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.topPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.midPanel);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PublisherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPublisherForm";
            this.Activated += new System.EventHandler(this.AddPublisherForm_Activated);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.midPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublisher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpboxEssentialDetails.ResumeLayout(false);
            this.grpboxEssentialDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPublisherList;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddPublisher;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.GroupBox grpboxEssentialDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPublisherAddress;
        private System.Windows.Forms.TextBox txtboxPublisherAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPublisherName;
        private System.Windows.Forms.TextBox txtboxPublisherName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPublisherEmail;
        private System.Windows.Forms.TextBox txtboxPublisherEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPublisherYearOfFoundation;
        private System.Windows.Forms.TextBox txtboxpublisherYearOffoundation;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdatePublisher;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeletePublisher;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dataGridViewPublisher;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}