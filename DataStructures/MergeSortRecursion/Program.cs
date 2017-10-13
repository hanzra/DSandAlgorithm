using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort sort = new MergeSort(10);
            sort.Insert(2);
            sort.Insert(4);
            sort.Insert(3);
            sort.Insert(7);
            sort.Insert(12);
            sort.Insert(45);
            sort.Insert(22);
            sort.Insert(11);
            sort.Insert(10);
            sort.Insert(17);

            sort.SortArray();
            sort.Display();

            Console.ReadKey();
        }
    }
}
