using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidOfLinkedList
{
    public class Link
    {
        public int iData;
        public Link Next;
        public Link(int iData)
        {
            this.iData = iData;
            Next = null;
        }

        public void Display()
        {
            Console.WriteLine(iData);
        }
    }
    public class LinkedListMidValue
    {
        Link Head;

        public LinkedListMidValue()
        {
            Head = null;
        }

        public void InsertNode(int iData)
        {
            Link newNode = new Link(iData);
            newNode.Next = Head;
            Head = newNode;
        }

        public void DisplayList()
        {
            Link current = Head;

            while (current != null)
            {
                Console.WriteLine($"{current.iData} ");
                current = current.Next;
            }
        }

        public Link FindModdleLinkedList()
        {
            if (Head == null)
                throw new Exception("There should be atleast 1 value in the list");

            Link sloPtr = Head;
            Link fastPtr = Head;

            while (fastPtr != null && fastPtr.Next !=null){
                sloPtr = sloPtr.Next;
                fastPtr = fastPtr.Next.Next;
            }

            return sloPtr;
        }
    }
}
