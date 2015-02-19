using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ArtistComplex.Source
{
    public class Artist : IComparable
    {

        // Class Fields such as name, age of artist etc.
        private int members;
        private string name;
        private string biography;
        private string hometown;
        private string bandname;
        private int gender;
        private DateTime dob;
        private LinkedList<Album> Albums;
        private string artistPicture;

        // Constructor for Artist Class used for pre entry as starter field at the instantiation time.
        public Artist()
        {

        }

        // Constructor for artist class with artist name only used for compararing artists
        public Artist(string name)
        {
            this.name = name;
        }

        // Constructor for all artists information, since constructors can be overloaded
        public Artist(string name, int gender, DateTime dob, string biography, string hometown, string bandname, int members, LinkedList<Album> Albums, String artistPicture)
        {
            this.name = name;
            this.dob = dob;
            this.biography = biography;
            this.hometown = hometown;
            this.bandname = bandname;
            this.members = members;
            this.Albums = Albums;
            this.gender = gender;
            this.artistPicture = artistPicture;
        }

        // Setters and Getters for Artist Class
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public int GENDER
        {
            get { return gender; }
            set { gender = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public int MEMBERS
        {
            get { return members; }
            set { members = value; }
        }
        public string BIO
        {
            get { return biography; }
            set { biography = value; }
        }
        public string BANDNAME
        {
            get { return bandname; }
            set { bandname = value; }
        }
        public string HOMETOWN
        {
            get { return hometown; }
            set { hometown = value; }
        }
        public LinkedList<Album> ALBUMS
        {
            get { return Albums; }
            set { Albums = value; }
        }
        public string PICPATH
        {
            get { return artistPicture; }
            set { artistPicture = value; }
        }

        // Function to calculate artist age
        public int getAge()
        {
            TimeSpan artistAge = DateTime.Now.Subtract(dob);
            return (int)(artistAge.TotalDays / 365);
        }

        // override tostring to print artist name along with age
        public override string ToString()
        {
            return name + ", Age " + getAge();
        }

        // search in case looking for artist name in substring form
        public bool checkartistalbum(string item)
        {
            if (name.ToLower().Contains(item.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // overriden CompareTo to a specific needs
        public int CompareTo(object obj)
        {
            if (obj is Artist) // if compare were called by artist tree with artist object as parameter then execute following
            {
                Artist other = (Artist)obj;
                return name.ToLower().CompareTo(other.name.ToLower());
            }
            if (obj is string) // if compare were called by artist tree with string object as parameter do fllowing
            {
                string other = (string)obj;
                if (Albums.Count != 0 && string.Join(",", Albums).ToLower().Contains(other.ToLower())) // get all artist albums in one string
                {
                    return 0;
                }
                else
                {
                    return -999;
                }
            }
            else
            {
                return -999; //indicates can’t make a comparison 
            }
        }



    }
}
