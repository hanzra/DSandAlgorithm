using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        int[] array;
        int nelem;

        public QuickSort(int size)
        {
            array = new int[size];
            nelem = 0;
        }

        public void Insert(int data)
        {
            array[nelem++] = data;
        }

        public void DoQuickSort()
        {
            QuickSortData(0, nelem - 1);
        }

        public void DisplayArray()
        {
            for (int i = 0; i < nelem-1; i++)
            {
                Console.WriteLine(array[i]);
                Console.WriteLine(" ");
            }
        }

        private void QuickSortData(int lowerBound, int upperBound)
        {
            if (lowerBound >= upperBound)
                return;

            int pivotIndex = DoPartitioning(lowerBound, upperBound);

            QuickSortData(lowerBound, pivotIndex - 1);
            QuickSortData(pivotIndex + 1, upperBound);
            
        }

        private int DoPartitioning(int lowerBound, int upperBound)
        {
            int pivot = array[upperBound];
            int pivotIndex = lowerBound;
            
            for(int i = lowerBound; i < upperBound; i++)
            {
                if (array[i] <= pivot)
                {
                    Swap(pivotIndex, i);
                    pivotIndex++;
                }
            }

            Swap(pivotIndex, upperBound);
            return pivotIndex;
        }

        private void Swap(int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
