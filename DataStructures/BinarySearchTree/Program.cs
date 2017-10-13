using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bs = new BinarySearchTree();
            bs.Insert(2, 3);
            bs.Insert(5, 3);
            bs.Insert(1, 3);
            bs.Insert(9, 3);
            bs.Insert(10, 3);

            bs.Display();

             Console.ReadKey();

            Console.WriteLine("Finding 5");

            if (bs.Find(5) != null)
                Console.WriteLine($"Found {bs.Find(5).iData}");
            else
                Console.WriteLine("Not found");

            Console.WriteLine($"Min number: {bs.FindMin()}");
            Console.WriteLine($"Max number: {bs.FindMax()}");

            Console.ReadLine();

            //ToDo
            //Min from the list
            //Max from the list
            //insert
            //find
            //delete
        }
    }
}
