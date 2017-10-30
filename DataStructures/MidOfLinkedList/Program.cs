using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListMidValue ls = new LinkedListMidValue();

            
            ls.InsertNode(6);
            ls.InsertNode(5);
            ls.InsertNode(4);
            ls.InsertNode(3);
            ls.InsertNode(2);
            ls.InsertNode(1);

            ls.DisplayList();

            Link mid = ls.FindModdleLinkedList();

            Console.WriteLine("mid value is ");
            mid.Display();

            Console.ReadKey();


        }
    }
}
