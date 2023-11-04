using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class ProductGet
    {
        private string name;
        private int price;

       
        public string Name
        {
            

            set {name=value;}
            get { return name; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        public string Print()
        {
            return $"Product name:{name}, Price:{price}";
        }
           
    }
}
