using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.genricpro
{
    internal class hashset1
    {
        static void Main(string[] args)
        {

            HashSet<string> h1 = new HashSet<string>();
            {
                h1.Add("alisha");
                h1.Add("tanuja");
                h1.Add("payal");
                h1.Add("pradhnya");
                h1.Add("riya");
                h1.Add("alisha");
                h1.Add("alisha");

            }

            foreach (string item in h1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            ///math opertaion
            HashSet<string> h2 = new HashSet<string>();
            {
                h2.Add("alisha");
                h2.Add("tanuja");
                h2.Add("riya");
                h2.Add("pradhnya");
                h2.Add("riya");
                h2.Add("alisha");
                h2.Add("alisha");

            }
            Console.WriteLine();

            HashSet<string> h3 = new HashSet<string>();
            {
                h3.Add("alisha");
                h3.Add("tanu");
                h3.Add("aaru");
                h3.Add("prachi");
                h3.Add("riya");
                h3.Add("alisha");
                h3.Add("tane");

            }

            foreach (string item in h3)
            {
                Console.WriteLine(item);
            }

            // combine the result & display unique elements
            Console.WriteLine();
            Console.WriteLine("unoin operation");
            h2.UnionWith(h3);



            foreach (string item1 in h2)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine();
            Console.WriteLine("interacsect operation");
            h2.Except(h3);
            foreach (string item2 in h2)
            {
                Console.WriteLine(item2);
            }


        }


    }
}
