using System;
using static System.Console;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(10);

            queue.Insert(2);
            queue.Insert(3);
            queue.Insert(4);
            queue.Insert(5);
            queue.Insert(6);
            queue.Insert(6);
            queue.Insert(6);
            queue.Insert(8);
            queue.Insert(9);
            queue.Insert(9);


            WriteLine(queue.Peek());
            queue.Remove();
            WriteLine(queue.Peek());
            queue.Remove();
            queue.Insert(10);
            WriteLine(queue.Peek());

            ReadLine();
        }
    }
}
