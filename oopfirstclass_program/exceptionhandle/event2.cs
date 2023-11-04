using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.exceptionhandle
{
    public class event2
    {


        static void Main(string[] args)
        {
            try
            {
                Student1 stud1 = new Student1();

                // bind event with delegate
                // this a method body / code
                //{ Console.WriteLine("You are fail"); }
                stud1.Fail += delegate () 
                { 
                    Console.WriteLine("You are fail"); 
                };
                stud1.Pass += delegate () 
                {
                    Console.WriteLine("You are pass"); 
                };

                stud1.AcceptPercentage(65);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

    //
    public delegate void MyDelegate1();
    public class Student1
    {
        //when event raise then notification will be sent to MyDelegate
        public event MyDelegate Fail; // Fail & pass are the event names
        public event MyDelegate Pass;
        public void AcceptPercentage(double per)
        {
            if (per < 40)
            {
                Fail(); // raise an event / call to event
            }
            else
            {
                Pass();
            }
        }
    }
    


}
