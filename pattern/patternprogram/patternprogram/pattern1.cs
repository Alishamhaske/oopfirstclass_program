using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprogram
{
    public class pattern1
    {
        static void Main(string[] args)
        {
/*
            ****
            ****
            ****
            ****
*/
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            /*
            1111
            2222
            3333
            4444
*/
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            /*
           1234
           1234
           1234
           1234
*/
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
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
