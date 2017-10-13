using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            BubbleSort sort = new BubbleSort(10);

            sort.Insert(2);
            sort.Insert(1);
            sort.Insert(5);
            sort.Insert(3);
            sort.Insert(6);
            sort.Insert(8);
            sort.Insert(4);
            sort.Insert(7);

            sort.SortArrayInsertion();

            sort.DisplaySortedArray();

            Console.ReadKey();

        }
    }
}
