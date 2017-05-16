using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch br = new BinarySearch();
            int searchnumber;
            string moreSearch = "Y";
            do
            {
                Console.WriteLine("enternumber");
                searchnumber = Convert.ToInt32(Console.ReadLine());
                br.Search(searchnumber);
                Console.WriteLine("More Search?");
                moreSearch = Console.ReadLine().ToUpper();                
            } while (moreSearch=="Y");
        }
    }
}