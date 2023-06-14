using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
