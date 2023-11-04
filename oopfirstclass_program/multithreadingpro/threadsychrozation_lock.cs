using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oopfirstclass_program.multithreadingpro
{
    public class threadsychrozation_lock
    {

        
            public void first()
            {
                lock (this)
                {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
                }
            }
        
       
    }
    //
    public class program
    {
        static void Main(string[] args)
        {
            threadprogram fst = new threadprogram();
            Thread t1 = new Thread(new ThreadStart(fst.first));
            Thread t2 = new Thread(new ThreadStart(fst.first));

            t1.Start();
            t2.Start();
        }
    }
}
