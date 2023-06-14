using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree<T>
        where T : IComparable<T>
    {
        private Node<T>? root;

        public void Add(T data)
        {
            root = AddNode(root!, data);
        }

        public Node<T> AddNode(Node<T> node, T data)
        {
            if (node == null)
            {
                return new Node<T>(data);
            }

            if (data.CompareTo(node.Data) == -1)
            {
                node.Left = AddNode(node.Left!, data);
            }
            else
            {
                node.Right = AddNode(node.Right!, data);
            }

            return node;
        }

        public List<T> PreorderLog()
        {
            if (root == null)
            {
                return new List<T>();
            }

            return PreorderLog(root);
        }
        private List<T> PreorderLog(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(PreorderLog(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PreorderLog(node.Right));
                }
            }
            return list;
        }

        public List<T> PostorderLog()
        {
            if (root == null)
            {
                return new List<T>();
            }

            return PostorderLog(root);
        }
        private List<T> PostorderLog(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(PostorderLog(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PostorderLog(node.Right));
                }

                list.Add(node.Data);
            }
            return list;
        }

        public List<T> InorderLog()
        {
            if (root == null)
            {
                return new List<T>();
            }

            return InorderLog(root);
        }
        private List<T> InorderLog(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InorderLog(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(InorderLog(node.Right));
                }
            }
            return list;
        }

        public void Search(T data)
        {
            Search(root!, data);
            Console.WriteLine("Такой элемент есть.");
        }

        public Node<T> Search(Node<T> node, T data)
        {
            if (node == null)
            {
                throw new ArgumentException("Дерево пусто/Такого элемента нет.");
            }
            if (data.CompareTo(node.Data) == 1)
            {
                Search(node.Right!, data);
            }
            if (data.CompareTo(node.Data) == -1)
            {
                Search(node.Left!, data);
            }
            return node;
        }
    }
}
