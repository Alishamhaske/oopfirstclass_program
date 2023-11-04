using oopfirstclass_program.second_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.polymorphismpro
{
    internal class override1
    {
        static void Main(string[] args)
        {
            father f1 = new father("sanjay", 45);
         
            //Console.WriteLine(f1.display());

        }
    }
    //override method example
    public class grandfather
    {
        public string g_name;
        public int g_age;

        public grandfather(string g_name, int g_age)
        {
            this.g_name = g_name;
            this.g_age = g_age;
        }
        public virtual string display()
        {
            Console.WriteLine("grand father details");
            return $"grandfather_name:{g_name} grand_age:{g_age}";
        }

    }

    //second class
    public class father
    {
        public string f_name;
        public int f_age;

        public father(string f_name,int f_age)
        {
            this.f_name = f_name;
            this.f_age = f_age;

        }
       /* public override string  display()
        {
            Console.WriteLine("father details");
            return $"Father name:{f_name} Father age:{f_age}";
        }
*/
    }

}
 