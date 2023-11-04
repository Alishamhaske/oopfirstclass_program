using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arrayfobject
{

    public class product1
    {
        public static void Main(string[] args)
        {
            product[] p = new product[5];
            p[0] = new product(1, "mobile", 87537);
            p[1] = new product(2, "mobile", 87537);
            p[2] = new product(3, "mobile", 87537);
            p[3] = new product(4, "mobile", 87537);
            p[4] = new product(5, "mobile", 87537);



            foreach (var item in p)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

    }


    public class product
    {
        public int id;
        public string name;
        public double price;

        public product(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{id} ,{name} ,{price}";


        }

    }


}
