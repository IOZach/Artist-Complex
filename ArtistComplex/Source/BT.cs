using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistComplex.Source
{
    public class BT<T> where T : IComparable
    {
        protected Node<T> root; // starter node for binary tree

        public BT()  // constructor with empty tree
        {
            root = null;
        }

        public BT(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void PreOrder(ref string output) // display treee nodes in pre order of insertion
        {
            preOrder(root, ref output);
        }

        private void preOrder(Node<T> tree, ref string output)
        {
            if (tree != null)
            {
                output = output + tree.Data + " ";
                preOrder(tree.Left, ref output);
                preOrder(tree.Right, ref output);
            }
        }

        public void InOrder(ref string output) // display tree nodes in order of insertion
        {
            inOrder(root, ref output);
        }

        private void inOrder(Node<T> tree, ref string output)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref output);
                output = output + tree.Data + " ";
                inOrder(tree.Right, ref output);
            }
        }

        public void PostOrder(ref string output) // display tree nodes  post order of insertion
        {
            postOrder(root, ref output);
        }

        private void postOrder(Node<T> tree, ref string output)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref output);
                postOrder(tree.Right, ref output);
                output += tree.Data;
            }
        }

        public int Count() // Calculates the number of nodes in the tree
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {
            int counter = 0;
            if (tree != null)
            {
                counter = 1 + count(tree.Left) + count(tree.Right);
            }
            return counter;
        }

    }
}
