using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ArtistComplex.Source;

namespace ArtistComplex.NUnitTesting
{
    [TestFixture]
    class AlbumTest
    {
        LinkedList<Album> Albums;
        Album album;

        [SetUp]
        public void Init()
        {
            Albums = new LinkedList<Album>();
            album = new Album();
        }

        [Test]
        public void instantiatealbum()
        {
            album = new Album(0, "The wongbong", DateTime.Parse("28/05/1993"), "");
            Assert.AreEqual("The wongbong", album.ALBUMNAME);
        }

        [Test]
        public void getalbum(){
        
            album = new Album(0, "The wongbong", DateTime.Parse("28/05/1993"), "");
            Assert.AreEqual("0, The wongbong", album.ToString());
        }
    }
}
