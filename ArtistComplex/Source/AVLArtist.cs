using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtistComplex.Source
{
    public class AVLArtist<T> : AVL<T> where T : IComparable
    {
        public void NodesToListBox(ref ListBox listBox) // Pass in windows form object and print in all nodes in AVL tree
        {
            listBox.Items.Clear();
            nodestolistbox(root, ref listBox);
        }

        private void nodestolistbox(Node<T> tree, ref ListBox listBox)
        {
            if (tree != null)
            {
                listBox.Items.Add(tree.Data.ToString());
                nodestolistbox(tree.Left, ref listBox);
                nodestolistbox(tree.Right, ref listBox);
            }
        }

        public void RebalanceNodes() // Rebalance all nodes in AVL tree
        {
            Node<T> newroot = root;
            root = null;
            rebalancenodes(ref newroot);
        }

        private void rebalancenodes(ref Node<T> newroot)
        {
            if (newroot != null)
            {
                rebalancenodes(ref newroot.Left);
                rebalancenodes(ref newroot.Right);
                InsertItem(newroot.Data);
            }
        }

        // two purpose function, either seach for artist name or any album title has in it a substring defined by user.
        public void FindByStringItem(string item, bool albums, bool artist, ref ListBox listBox)
        {
            listBox.Items.Clear();
            findByStringItem(root, item.ToLower(), albums, artist, ref listBox);
        }

        private void findByStringItem(Node<T> tree, string item, bool albums, bool artist, ref ListBox listBox)
        {
            if (tree != null)
            {
                if ((artist && new Artist(tree.Data.ToString().Split(',')[0].ToLower()).checkartistalbum(item)) || (albums && tree.Data.CompareTo(item) == 0) || (tree.Data.CompareTo(new Artist(item)) == 0))
                {
                    listBox.Items.Add(tree.Data.ToString());
                }
                findByStringItem(tree.Left, item, albums, artist, ref listBox);
                findByStringItem(tree.Right, item, albums, artist, ref listBox);
            }
        }
    }
}
