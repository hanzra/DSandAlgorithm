using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class DoubleLink
    {
        public int dData;
        public DoubleLink next;
        public DoubleLink previous;

        public DoubleLink(int dData)
        {
            this.dData = dData;
        }

        public void DisplayLink()
        {
            Console.WriteLine($"Data: {dData}");
        }
    }
    class DoublyLinkedList
    {
        DoubleLink first;        
        DoubleLink last;

        public DoublyLinkedList()
        {
            first = null;
            last = null;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void InsertFirst(int dData)
        {
            DoubleLink newLink = new DoubleLink(dData);

            if (IsEmpty())
                last = newLink;
            else
                first.previous = newLink;
            newLink.next = first;
            first = newLink;            
        }

        public DoubleLink DeleteFirst()
        {
            DoubleLink temp = first;

            if (first.next == null)
            {
                last = null;                
            }
            else
            {
                first.next.previous = null;                
            }            
            first = first.next;
            return temp;
        }

        public void InsertLast(int iData)
        {
            DoubleLink newLink = new DoubleLink(iData);
            if (IsEmpty())
            {
                first = newLink;
            }
            else
            {
                last.next = newLink;
                newLink.previous = last;
            }
            last = newLink;
        }

        public DoubleLink DeleteLast()
        {
            if (!IsEmpty())
            {
                DoubleLink temp = last;
                if (first.next == null)
                {
                    first = null;                    
                }
                else
                {
                    last.previous.next = null;                    
                }
                last = last.previous;
                return temp;
            }
            else
            {
                return null;
            }
        }
        public bool InsertAfter(int key,int toBeInserted) //assume non-empty list
        {
            DoubleLink current = first;

            while (current.dData != key)
            {
                current = current.next;
                if (current == null)
                    return false;
            }

            DoubleLink newLink = new DoubleLink(toBeInserted);

            if (current == last)
            {
                last = newLink;
            }
            else
            {                                
                newLink.next.previous = newLink;
            }
            newLink.next = current.next;
            newLink.previous = current;
            current.next = newLink;

            return true;
        }

        public DoubleLink DeleteKey(int key)
        {
            DoubleLink current = first;
            while (current.dData != key)
            {
                current = current.next;
                if (current == null)
                    return null;
            }

            if (current == first)
            {
                first = current.next;
            }
            else
            {
                current.previous.next = current.next;
            }

            if (current == last) {                
                last = current.previous;
            }
            else { 
               current.next.previous = current.previous;               
            }

            return current;
        }

        public void DisplayForward()
        {
            DoubleLink current = first;
            while(current != null)
            {
                current.DisplayLink();
                current = current.next;
            }
        }

        public void DisplayBackward()
        {
            DoubleLink current = last;

            while (current != null)
            {
                current.DisplayLink();
                current = current.previous;
            }
        }



    }
}


