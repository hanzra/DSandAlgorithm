using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            /***LinkedList*****/
            //LinkedList linkList = new LinkedList();

            //linkList.InsertFirst(1, 23);
            //linkList.InsertFirst(2, 23);
            //linkList.InsertFirst(3, 23);
            //linkList.InsertFirst(4, 23);
            //linkList.InsertFirst(5, 23);

            //linkList.DisplayList();

            //Console.WriteLine("---------------");

            //if (!linkList.IsEmpty())
            //{
            //    linkList.DeleteFirst().DisplayData();
            //}

            //Console.WriteLine("---------------");

            //if (!linkList.IsEmpty())
            //    linkList.Delete(1).DisplayData();

            //Console.WriteLine("---------------");

            //linkList.Find(2).DisplayData();

            //Console.WriteLine("---------------");

            //linkList.DisplayList();

            //Console.ReadLine();

            /************-------------------------------*******************/


            DoublyLinkedList list = new DoublyLinkedList();
            list.InsertFirst(2);
            list.InsertAfter(2, 3);

            list.DisplayForward();
            list.DisplayBackward();

            Console.ReadKey();
        }
    }
}
