using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistComplex.Source
{
    public class BST<T> : BT<T> where T : IComparable
    {  

        public BST() // using the root of binary tree 
        {
            root = null;
        }
        public BST(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InsertItem(T item) // insertion method, add node to left of its less than its root and add to right if its greater.
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

        }

        public void RemoveItem(T item) // remove item by recursioning over the tree , if it haven't got childs then just remove 
        // it if it has then replace it with the deapest(using FindMin()) the right from left or left from right of the root and then remove the one has no child, i.e. the one replaced.
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
        }

        public int Height() // calculate the height of the tree
        {
            return height(root);
        }

        protected int height(Node<T> tree)
        {

            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(tree.Left), height(tree.Right));
            }
        }

        public bool Contains(ref T item) // return if tree contains the passed item if yes then return bool as well as pass the node via reference
        {
            return contains(root, ref item);
        }

        private bool contains(Node<T> node, ref T item)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.Data.CompareTo(item)==0)
            {
                item = node.Data;
                return true;
            }
            else if (node.Data.CompareTo(item) > 0)
            {
                return contains(node.Left, ref item);
            }
            else
            {
                return contains(node.Right, ref item);
            }
        }

        public T FindMin(Node<T> tree) // Find the depeast left node from the right tree of the root
        {
            return findMin(tree);
        }

        private T findMin(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return findMin(tree.Left);
            }
        }

        public void CopyTo(ref BST<T> original) // copy one tree to another tree
        {
            copyTo(ref original.root);
        }

        private void copyTo(ref Node<T> original)
        {
            if (original != null)
            {
                if (this.root == null)
                {
                    this.root = new Node<T>(original.Data);
                }
                else
                {
                    this.InsertItem(original.Data);
                }
                copyTo(ref original.Left);
                copyTo(ref original.Right);
            }
        }

        public bool Equals(BST<T> tree) // bool returns upon if the check two tree whether equal each other or not.
        {

            return equals(tree.root, this.root);

        }

        private bool equals(Node<T> fnode, Node<T> snode)
        {
            if (fnode == snode)
            {
                return true;
            }
            if (fnode == null || snode == null)
            {
                return false;
            }
            return fnode.Data.CompareTo(snode.Data) == 0 && equals(fnode.Left, snode.Left) && equals(fnode.Right, snode.Right);
        }

        public bool SubTree(BST<T> tree) // check if a tree is subtree out of a whole tree
        {
            return subTree(tree.root, this.root);
        }

        private bool subTree(Node<T> tree, Node<T> subtree)
        {

            if (subtree == null)
            {
                return true;
            }
            if (tree == null)
            {
                return false;
            }

            if (equals(tree, subtree))
            {
                return true;
            }

            return (tree == subtree) || subTree(tree.Right, subtree) || subTree(tree.Left, subtree);

        }

    }
}
