using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.arraylistcollection
{
    public class arraylist1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 44, 23, 2, 26 };
            ArrayList list1 = new ArrayList();
            list1.Add(10);
            list1.Add(12);
            list1.Add(11);
            list1.Add(1);
            list1.Add(17);
           

            list1.Insert(1, 20);
            list1.Remove(20);
            list1.Remove(1);
            //list1.RemoveRange(1, 1); //removrange(index, num of elememt)
            list1.Sort();
            //list1.Reverse();
            Console.WriteLine("Count (total element) " + list1.Count);
            Console.WriteLine("Capacity " + list1.Capacity);


            //list1.Clear();



            foreach (int a in list1)
            {
                Console.WriteLine(a);
            }

        }
    }
}
