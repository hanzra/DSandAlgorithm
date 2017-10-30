using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortRecursion
{
    public class MergeSort
    {
        int[] thisArray;
        int nElement=0;

        public MergeSort(int  maxSize)
        {
            thisArray = new int[maxSize];
        }

        public void Insert(int data)
        {
            thisArray[nElement++] = data;
        }

        public void Display()
        {
            for (int i = 0; i < nElement; i++)
            {
                Console.WriteLine(thisArray[i]);
                Console.WriteLine("");
            }
        }

        public void SortArray() {
            int[] workspace = new int[nElement];
            
            recSort(workspace, 0, nElement-1);
        }

        public void recSort1(int[] workspace, int lowerBound, int UpperBound)
        {
            if (lowerBound == UpperBound)
                return;
            int mid = (UpperBound + lowerBound) / 2;            

            recSort1(workspace, lowerBound, mid);
            recSort1(workspace, mid + 1, UpperBound);

            Merge1(workspace, lowerBound, UpperBound);
        }

        private void Merge1(int[] workspace, int lowerBound, int UpperBound)
        {
            int mid = (lowerBound + UpperBound) / 2;
            int lptr = lowerBound;
            int hptr = mid + 1;
            int j = 0;

            while(lptr<=mid && hptr <= UpperBound)
            {
                if (thisArray[lptr] < thisArray[hptr))
                {
                    workspace[j++] = thisArray[lptr];
                    lptr++;
                }

                else
                {
                    workspace[j++] = thisArray[hptr];
                    hptr++;
                }
            }

            while (lptr <= mid)
                workspace[j++] = thisArray[lptr++];

            while (hptr <= UpperBound)
                workspace[j++] = thisArray[hptr++];


            for (int i = 0; i < j; i++)
            {
                thisArray[lowerBound++] = workspace[i];
            }
        }


        private void recSort(int[] workspace,int lowerbound, int upperbound)
        {
            Console.WriteLine($"Sorting {lowerbound} - {upperbound}");

            if (lowerbound == upperbound)
                return;
              
            int mid = (upperbound + lowerbound) / 2;

            recSort(workspace, lowerbound, mid);
            recSort(workspace, mid + 1, upperbound);

            Merge(workspace, lowerbound, upperbound);
        }

        private void Merge(int[] workspace, int lowebound, int upperbound)
        {
            Console.WriteLine($"Merging {lowebound} and {upperbound}");
            int j = 0;
            int lpointer = lowebound;
            int mid = (lowebound + upperbound) / 2;
            int hpointer = mid + 1;

            

            while(lpointer<=mid & hpointer<=upperbound)
            {
                Console.WriteLine($"Sorting {lpointer} - {mid} and {hpointer}- {upperbound}");
                if (thisArray[lpointer] > thisArray[hpointer])
                    workspace[j++] = thisArray[hpointer++];
                else
                    workspace[j++] = thisArray[lpointer++];
            }

            while (lpointer <= mid)
                workspace[j++] = thisArray[lpointer++];

            while (hpointer <= upperbound)
                workspace[j++] = thisArray[hpointer++];

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine($"Copying {workspace[i]} to {lowebound} + 1");
                thisArray[lowebound+i] = workspace[i];
            }
        }
    }
}
