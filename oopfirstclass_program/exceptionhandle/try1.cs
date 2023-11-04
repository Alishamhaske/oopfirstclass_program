using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.exceptionhandle
{
    public class try1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int c = n1 / n2;
                Console.WriteLine("division is: "+c);
                
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
