using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.abstractprogram

{
    public class Areacircelpro
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(8);
            Console.WriteLine(c1.display());
            c1.Area();
            Console.WriteLine(c1.Draw("circle shape:"));
            Console.WriteLine(c1.Print());
        }
    }


    ///

    public abstract class shape
    {
        public abstract string Draw(string name);
        public abstract void Area();
        public string display()
        {
            return "this class shape:";
        }

    }
    //
    public class Circle : shape
    {
        private const double pi = 3.14;
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }

        public override void Area()
        {
            area = pi * r * r;
        }

        public override string Draw(string name)
        {
            return name;
        }

        public string Print()
        {
            return $"area of circle:{area}";
        }
    }
}
