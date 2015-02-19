using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtistComplex.Source
{
    public class AVL<T> : BST<T> where T : IComparable
    {
        public new void InsertItem(T item) // AVL tree insert item same as BST yet balancing involved to keep tree flat as possible, using rotate left and right.
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {

            if (tree == null)
            {
                tree = new Node<T>(item);

            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);

            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }

            Balance(ref tree);

        }

        public void Balance(ref Node<T> tree) // Balancing tree
        {
            balance(ref tree);
        }

        private void balance(ref Node<T> tree)
        {

            tree.BalanceFactor = height(tree.Left) - height(tree.Right);

            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }

        }

        private void rotateLeft(ref Node<T> tree) // root right subtree becomes new root. The left subtree of old root becomes left subtree of new root, and newroot left subtree becomes right subtree of newroot left subtree of old root
        {
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right);
            }
            Node<T> oldRoot = tree;
            tree = tree.Right;
            oldRoot.Right = tree.Left;
            tree.Left = oldRoot;
        }

        private void rotateRight(ref Node<T> tree) // root left subtree becomes new root. The right subtree of old root becomes right subtree of new root, and newroot right subtree becomes left subtree of right subtree of old root
        {
            if (tree.Left.BalanceFactor < 0)
            {
                rotateLeft(ref tree.Left);
            }
            Node<T> oldRoot = tree;
            tree = tree.Left;
            oldRoot.Left = tree.Right;
            tree.Right = oldRoot;
        }

        public new void RemoveItem(T item) // similar to BST yet once remove components as the recursion reverse back it keep check same balance function along the way until it reaches root
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree != null)
            {

                if (item.CompareTo(tree.Data) < 0)
                {
                    removeItem(item, ref tree.Left);
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    removeItem(item, ref tree.Right);
                }
                else if (item.CompareTo(tree.Data) == 0)
                {
                    if (tree.Left == null)
                    {
                        tree = tree.Right;
                    }
                    else if (tree.Right == null)
                    {
                        tree = tree.Left;
                    }
                    else
                    {
                        T temp = FindMin(tree.Right);
                        tree.Data = temp;
                        removeItem(temp, ref tree.Right);
                    }
                }
            }
            if (tree != null)
            {
                balance(ref tree);
            }

        }

    }
}
