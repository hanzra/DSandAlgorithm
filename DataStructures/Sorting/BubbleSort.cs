using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        int[] array;
        int nElements = 0;

        public BubbleSort(int maxSize)
        {
            array = new int[maxSize];
        }

        public void Insert(int data)
        {
            array[nElements++] = data;
        }

        public void DisplaySortedArray()
        {
            for (int i = 0; i < nElements; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void SortArrayBubble()
        {
            for (int outerLoop = nElements-1; outerLoop >1; outerLoop--)
            {
                for (int innerLoop = 0; innerLoop < outerLoop; innerLoop++)
                {
                    if (array[innerLoop] > array[innerLoop + 1])
                        Swap(innerLoop, innerLoop + 1);
                }
            }
        }

        public void SortArraySelection()
        {
            int min;

            for (int j = 0; j < nElements-1; j++)
            {
                min = j;

                for (int i = j+1; i < nElements; i++)
                {
                    if (array[i] < array[min])
                    {
                        min = i;                        
                    }
                }
                Swap(j, min);
            }
        }

        public void SortArrayInsertion() {            

            for (int i = 1; i < nElements; i++)
            {
                int temp = array[i];
                int pointer = i-1;
                
                while(pointer >= 0 && array[pointer] > temp)
                {
                    array[pointer+1] = array[pointer];
                    pointer = pointer - 1; ;
                }

                array[pointer+1] = temp;   
            }
        }

        public void SortArrayInsertion1()
        {
            for (int i = 1; i < nElements; i++)
            {
                int temp = array[i];
                int pointer = i-1;

                while(pointer>=0 && array[pointer] > temp)
                {
                    array[pointer + 1] = array[pointer];
                    pointer--;
                }

                array[pointer + 1] = temp;
            }
        }

        private void Swap(int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
