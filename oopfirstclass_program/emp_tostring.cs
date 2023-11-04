using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class emp_tostring
    {
        static void Main(string[] args)
        {
            Employee2[] emp = new Employee2[3];
            emp[0] = new Employee2(1, "alisha", 768787);
            emp[1] = new Employee2(2, "tanu", 768787);
            emp[2] = new Employee2(3, "prasad", 768787);
            foreach (Employee2 e in emp)
            {
                Console.WriteLine(e);
            }

        }
    }
    //
    public class Employee2
    {
        int id;
        string name;
        int salary;
        
        public Employee2(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public  override string  ToString()
        {
            return $"id { id} , name is: {name} salary is: {salary}";
        }
    }
}
