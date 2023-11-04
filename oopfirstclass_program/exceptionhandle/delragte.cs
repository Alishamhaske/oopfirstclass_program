using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oopfirstclass_program.exceptionhandle.User;



namespace oopfirstclass_program.exceptionhandle
{
    /*Create a class User, create a method with name AccpetName(string name), convert the name in
     * upper case & return.
      Create the delegate to hold AcceptName method reference & invoke using delegate*/
    internal class delragte
    {
        static void Main(string[] args)
        {
            User u = new User();
            Mydelegate md = new Mydelegate(u.AcceptName);
            md += new Mydelegate(u.StringTolower);
            md += new Mydelegate(u.StringToupper);

            Delegate[] list = md.GetInvocationList();

            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                string result = Convert.ToString(d.DynamicInvoke("Hello All"));
                Console.WriteLine(result);

            }
        }
    }

    public class User
    {
        public delegate string Mydelegate(string s);
        public string AcceptName(string name)
        {
            return name;

        }
        public string StringToupper(string name)
        {
            return name.ToUpper();

        }
        public string StringTolower(string name)
        {
            return name.ToLower();

        }
    }
}