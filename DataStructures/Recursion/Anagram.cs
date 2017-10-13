using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class Anagram
    {
        private char[] word = new char[100];
        private int size;
        private int count;
        
        public Anagram(char[] word)
        {
            this.word = word;
            size = word.Length;
        }

        public void DoAnagram(int newSize)
        {
            if (newSize == 1)
                return;

            for(int i = 0; i<newSize; i++)
            {
                DoAnagram(newSize - 1);

                if (newSize == 2)
                    DisplayWord();

                RotateWord(newSize);
            }

        }

        private void RotateWord(int newSize)
        {
            int Position = size - newSize;
            char temp = word[Position];
            

            for (int i = Position+1 ; i < size; i++)
            {
                word[i - 1] = word[i];
            }

            word[size - 1] = temp;
        }

        private void DisplayWord()
        {
            Console.Write($"{ ++count} :  ");
            foreach (var item in word)
            {
                Console.Write(item);
            }

            Console.Write($"    ");

            if (count % 6 == 0)
                Console.WriteLine("");
        }
    }
}
