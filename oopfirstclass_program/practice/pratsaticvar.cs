using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.practice
{
    public class pratsaticvar
    {
        static void Main(string[] args)
        {
            student2 s1 = new student2();
            s1.show();
            student2.output();
           


        }
    }
    ///
     
    class student2
    {
        int x = 10;
        static int y = 20;

        public void show()
        {
            Console.WriteLine(x+" "+y);
        }
        public static void output()
        {
            student2 s2 = new student2();
            Console.WriteLine(s2.x+" "+y);
        }

    }
}
