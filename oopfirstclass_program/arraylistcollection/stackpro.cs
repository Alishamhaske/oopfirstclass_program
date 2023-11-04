using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.arraylistcollection
{
    public class stackpro
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push(10);
            s1.Push(20);
            s1.Push(30);
            s1.Push(40); 
           
            s1.Pop();// remove the top element
            //Peek()-- returns the top element in the stack
            Console.WriteLine("peek element is: "+s1.Peek());


            foreach (int item in s1)
            {
                Console.WriteLine(item);
            }
        }
    
        
        

    }
}
