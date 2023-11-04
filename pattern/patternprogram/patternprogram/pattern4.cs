using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprogram
{
    public class pattern4
    {
        static void Main(string[] args)
        {
            /*

          *****
          ****
          ***
          **
          *


          */
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            /*

          55555
          4444
          333
          22
          1
         


          */
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            /*


            
12345
1234
123
12
1
         


          */
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }



            /*

          *****
           ****
            ***
             **
              *


          */

            for (int i = 1; i<=5; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 5; j >=i; j--)
                {
                   
                    
                    Console.Write("*");
                }
               
                Console.WriteLine();
            }


            Console.WriteLine();

            /*

                      54321
                      5432
                      543
                      54
                      5
             */
            
            Console.ReadLine();
        }
    }
}
