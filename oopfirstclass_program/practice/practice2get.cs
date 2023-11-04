using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.practice
{
    //get set
    public class practice2get
    {
        static void Main(string[] args)
        {
            student stu1 = new student();
            
            Console.WriteLine(stu1.Id = 3);
            Console.WriteLine(stu1.Name = "alisha");

        }
    }

    //
    class student
    {
        int id;
        string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }


}
