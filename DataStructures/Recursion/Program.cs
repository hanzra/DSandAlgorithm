using System;
using static System.Console;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 5, 7, 8, 10, 12, 13};

            BinarySearch bs = new BinarySearch(array);
            if (bs.Find(12) > 0)
                Console.WriteLine("found");
            else
                Console.WriteLine("Not found");

            Console.ReadKey();
        }
            




        /// <summary>
        /// For Anagrams
        /// </summary>
        /// <param name="args"></param>
     /*   static void Main(string[] args)
        {
            char[] word = new char[100];
            string wordString = "cats";

            word = wordString.ToCharArray();
            Anagram anagram = new Anagram(word);

            anagram.DoAnagram(word.Length);

            Console.ReadKey();
        }
        */



       /// <summary>
       /// Tiagular numbers below 
       /// </summary>
       /// <param name="args"></param>
/*
        static void Main(string[] args)
        {
            WriteLine("Enter integer");
            int value = Convert.ToInt32(ReadLine());

            int trianglenumber = TriangleNumber(value);

            WriteLine($"Triangle number at {value} is:  {trianglenumber}");
            ReadKey();
        }

        public static int TriangleNumber(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + TriangleNumber(n - 1);
        }

    */
    }
}
