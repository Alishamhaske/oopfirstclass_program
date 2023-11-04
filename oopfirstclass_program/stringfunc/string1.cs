using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.stringfunc
{
    public class string1
    {
        static void Main(string[] args)
        {
            string str1 = "    hello    world    ";
            string str2 = "Good morning everyone ";
            string str3 = "";
            // concat,Trim,TrimStart,TrimEnd,IndexOf,LastIndexOf ,ToUpper , ToLowercw

            Console.WriteLine("first string is : "+str1);
            Console.WriteLine("second string: " +str2);

            //concat
            string msg1 = string.Concat(str1, " ",str2);
            Console.WriteLine("concate function: "+msg1);

            //trim

            
            Console.WriteLine("\n\nspace remove using trim function");
            Console.WriteLine("without trim string is:" +str1);
            Console.WriteLine("str1 use  trim fun : " + str1.Trim());
            Console.WriteLine("str1 use  TrimEnd  fun : " + str1.TrimEnd());
            Console.WriteLine("str1 use  TrimStart  fun : " + str1.TrimStart());
          

            //indexof
            Console.WriteLine("\n\n indexof function");
            Console.WriteLine("find indexof character: " +str1.IndexOf('o'));
            Console.WriteLine("find Lastindexof n   character is : " + str2.LastIndexOf('n'));

            //touppear
            Console.WriteLine("\n\n uppear lower function");
            Console.WriteLine("str2 use uppear fun:  "+str2.ToUpper());
            Console.WriteLine("str2 use lower fun:  " + str2.ToLower());
            Console.WriteLine("lenght is str2 is :"+str2.Length);

            //nullfun
            Console.WriteLine("\n\n null fuction");

            Console.WriteLine("check the string is empty:  ");
            if(string.IsNullOrEmpty(str3))
            {
                Console.WriteLine("string is empty");
            }

            //
            Console.WriteLine("enetr a string: ");
            string name = Convert.ToString(Console.ReadLine());
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("name is requird");
            }
            else
            {
                Console.WriteLine("hello "+name);
            }



            //split function
            string[] arr = str2.Split(' ');
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            //get element by index
            Console.WriteLine(str2[7]);

            //eqquals=
            Console.WriteLine(str1.Equals(str2));

            //compareto
            Console.WriteLine(str1.CompareTo(str2));

            //another way to declare string
            string s = new string('k', 20);
            Console.WriteLine(s);

            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("Joined string: " + joinedString);

        }
    }
}
