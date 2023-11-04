using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.partialpro
{
   public class program1
    {
        static void Main(string[] args)
        {
            calu c1 = new calu();
            Console.WriteLine(c1.add(2, 7));
            Console.WriteLine(c1.sub(8, 7));
            Console.WriteLine(c1.mul(2, 7));
            Console.WriteLine(c1.square(2));
            Console.WriteLine(c1.cube( 7));
            
      
        }
    }

    //first  classes

    public partial class calu
    {
        public int add(int a, int b)
        {
            return a + b;

        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        partial void squareroot(int a);
       





    }
    //second class
        public partial class calu //calu partial class
        {
            public int square(int a)
            {
               squareroot(a);

                return a * a;
            }
        partial void squareroot(int a) //partial method
        {
            Console.WriteLine("square is :");
        }
    }

    //third class
        public partial class calu
        {
            public int cube(int a)
            {
          
            return a * a * a;
           
            }
      

    }


}
