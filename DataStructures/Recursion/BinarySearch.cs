using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class BinarySearch
    {
        int[] array = new int[100];
        public BinarySearch(int[] array)
        {
            this.array = array;
        }

        public int Find(int searchKey)
        {
            return RecFind(searchKey, 0, array.Length - 1);
        } 

        private int RecFind(int searchKey, int lowerBound, int upperBound)
        {
            if (lowerBound > upperBound)
                return 0;

            int Current = (lowerBound + upperBound) / 2;

            if (array[Current] == searchKey)
                return Current;
 
               if ( searchKey > array[Current])
                    return RecFind(searchKey, lowerBound + 1, upperBound);
                else
                    return RecFind(searchKey, lowerBound, upperBound - 1);     
          }
        
    }
}
