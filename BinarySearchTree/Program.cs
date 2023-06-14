using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main()
        {
            Tree<int> tree = new Tree<int>();

            tree.Add(4);
            tree.Add(7);
            tree.Add(3);
            tree.Add(5);
            tree.Add(2);
            tree.Add(8);
            tree.Add(1);

            Console.WriteLine("Инфиксный обход: ");
            foreach (var item in tree.InorderLog())
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Прямой обход: ");
            foreach (var item in tree.PreorderLog())
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Постфиксный обход: ");
            foreach (var item in tree.PostorderLog())
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
