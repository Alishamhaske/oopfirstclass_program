using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.jagged_array
{
    public class bookpro
    {
        static void Main(string[] args)
        {
            book[] list2 = new book[4]
            {
                new book{b_id=121,b_name="python",b_price=778},
                new book{b_id=122,b_name="oop",b_price=888 },
                new book{b_id=123,b_name="java",b_price=500 },
                new book{b_id=124,b_name="c sharp",b_price=212 }

            };

            foreach(book b in list2)
            {
                Console.WriteLine($"{b.b_id} , {b.b_name}  ,{b.b_price} ");
            }
        }
    }

    //
    class book
    {
        public int b_id { get; set; }
        public string b_name { get; set; }
        public int b_price { get; set; }


    }
}
