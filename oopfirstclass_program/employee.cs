using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class employee
    {
        private int emp_id;
        private string emp_name, emp_dept;
        private double emp_salary,hra,da,ta,pf,gross;
        private static int count;


        
        public employee()//parameter less
        {
            count++;
            this.emp_id = count;
            this.emp_name ="tanu";
            this.emp_dept = "gygjk";
            this.emp_salary = 4556;
        }
        public static int getcount()
        {
            return count;

        }
        //construct parametrized
        public  employee(string emp_name, 
            string emp_dept,double emp_salary)
        {
            count++;
            this.emp_id = count;
            this.emp_name = emp_name;
            this.emp_dept = emp_dept;
            this.emp_salary = emp_salary;
            
        }
        public void Calculatesalary()
        {
            hra = emp_salary * 0.40;
            da = emp_salary * 0.20;
            ta = emp_salary * 0.10;
            pf = emp_salary * 0.12;
            gross = (emp_salary + hra + da + ta) - pf;

        }
        public string empprint()
        {
            return $"emp_id: {emp_id} emp_name: {emp_name}" +
                $" emp_dept: {emp_dept} emp_salary: {emp_salary} Gross_salary:{gross} ";
        }

    }
}
