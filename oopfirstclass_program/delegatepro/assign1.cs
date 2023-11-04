using oopfirstclass_program.exceptionhandle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.delegatepro
{
    public class assign1
    {
        static void Main(string[] args)
        {
            try
            {
                bank b1 = new bank();
            
                Message msg1 = new Message();
                b1.credit += new MyDelegate(msg1.FailMessage);
                b1.InsufficientBalance += new MyDelegate(msg1.SuccessMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    //
    public delegate void MyDelegate();
    public class bank
    {
        public event MyDelegate  credit;
        public event MyDelegate InsufficientBalance;

        int bal;
        public void debit(int d_amt)
        {
            if(bal>=d_amt)
            {
                credit();
            }
            else
            {
                InsufficientBalance();
            }
        }
    }

    public class Message
    {
        public void SuccessMessage()
        {
            Console.WriteLine("sucfully transaction");
        }
        public void FailMessage()
        {
            Console.WriteLine("not suffient balance:  ");
        }
    }
}
