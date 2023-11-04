using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprogram
{
    public class pattern3
    {
        static void Main(string[] args)
        {
            /*
             
             * 
             **
             ***
             *****
             

             */
        for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
             
             1 
             22
             333
             4444
             

             */
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*

            1 
            12
            123
            1234


            */
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

          
            Console.ReadLine();
        }
    }
}
