using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.queuepro
{
    internal class queue1
    {
        static void Main(string[] args)
        {
            //queue opeartion 
            Queue q1 = new Queue();
            q1.Enqueue(12);
            q1.Enqueue(13);
            q1.Enqueue(14);
            q1.Enqueue(15);
            Console.WriteLine("dequeue opertaion :"+q1.Dequeue());
            Console.WriteLine("peek operatio  is: "+q1.Peek());

            foreach (int n in q1)
            {
                Console.WriteLine(n);
            }
        }
    }
}
