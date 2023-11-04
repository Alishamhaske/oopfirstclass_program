using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    internal class account
    {
        private int acc_no;
        private string acc_type;
        private double acc_balance;


        public void AccAccpect(int acc_no,string acc_type,double acc_balance)
        {
            this.acc_no = acc_no;
            this.acc_type = acc_type;
            this.acc_balance = acc_balance;
        }
        public string AccShow()
        {
            return $"acc_no: {acc_no} ,acc_type: {acc_type},acc_balance:{acc_balance}";
        }

        public void withdraw()
        {
            Console.WriteLine("enter a withdraw amount:");
            int with_amt = Convert.ToInt32(Console.ReadLine());
            if(with_amt<acc_balance)
            {
                 acc_balance = acc_balance - with_amt;
                Console.WriteLine(" current balance is: " +acc_balance);

            }
            else
            {
                Console.WriteLine("not enough balance");
            }

        }

        public void Deposite()
        {
            Console.WriteLine("enter a deposit amount:");
            int dep_amt = Convert.ToInt32(Console.ReadLine());
            if (dep_amt >0)
            {
                acc_balance = acc_balance +dep_amt;
                Console.WriteLine(" current balance is: " + acc_balance);

            }
            else
            {
                Console.WriteLine("not enough balance");
            }

        }

    }
}
