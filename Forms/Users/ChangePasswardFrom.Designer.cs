
namespace LibraryManegement.Forms
{
    partial class ChangePasswardFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswardFrom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.btnbnfChangePass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnftxtboxCurrentPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnftxtboxNewPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnftxtboxConfirmPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.picboxClose);
            this.panel1.Controls.Add(this.lblChangePass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 70);
            this.panel1.TabIndex = 8;
            // 
            // picboxClose
            // 
            this.picboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(492, 12);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblChangePass
            // 
            this.lblChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePass.ForeColor = System.Drawing.Color.White;
            this.lblChangePass.Location = new System.Drawing.Point(170, 20);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(213, 27);
            this.lblChangePass.TabIndex = 3;
            this.lblChangePass.Text = "Change Password";
            // 
            // btnbnfChangePass
            // 
            this.btnbnfChangePass.ActiveBorderThickness = 1;
            this.btnbnfChangePass.ActiveCornerRadius = 20;
            this.btnbnfChangePass.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnbnfChangePass.ActiveForecolor = System.Drawing.Color.White;
            this.btnbnfChangePass.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnbnfChangePass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnbnfChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnbnfChangePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbnfChangePass.BackgroundImage")));
            this.btnbnfChangePass.ButtonText = "Change Password";
            this.btnbnfChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbnfChangePass.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnbnfChangePass.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnbnfChangePass.IdleBorderThickness = 1;
            this.btnbnfChangePass.IdleCornerRadius = 20;
            this.btnbnfChangePass.IdleFillColor = System.Drawing.Color.White;
            this.btnbnfChangePass.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnbnfChangePass.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnbnfChangePass.Location = new System.Drawing.Point(170, 11);
            this.btnbnfChangePass.Margin = new System.Windows.Forms.Padding(5);
            this.btnbnfChangePass.Name = "btnbnfChangePass";
            this.btnbnfChangePass.Size = new System.Drawing.Size(213, 41);
            this.btnbnfChangePass.TabIndex = 0;
            this.btnbnfChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbnfChangePass.Click += new System.EventHandler(this.btnbnfChangePass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnbnfChangePass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 61);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label1.Location = new System.Drawing.Point(201, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Password";
            // 
            // btnftxtboxCurrentPass
            // 
            this.btnftxtboxCurrentPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnftxtboxCurrentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnftxtboxCurrentPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnftxtboxCurrentPass.ForeColor = System.Drawing.Color.White;
            this.btnftxtboxCurrentPass.HintForeColor = System.Drawing.Color.Empty;
            this.btnftxtboxCurrentPass.HintText = "";
            this.btnftxtboxCurrentPass.isPassword = true;
            this.btnftxtboxCurrentPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.btnftxtboxCurrentPass.LineIdleColor = System.Drawing.Color.Gray;
            this.btnftxtboxCurrentPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btnftxtboxCurrentPass.LineThickness = 3;
            this.btnftxtboxCurrentPass.Location = new System.Drawing.Point(122, 112);
            this.btnftxtboxCurrentPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnftxtboxCurrentPass.Name = "btnftxtboxCurrentPass";
            this.btnftxtboxCurrentPass.Size = new System.Drawing.Size(293, 25);
            this.btnftxtboxCurrentPass.TabIndex = 0;
            this.btnftxtboxCurrentPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lblNewPassword.Location = new System.Drawing.Point(215, 164);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(123, 20);
            this.lblNewPassword.TabIndex = 10;
            this.lblNewPassword.Text = "New Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label4.Location = new System.Drawing.Point(180, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm New Password";
            // 
            // btnftxtboxNewPass
            // 
            this.btnftxtboxNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnftxtboxNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnftxtboxNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnftxtboxNewPass.ForeColor = System.Drawing.Color.White;
            this.btnftxtboxNewPass.HintForeColor = System.Drawing.Color.Empty;
            this.btnftxtboxNewPass.HintText = "";
            this.btnftxtboxNewPass.isPassword = true;
            this.btnftxtboxNewPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.btnftxtboxNewPass.LineIdleColor = System.Drawing.Color.Gray;
            this.btnftxtboxNewPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btnftxtboxNewPass.LineThickness = 3;
            this.btnftxtboxNewPass.Location = new System.Drawing.Point(122, 188);
            this.btnftxtboxNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnftxtboxNewPass.Name = "btnftxtboxNewPass";
            this.btnftxtboxNewPass.Size = new System.Drawing.Size(293, 25);
            this.btnftxtboxNewPass.TabIndex = 1;
            this.btnftxtboxNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnftxtboxConfirmPass
            // 
            this.btnftxtboxConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnftxtboxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnftxtboxConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnftxtboxConfirmPass.ForeColor = System.Drawing.Color.White;
            this.btnftxtboxConfirmPass.HintForeColor = System.Drawing.Color.Empty;
            this.btnftxtboxConfirmPass.HintText = "";
            this.btnftxtboxConfirmPass.isPassword = true;
            this.btnftxtboxConfirmPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.btnftxtboxConfirmPass.LineIdleColor = System.Drawing.Color.Gray;
            this.btnftxtboxConfirmPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btnftxtboxConfirmPass.LineThickness = 3;
            this.btnftxtboxConfirmPass.Location = new System.Drawing.Point(122, 262);
            this.btnftxtboxConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnftxtboxConfirmPass.Name = "btnftxtboxConfirmPass";
            this.btnftxtboxConfirmPass.Size = new System.Drawing.Size(293, 25);
            this.btnftxtboxConfirmPass.TabIndex = 2;
            this.btnftxtboxConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ChangePasswardFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(552, 359);
            this.Controls.Add(this.btnftxtboxConfirmPass);
            this.Controls.Add(this.btnftxtboxNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnftxtboxCurrentPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswardFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePasswardFrom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChangePass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbnfChangePass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnftxtboxCurrentPass;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnftxtboxNewPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnftxtboxConfirmPass;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}