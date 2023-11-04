using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class Product
    {
        private int id;
        private float price;
        private string name;

        public Product()
        {
            id = 0;
            price = 0;
            name = "";
            
        }

        public Product(int id,float price,string name)
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }

        public  string Discount(int dis_per)
        {
            price = price - ((price / 100) * dis_per);
            return $"Prooduct id:{id}\n Price:{price}\n Name:{name}";
        }

       
    }
}
