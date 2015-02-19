namespace ArtistComplex
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.memberslbl = new System.Windows.Forms.Label();
            this.bandnamelbl = new System.Windows.Forms.Label();
            this.ArtistsListBox = new System.Windows.Forms.ListBox();
            this.hometowntxtbx = new System.Windows.Forms.TextBox();
            this.hometownlbl = new System.Windows.Forms.Label();
            this.dobdatepick = new System.Windows.Forms.DateTimePicker();
            this.doblbl = new System.Windows.Forms.Label();
            this.bandnametxtbx = new System.Windows.Forms.TextBox();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.addArtistBtn = new System.Windows.Forms.Button();
            this.ArtistProfileBx = new System.Windows.Forms.GroupBox();
            this.gendercombbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvatarAdjstBtn = new System.Windows.Forms.Button();
            this.editAlbumBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ciycleLeftBtn = new System.Windows.Forms.Button();
            this.biographytxtbx = new System.Windows.Forms.RichTextBox();
            this.ciycleRightBtn = new System.Windows.Forms.Button();
            this.memberstxtbx = new System.Windows.Forms.TextBox();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.titleDesc = new System.Windows.Forms.Label();
            this.AppTitle = new System.Windows.Forms.Label();
            this.ArtistListBx = new System.Windows.Forms.GroupBox();
            this.showallBtn = new System.Windows.Forms.Button();
            this.artistlistbxlbl = new System.Windows.Forms.Label();
            this.removeArtistBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBx = new System.Windows.Forms.GroupBox();
            this.foundphoto = new System.Windows.Forms.PictureBox();
            this.criterialbl = new System.Windows.Forms.Label();
            this.searchlbl = new System.Windows.Forms.Label();
            this.bytitleCBX = new System.Windows.Forms.CheckBox();
            this.copyrights = new System.Windows.Forms.Label();
            this.StatisticsBox = new System.Windows.Forms.GroupBox();
            this.statsalbum = new System.Windows.Forms.Label();
            this.statsdepth = new System.Windows.Forms.Label();
            this.statsartist = new System.Windows.Forms.Label();
            this.Albumslbl = new System.Windows.Forms.Label();
            this.treedepthlbl = new System.Windows.Forms.Label();
            this.artistlbl = new System.Windows.Forms.Label();
            this.saveArtist = new System.Windows.Forms.Button();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.artistsubstring = new System.Windows.Forms.CheckBox();
            this.ArtistProfileBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.ArtistListBx.SuspendLayout();
            this.SearchBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foundphoto)).BeginInit();
            this.StatisticsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // memberslbl
            // 
            this.memberslbl.AutoSize = true;
            this.memberslbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.memberslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.memberslbl.Location = new System.Drawing.Point(20, 173);
            this.memberslbl.Name = "memberslbl";
            this.memberslbl.Size = new System.Drawing.Size(121, 13);
            this.memberslbl.TabIndex = 15;
            this.memberslbl.Text = "Number of Members";
            // 
            // bandnamelbl
            // 
            this.bandnamelbl.AutoSize = true;
            this.bandnamelbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bandnamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.bandnamelbl.Location = new System.Drawing.Point(20, 145);
            this.bandnamelbl.Name = "bandnamelbl";
            this.bandnamelbl.Size = new System.Drawing.Size(100, 13);
            this.bandnamelbl.TabIndex = 13;
            this.bandnamelbl.Text = "Band/Solo Name";
            // 
            // ArtistsListBox
            // 
            this.ArtistsListBox.BackColor = System.Drawing.Color.White;
            this.ArtistsListBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ArtistsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.ArtistsListBox.FormattingEnabled = true;
            this.ArtistsListBox.Location = new System.Drawing.Point(13, 40);
            this.ArtistsListBox.Name = "ArtistsListBox";
            this.ArtistsListBox.Size = new System.Drawing.Size(258, 147);
            this.ArtistsListBox.TabIndex = 31;
            this.ArtistsListBox.SelectedIndexChanged += new System.EventHandler(this.ArtistsListBox_SelectedIndexChanged);
            // 
            // hometowntxtbx
            // 
            this.hometowntxtbx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hometowntxtbx.Location = new System.Drawing.Point(90, 111);
            this.hometowntxtbx.Name = "hometowntxtbx";
            this.hometowntxtbx.Size = new System.Drawing.Size(110, 21);
            this.hometowntxtbx.TabIndex = 12;
            // 
            // hometownlbl
            // 
            this.hometownlbl.AutoSize = true;
            this.hometownlbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.hometownlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.hometownlbl.Location = new System.Drawing.Point(20, 115);
            this.hometownlbl.Name = "hometownlbl";
            this.hometownlbl.Size = new System.Drawing.Size(68, 13);
            this.hometownlbl.TabIndex = 11;
            this.hometownlbl.Text = "Hometown";
            // 
            // dobdatepick
            // 
            this.dobdatepick.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.dobdatepick.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.dobdatepick.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.dobdatepick.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dobdatepick.Location = new System.Drawing.Point(65, 54);
            this.dobdatepick.Name = "dobdatepick";
            this.dobdatepick.Size = new System.Drawing.Size(135, 21);
            this.dobdatepick.TabIndex = 28;
            this.dobdatepick.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.doblbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.doblbl.Location = new System.Drawing.Point(20, 57);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(30, 13);
            this.doblbl.TabIndex = 9;
            this.doblbl.Text = "DOB";
            // 
            // bandnametxtbx
            // 
            this.bandnametxtbx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bandnametxtbx.Location = new System.Drawing.Point(122, 140);
            this.bandnametxtbx.Name = "bandnametxtbx";
            this.bandnametxtbx.Size = new System.Drawing.Size(78, 21);
            this.bandnametxtbx.TabIndex = 14;
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameTxtBx.Location = new System.Drawing.Point(65, 26);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(135, 21);
            this.NameTxtBx.TabIndex = 8;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.namelbl.Location = new System.Drawing.Point(20, 30);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(39, 13);
            this.namelbl.TabIndex = 7;
            this.namelbl.Text = "Name";
            // 
            // addArtistBtn
            // 
            this.addArtistBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.addArtistBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.addArtistBtn.Location = new System.Drawing.Point(13, 193);
            this.addArtistBtn.Name = "addArtistBtn";
            this.addArtistBtn.Size = new System.Drawing.Size(77, 30);
            this.addArtistBtn.TabIndex = 26;
            this.addArtistBtn.Text = "Add/Edit";
            this.addArtistBtn.UseVisualStyleBackColor = true;
            this.addArtistBtn.Click += new System.EventHandler(this.addArtistBtn_Click);
            // 
            // ArtistProfileBx
            // 
            this.ArtistProfileBx.Controls.Add(this.gendercombbx);
            this.ArtistProfileBx.Controls.Add(this.label1);
            this.ArtistProfileBx.Controls.Add(this.AvatarAdjstBtn);
            this.ArtistProfileBx.Controls.Add(this.editAlbumBtn);
            this.ArtistProfileBx.Controls.Add(this.label7);
            this.ArtistProfileBx.Controls.Add(this.ciycleLeftBtn);
            this.ArtistProfileBx.Controls.Add(this.biographytxtbx);
            this.ArtistProfileBx.Controls.Add(this.ciycleRightBtn);
            this.ArtistProfileBx.Controls.Add(this.dobdatepick);
            this.ArtistProfileBx.Controls.Add(this.memberstxtbx);
            this.ArtistProfileBx.Controls.Add(this.memberslbl);
            this.ArtistProfileBx.Controls.Add(this.bandnametxtbx);
            this.ArtistProfileBx.Controls.Add(this.doblbl);
            this.ArtistProfileBx.Controls.Add(this.bandnamelbl);
            this.ArtistProfileBx.Controls.Add(this.hometowntxtbx);
            this.ArtistProfileBx.Controls.Add(this.hometownlbl);
            this.ArtistProfileBx.Controls.Add(this.NameTxtBx);
            this.ArtistProfileBx.Controls.Add(this.namelbl);
            this.ArtistProfileBx.Controls.Add(this.ProfilePic);
            this.ArtistProfileBx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ArtistProfileBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.ArtistProfileBx.Location = new System.Drawing.Point(25, 123);
            this.ArtistProfileBx.Name = "ArtistProfileBx";
            this.ArtistProfileBx.Size = new System.Drawing.Size(385, 356);
            this.ArtistProfileBx.TabIndex = 32;
            this.ArtistProfileBx.TabStop = false;
            this.ArtistProfileBx.Text = "Artist Profile";
            this.ArtistProfileBx.Enter += new System.EventHandler(this.albumlistBox_Enter);
            // 
            // gendercombbx
            // 
            this.gendercombbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercombbx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gendercombbx.FormattingEnabled = true;
            this.gendercombbx.Items.AddRange(new object[] {
            "male",
            "female"});
            this.gendercombbx.Location = new System.Drawing.Point(71, 82);
            this.gendercombbx.Name = "gendercombbx";
            this.gendercombbx.Size = new System.Drawing.Size(129, 21);
            this.gendercombbx.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gender";
            // 
            // AvatarAdjstBtn
            // 
            this.AvatarAdjstBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AvatarAdjstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.AvatarAdjstBtn.Location = new System.Drawing.Point(232, 170);
            this.AvatarAdjstBtn.Name = "AvatarAdjstBtn";
            this.AvatarAdjstBtn.Size = new System.Drawing.Size(134, 30);
            this.AvatarAdjstBtn.TabIndex = 35;
            this.AvatarAdjstBtn.Text = "Add/Change Avatar ";
            this.AvatarAdjstBtn.UseVisualStyleBackColor = true;
            this.AvatarAdjstBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // editAlbumBtn
            // 
            this.editAlbumBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.editAlbumBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.editAlbumBtn.Location = new System.Drawing.Point(190, 310);
            this.editAlbumBtn.Name = "editAlbumBtn";
            this.editAlbumBtn.Size = new System.Drawing.Size(176, 30);
            this.editAlbumBtn.TabIndex = 33;
            this.editAlbumBtn.Text = "Add/Edit/Browse Albums";
            this.editAlbumBtn.UseVisualStyleBackColor = true;
            this.editAlbumBtn.Click += new System.EventHandler(this.editAlbumBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.label7.Location = new System.Drawing.Point(21, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Artist Biography";
            // 
            // ciycleLeftBtn
            // 
            this.ciycleLeftBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ciycleLeftBtn.BackgroundImage")));
            this.ciycleLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ciycleLeftBtn.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ciycleLeftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.ciycleLeftBtn.Location = new System.Drawing.Point(19, 310);
            this.ciycleLeftBtn.Name = "ciycleLeftBtn";
            this.ciycleLeftBtn.Size = new System.Drawing.Size(35, 30);
            this.ciycleLeftBtn.TabIndex = 19;
            this.ciycleLeftBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ciycleLeftBtn.UseVisualStyleBackColor = true;
            this.ciycleLeftBtn.Click += new System.EventHandler(this.ciycleLeftBtn_Click);
            // 
            // biographytxtbx
            // 
            this.biographytxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.biographytxtbx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.biographytxtbx.Location = new System.Drawing.Point(19, 222);
            this.biographytxtbx.Name = "biographytxtbx";
            this.biographytxtbx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.biographytxtbx.Size = new System.Drawing.Size(347, 80);
            this.biographytxtbx.TabIndex = 24;
            this.biographytxtbx.Text = "";
            // 
            // ciycleRightBtn
            // 
            this.ciycleRightBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ciycleRightBtn.BackgroundImage")));
            this.ciycleRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ciycleRightBtn.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ciycleRightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.ciycleRightBtn.Location = new System.Drawing.Point(60, 310);
            this.ciycleRightBtn.Name = "ciycleRightBtn";
            this.ciycleRightBtn.Size = new System.Drawing.Size(35, 30);
            this.ciycleRightBtn.TabIndex = 20;
            this.ciycleRightBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ciycleRightBtn.UseVisualStyleBackColor = true;
            this.ciycleRightBtn.Click += new System.EventHandler(this.ciycleRightBtn_Click);
            // 
            // memberstxtbx
            // 
            this.memberstxtbx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.memberstxtbx.Location = new System.Drawing.Point(142, 170);
            this.memberstxtbx.Name = "memberstxtbx";
            this.memberstxtbx.Size = new System.Drawing.Size(58, 21);
            this.memberstxtbx.TabIndex = 16;
            // 
            // ProfilePic
            // 
            this.ProfilePic.Location = new System.Drawing.Point(215, 26);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(150, 140);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePic.TabIndex = 6;
            this.ProfilePic.TabStop = false;
            this.ProfilePic.WaitOnLoad = true;
            this.ProfilePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titleDesc
            // 
            this.titleDesc.AutoSize = true;
            this.titleDesc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.titleDesc.Location = new System.Drawing.Point(308, 62);
            this.titleDesc.Name = "titleDesc";
            this.titleDesc.Size = new System.Drawing.Size(163, 13);
            this.titleDesc.TabIndex = 25;
            this.titleDesc.Text = "Collection of artists you like";
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.AppTitle.Location = new System.Drawing.Point(307, 37);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(141, 22);
            this.AppTitle.TabIndex = 23;
            this.AppTitle.Text = "Artist Complex";
            // 
            // ArtistListBx
            // 
            this.ArtistListBx.Controls.Add(this.showallBtn);
            this.ArtistListBx.Controls.Add(this.artistlistbxlbl);
            this.ArtistListBx.Controls.Add(this.ArtistsListBox);
            this.ArtistListBx.Controls.Add(this.addArtistBtn);
            this.ArtistListBx.Controls.Add(this.removeArtistBtn);
            this.ArtistListBx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ArtistListBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.ArtistListBx.Location = new System.Drawing.Point(430, 256);
            this.ArtistListBx.Name = "ArtistListBx";
            this.ArtistListBx.Size = new System.Drawing.Size(287, 233);
            this.ArtistListBx.TabIndex = 33;
            this.ArtistListBx.TabStop = false;
            this.ArtistListBx.Text = "Artists List";
            // 
            // showallBtn
            // 
            this.showallBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.showallBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.showallBtn.Location = new System.Drawing.Point(170, 193);
            this.showallBtn.Name = "showallBtn";
            this.showallBtn.Size = new System.Drawing.Size(101, 30);
            this.showallBtn.TabIndex = 39;
            this.showallBtn.Text = "Show All";
            this.showallBtn.UseVisualStyleBackColor = true;
            this.showallBtn.Click += new System.EventHandler(this.showallBtn_Click);
            // 
            // artistlistbxlbl
            // 
            this.artistlistbxlbl.AutoSize = true;
            this.artistlistbxlbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.artistlistbxlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.artistlistbxlbl.Location = new System.Drawing.Point(12, 22);
            this.artistlistbxlbl.Name = "artistlistbxlbl";
            this.artistlistbxlbl.Size = new System.Drawing.Size(68, 13);
            this.artistlistbxlbl.TabIndex = 37;
            this.artistlistbxlbl.Text = "Artists List";
            // 
            // removeArtistBtn
            // 
            this.removeArtistBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.removeArtistBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.removeArtistBtn.Location = new System.Drawing.Point(96, 193);
            this.removeArtistBtn.Name = "removeArtistBtn";
            this.removeArtistBtn.Size = new System.Drawing.Size(68, 30);
            this.removeArtistBtn.TabIndex = 38;
            this.removeArtistBtn.Text = "Remove";
            this.removeArtistBtn.UseVisualStyleBackColor = true;
            this.removeArtistBtn.Click += new System.EventHandler(this.removeArtistBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.searchBtn.Location = new System.Drawing.Point(175, 81);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(98, 27);
            this.searchBtn.TabIndex = 39;
            this.searchBtn.Text = "Search Artist";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTxtBox.Location = new System.Drawing.Point(79, 27);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(192, 21);
            this.searchTxtBox.TabIndex = 40;
            // 
            // SearchBx
            // 
            this.SearchBx.Controls.Add(this.artistsubstring);
            this.SearchBx.Controls.Add(this.foundphoto);
            this.SearchBx.Controls.Add(this.criterialbl);
            this.SearchBx.Controls.Add(this.searchlbl);
            this.SearchBx.Controls.Add(this.searchBtn);
            this.SearchBx.Controls.Add(this.bytitleCBX);
            this.SearchBx.Controls.Add(this.searchTxtBox);
            this.SearchBx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.SearchBx.Location = new System.Drawing.Point(430, 123);
            this.SearchBx.Name = "SearchBx";
            this.SearchBx.Size = new System.Drawing.Size(287, 120);
            this.SearchBx.TabIndex = 41;
            this.SearchBx.TabStop = false;
            this.SearchBx.Text = "Search";
            // 
            // foundphoto
            // 
            this.foundphoto.Image = global::ArtistComplex.Properties.Resources.pointing;
            this.foundphoto.Location = new System.Drawing.Point(25, 78);
            this.foundphoto.Name = "foundphoto";
            this.foundphoto.Size = new System.Drawing.Size(74, 33);
            this.foundphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foundphoto.TabIndex = 43;
            this.foundphoto.TabStop = false;
            this.foundphoto.Visible = false;
            // 
            // criterialbl
            // 
            this.criterialbl.AutoSize = true;
            this.criterialbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.criterialbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.criterialbl.Location = new System.Drawing.Point(9, 56);
            this.criterialbl.Name = "criterialbl";
            this.criterialbl.Size = new System.Drawing.Size(69, 13);
            this.criterialbl.TabIndex = 44;
            this.criterialbl.Text = "By Criteria ";
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.searchlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.searchlbl.Location = new System.Drawing.Point(8, 30);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(65, 13);
            this.searchlbl.TabIndex = 43;
            this.searchlbl.Text = "Search for";
            // 
            // bytitleCBX
            // 
            this.bytitleCBX.AutoSize = true;
            this.bytitleCBX.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bytitleCBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.bytitleCBX.Location = new System.Drawing.Point(79, 56);
            this.bytitleCBX.Name = "bytitleCBX";
            this.bytitleCBX.Size = new System.Drawing.Size(102, 17);
            this.bytitleCBX.TabIndex = 41;
            this.bytitleCBX.Text = "Album substring";
            this.bytitleCBX.UseVisualStyleBackColor = true;
            // 
            // copyrights
            // 
            this.copyrights.AutoSize = true;
            this.copyrights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.copyrights.Location = new System.Drawing.Point(93, 551);
            this.copyrights.Name = "copyrights";
            this.copyrights.Size = new System.Drawing.Size(270, 13);
            this.copyrights.TabIndex = 42;
            this.copyrights.Text = "Powered by ZAStudio, All copyrights reserved.";
            this.copyrights.Click += new System.EventHandler(this.appFooter_Click);
            // 
            // StatisticsBox
            // 
            this.StatisticsBox.Controls.Add(this.statsalbum);
            this.StatisticsBox.Controls.Add(this.statsdepth);
            this.StatisticsBox.Controls.Add(this.statsartist);
            this.StatisticsBox.Controls.Add(this.Albumslbl);
            this.StatisticsBox.Controls.Add(this.treedepthlbl);
            this.StatisticsBox.Controls.Add(this.artistlbl);
            this.StatisticsBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StatisticsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.StatisticsBox.Location = new System.Drawing.Point(430, 500);
            this.StatisticsBox.Name = "StatisticsBox";
            this.StatisticsBox.Size = new System.Drawing.Size(289, 93);
            this.StatisticsBox.TabIndex = 38;
            this.StatisticsBox.TabStop = false;
            this.StatisticsBox.Text = "Statistics";
            // 
            // statsalbum
            // 
            this.statsalbum.AutoSize = true;
            this.statsalbum.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statsalbum.Location = new System.Drawing.Point(226, 51);
            this.statsalbum.Name = "statsalbum";
            this.statsalbum.Size = new System.Drawing.Size(23, 24);
            this.statsalbum.TabIndex = 44;
            this.statsalbum.Text = "0";
            this.statsalbum.Click += new System.EventHandler(this.statsalbum_Click);
            // 
            // statsdepth
            // 
            this.statsdepth.AutoSize = true;
            this.statsdepth.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statsdepth.Location = new System.Drawing.Point(123, 51);
            this.statsdepth.Name = "statsdepth";
            this.statsdepth.Size = new System.Drawing.Size(23, 24);
            this.statsdepth.TabIndex = 43;
            this.statsdepth.Text = "0";
            // 
            // statsartist
            // 
            this.statsartist.AutoSize = true;
            this.statsartist.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statsartist.Location = new System.Drawing.Point(32, 51);
            this.statsartist.Name = "statsartist";
            this.statsartist.Size = new System.Drawing.Size(23, 24);
            this.statsartist.TabIndex = 42;
            this.statsartist.Text = "0";
            this.statsartist.Click += new System.EventHandler(this.statslbl_Click);
            // 
            // Albumslbl
            // 
            this.Albumslbl.AutoSize = true;
            this.Albumslbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Albumslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.Albumslbl.Location = new System.Drawing.Point(212, 28);
            this.Albumslbl.Name = "Albumslbl";
            this.Albumslbl.Size = new System.Drawing.Size(49, 13);
            this.Albumslbl.TabIndex = 40;
            this.Albumslbl.Text = "Albums";
            // 
            // treedepthlbl
            // 
            this.treedepthlbl.AutoSize = true;
            this.treedepthlbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.treedepthlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.treedepthlbl.Location = new System.Drawing.Point(100, 28);
            this.treedepthlbl.Name = "treedepthlbl";
            this.treedepthlbl.Size = new System.Drawing.Size(70, 13);
            this.treedepthlbl.TabIndex = 39;
            this.treedepthlbl.Text = "Tree Depth";
            // 
            // artistlbl
            // 
            this.artistlbl.AutoSize = true;
            this.artistlbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.artistlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.artistlbl.Location = new System.Drawing.Point(21, 28);
            this.artistlbl.Name = "artistlbl";
            this.artistlbl.Size = new System.Drawing.Size(45, 13);
            this.artistlbl.TabIndex = 38;
            this.artistlbl.Text = "Artists";
            // 
            // saveArtist
            // 
            this.saveArtist.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.saveArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.saveArtist.Location = new System.Drawing.Point(177, 485);
            this.saveArtist.Name = "saveArtist";
            this.saveArtist.Size = new System.Drawing.Size(88, 30);
            this.saveArtist.TabIndex = 40;
            this.saveArtist.Text = "Save Artist";
            this.saveArtist.UseVisualStyleBackColor = true;
            this.saveArtist.Click += new System.EventHandler(this.AddORedit_Click);
            // 
            // appLogo
            // 
            this.appLogo.Image = global::ArtistComplex.Properties.Resources.log;
            this.appLogo.Location = new System.Drawing.Point(240, 13);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(60, 94);
            this.appLogo.TabIndex = 24;
            this.appLogo.TabStop = false;
            this.appLogo.Click += new System.EventHandler(this.appLogo_Click);
            // 
            // artistsubstring
            // 
            this.artistsubstring.AutoSize = true;
            this.artistsubstring.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.artistsubstring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.artistsubstring.Location = new System.Drawing.Point(179, 56);
            this.artistsubstring.Name = "artistsubstring";
            this.artistsubstring.Size = new System.Drawing.Size(100, 17);
            this.artistsubstring.TabIndex = 45;
            this.artistsubstring.Text = "Name substring";
            this.artistsubstring.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(742, 611);
            this.Controls.Add(this.saveArtist);
            this.Controls.Add(this.StatisticsBox);
            this.Controls.Add(this.copyrights);
            this.Controls.Add(this.titleDesc);
            this.Controls.Add(this.appLogo);
            this.Controls.Add(this.AppTitle);
            this.Controls.Add(this.ArtistProfileBx);
            this.Controls.Add(this.ArtistListBx);
            this.Controls.Add(this.SearchBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artist Complex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ArtistProfileBx.ResumeLayout(false);
            this.ArtistProfileBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.ArtistListBx.ResumeLayout(false);
            this.ArtistListBx.PerformLayout();
            this.SearchBx.ResumeLayout(false);
            this.SearchBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foundphoto)).EndInit();
            this.StatisticsBox.ResumeLayout(false);
            this.StatisticsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberslbl;
        private System.Windows.Forms.Label bandnamelbl;
        private System.Windows.Forms.TextBox hometowntxtbx;
        private System.Windows.Forms.Label hometownlbl;
        private System.Windows.Forms.DateTimePicker dobdatepick;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.TextBox bandnametxtbx;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Button addArtistBtn;
        private System.Windows.Forms.GroupBox ArtistProfileBx;
        private System.Windows.Forms.Button ciycleLeftBtn;
        private System.Windows.Forms.Button ciycleRightBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox biographytxtbx;
        private System.Windows.Forms.TextBox memberstxtbx;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label titleDesc;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Button AvatarAdjstBtn;
        private System.Windows.Forms.Button editAlbumBtn;
        private System.Windows.Forms.GroupBox ArtistListBx;
        private System.Windows.Forms.Label artistlistbxlbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button removeArtistBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.GroupBox SearchBx;
        private System.Windows.Forms.Label criterialbl;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.CheckBox bytitleCBX;
        private System.Windows.Forms.Label copyrights;
        private System.Windows.Forms.GroupBox StatisticsBox;
        private System.Windows.Forms.Label Albumslbl;
        private System.Windows.Forms.Label treedepthlbl;
        private System.Windows.Forms.Label artistlbl;
        private System.Windows.Forms.Button showallBtn;
        private System.Windows.Forms.Button saveArtist;
        private System.Windows.Forms.ComboBox gendercombbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statsalbum;
        private System.Windows.Forms.Label statsdepth;
        private System.Windows.Forms.Label statsartist;
        public System.Windows.Forms.ListBox ArtistsListBox;
        private System.Windows.Forms.PictureBox foundphoto;
        private System.Windows.Forms.CheckBox artistsubstring;
    }
}

