using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oopfirstclass_program
{
    public class primearray
    {
        static void Main(string[] args)
        {
            //write code to display prime elements from the array
            int[] arr2 = new int[6];
            Console.WriteLine("enter element");
            for (int i=0;i<arr2.Length;i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (int i = 0; i < arr2.Length; i++)
            {

                int cnt = 0;
                for (int j = 2; j < arr2[i];j++)
                {
                   
                    if (arr2[i] %j==0)
                    {
                        cnt++;
                        break;
                        
                    }
                    
                }
                if (cnt == 0)
                {
                    Console.WriteLine(arr2[i]);
                }

            }
            
        }
    }
}
