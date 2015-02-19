using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistComplex.Source
{
    public class Node<T> where T : IComparable
    {
        // Nodes parameters, data , left and right as well as balance factor
        private T data;
        public Node<T> Left, Right;
        private int balanceFactor = 0;

        public Node(T item) // node constructor
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data // node setter and getter
        {
            set { data = value; }
            get { return data; }
        }
        public int BalanceFactor // node balance factor ( height to the left minus highet to the right)
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }

    }
}
