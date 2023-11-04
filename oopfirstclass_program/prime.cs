using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class prime
    {

        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("eneter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            {

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("prime number:");

                }
                else
                {
                    Console.WriteLine("not prime");
                }
            }

        }





    }

 
}
