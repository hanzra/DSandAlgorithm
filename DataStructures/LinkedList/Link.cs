using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace LinkedList
{
    public class Link
    {
        public int iData;
        public double dData;
        public Link next;

        public Link(int iData, double dData)
        {
            this.iData = iData;
            this.dData = dData;
        }

        public void DisplayData()
        {
            WriteLine($"iData: {iData} and dData: {dData}");
        }
    }
}
