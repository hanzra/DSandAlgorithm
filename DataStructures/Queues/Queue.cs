using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    public class Queue
    {

        int maxsize;
        int nItems;
        int front = 0;
        int rear = -1;
        int[] queue;

        public Queue(int size)
        {
            this.maxsize = size;
            queue = new int[maxsize];
        }

        public void Insert(int item)
        {
            if (rear == maxsize - 1)        //deal with wrap around
                rear = -1;
            queue[++rear] = item;
            nItems++;                       //one more items 
        }

        public int Remove()
        {
            int temp = queue[front++];            
            if (front == maxsize)
                front = 0;
            nItems--;
            return temp;
        }

        public int Peek()
        {
            return queue[front];
        }

        public bool IsEmpty()
        {
            return nItems == 0;
        }

        public bool IsFull()
        {
            return nItems == maxsize;
        }

        public int Size()
        {
            return nItems;
        }
    }
}
