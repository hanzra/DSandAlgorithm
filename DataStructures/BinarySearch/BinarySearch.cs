using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{    class BinarySearch
    {

        int[] arr = new int[] {2,4,5,7,10,33,44,55,90,100};

        
        public bool Search(int number)
        {
            int lo = 0;
            int hi = 9;            
            int comparison = 1;


            while (lo <= hi)
            {
                int Mid = lo + (hi - lo) / 2;
                if (arr[Mid] == number)
                {
                    OutPut(comparison, true);
                    return true;
                }
                else if (arr[Mid] < number)
                {
                    lo = Mid + 1;
                }
                else
                {
                    hi = Mid - 1;
                }
                comparison++;
            }
            OutPut(comparison, false);
            return false;
        }

        public void OutPut(int compariosns, bool found)
        {
            Console.WriteLine($"Found: {found} Comparisons: {compariosns}");
        }



    }
}
