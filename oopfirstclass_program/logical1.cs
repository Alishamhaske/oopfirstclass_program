using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class logical1
    {
        static void Main(string[] args)
        {
        
            // alphbabetically sorted consecutive  aplhabetical order 
            string str = "accent";
            str.ToLower();
           
            char[] ch = str.ToCharArray();
           // char temp;
           
           
                bool isconsecutive = true;
            for (int i = 0; i < ch.Length; i++)
            {
                for(int j=i+1;j<ch.Length;j++)
                {
                    if (ch[i] > ch[j])
                    {
                        isconsecutive = false;
                        break;
                    }
                }
        
            }
            if (isconsecutive == true)
            {
                Console.WriteLine("Consective string: "+str);
            }
            else
            {
                Console.WriteLine("not consecutive");
            }




            Console.ReadLine();

        }
    }
}
