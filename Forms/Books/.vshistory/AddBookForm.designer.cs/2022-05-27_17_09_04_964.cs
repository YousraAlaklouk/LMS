
namespace LibraryManegement
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.cmbboxAddBookType = new System.Windows.Forms.ComboBox();
            this.lblAddBooktype = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxMax = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddBook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.MaskedTextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.btnAddPublisher1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddAuthor1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbboxCategory = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.cmbboxPublisherName = new System.Windows.Forms.ComboBox();
            this.cmbboxAuthorsName = new System.Windows.Forms.ComboBox();
            this.txtboxAddBookTitle = new System.Windows.Forms.TextBox();
            this.lblAddBookName = new System.Windows.Forms.Label();
            this.txtboxAddBookIsbn = new System.Windows.Forms.TextBox();
            this.lblAddBookPublisher = new System.Windows.Forms.Label();
            this.lblAddAuthorName = new System.Windows.Forms.Label();
            this.lblAddBookIsbn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnklblPickBook = new System.Windows.Forms.LinkLabel();
            this.picbocCover = new System.Windows.Forms.PictureBox();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.BookDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.lblBookCover = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPublisher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAuthor1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbocCover)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbboxAddBookType
            // 
            this.cmbboxAddBookType.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbboxAddBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxAddBookType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbboxAddBookType.FormattingEnabled = true;
            this.cmbboxAddBookType.Items.AddRange(new object[] {
            "Action",
            "Herror",
            "Drama",
            "Novel",
            "Short story",
            "Thrill",
            "Romance",
            "Comedy",
            "LOL"});
            this.cmbboxAddBookType.Location = new System.Drawing.Point(471, 645);
            this.cmbboxAddBookType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxAddBookType.Name = "cmbboxAddBookType";
            this.cmbboxAddBookType.Size = new System.Drawing.Size(253, 35);
            this.cmbboxAddBookType.TabIndex = 27;
            // 
            // lblAddBooktype
            // 
            this.lblAddBooktype.AutoSize = true;
            this.lblAddBooktype.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblAddBooktype.ForeColor = System.Drawing.Color.White;
            this.lblAddBooktype.Location = new System.Drawing.Point(75, 634);
            this.lblAddBooktype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBooktype.Name = "lblAddBooktype";
            this.lblAddBooktype.Size = new System.Drawing.Size(150, 38);
            this.lblAddBooktype.TabIndex = 28;
            this.lblAddBooktype.Text = "Book Type:";
            this.lblAddBooktype.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picboxMax);
            this.panel1.Controls.Add(this.picboxClose);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 99;
            // 
            // picboxMax
            // 
            this.picboxMax.Image = ((System.Drawing.Image)(resources.GetObject("picboxMax.Image")));
            this.picboxMax.Location = new System.Drawing.Point(1084, 3);
            this.picboxMax.Name = "picboxMax";
            this.picboxMax.Size = new System.Drawing.Size(48, 48);
            this.picboxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxMax.TabIndex = 14;
            this.picboxMax.TabStop = false;
            this.picboxMax.Click += new System.EventHandler(this.picboxMax_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(1140, 3);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(48, 48);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClose.TabIndex = 13;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(487, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(263, 37);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Add a new Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnAddBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 725);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 75);
            this.panel2.TabIndex = 50;
            // 
            // btnAddBook
            // 
            this.btnAddBook.ActiveBorderThickness = 1;
            this.btnAddBook.ActiveCornerRadius = 20;
            this.btnAddBook.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddBook.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddBook.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAddBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddBook.BackgroundImage")));
            this.btnAddBook.ButtonText = "Add";
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddBook.IdleBorderThickness = 1;
            this.btnAddBook.IdleCornerRadius = 20;
            this.btnAddBook.IdleFillColor = System.Drawing.Color.White;
            this.btnAddBook.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddBook.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddBook.Location = new System.Drawing.Point(527, 3);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(166, 41);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.txtEdition);
            this.groupBox1.Controls.Add(this.txtEditor);
            this.groupBox1.Controls.Add(this.txtLang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.txtboxQuantity);
            this.groupBox1.Controls.Add(this.btnAddPublisher1);
            this.groupBox1.Controls.Add(this.btnAddAuthor1);
            this.groupBox1.Controls.Add(this.cmbboxCategory);
            this.groupBox1.Controls.Add(this.lblCat);
            this.groupBox1.Controls.Add(this.cmbboxPublisherName);
            this.groupBox1.Controls.Add(this.cmbboxAuthorsName);
            this.groupBox1.Controls.Add(this.txtboxAddBookTitle);
            this.groupBox1.Controls.Add(this.lblAddBookName);
            this.groupBox1.Controls.Add(this.txtboxAddBookIsbn);
            this.groupBox1.Controls.Add(this.lblAddBookPublisher);
            this.groupBox1.Controls.Add(this.lblAddAuthorName);
            this.groupBox1.Controls.Add(this.lblAddBookIsbn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 604);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Required info";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(251, 551);
            this.txtCount.Mask = "00000";
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(253, 36);
            this.txtCount.TabIndex = 92;
            this.txtCount.ValidatingType = typeof(int);
            // 
            // txtEdition
            // 
            this.txtEdition.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEdition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdition.Location = new System.Drawing.Point(251, 377);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(253, 36);
            this.txtEdition.TabIndex = 91;
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditor.Location = new System.Drawing.Point(251, 440);
            this.txtEditor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(253, 36);
            this.txtEditor.TabIndex = 90;
            // 
            // txtLang
            // 
            this.txtLang.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLang.Location = new System.Drawing.Point(251, 496);
            this.txtLang.Margin = new System.Windows.Forms.Padding(4);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(253, 36);
            this.txtLang.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.label4.Location = new System.Drawing.Point(44, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 38);
            this.label4.TabIndex = 87;
            this.label4.Text = "Language:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.label3.Location = new System.Drawing.Point(43, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 38);
            this.label3.TabIndex = 86;
            this.label3.Text = "Page Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.label2.Location = new System.Drawing.Point(46, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 38);
            this.label2.TabIndex = 85;
            this.label2.Text = "Editors:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.label1.Location = new System.Drawing.Point(53, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 38);
            this.label1.TabIndex = 84;
            this.label1.Text = "Edition:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageActive = null;
            this.btnAddCategory.Location = new System.Drawing.Point(543, 201);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(50, 30);
            this.btnAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCategory.TabIndex = 83;
            this.btnAddCategory.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAddCategory, "add catrgory");
            this.btnAddCategory.Zoom = 10;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(46, 315);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(129, 38);
            this.lblQuantity.TabIndex = 82;
            this.lblQuantity.Text = "Qauntity:";
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.txtboxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxQuantity.Location = new System.Drawing.Point(251, 315);
            this.txtboxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.Size = new System.Drawing.Size(253, 36);
            this.txtboxQuantity.TabIndex = 5;
            // 
            // btnAddPublisher1
            // 
            this.btnAddPublisher1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPublisher1.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPublisher1.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPublisher1.Image")));
            this.btnAddPublisher1.ImageActive = null;
            this.btnAddPublisher1.Location = new System.Drawing.Point(543, 145);
            this.btnAddPublisher1.Name = "btnAddPublisher1";
            this.btnAddPublisher1.Size = new System.Drawing.Size(50, 30);
            this.btnAddPublisher1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddPublisher1.TabIndex = 80;
            this.btnAddPublisher1.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAddPublisher1, "add publisher");
            this.btnAddPublisher1.Zoom = 10;
            this.btnAddPublisher1.Click += new System.EventHandler(this.btnAddPublisher1_Click);
            // 
            // btnAddAuthor1
            // 
            this.btnAddAuthor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAuthor1.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAuthor1.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAuthor1.Image")));
            this.btnAddAuthor1.ImageActive = null;
            this.btnAddAuthor1.Location = new System.Drawing.Point(543, 84);
            this.btnAddAuthor1.Name = "btnAddAuthor1";
            this.btnAddAuthor1.Size = new System.Drawing.Size(50, 30);
            this.btnAddAuthor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddAuthor1.TabIndex = 6;
            this.btnAddAuthor1.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAddAuthor1, "Add author");
            this.btnAddAuthor1.Zoom = 10;
            this.btnAddAuthor1.Click += new System.EventHandler(this.btnAddAuthor1_Click);
            // 
            // cmbboxCategory
            // 
            this.cmbboxCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "    "});
            this.cmbboxCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbboxCategory.DisplayMember = "(none)";
            this.cmbboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbboxCategory.FormattingEnabled = true;
            this.cmbboxCategory.Items.AddRange(new object[] {
            "English",
            "Adyga",
            "Turkish",
            "Russian"});
            this.cmbboxCategory.Location = new System.Drawing.Point(254, 201);
            this.cmbboxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxCategory.Name = "cmbboxCategory";
            this.cmbboxCategory.Size = new System.Drawing.Size(253, 35);
            this.cmbboxCategory.TabIndex = 3;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(45, 197);
            this.lblCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(134, 38);
            this.lblCat.TabIndex = 77;
            this.lblCat.Text = "Category:";
            // 
            // cmbboxPublisherName
            // 
            this.cmbboxPublisherName.AutoCompleteCustomSource.AddRange(new string[] {
            "    "});
            this.cmbboxPublisherName.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbboxPublisherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxPublisherName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbboxPublisherName.FormattingEnabled = true;
            this.cmbboxPublisherName.Location = new System.Drawing.Point(254, 145);
            this.cmbboxPublisherName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxPublisherName.Name = "cmbboxPublisherName";
            this.cmbboxPublisherName.Size = new System.Drawing.Size(253, 35);
            this.cmbboxPublisherName.TabIndex = 2;
            // 
            // cmbboxAuthorsName
            // 
            this.cmbboxAuthorsName.AutoCompleteCustomSource.AddRange(new string[] {
            "    "});
            this.cmbboxAuthorsName.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbboxAuthorsName.DisplayMember = "NAME";
            this.cmbboxAuthorsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxAuthorsName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbboxAuthorsName.FormattingEnabled = true;
            this.cmbboxAuthorsName.Location = new System.Drawing.Point(254, 84);
            this.cmbboxAuthorsName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxAuthorsName.Name = "cmbboxAuthorsName";
            this.cmbboxAuthorsName.Size = new System.Drawing.Size(253, 35);
            this.cmbboxAuthorsName.TabIndex = 1;
            // 
            // txtboxAddBookTitle
            // 
            this.txtboxAddBookTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.txtboxAddBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxAddBookTitle.Location = new System.Drawing.Point(253, 32);
            this.txtboxAddBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAddBookTitle.Name = "txtboxAddBookTitle";
            this.txtboxAddBookTitle.Size = new System.Drawing.Size(253, 36);
            this.txtboxAddBookTitle.TabIndex = 0;
            // 
            // lblAddBookName
            // 
            this.lblAddBookName.AutoSize = true;
            this.lblAddBookName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblAddBookName.ForeColor = System.Drawing.Color.White;
            this.lblAddBookName.Location = new System.Drawing.Point(44, 32);
            this.lblAddBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBookName.Name = "lblAddBookName";
            this.lblAddBookName.Size = new System.Drawing.Size(146, 38);
            this.lblAddBookName.TabIndex = 69;
            this.lblAddBookName.Text = "Book Title:";
            // 
            // txtboxAddBookIsbn
            // 
            this.txtboxAddBookIsbn.BackColor = System.Drawing.Color.Gainsboro;
            this.txtboxAddBookIsbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxAddBookIsbn.Location = new System.Drawing.Point(252, 262);
            this.txtboxAddBookIsbn.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAddBookIsbn.Name = "txtboxAddBookIsbn";
            this.txtboxAddBookIsbn.Size = new System.Drawing.Size(253, 36);
            this.txtboxAddBookIsbn.TabIndex = 4;
            // 
            // lblAddBookPublisher
            // 
            this.lblAddBookPublisher.AutoSize = true;
            this.lblAddBookPublisher.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBookPublisher.ForeColor = System.Drawing.Color.White;
            this.lblAddBookPublisher.Location = new System.Drawing.Point(44, 141);
            this.lblAddBookPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBookPublisher.Name = "lblAddBookPublisher";
            this.lblAddBookPublisher.Size = new System.Drawing.Size(208, 38);
            this.lblAddBookPublisher.TabIndex = 66;
            this.lblAddBookPublisher.Text = "Book Publisher:";
            // 
            // lblAddAuthorName
            // 
            this.lblAddAuthorName.AutoSize = true;
            this.lblAddAuthorName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblAddAuthorName.ForeColor = System.Drawing.Color.White;
            this.lblAddAuthorName.Location = new System.Drawing.Point(44, 80);
            this.lblAddAuthorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAuthorName.Name = "lblAddAuthorName";
            this.lblAddAuthorName.Size = new System.Drawing.Size(190, 38);
            this.lblAddAuthorName.TabIndex = 64;
            this.lblAddAuthorName.Text = "Author Name:";
            // 
            // lblAddBookIsbn
            // 
            this.lblAddBookIsbn.AutoSize = true;
            this.lblAddBookIsbn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblAddBookIsbn.ForeColor = System.Drawing.Color.White;
            this.lblAddBookIsbn.Location = new System.Drawing.Point(43, 258);
            this.lblAddBookIsbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBookIsbn.Name = "lblAddBookIsbn";
            this.lblAddBookIsbn.Size = new System.Drawing.Size(144, 38);
            this.lblAddBookIsbn.TabIndex = 63;
            this.lblAddBookIsbn.Text = "Book Isbn:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 665);
            this.panel3.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnklblPickBook);
            this.groupBox2.Controls.Add(this.picbocCover);
            this.groupBox2.Controls.Add(this.bunifuRating1);
            this.groupBox2.Controls.Add(this.BookDate);
            this.groupBox2.Controls.Add(this.lblPublishDate);
            this.groupBox2.Controls.Add(this.lblBookCover);
            this.groupBox2.Controls.Add(this.lblRate);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(627, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 604);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extra Info";
            // 
            // lnklblPickBook
            // 
            this.lnklblPickBook.AutoSize = true;
            this.lnklblPickBook.Location = new System.Drawing.Point(247, 510);
            this.lnklblPickBook.Name = "lnklblPickBook";
            this.lnklblPickBook.Size = new System.Drawing.Size(135, 27);
            this.lnklblPickBook.TabIndex = 2;
            this.lnklblPickBook.TabStop = true;
            this.lnklblPickBook.Text = "Pick Cover";
            this.toolTip1.SetToolTip(this.lnklblPickBook, "choose a cover pic");
            this.lnklblPickBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblPickBook_LinkClicked);
            // 
            // picbocCover
            // 
            this.picbocCover.Image = ((System.Drawing.Image)(resources.GetObject("picbocCover.Image")));
            this.picbocCover.Location = new System.Drawing.Point(230, 380);
            this.picbocCover.Name = "picbocCover";
            this.picbocCover.Size = new System.Drawing.Size(126, 127);
            this.picbocCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbocCover.TabIndex = 83;
            this.picbocCover.TabStop = false;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuRating1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.bunifuRating1.Location = new System.Drawing.Point(147, 270);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(308, 50);
            this.bunifuRating1.TabIndex = 1;
            this.bunifuRating1.Value = 0;
            // 
            // BookDate
            // 
            this.BookDate.BackColor = System.Drawing.Color.CadetBlue;
            this.BookDate.BorderRadius = 0;
            this.BookDate.ForeColor = System.Drawing.Color.White;
            this.BookDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BookDate.FormatCustom = "";
            this.BookDate.Location = new System.Drawing.Point(120, 155);
            this.BookDate.Margin = new System.Windows.Forms.Padding(6);
            this.BookDate.Name = "BookDate";
            this.BookDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BookDate.Size = new System.Drawing.Size(376, 44);
            this.BookDate.TabIndex = 0;
            this.BookDate.Value = new System.DateTime(2021, 5, 4, 12, 17, 11, 16);
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblPublishDate.ForeColor = System.Drawing.Color.White;
            this.lblPublishDate.Location = new System.Drawing.Point(23, 94);
            this.lblPublishDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(218, 38);
            this.lblPublishDate.TabIndex = 79;
            this.lblPublishDate.Text = "Publishing Date:";
            // 
            // lblBookCover
            // 
            this.lblBookCover.AutoSize = true;
            this.lblBookCover.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblBookCover.ForeColor = System.Drawing.Color.White;
            this.lblBookCover.Location = new System.Drawing.Point(32, 394);
            this.lblBookCover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCover.Name = "lblBookCover";
            this.lblBookCover.Size = new System.Drawing.Size(164, 38);
            this.lblBookCover.TabIndex = 78;
            this.lblBookCover.Text = "Book Cover:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(28, 242);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(72, 38);
            this.lblRate.TabIndex = 77;
            this.lblRate.Text = "Rate";
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
            this.bunifuDragControl2.TargetControl = this.lblWelcome;
            this.bunifuDragControl2.Vertical = true;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddBooktype);
            this.Controls.Add(this.cmbboxAddBookType);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPublisher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAuthor1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbocCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbboxAddBookType;
        private System.Windows.Forms.Label lblAddBooktype;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAddBookName;
        private System.Windows.Forms.Label lblAddBookPublisher;
        private System.Windows.Forms.Label lblAddAuthorName;
        private System.Windows.Forms.Label lblAddBookIsbn;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.Label lblBookCover;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.LinkLabel lnklblPickBook;
        private System.Windows.Forms.Label lblCat;
        private Bunifu.Framework.UI.BunifuImageButton btnAddPublisher1;
        private Bunifu.Framework.UI.BunifuImageButton btnAddAuthor1;
        private System.Windows.Forms.Label lblQuantity;
        private Bunifu.Framework.UI.BunifuImageButton btnAddCategory;
        public Bunifu.Framework.UI.BunifuThinButton2 btnAddBook;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cmbboxPublisherName;
        public System.Windows.Forms.ComboBox cmbboxAuthorsName;
        public System.Windows.Forms.TextBox txtboxAddBookIsbn;
        public Bunifu.Framework.UI.BunifuDatepicker BookDate;
        public System.Windows.Forms.TextBox txtboxAddBookTitle;
        public System.Windows.Forms.PictureBox picbocCover;
        public Bunifu.Framework.UI.BunifuRating bunifuRating1;
        public System.Windows.Forms.ComboBox cmbboxCategory;
        public System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.PictureBox picboxMax;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.MaskedTextBox txtCount;
        public System.Windows.Forms.TextBox txtEdition;
        public System.Windows.Forms.TextBox txtEditor;
        public System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}