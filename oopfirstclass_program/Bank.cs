using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{

    public class Bank
    {
        private int accno;
        private string name;
        private double accbalance;
        // assign the value to the Data member
        public Bank(int accno, string name, double accbalance)
        {
            this.accno = accno;
            this.name = name;
            this.accbalance = accbalance;
        }

        public void Credit(double creditamt)
        {
            accbalance += creditamt;
            //+= is called short hand operator --> OR
            // accbalance = accbalance + creditamt;
        }

        public string Debit(double debitamt)
        {
            string msg = "";
            if (debitamt <= accbalance)
            {
                accbalance = accbalance - debitamt;
                msg = "Done transaction";
            }
            else
            {
                msg = "Insufficient balance";
            }
            return msg;
        }
        public string Print()
        {
            return $"Acc no {accno}, Name= {name}, Balance= {accbalance}";
        }
    }


}
