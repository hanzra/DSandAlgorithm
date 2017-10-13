using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack(20);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(5);
            //stack.Push(6);
            //stack.Push(4);

            //while (!stack.IsEmpty())
            //{
            //    Console.WriteLine(stack.Peek());
            //    stack.Pop();
            //}

            StringReverser sr = new StringReverser("sandeep");
            Console.WriteLine("Reverse string is: " + sr.DoReverse());
            Console.ReadLine();
        }
    }
}