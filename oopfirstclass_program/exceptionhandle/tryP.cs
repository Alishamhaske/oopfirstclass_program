using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.exceptionhandle
{
    public class tryP
    {
        static void Main(string[] args)
        {
            try
            {
                string str = " ";
  
                 if(string.IsNullOrEmpty(str))
                {
                    throw new Exception("string is empty:");
                }
                Console.WriteLine("string is "+str);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally block executed: ");
            }
        }
    }
}
