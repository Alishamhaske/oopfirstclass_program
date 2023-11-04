using oopfirstclass_program.Arraypro;
using oopfirstclass_program.practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.exceptionhandle
{
    internal class student
    {
        /*Use  create Student class , accept the name from constructor &
        if name is empty or null then raise an exception ie. NameException with 
        message ‘name is required’ */

        static void Main(string[] args)
        {
            try
            {
                student3 std = new student3("tanu");

            }
            catch(NameException n)
            {
                Console.WriteLine(n.Message);
            }

        }
    }

    public class NameException : Exception
    {
        public NameException(string error) : base(error)
        {

        }

    }
        public class  student3
        {
            public student3(string name)
            {
                if(string.IsNullOrEmpty(name))
                {
                    throw new NameException("name");
                }
                else
            {
                Console.WriteLine(name);
            }
            }
        }
    
}
