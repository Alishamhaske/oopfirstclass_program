using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.practice
{
    //simple constructor
    public class practice1
    {
        static void Main(string[] args)
        {
            prac1 p1 = new prac1(1, "tanu");
            p1.show();

        }
    }


    //
    class prac1
    {
        int id;
        string name;

        public prac1(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public  void show()
        {
            Console.WriteLine(id+" "+name);
        }
    }
}
