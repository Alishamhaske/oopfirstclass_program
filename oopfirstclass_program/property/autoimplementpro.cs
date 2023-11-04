using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.property
{
    public class autoimplementpro
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            //property initilizer
            s1.Id = 1;
            s1.Name = "alisha";
            s1.Per = 45;

            Console.WriteLine(s1.print());

            Console.WriteLine($"{s1.Id}, {s1.Name} {s1.Per} ");

            Console.ReadLine();

        }
    }

    //

    public class student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Per { set; get; }
        // //ID Name is property name
        public string print()
        {
            return $"student id:{Id},Student name {Name},student per {Per} ";
        }
       
    }
}
