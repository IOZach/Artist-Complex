using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ArtistComplex.Source;
using System.Windows.Forms;
namespace ArtistComplex.NUnitTesting
{
    [TestFixture]
    class ArtistTest
    {

        AVLArtist<Artist> artistsTree;
        Artist artist;
        LinkedList<Album> Albums;
        ListBox listbox;

        [SetUp]
        public void Init()
        {
            listbox = new ListBox();
            artistsTree = new AVLArtist<Artist>();
            Albums = new LinkedList<Album>();
            Albums.AddFirst(new Album(0, "The bboory nflalgs", DateTime.Parse("28/05/1993"), ""));
            Albums.AddFirst(new Album(1, "The flame wongy", DateTime.Parse("2/05/1992"), ""));
            Albums.AddFirst(new Album(2, "The bang hot", DateTime.Parse("23/05/1973"), ""));
            artist = new Artist("aba", 0, DateTime.Parse("28/05/1993"), "", "Manchester, UK", "The Syck", 20, Albums, "");
            artistsTree.InsertItem(artist);
        }

        [Test]
        public void checkBandName()
        {
            Assert.AreEqual(artist.BANDNAME, "The Syck");
        }

        [Test]
        public void CheckString()
        {
            Assert.AreEqual(artist.ToString(),"aba, Age 20");
        }

        [Test]
        public void searchName()
        {
            artistsTree.FindByStringItem("aba", false, false, ref listbox);
            Assert.AreEqual(1,listbox.Items.Count);
        }

        [Test]
        public void searchtitle()
        {
            artistsTree.FindByStringItem("wongy", true, false, ref listbox);
            Assert.AreEqual(1,listbox.Items.Count);
        }

        [Test]
        public void getAge()
        {
            Assert.AreEqual(20,artist.getAge());
        }

    }
}
