using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            char? c = firstNonRepeatingCharacter("thisthi");

           if ( c!=null)
                Console.WriteLine(c);
            Console.ReadKey();
        }


        public static char? firstNonRepeatingCharacter(string str)
        {            
            Hashtable hash = new Hashtable();
            char c;
            char[] characterString = str.ToCharArray();            

            for (int i = 0; i < str.Length; i++)
            {
                c = characterString[i];
                
                if (hash.ContainsKey(c))
                {
                    hash[c] = (int)hash[c] + 1;
                }
                else
                {
                    hash.Add(c, 1);
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                c = characterString[i];
                if ((int)hash[c] == 1)
                    return characterString[i];
            }

            return null;            
        }
    }
}
