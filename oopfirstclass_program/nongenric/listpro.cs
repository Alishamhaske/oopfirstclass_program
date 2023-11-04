using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.nongenric
{
    internal class listpro
    {
        static void Main(string[] args)
        {
            //list
            List<int> list1 = new List<int>(){ 12,23};
             list1.Add(66);
             list1.Add(67);
             list1.Add(61);
             list1.Add(63);
             list1.Add(62);
            list1.Remove(62);
           // list1.AddRange(list1);
            list1.Insert(2, 55);
          
            Console.WriteLine("list elements is :");
            foreach (int n1 in list1)
            {
                Console.WriteLine(n1);
            }
            Console.WriteLine("index of 63 is :" + list1.IndexOf(63));
            Console.WriteLine("last index of 63 is :"+list1.LastIndexOf(63));
            Console.WriteLine("  ");
            //stack=lifo
            Stack<int> st1 = new Stack<int>();
            Stack<string> st2 = new Stack<string>();
          
            st1.Push(56);
            st1.Push(86);
            st1.Push(76);
       
            st1.Push(66);
            st1.Pop();
            //st1.Peek();


            Console.WriteLine("stack elements is :");

            foreach (object n2 in st1)
            {
                Console.WriteLine(n2);
            }
            Console.WriteLine("count of stack elements:" + st1.Count);

            ///queue
            /// fifo
            /// 
            Console.WriteLine("  ");
            Queue<string> q1 = new Queue<string>();
            q1.Enqueue("alisha");
            q1.Enqueue("tanu");
            q1.Enqueue("tanuja");
            q1.Enqueue("tane");
            q1.Enqueue("tani");
            q1.Dequeue();
       

            Console.WriteLine("queue elements:");

            foreach (string n3 in q1)
            {
                Console.WriteLine(n3);
            }
            Console.WriteLine("count of queue elements:" + q1.Count);
            Console.WriteLine("  ");

            // List<Product> p1 = new List<Product>();

            //dictionary
            Console.WriteLine(" ");
            Console.WriteLine("dictionary ");
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(91, "india");
            d1.Add(92, "china");
            d1.Add(93, "japan");
            d1.Add(94, "US");
            d1.Add(95, "pakistan");
            d1.Add(96, "nepal");
            d1.Add(97, "china");



            foreach (KeyValuePair<int,string> n4 in d1)
            {
                Console.WriteLine($"country code is: {n4.Key} country name is: {n4.Value}");
           
            }
            Console.WriteLine("value of 94 code :" + d1[94]);

        }
    }
}
