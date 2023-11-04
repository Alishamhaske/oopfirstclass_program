using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class student
    {
        private int std_id, roll_no;
        private string name, branch;
        private double persen,total, math,eng,marathi;

        public student()
        {
            this.std_id = 55;
            this.roll_no = 2;
            this.name = "hgsd";
            this.branch = "jhgda";

            this.math = 68;
            this.eng = 98;
            this.marathi = 99;
        }
        public student(int std_id, int roll_no, string name, string branch, double math,double  eng, double marathi)
        {
            this.std_id = std_id;
            this.roll_no = roll_no;
            this.name = name;
            this.branch = branch;
           
            this.math = math;
            this.eng = eng;
            this.marathi = marathi;
        }
        public void MarkCal()
        {
            total = math + eng + marathi;
            persen = (total / 3);
        }
        public void grade()
        {
            
            if(persen>80)
            {
                Console.WriteLine("grade A");
            }
            else if(persen>60)
            {
                Console.WriteLine("grade B");
            }
            else if(persen>40)
            {
                Console.WriteLine("grade C");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
        public string stdprint()
        {
            return $"stud_id: {std_id} stud_roll: {roll_no} stud_name: {name} stud_branch: {branch} total marks: {total} stud_persentage: {persen}";

        }

    }
}
