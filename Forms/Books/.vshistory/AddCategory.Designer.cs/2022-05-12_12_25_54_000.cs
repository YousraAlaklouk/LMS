
namespace LibraryManegement
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxAddCat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Category \r\n";
            // 
            // txtboxAddCat
            // 
            this.txtboxAddCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxAddCat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtboxAddCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxAddCat.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxAddCat.HintText = "";
            this.txtboxAddCat.isPassword = false;
            this.txtboxAddCat.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxAddCat.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxAddCat.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxAddCat.LineThickness = 3;
            this.txtboxAddCat.Location = new System.Drawing.Point(0, 134);
            this.txtboxAddCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAddCat.Name = "txtboxAddCat";
            this.txtboxAddCat.Size = new System.Drawing.Size(385, 44);
            this.txtboxAddCat.TabIndex = 0;
            this.txtboxAddCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.picboxClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 70);
            this.panel1.TabIndex = 2;
            // 
            // picboxClose
            // 
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(321, 6);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 12;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add a new Category";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.ActiveBorderThickness = 1;
            this.btnAddCategory.ActiveCornerRadius = 20;
            this.btnAddCategory.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCategory.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCategory.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.ButtonText = "Add Category";
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddCategory.IdleBorderThickness = 1;
            this.btnAddCategory.IdleCornerRadius = 20;
            this.btnAddCategory.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCategory.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddCategory.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddCategory.Location = new System.Drawing.Point(97, 3);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(190, 41);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnAddCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 49);
            this.panel2.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 257);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxAddCat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxAddCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}