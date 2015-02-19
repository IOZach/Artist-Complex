using System;
using System.Collections.Generic;
using ArtistComplex.Source;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtistComplex
{
    public partial class EditAlbum : Form
    {
        // Album form fields
        public int selectedalbum;
        public LinkedList<Album> albums = new LinkedList<Album>();
        public Album album;
        private string albumImage = "";
        private Label statsalbum;
        private int counter = -1;
        private OpenFileDialog open;

        // Form constructor passed with albums counter textbox and artist album linked list by ref
        public EditAlbum(ref LinkedList<Album> albums, ref Label statsalbum)
        {
            InitializeComponent();
            this.albums = albums;
            this.statsalbum = statsalbum;
        }

        // Set starter for fields when open form
        private void EditAlbum_Load(object sender, EventArgs e)
        {
            refreshList();
            openFields(false);
            defualtpic();
        }
            
        // defualt picture box photo
        private void defualtpic()
        {
            albumcoverBox.Image = Properties.Resources.albumcover;
        }

        // Clean text boxes and fields.
        private void cleanfields()
        {
            NameTxtBx.Text = "";
            dobdatepick.Value = DateTime.Now;
            defualtpic();
        }

        // retrieve and remove selected album
        private void removeAlbumBtn_Click(object sender, EventArgs e)
        {
            if ((string)AlbumListBox.SelectedItem != null)
            {
                albums.Remove(album);
                AlbumListBox.Items.Remove(AlbumListBox.SelectedItem);
                statsalbum.Text = (int.Parse(statsalbum.Text) - 1) + "";
                defualtpic();
                cleanfields();
                openFields(false);
                MessageBox.Show(album.ALBUMNAME + " album has been removed successfully.",
    "Notification",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Sorry, you have to highlight an album from above list box to remove.",
    "Notification",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }
        }

        private void EditSongBtn_Click(object sender, EventArgs e)
        {
        }

        // open fields such as text box.
        private void saveAlbumBtn_Click(object sender, EventArgs e)
        {
            openFields(false);
        }

        // determine either add new field or save
        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)AlbumListBox.SelectedItem == null)
            {
                cleanfields();
            }
            else
            {
                retrieveselected();
            }
            openFields(true);
        }

        // when click save album,check all criteria such as not empty text boxes etc.
        private void savealbum_Click(object sender, EventArgs e)
        {
            if (AlbumListBox.SelectedItem == null)
            {
                if (NameTxtBx.Text.Replace(" ", "").Trim().Equals(""))
                {
                    MessageBox.Show("Sorry, you have to enter a value in album name field.",
        "Notification",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    addnewalbum();
                    statsalbum.Text = (int.Parse(statsalbum.Text) + 1) + "";
                    defualtpic();
                    cleanfields();
                    openFields(false);
                    MessageBox.Show(album.ALBUMNAME + " album has been added successfully.",
                                "Notification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                album.ALBUMID = counter;
                album.ALBUMNAME = NameTxtBx.Text;
                album.ALBUMDATE = dobdatepick.Value;
                album.PICTUREPATH = albumImage;
                AlbumListBox.Items[AlbumListBox.SelectedIndex] = album.ToString();
                AlbumListBox.SelectedIndex = -1;
                openFields(false);
                MessageBox.Show(album.ALBUMNAME + " album has been edited successfully.",
            "Notification",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1);
            }

        }

        // retrieve album by name or id function
        private void getAlbumbySelect(ref Album album)
        {
            int id = int.Parse(AlbumListBox.SelectedItem.ToString().Split(',')[0]);
            foreach (var item in albums)
            {
                if (item.ALBUMID.Equals(id))
                {
                    album = item;
                    break;
                }
            }
        }

        private void getBackAlbum(object sender, FormClosedEventArgs e)
        {

        }

        // method to retrieve albums
        private void retrieveselected()
        {
            if ((string)AlbumListBox.SelectedItem != null)
            {
                getAlbumbySelect(ref album);
                counter = album.ALBUMID;
                NameTxtBx.Text = album.ALBUMNAME;
                dobdatepick.Value = album.ALBUMDATE;
                albumImage = album.PICTUREPATH;
                if (albumImage != "")
                {
                    albumcoverBox.Image = new Bitmap(album.PICTUREPATH);
                }
                else
                {
                    defualtpic();
                }
            }
        }

        // refresh album list box
        private void refreshList()
        {
            if (albums.Count != 0)
            {
                foreach (var item in albums)
                {
                    AlbumListBox.Items.Add(item.ToString());
                }
            }
        }

        // add album to the album linked list
        private void addnewalbum()
        {
            if (albums.Count != 0) { counter = albums.First.Value.ALBUMID; } else { counter = -1; }
            album = new Album(++counter, NameTxtBx.Text, dobdatepick.Value, albumImage);
            albums.AddFirst(album);
            AlbumListBox.Items.Add(album.ToString());
        }

        // Open fields method
        private void openFields(bool condition)
        {
            NameTxtBx.Enabled = condition;
            dobdatepick.Enabled = condition;
            editCoverBtn.Enabled = condition;
            savealbum.Enabled = condition;
        }

        // load album cover method
        private void editCoverBtn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                albumcoverBox.Image = new Bitmap(open.FileName);
                albumImage = open.FileName; // image file path
            }
        }

        // when selected item of list box change occurs to retrieve the selected new item information, such as album name.
        private void AlbumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            retrieveselected();
        }

        private void EditAlbumBx_Enter(object sender, EventArgs e)
        {

        }

        private void NameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
