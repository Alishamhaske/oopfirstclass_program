using oopfirstclass_program.queuepro;
using oopfirstclass_program.stringassignement;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace oopfirstclass_program.multithreadingpro
{
    public class threaddemo
    {
        static void Main(string[] args)
        {
            threadprogram fst = new threadprogram();
            /*fst.first();
            fst.second();*/

            Thread t1 = new Thread(new ThreadStart(fst.first));
            Thread t2 = new Thread(new ThreadStart(fst.second));

            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.AboveNormal;
            t1.Start();
            /*join= all the threads which are in queue will remain in the wait state , 
                till the current thread completes its execution*/


           /* Join(duration)   → Join(3000) → all the threads which are in queue 
                goes into the wait state till the time specified in the Join()*/

            //t1.Join();
            t1.Join(1000);
            t2.Start();
            Console.ReadLine();
        }

    }
    ///
    public class threadprogram
    {
        public void first()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        

        }
        public void second()
        {
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);

            }
            Console.ReadLine();
        }
       

    }
}
