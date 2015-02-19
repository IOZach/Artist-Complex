namespace ArtistComplex
{
    partial class EditAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAlbum));
            this.titleDesc = new System.Windows.Forms.Label();
            this.AppTitle = new System.Windows.Forms.Label();
            this.EditAlbumBx = new System.Windows.Forms.GroupBox();
            this.albumdateBox = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.dobdatepick = new System.Windows.Forms.DateTimePicker();
            this.editCoverBtn = new System.Windows.Forms.Button();
            this.albumcoverlbl = new System.Windows.Forms.Label();
            this.albumcoverBox = new System.Windows.Forms.PictureBox();
            this.AlbumBox = new System.Windows.Forms.GroupBox();
            this.AlbumListBox = new System.Windows.Forms.ListBox();
            this.removeAlbumBtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.savealbum = new System.Windows.Forms.Button();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.EditAlbumBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumcoverBox)).BeginInit();
            this.AlbumBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // titleDesc
            // 
            this.titleDesc.AutoSize = true;
            this.titleDesc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.titleDesc.Location = new System.Drawing.Point(192, 67);
            this.titleDesc.Name = "titleDesc";
            this.titleDesc.Size = new System.Drawing.Size(163, 13);
            this.titleDesc.TabIndex = 28;
            this.titleDesc.Text = "Collection of artists you like";
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.AppTitle.Location = new System.Drawing.Point(191, 42);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(141, 22);
            this.AppTitle.TabIndex = 26;
            this.AppTitle.Text = "Artist Complex";
            // 
            // EditAlbumBx
            // 
            this.EditAlbumBx.Controls.Add(this.albumdateBox);
            this.EditAlbumBx.Controls.Add(this.namelbl);
            this.EditAlbumBx.Controls.Add(this.NameTxtBx);
            this.EditAlbumBx.Controls.Add(this.dobdatepick);
            this.EditAlbumBx.Controls.Add(this.editCoverBtn);
            this.EditAlbumBx.Controls.Add(this.albumcoverlbl);
            this.EditAlbumBx.Controls.Add(this.albumcoverBox);
            this.EditAlbumBx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EditAlbumBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.EditAlbumBx.Location = new System.Drawing.Point(31, 134);
            this.EditAlbumBx.Name = "EditAlbumBx";
            this.EditAlbumBx.Size = new System.Drawing.Size(211, 266);
            this.EditAlbumBx.TabIndex = 44;
            this.EditAlbumBx.TabStop = false;
            this.EditAlbumBx.Text = "Add/Edit";
            this.EditAlbumBx.Enter += new System.EventHandler(this.EditAlbumBx_Enter);
            // 
            // albumdateBox
            // 
            this.albumdateBox.AutoSize = true;
            this.albumdateBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.albumdateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.albumdateBox.Location = new System.Drawing.Point(13, 55);
            this.albumdateBox.Name = "albumdateBox";
            this.albumdateBox.Size = new System.Drawing.Size(34, 13);
            this.albumdateBox.TabIndex = 46;
            this.albumdateBox.Text = "Date";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.namelbl.Location = new System.Drawing.Point(13, 25);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(39, 13);
            this.namelbl.TabIndex = 45;
            this.namelbl.Text = "Name";
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameTxtBx.Location = new System.Drawing.Point(58, 21);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(135, 21);
            this.NameTxtBx.TabIndex = 44;
            this.NameTxtBx.TextChanged += new System.EventHandler(this.NameTxtBx_TextChanged);
            // 
            // dobdatepick
            // 
            this.dobdatepick.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.dobdatepick.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.dobdatepick.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.dobdatepick.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dobdatepick.Location = new System.Drawing.Point(58, 52);
            this.dobdatepick.Name = "dobdatepick";
            this.dobdatepick.Size = new System.Drawing.Size(135, 21);
            this.dobdatepick.TabIndex = 43;
            // 
            // editCoverBtn
            // 
            this.editCoverBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.editCoverBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.editCoverBtn.Location = new System.Drawing.Point(51, 228);
            this.editCoverBtn.Name = "editCoverBtn";
            this.editCoverBtn.Size = new System.Drawing.Size(110, 30);
            this.editCoverBtn.TabIndex = 42;
            this.editCoverBtn.Text = "Add/Edit Cover";
            this.editCoverBtn.UseVisualStyleBackColor = true;
            this.editCoverBtn.Click += new System.EventHandler(this.editCoverBtn_Click);
            // 
            // albumcoverlbl
            // 
            this.albumcoverlbl.AutoSize = true;
            this.albumcoverlbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.albumcoverlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.albumcoverlbl.Location = new System.Drawing.Point(62, 81);
            this.albumcoverlbl.Name = "albumcoverlbl";
            this.albumcoverlbl.Size = new System.Drawing.Size(79, 13);
            this.albumcoverlbl.TabIndex = 41;
            this.albumcoverlbl.Text = "Album Cover";
            // 
            // albumcoverBox
            // 
            this.albumcoverBox.Location = new System.Drawing.Point(32, 101);
            this.albumcoverBox.Name = "albumcoverBox";
            this.albumcoverBox.Size = new System.Drawing.Size(150, 120);
            this.albumcoverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumcoverBox.TabIndex = 0;
            this.albumcoverBox.TabStop = false;
            // 
            // AlbumBox
            // 
            this.AlbumBox.Controls.Add(this.AlbumListBox);
            this.AlbumBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AlbumBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.AlbumBox.Location = new System.Drawing.Point(253, 134);
            this.AlbumBox.Name = "AlbumBox";
            this.AlbumBox.Size = new System.Drawing.Size(240, 266);
            this.AlbumBox.TabIndex = 47;
            this.AlbumBox.TabStop = false;
            this.AlbumBox.Text = "Album List";
            // 
            // AlbumListBox
            // 
            this.AlbumListBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AlbumListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.AlbumListBox.FormattingEnabled = true;
            this.AlbumListBox.Location = new System.Drawing.Point(6, 21);
            this.AlbumListBox.Name = "AlbumListBox";
            this.AlbumListBox.Size = new System.Drawing.Size(228, 238);
            this.AlbumListBox.TabIndex = 0;
            this.AlbumListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumListBox_SelectedIndexChanged);
            // 
            // removeAlbumBtn
            // 
            this.removeAlbumBtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.removeAlbumBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.removeAlbumBtn.Location = new System.Drawing.Point(333, 405);
            this.removeAlbumBtn.Name = "removeAlbumBtn";
            this.removeAlbumBtn.Size = new System.Drawing.Size(103, 30);
            this.removeAlbumBtn.TabIndex = 47;
            this.removeAlbumBtn.Text = "Remove Album";
            this.removeAlbumBtn.UseVisualStyleBackColor = true;
            this.removeAlbumBtn.Click += new System.EventHandler(this.removeAlbumBtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.addbtn.Location = new System.Drawing.Point(252, 406);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(73, 29);
            this.addbtn.TabIndex = 49;
            this.addbtn.Text = "Add/Edit";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // savealbum
            // 
            this.savealbum.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.savealbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.savealbum.Location = new System.Drawing.Point(89, 406);
            this.savealbum.Name = "savealbum";
            this.savealbum.Size = new System.Drawing.Size(93, 29);
            this.savealbum.TabIndex = 51;
            this.savealbum.Text = "Save Album";
            this.savealbum.UseVisualStyleBackColor = true;
            this.savealbum.Click += new System.EventHandler(this.savealbum_Click);
            // 
            // appLogo
            // 
            this.appLogo.Image = global::ArtistComplex.Properties.Resources.log;
            this.appLogo.Location = new System.Drawing.Point(124, 18);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(60, 94);
            this.appLogo.TabIndex = 27;
            this.appLogo.TabStop = false;
            // 
            // EditAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(525, 464);
            this.Controls.Add(this.AlbumBox);
            this.Controls.Add(this.savealbum);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.removeAlbumBtn);
            this.Controls.Add(this.EditAlbumBx);
            this.Controls.Add(this.titleDesc);
            this.Controls.Add(this.appLogo);
            this.Controls.Add(this.AppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artist Complex - Add/Edit Album";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.getBackAlbum);
            this.Load += new System.EventHandler(this.EditAlbum_Load);
            this.EditAlbumBx.ResumeLayout(false);
            this.EditAlbumBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumcoverBox)).EndInit();
            this.AlbumBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleDesc;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.GroupBox EditAlbumBx;
        private System.Windows.Forms.PictureBox albumcoverBox;
        private System.Windows.Forms.Label albumcoverlbl;
        private System.Windows.Forms.Button editCoverBtn;
        private System.Windows.Forms.DateTimePicker dobdatepick;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.Label albumdateBox;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.GroupBox AlbumBox;
        private System.Windows.Forms.ListBox AlbumListBox;
        private System.Windows.Forms.Button removeAlbumBtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button savealbum;
    }
}