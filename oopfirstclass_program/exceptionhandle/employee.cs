using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.exceptionhandle
{
    public class program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
               
             
                 string str = null;
               
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("string is empty:");
                }
                Console.WriteLine(str);
            }
            catch(Exception n)
            {
                Console.WriteLine(n.Message);
            }
            finally
            {
                Console.WriteLine("Inside the finallay block: ");
            }
        }
    }


}
