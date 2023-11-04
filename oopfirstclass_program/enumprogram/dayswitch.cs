using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.enumprogram
{
    enum day2
    {
        sunday = 1,
        monday,
        thuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }
    internal class dayswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value of day");
            int n=Convert.ToInt32(Console.ReadLine());
            int  myday2 = (int)(day2)n;
            switch (myday2)
            {
                case 1:
                    Console.WriteLine( "hello this is sunday");
                    break;
                case 2:
                    Console.WriteLine("hello this is monday");
                    break;
                case 3:
                    Console.WriteLine("hello this is thuesday");
                    break;
                case 4:
                    Console.WriteLine("hello this is wednesday");
                    break;
                case 5:
                    Console.WriteLine("hello this is thursday");
                    break;
                case 6:
                    Console.WriteLine("hello this is friday");
                    break;
                case 7:
                    Console.WriteLine("hello this is saturday");
                    break;
                default:
                    Console.WriteLine("hello this is invalid day");
                    break;
            }

        }

        

    }
}
