using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        public Link first;

        public bool IsEmpty()
        {
            return first == null;
        }

        public void InsertFirst(int iData, double dData)
        {
            Link newLink = new Link(iData, dData);
            newLink.next = first;
            first = newLink;
        }

        public Link DeleteFirst()
        {
            Link temp = first;
            first = first.next;
            return temp;
        }

        public void DisplayList()
        {
            Link current = first;
            while (current != null)
            {
                current.DisplayData();
                current = current.next;
            }
        }

        public Link Find(int key)
        {
            Link current = first;

            while (current != null)
            {
                if(current.iData == key)
                {
                    return current;
                }
                else
                {
                    current = current.next;
                }
            }
            return null;
        }

        public Link Delete(int key)
        {
            Link current = first;
            Link previous = first;

            while (current != null)
            {
                if (current.iData == key)
                {
                    if (current == first)
                        first = first.next;
                    else
                        previous.next = current.next;
                    return current;
                }
                else
                {
                    previous = current;
                    current = current.next;
                }
            }
            return null;
        }
    }
}
