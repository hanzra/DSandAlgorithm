using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        int maxLength;
        char[] stack = null;
        int top = -1;

        public Stack(int maxLength)
        {
            this.maxLength = maxLength;
            stack = new char[maxLength];
        }

        public void Push(char number)
        {
            stack[++top] = number;
        }

        public char Pop()
        {
            return stack[top--];
        }

        public char Peek()
        {
            return stack[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return (top == maxLength - 1);
        }
    }
}
