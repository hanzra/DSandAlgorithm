using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Node
    {
        int iData;

        public Node(int data)
        {
            iData = data;
        }

        public int GetKey()
        {
            return iData;
        }

        public void SetKey(int newData)
        {
            iData = newData;
        }
    }

    public class Heap
    {
        Node[]  heapArray = null;
        int maxSize;
        int currentSize;

        public Heap(int maxSize)
        {
            heapArray = new Node[maxSize];
            this.maxSize = maxSize;
            currentSize = 0;
        }

        public bool InsertKey(int key)
        {
            Node newNode = new Node(key);

            if (currentSize == maxSize)
                return false;

            heapArray[currentSize] = newNode;

            TrickleUp(currentSize++);
            return true;
        }

        public Node Remove()
        {
            if (currentSize == 0)
                return null;

            Node removeNode = heapArray[0];

            heapArray[0] = heapArray[--currentSize];
            TrickleDown(0);
            return removeNode;
        }

        public void TrickleDown(int index)
        {
            int largerChild ;
            Node top = heapArray[index];

            while(index > currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if(rightChild < currentSize && heapArray[leftChild].GetKey() < heapArray[rightChild].GetKey())
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }

                if (heapArray[largerChild].GetKey() <= top.GetKey())
                    break;
                
                heapArray[index] = heapArray[largerChild];
                index = largerChild;                
            }
            heapArray[index] = top;
        }

        public void TrickleUp(int index)
        {
            int Parent = (index - 1) / 2;
            Node bottom = heapArray[index];

            while(index>0 && bottom.GetKey() > heapArray[Parent].GetKey())
            {
                heapArray[index] = heapArray[Parent];
                index = Parent;
                Parent = (index - 1) / 2;
            }
            heapArray[index] = bottom;
        }
    }
}
