
namespace LibraryManegement.Forms
{
    partial class SignUpMemberForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpMemberForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.chckboxPrivecy = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picboxClose);
            this.panel1.Controls.Add(this.lblSignUp);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 55);
            this.panel1.TabIndex = 29;
            // 
            // picboxClose
            // 
            this.bunifuTransition1.SetDecoration(this.picboxClose, BunifuAnimatorNS.DecorationType.None);
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(1140, 5);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 45;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblSignUp, BunifuAnimatorNS.DecorationType.None);
            this.lblSignUp.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSignUp.Location = new System.Drawing.Point(540, 9);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(120, 35);
            this.lblSignUp.TabIndex = 44;
            this.lblSignUp.Text = "Sign up";
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Signup";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnRegister, BunifuAnimatorNS.DecorationType.None);
            this.btnRegister.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnRegister.Location = new System.Drawing.Point(469, 541);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(252, 54);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 100;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblUsername, BunifuAnimatorNS.DecorationType.None);
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(57, 161);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 23);
            this.lblUsername.TabIndex = 31;
            this.lblUsername.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Password:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblGender, BunifuAnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(57, 383);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 23);
            this.lblGender.TabIndex = 33;
            this.lblGender.Text = "Gender:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblName, BunifuAnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(693, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 23);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblEmail, BunifuAnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(693, 273);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 23);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblAddress, BunifuAnimatorNS.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(693, 383);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 23);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address:";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.cmbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.cmbGender, BunifuAnimatorNS.DecorationType.None);
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer Not To Say"});
            this.cmbGender.Location = new System.Drawing.Point(106, 418);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(290, 44);
            this.cmbGender.TabIndex = 2;
            // 
            // chckboxPrivecy
            // 
            this.chckboxPrivecy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chckboxPrivecy.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chckboxPrivecy.Checked = false;
            this.chckboxPrivecy.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.chckboxPrivecy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.chckboxPrivecy, BunifuAnimatorNS.DecorationType.None);
            this.chckboxPrivecy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckboxPrivecy.ForeColor = System.Drawing.Color.White;
            this.chckboxPrivecy.Location = new System.Drawing.Point(394, 496);
            this.chckboxPrivecy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chckboxPrivecy.Name = "chckboxPrivecy";
            this.chckboxPrivecy.Size = new System.Drawing.Size(20, 20);
            this.chckboxPrivecy.TabIndex = 6;
            this.toolTip1.SetToolTip(this.chckboxPrivecy, "You can\'t create an account with out accepting the privecy policy");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(422, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "I\'ve read & Accept library privecy policy";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblWelcome, BunifuAnimatorNS.DecorationType.None);
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(370, 91);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(460, 35);
            this.lblWelcome.TabIndex = 45;
            this.lblWelcome.Text = "Welcome To The Digital Library";
            // 
            // txtboxName
            // 
            this.txtboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.bunifuTransition1.SetDecoration(this.txtboxName, BunifuAnimatorNS.DecorationType.None);
            this.txtboxName.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.ForeColor = System.Drawing.Color.White;
            this.txtboxName.Location = new System.Drawing.Point(759, 206);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(290, 35);
            this.txtboxName.TabIndex = 3;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.bunifuTransition1.SetDecoration(this.txtboxUsername, BunifuAnimatorNS.DecorationType.None);
            this.txtboxUsername.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.White;
            this.txtboxUsername.Location = new System.Drawing.Point(106, 215);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(290, 35);
            this.txtboxUsername.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtboxUsername, "It will be used to log in");
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.bunifuTransition1.SetDecoration(this.txtboxEmail, BunifuAnimatorNS.DecorationType.None);
            this.txtboxEmail.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.ForeColor = System.Drawing.Color.White;
            this.txtboxEmail.Location = new System.Drawing.Point(759, 303);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(290, 35);
            this.txtboxEmail.TabIndex = 4;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.bunifuTransition1.SetDecoration(this.txtboxAddress, BunifuAnimatorNS.DecorationType.None);
            this.txtboxAddress.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAddress.ForeColor = System.Drawing.Color.White;
            this.txtboxAddress.Location = new System.Drawing.Point(759, 409);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(290, 35);
            this.txtboxAddress.TabIndex = 5;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.bunifuTransition1.SetDecoration(this.txtboxPassword, BunifuAnimatorNS.DecorationType.None);
            this.txtboxPassword.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxPassword.Location = new System.Drawing.Point(106, 314);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(290, 35);
            this.txtboxPassword.TabIndex = 1;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblSignUp;
            this.bunifuDragControl2.Vertical = true;
            // 
            // SignUpMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chckboxPrivecy);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSignUp;
        private Bunifu.Framework.UI.BunifuCheckbox chckboxPrivecy;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}