using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.hashtablepro
{
    internal class hashtable1
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add("91","India");
            h1.Add("92","usa");
            h1.Add("93","china");
            h1.Add("94","japan");

            foreach(DictionaryEntry n in h1)
            {
                Console.WriteLine($"{n.Key}={n.Value}");
            }
            h1.Remove("93");
            Console.WriteLine("after remove: ");
            foreach (DictionaryEntry n in h1)
            {
                Console.WriteLine($"{n.Key}={n.Value}");
            }

        }
    }
}
