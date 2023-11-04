using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    internal class methodhide
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.display(54, "alisha");
          

        }
    }

    //.method hiding
    public abstract class person
    {
        int id;
        string p_name;

        public abstract void display(int id, string p_name);
      
        

            

    }

    public class Employee:person
    {
        public override void display(int id, string p_name)
        {
            Console.WriteLine($"id:{id}, Name: {p_name}");
        }
    }

}
