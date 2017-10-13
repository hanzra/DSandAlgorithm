using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class StringReverser
    {
        string input;
        string output;

        public StringReverser(string input)
        {
            this.input = input;
        }
       
        public string DoReverse()
        {
            Stack stack = new Stack(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                stack.Push(ch);
            }

            output = "";

            while (!stack.IsEmpty())
            {
                char ch = stack.Pop();
                output = output + ch;
            }

            return output;
        }
    }
}
