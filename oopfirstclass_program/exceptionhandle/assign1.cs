using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.exceptionhandle
{
    public class assign1
    {
        //If number is negative then throw negative number exception.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number :");
                int n = Convert.ToInt32(Console.ReadLine());
                if(n<0)
                {
                    throw new Exception("it is negative number:");
                }
                else
                {
                    Console.WriteLine("number is: "+n);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
