using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.jagged_array
{
    public class employee
    {
        //list and properties
        static void Main(string[] args)
        {
            emp[] list1 = new emp[5]
            {
                new emp{id=1,name="alisha",salary=9988 },
                new emp{id=2,name="tanu",salary=6588 },
                new emp {id=3,name="tanuja",salary=76878},
                new emp {id=4,name="prasad",salary=76878},
                new emp {id=5,name="payal",salary=76878}
            };
           

            foreach (emp e in list1)
            {
                Console.WriteLine($"emp_id:{e.id} emp_name= {e.name} emp_salary={e.salary}");
            }
            
       
            
        }
 
    }

    ///s
    class emp
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

    }
}
