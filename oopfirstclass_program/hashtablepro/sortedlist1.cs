using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.hashtablepro
{
    internal class sortedlist1
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add("99", "india");
            s1.Add("92", "india");
            s1.Add("98", "india");
            s1.Add("93", "india");
            s1.Add("94", "india");
            s1.Add("95", "india");
           
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine($"{item.Key}={item.Value}");
            }
            Console.WriteLine("after remove ");
            s1.Remove("95");
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine($"{item.Key}={item.Value}");
            }
        }
    }
}
