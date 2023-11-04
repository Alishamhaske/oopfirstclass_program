using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprogram
{
    public class pattern2
    {
        static void Main(string[] args)
        {

           /*
            5555
           4444
           3333
           2222
           1111
            */

            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=4;j++)
                // for(int j=4;j>=1;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
           54321
            54321
            54321
            54321
            54321
           */

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 5; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
