using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.enumprogram
{
    enum day
    {
        sunday=1,
        monday,
        thuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }
    internal class myday
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name:" );
            string name = Console.ReadLine();
            Console.WriteLine("enter a day sunday=1,monday=2 ,thues=3,wed=4,thur=5,fri=6, sta=7 ");
            int n = Convert.ToInt32(Console.ReadLine());
            day myday11 = (day)n;

            Console.WriteLine("my name is "+ name+"my birthday is "+myday11);
        }

    }
}
