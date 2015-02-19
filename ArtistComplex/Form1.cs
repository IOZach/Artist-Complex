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
    public partial class Form1 : Form
    {

        // Main form class fields including openfile dialog artist avl tree , albums linkedlist to pass in and out edit form
        private AVLArtist<Artist> artistTree = new AVLArtist<Artist>();
        private LinkedList<Album> Albums = new LinkedList<Album>();
        private Artist artist;
        private EditAlbum editform;
        private OpenFileDialog open;

        // variables to use accross functions
        private int counter = -1;
        private bool signupFlag = true;
        private string Artistimage = "";
        private string artistname = "";
        private int editselected = 0;

        // Form 1 constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Form 1 construct loader
        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultPictureBox();
            openFields(false);
            Albums.AddFirst(new Album(0, "The bboory nflalgs", DateTime.Parse("28/05/1993"), ""));
            Albums.AddFirst(new Album(1, "The flame wongy", DateTime.Parse("2/05/1992"), ""));
            Albums.AddFirst(new Album(2, "The bang hot", DateTime.Parse("23/05/1973"), ""));
            artist = new Artist("Zakaria Abushima", 0, DateTime.Parse("28/05/1993"), "", "Wigan, UK", "The Syck", 20, Albums, "");
            statsalbum.Text = (int.Parse(statsalbum.Text) + artist.ALBUMS.Count) + "";
            artistTree.InsertItem(artist);
            Albums = new LinkedList<Album>();
            Albums.AddFirst(new Album(0, "The ruhs blush", DateTime.Parse("28/05/1993"), ""));
            Albums.AddFirst(new Album(1, "The mushet", DateTime.Parse("2/05/1992"), ""));
            Albums.AddFirst(new Album(2, "The bang hot", DateTime.Parse("23/05/1973"), ""));
            artist = new Artist("David Mclean", 0, DateTime.Parse("14/02/1983"), "", "Manchester, UK", "The bang", 5, Albums, "");
            statsalbum.Text = (int.Parse(statsalbum.Text) + artist.ALBUMS.Count) + "";
            artistTree.InsertItem(artist);
            Albums = new LinkedList<Album>();
            Albums.AddFirst(new Album(0, "The night out", DateTime.Parse("28/05/1993"), ""));
            Albums.AddFirst(new Album(1, "The wihsiky", DateTime.Parse("2/05/1992"), ""));
            Albums.AddFirst(new Album(2, "The roullete", DateTime.Parse("23/05/1973"), ""));
            artist = new Artist("Moi Moi", 1, DateTime.Parse("22/01/2000"), "", "Liverpool, UK", "The lingy", 1, Albums, "");
            statsalbum.Text = (int.Parse(statsalbum.Text) + artist.ALBUMS.Count) + "";
            artistTree.InsertItem(artist);
            Albums = new LinkedList<Album>();
            showallBtn.PerformClick();
            if (ArtistsListBox.Items.Count > 0)
            {
                setCyclingBtn(true);
            }
            else
            {
                setCyclingBtn(false);
            }
            updateStats(false, false);
        }

        // Method when add album button clicked, will trigger edit album form
        private void editAlbumBtn_Click(object sender, EventArgs e)
        {
            if (editform == null || editform.IsDisposed)
            {
                editform = new EditAlbum(ref Albums, ref statsalbum);
            }

            editform.Show();
        }

        // method when artist image button clicked, which will give the ability to choose the image
        private void button4_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                ProfilePic.Image = new Bitmap(open.FileName);
                Artistimage = open.FileName; // image file path
            }
        }

        // Method when click on add/edit button, check if something is highlighed in listbox then retrieve highlighted artist and let to edit
        // otherwise is new artist clean fields and open them so user can enter his info
        private void addArtistBtn_Click(object sender, EventArgs e)
        {
            if ((string)ArtistsListBox.SelectedItem == null)
            {
                cleanFields();
                DefaultPictureBox();
            }
            else
            {
                retrieveSelectedArtist();
            }
            openFields(true);
        }

        // The big deal is here, check different situation where user might transfer from artist to another while already clicked on edit button etc.
        private void AddORedit_Click(object sender, EventArgs e)
        {
            bool nameFlag = checkDuplicates(NameTxtBx.Text.ToLower());
            try
            {
                if ((string)ArtistsListBox.SelectedItem == null && !nameFlag && (!((NameTxtBx.Text.Replace(" ", "")).Trim().Equals("")))) // nothing is selected, entered artist name doesn't exist, and entered value is not spaces
                {
                    signupFlag = true;
                    artist = new Artist(NameTxtBx.Text, gendercombbx.SelectedIndex, dobdatepick.Value, biographytxtbx.Text, hometowntxtbx.Text, bandnametxtbx.Text, int.Parse(memberstxtbx.Text), Albums, Artistimage);
                    createBio();
                    cleanFields();
                    openFields(false);
                    DefaultPictureBox();
                }
                else if (((string)ArtistsListBox.SelectedItem != null) && (NameTxtBx.Text.ToLower() == artistname.ToLower() && nameFlag) || (!nameFlag) && (!((NameTxtBx.Text.Replace(" ", "")).Trim().Equals("")))) // something should be selected, and artist name with edited one is equal or artist name doesn't exist and entered value is not spaces
                {
                    signupFlag = false;
                    nameFlag = false;
                    editArtist(ref artist);
                    ArtistsListBox.Items[editselected] = artist.ToString();
                    if (NameTxtBx.Text.ToLower() != artistname.ToLower())
                    {
                        artistTree.RebalanceNodes();
                        artistTree.NodesToListBox(ref ArtistsListBox);
                    }
                    else
                    {
                        ArtistsListBox.SelectedIndex = -1;
                    }
                    openFields(false);
                    MessageBox.Show(artist.NAME + " has been edited successfully.",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    signupFlag = false;
                    nameFlag = true;
                }
            }
            catch (FormatException)
            {
                signupFlag = false;
                MessageBox.Show("Sorry, Please enter numeric value in number of members field.\nEnter 1 if Solo",
        "Notification",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
            }
            catch (NullReferenceException)
            {
                signupFlag = false;
                MessageBox.Show("Sorry, Please choose artist gender and make sure entered correct values",
        "Notification",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (signupFlag && (string)ArtistsListBox.SelectedItem == null && !nameFlag) // signflag will be changed to true if there was no element highlighted in artists list box
                {
                    artistTree.InsertItem(artist);
                    artistTree.NodesToListBox(ref ArtistsListBox);
                    updateStats(false, false);
                    setCyclingBtn(true);
                    MessageBox.Show(artist.NAME + " artist has been added sucessfully.",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                }
                else if (nameFlag) // if nameflag is true then name tried to enter already exist
                {
                    MessageBox.Show("Sorry, artist name in field name is either already exist or left blank.\nTo edit highlight the artist from the list box,\nor try another name!",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void showallBtn_Click(object sender, EventArgs e) // if show all button clicked, then retrieve all artists are available in the tree.
        {
            artistTree.NodesToListBox(ref ArtistsListBox);
            counter = -1;
            if (ArtistsListBox.Items.Count == 0)
            {
                MessageBox.Show("Sorry, there were no artist are available to list.\n Try to add few artist.",
        "Notification",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
            }
        }

        private void ArtistsListBox_SelectedIndexChanged(object sender, EventArgs e) // if highlighting changed to another element in the artists list box , then retrieve to text fields artist info
        {
            foundphoto.Visible = false;
            counter = ArtistsListBox.SelectedIndex;
            retrieveSelectedArtist();
        }

        private void removeArtistBtn_Click(object sender, EventArgs e) // if remove button clicked and there is one highlighted element then it will remove fro mthe tree
        {
            if ((string)ArtistsListBox.SelectedItem != null)
            {
                artistTree.RemoveItem(artist);
                ArtistsListBox.Items.Remove(ArtistsListBox.SelectedItem);
                updateStats(true, false);
                DefaultPictureBox();
                openFields(false);
                cleanFields();
                if (ArtistsListBox.Items.Count == 0)
                {
                    setCyclingBtn(false);
                }
                MessageBox.Show(artist.NAME + " has been removed successfully.",
        "Notification",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Sorry, Please highlight from the List Box the artist to remove.\nOtherwise click show all button to retrieve artists.",
        "Notification",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
            }
        }

        private void ciycleLeftBtn_Click(object sender, EventArgs e) // if left button arrow icon clicked then retrieve the next element in left postorder of the tree nodes
        {
            if (ArtistsListBox.Items.Count != 0)
            {
                if (counter <= 0)
                {
                    counter = (ArtistsListBox.Items.Count - 1);
                }
                else
                {
                    counter--;
                }
                ArtistsListBox.SelectedIndex = counter;
            }
        }

        private void ciycleRightBtn_Click(object sender, EventArgs e) // if right button arrow icon clicked then retrieve the next element in right postorder of tree nodes
        {
            if (ArtistsListBox.Items.Count != 0)
            {
                if (counter == (ArtistsListBox.Items.Count - 1))
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                ArtistsListBox.SelectedIndex = counter;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e) // Search button through artists either by artist name or album title
        {
            if (!(searchTxtBox.Text.Replace(" ", "").Trim().Equals("")) && ArtistsListBox.Items.Count != 0)
            {
                artistTree.FindByStringItem(searchTxtBox.Text, bytitleCBX.Checked, artistsubstring.Checked, ref ArtistsListBox);
                counter = -1;
            }
            if (searchTxtBox.Text.Replace(" ", "").Trim().Equals(""))
            {
                foundphoto.Visible = false;
                MessageBox.Show("Sorry, you have to enter a value to search for.",
    "Notification",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);

            }
            else if (ArtistsListBox.Items.Count == 0)
            {
                foundphoto.Visible = false;
                artistTree.NodesToListBox(ref ArtistsListBox);
                MessageBox.Show("Sorry, nothing has been found that matches : " + searchTxtBox.Text,
    "Notification",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }
            else
            {
                foundphoto.Visible = true;
                MessageBox.Show("Horray, we have found matches of : " + searchTxtBox.Text + ".\nCheckout the list box below, and note if you want to display all artists in list box then you just click on show all button below.",
                "Notification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

        }

        private void statsalbum_Click(object sender, EventArgs e)
        {

        }

        private void addAlbumbtn_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void albumlistBox_Enter(object sender, EventArgs e)
        {

        }

        private void AlbumCover_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playBtn_Click(object sender, EventArgs e)
        {

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {

        }

        private void appFooter_Click(object sender, EventArgs e)
        {

        }

        private void statslbl_Click(object sender, EventArgs e)
        {

        }

        private void updateStats(bool remove, bool edit) // update statistics of current tree artists, albums and depth
        {
            if (!edit)
            {
                counter = ArtistsListBox.Items.Count;
                statsartist.Text = counter + "";
                statsdepth.Text = artistTree.Height() + "";
                counter--;
            }
            if (remove && int.Parse(statsalbum.Text) >= 0)
            {
                statsalbum.Text = (int.Parse(statsalbum.Text) - artist.ALBUMS.Count) + "";
            }
        }

        private bool checkDuplicates(String name) // check if given artist name exist in the tree
        {
            Artist testart = new Artist(name);
            return artistTree.Contains(ref testart);
        }

        private void cleanFields() // clean all text fields, dob and text area.
        {
            NameTxtBx.Text = "";
            dobdatepick.Value = DateTime.Now;
            hometowntxtbx.Text = "";
            bandnametxtbx.Text = "";
            memberstxtbx.Text = "";
            biographytxtbx.Text = "";
            Artistimage = "";
            Albums = new LinkedList<Album>();
            gendercombbx.SelectedIndex = -1;
        }

        private void DefaultPictureBox() // set the picture box of artists to default
        {
            ProfilePic.Image = Properties.Resources.profilepic;
        }

        private void openFields(bool AddorEdit) // Open fields 
        {
            NameTxtBx.Enabled = AddorEdit;
            dobdatepick.Enabled = AddorEdit;
            hometowntxtbx.Enabled = AddorEdit;
            bandnametxtbx.Enabled = AddorEdit;
            memberstxtbx.Enabled = AddorEdit;
            AvatarAdjstBtn.Enabled = AddorEdit;
            biographytxtbx.Enabled = AddorEdit;
            editAlbumBtn.Enabled = AddorEdit;
            gendercombbx.Enabled = AddorEdit;
            saveArtist.Enabled = AddorEdit;
        }

        private void setCyclingBtn(bool CycleOrNo) // disable cycling through artists
        {
            ciycleLeftBtn.Enabled = CycleOrNo;
            ciycleRightBtn.Enabled = CycleOrNo;
        }

        private void createBio() // this methods creates biography for each artist depending on the information provided.
        {
            string determination = "";
            biographytxtbx.Text = "";

            if (gendercombbx.SelectedIndex == 0)
            {
                determination = "he ";
            }
            else if (gendercombbx.SelectedIndex == 1)
            {
                determination = "she ";
            }

            biographytxtbx.Text += determination + "is " + artist.getAge() + " years old. ";
            biographytxtbx.Text += determination + "made " + Albums.Count + " albums, " + determination + "is currently ";
            if (int.Parse(memberstxtbx.Text) == 1) { biographytxtbx.Text += "solo singer for "; }
            else { biographytxtbx.Text += "one of the " + memberstxtbx.Text + " members of "; }
            biographytxtbx.Text += bandnametxtbx.Text + " band.";

            artist.BIO = biographytxtbx.Text;
        }

        private void editArtist(ref Artist artist) // this method when called just edit specified artist
        {
            artist.NAME = NameTxtBx.Text;
            artist.DOB = dobdatepick.Value;
            artist.HOMETOWN = hometowntxtbx.Text;
            artist.BANDNAME = bandnametxtbx.Text;
            artist.MEMBERS = int.Parse(memberstxtbx.Text);
            createBio();
            artist.BIO = biographytxtbx.Text;
            artist.GENDER = gendercombbx.SelectedIndex;
            artist.PICPATH = Artistimage;
            artist.ALBUMS = Albums;
        }

        private void retrieveSelectedArtist() // this method retrieve selected artist from the list box
        {
            if ((string)ArtistsListBox.SelectedItem != null)
            {
                artist = new Artist((ArtistsListBox.SelectedItem.ToString().Split(',')[0]));
                if (artistTree.Contains(ref artist))
                {
                    NameTxtBx.Text = artist.NAME;
                    artistname = artist.NAME;
                    editselected = ArtistsListBox.SelectedIndex;
                    dobdatepick.Value = artist.DOB;
                    hometowntxtbx.Text = artist.HOMETOWN;
                    bandnametxtbx.Text = artist.BANDNAME;
                    memberstxtbx.Text = artist.MEMBERS + "";
                    Albums = artist.ALBUMS;
                    gendercombbx.SelectedIndex = artist.GENDER;
                    Artistimage = artist.PICPATH;
                    if (Artistimage != "")
                    {
                        ProfilePic.Image = new Bitmap(artist.PICPATH);
                    }
                    else
                    {
                        DefaultPictureBox();
                    }
                    if (artist.BIO == "")
                    {
                        createBio();
                    }
                    else
                    {
                        biographytxtbx.Text = artist.BIO;
                    }
                }
            }
        }

        private void appLogo_Click(object sender, EventArgs e)
        {

        }

    }
}
