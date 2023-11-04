using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.refkeyprogram
{
    public class refpro1
    {

        static void Main(string[] args)
        {
            int a = 60, b = 80;
            Swap(ref a, ref b);
  
            Console.WriteLine($"after swapping value of A:{a} ");
            Console.WriteLine($"after swapping value of B:{b}");


        }
        static void Swap(ref int a, ref int b)
        {
            
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
}
