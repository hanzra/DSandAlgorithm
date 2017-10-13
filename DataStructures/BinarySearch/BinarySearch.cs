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
                int mid = lo + (hi-lo) / 2;
                if(number == arr[mid])
                {
                    OutPut(comparison, true);
                    break;
                }
                else if(number < arr[mid])
                {
                    hi = mid - 1;
                    comparison++;
                }
                else
                {
                    lo = mid + 1;
                    comparison++;
                }                
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
