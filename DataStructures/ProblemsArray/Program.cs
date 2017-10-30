using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            FindArray array = new FindArray();

            int[] finarray = new int[] {4,1,2};
            int[] arraynum = new int[] {1,3,4,2};

            int[] result = array.NextGreaterElement(finarray, arraynum);

            for (int i = 0; i < result.Count(); i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }
}
