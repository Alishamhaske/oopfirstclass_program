using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.structurepro
{
    public class firststrut
    {
        static void Main(string[] args)
        {
            screen s1 = new screen(11, 12);
            Console.WriteLine(s1.print());
        }
    }
    //

    public struct screen
    {
        int x, y;
        public screen(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public string print()
        {
            return $"x is: {x} , y is: {y}";

        }
    }
}
