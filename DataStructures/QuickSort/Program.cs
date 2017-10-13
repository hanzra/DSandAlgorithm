using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort q = new QuickSort(100);
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                q.Insert(rnd.Next(1, 25));
            }

            Console.WriteLine("Before Sorting .......................");
            q.DisplayArray();

            q.DoQuickSort();

            Console.WriteLine("After Sorting .......................");
            q.DisplayArray();

            Console.ReadLine();
        }
    }
}
