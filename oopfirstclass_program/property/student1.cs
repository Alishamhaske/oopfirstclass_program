using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.property
{
    public class student1
    {


        static void Main(string[] args)
        {
            stud s2 = new stud();
        
            // Property initializer syntax

            s2.ID = 1; //ID Name is property name
            s2.Name = "alisha";
            s2.Per = 77;
         

            //get accessor
            Console.WriteLine($"{s2.ID}  ,{s2.Name} , {s2.Per}");
            Console.WriteLine(s2.print());


            // object initiazlier syntax

/*
            stud stud2 = new stud() { ID = 2, Name = "Kishor", Per = 89.66 };
            Console.WriteLine($"{stud2.ID} {stud2.Name} {stud2.Per}");
*/


            Console.ReadLine();
        }

    }



    //

    public class stud
    {
        public int id;
        public string name;
        public double per;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Per
        {
            set { per = value; }
            get { return per; }
        }

        public string print()
        {
            return $"student id: {id} student name:{name} student persentage:{per} ";
        }



    }
}
