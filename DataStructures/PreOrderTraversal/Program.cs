using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.insert(100);
            tree.insert(50);
            tree.insert(150);
            tree.insert(25);
            tree.insert(75);
            tree.insert(125);
            tree.insert(175);
            tree.insert(110);

            Console.WriteLine("In Order");

            tree.DisplayInorder();

            Console.ReadKey();

            Console.WriteLine("Pre Order");

            tree.DisplayPreOder();

            Console.ReadKey();
        }
    }
}
