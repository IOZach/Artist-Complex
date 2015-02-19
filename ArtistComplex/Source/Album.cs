using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistComplex.Source
{
    public class Album : Artist
    {

        // Class Fields such as name, date of album etc.
        private int idalbum;
        private string albumName;
        private DateTime albumDate;
        private string picturePath;

        // Constructors for Album Class
        public Album(int idalbum, string albumName, DateTime albumDate, string picturePath)
        {
            this.albumName = albumName;
            this.albumDate = albumDate;
            this.picturePath = picturePath;
            this.idalbum = idalbum;
        }

        // Empty constructor to make pre entry for album variable as starter instantiation field of album form.
        public Album()
        {

        }

        // Setters and Getters for Album Class
        public int ALBUMID
        {
            get { return idalbum; }
            set { idalbum = value; }
        }
        public string ALBUMNAME
        {
            get { return albumName; }
            set { albumName = value; }
        }
        public DateTime ALBUMDATE
        {
            get { return albumDate; }
            set { albumDate = value; }
        }
        public string PICTUREPATH
        {
            get { return picturePath; }
            set { picturePath = value; }
        }

        // override current to string to print album id and name
        // Id of album used as identification for each album, since we may have albums with identical names therefore name is not ID.
        public override string ToString()
        {
            return idalbum + ", " + albumName;
        }

    }
}
