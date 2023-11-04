using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class studentGet
    {
        
        private int rollno;
        private string name;
        private double persentage;

        //RollNo property nmae
        //rollno assign value
     
        public int RollNo
        {
            set { rollno = value; }
            get { return rollno; }
        }
        public  string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Persentage
        {
            get { return persentage; }
            set { persentage = value; }
        }

        public string Print()
        {
            return $"student: {rollno}, {name}, {persentage}";
        }
    }

}


/*Properties in C#


It is special type of method, which is used to assign value to the data member
It has set & get accessors
Set accessor is used to assign the value to the data member
Get accessor is used to retrieve the value from the data member

         */