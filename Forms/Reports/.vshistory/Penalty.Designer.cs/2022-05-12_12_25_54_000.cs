
namespace LibraryManegement.Forms.Reports
{
    partial class Penalty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalty));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rdiobtnPaid = new System.Windows.Forms.RadioButton();
            this.rdiobtnUnpaid = new System.Windows.Forms.RadioButton();
            this.lblCleardata = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picboxMax);
            this.panel1.Controls.Add(this.picboxClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 13;
            // 
            // picboxMax
            // 
            this.picboxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(672, 3);
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
            this.picboxClose.Location = new System.Drawing.Point(740, 3);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Penalty Reports";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(92, 286);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 38);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "To ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(15, 87);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(70, 27);
            this.lblFrom.TabIndex = 10;
            this.lblFrom.Text = "From";
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(107, 142);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(122, 22);
            this.toDate.TabIndex = 9;
            // 
            // FromDate
            // 
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.Location = new System.Drawing.Point(107, 91);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(122, 22);
            this.FromDate.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(274, 91);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(514, 347);
            this.dataGridView.TabIndex = 7;
            // 
            // rdiobtnPaid
            // 
            this.rdiobtnPaid.AutoSize = true;
            this.rdiobtnPaid.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiobtnPaid.ForeColor = System.Drawing.Color.White;
            this.rdiobtnPaid.Location = new System.Drawing.Point(46, 209);
            this.rdiobtnPaid.Name = "rdiobtnPaid";
            this.rdiobtnPaid.Size = new System.Drawing.Size(64, 24);
            this.rdiobtnPaid.TabIndex = 14;
            this.rdiobtnPaid.TabStop = true;
            this.rdiobtnPaid.Text = "Paid";
            this.rdiobtnPaid.UseVisualStyleBackColor = true;
            // 
            // rdiobtnUnpaid
            // 
            this.rdiobtnUnpaid.AutoSize = true;
            this.rdiobtnUnpaid.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiobtnUnpaid.ForeColor = System.Drawing.Color.White;
            this.rdiobtnUnpaid.Location = new System.Drawing.Point(134, 209);
            this.rdiobtnUnpaid.Name = "rdiobtnUnpaid";
            this.rdiobtnUnpaid.Size = new System.Drawing.Size(86, 24);
            this.rdiobtnUnpaid.TabIndex = 15;
            this.rdiobtnUnpaid.TabStop = true;
            this.rdiobtnUnpaid.Text = "Unpaid";
            this.rdiobtnUnpaid.UseVisualStyleBackColor = true;
            // 
            // lblCleardata
            // 
            this.lblCleardata.AutoSize = true;
            this.lblCleardata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleardata.ForeColor = System.Drawing.Color.White;
            this.lblCleardata.Location = new System.Drawing.Point(89, 247);
            this.lblCleardata.Name = "lblCleardata";
            this.lblCleardata.Size = new System.Drawing.Size(88, 17);
            this.lblCleardata.TabIndex = 16;
            this.lblCleardata.Text = "Clear Choice";
            this.lblCleardata.Click += new System.EventHandler(this.lblCleardata_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Penalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCleardata);
            this.Controls.Add(this.rdiobtnUnpaid);
            this.Controls.Add(this.rdiobtnPaid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Penalty";
            this.Text = "PanaltyReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.RadioButton rdiobtnPaid;
        private System.Windows.Forms.RadioButton rdiobtnUnpaid;
        private System.Windows.Forms.Label lblCleardata;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}