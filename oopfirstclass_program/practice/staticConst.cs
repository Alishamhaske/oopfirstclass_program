using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.practice
{
    public class staticConst
    {
        static void Main(string[] args)
        {
            student3 stud3 = new student3();
            student3 stu3 = new student3();
            

        }
    }

    ///
    class student3
    {
        static student3()
        {
            Console.WriteLine("hello"); 
        }

        public student3()
        {
            Console.WriteLine("hello everyone");
            
        }
        

    }
}
