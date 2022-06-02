
namespace LibraryManegement.Forms
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblReturnAbook = new System.Windows.Forms.Label();
            this.cmboxBookToReturn = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TopPanel.Controls.Add(this.picboxClose);
            this.TopPanel.Controls.Add(this.lblReturnAbook);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 74);
            this.TopPanel.TabIndex = 0;
            // 
            // picboxClose
            // 
            this.picboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(1140, 6);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 12;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblReturnAbook
            // 
            this.lblReturnAbook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReturnAbook.AutoSize = true;
            this.lblReturnAbook.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAbook.ForeColor = System.Drawing.Color.White;
            this.lblReturnAbook.Location = new System.Drawing.Point(484, 13);
            this.lblReturnAbook.Name = "lblReturnAbook";
            this.lblReturnAbook.Size = new System.Drawing.Size(228, 37);
            this.lblReturnAbook.TabIndex = 0;
            this.lblReturnAbook.Text = "Return a Book";
            // 
            // cmboxBookToReturn
            // 
            this.cmboxBookToReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmboxBookToReturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxBookToReturn.FormattingEnabled = true;
            this.cmboxBookToReturn.Location = new System.Drawing.Point(118, 158);
            this.cmboxBookToReturn.Name = "cmboxBookToReturn";
            this.cmboxBookToReturn.Size = new System.Drawing.Size(323, 24);
            this.cmboxBookToReturn.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(201, 223);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(159, 28);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblReturnAbook;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmboxBookToReturn);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "returnBookForm";
            this.Activated += new System.EventHandler(this.ReturnBookForm_Activated);
            this.Load += new System.EventHandler(this.returnBookForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ComboBox cmboxBookToReturn;
        private System.Windows.Forms.Label lblReturnAbook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}