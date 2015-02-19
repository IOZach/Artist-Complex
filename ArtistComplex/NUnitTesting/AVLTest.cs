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
    class AVLTest
    {

        AVLArtist<Artist> artistsTree;
        Artist artist1;
        Artist artist2;
        Artist artist3;
        String output1;

        [SetUp]
        public void Init()
        {
            artistsTree = new AVLArtist<Artist>();
            artist1 = new Artist("aba", 0, DateTime.Parse("28/05/1993"), "", "Manchester, UK", "The Syck", 20, null, "");
            artist2 = new Artist("apa", 0, DateTime.Parse("28/05/1993"), "", "Manchester, UK", "The Syck", 20, null, "");
            artist3 = new Artist("zzz", 0, DateTime.Parse("28/05/1993"), "", "Manchester, UK", "The Syck", 20, null, "");
        }

        [Test]
        public void InsertItem()
        {
            artistsTree.InsertItem(artist1);
            Assert.AreEqual(1, artistsTree.Count());
        }

        [Test]
        public void removItem()
        {
            artistsTree.RemoveItem(artist1);
            Assert.AreEqual(0, artistsTree.Count());
        }

        [Test]
        public void TreeContain()
        {
            artistsTree.InsertItem(artist1);
            Assert.AreEqual(true, artistsTree.Contains(ref artist1));
        }

        [Test]
        public void TreeBalance()
        {
            artistsTree.InsertItem(artist1);
            artistsTree.InsertItem(artist2);
            artistsTree.InsertItem(artist3);
            artistsTree.PostOrder(ref output1);
            Assert.AreEqual("aba, Age 20zzz, Age 20apa, Age 20", output1);
        }

    }
}
