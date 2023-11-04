using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
           




            

            calculation calobj = new calculation();
            Console.WriteLine(calobj.addtion(3,5));
            Console.WriteLine(calobj.addtion(7,8,9));
            Console.WriteLine(calobj.addtion(5,76.8));
            Console.WriteLine(calobj.addtion(58.9, 76.8));

            


            /*

            Console.WriteLine("prime program");
            prime p = new prime();
            bool ischeck = p.IsPrimeCheck(8);
            if (ischeck)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            */


            /*
            

       
            //moive ticket
                 Console.WriteLine();
            Console.WriteLine("movie");
            moive moiveobj = new moive(2, "pathan",200,30);
            
            moiveobj.caltic();
            Console.WriteLine(moiveobj.Display());

            */








            /*


            Console.WriteLine();
            Console.WriteLine("get set accessor ");
            studentGet stud = new studentGet();//property intializer
            stud.RollNo = 1;
            stud.Name = "tanu";



            stud.Persentage = 99;
           
            //get access
        
           Console.WriteLine(stud.Print());

            //object initiazier
            studentGet stud2 = new studentGet() { RollNo = 2, Name = "prasad", Persentage = 88 };
            Console.WriteLine($"{stud2.RollNo} {stud2.Name} {stud2.Persentage}");


            */


            /*
            //Product get
            Console.WriteLine("  ");
            Console.WriteLine("product class using get set");
            ProductGet prodget = new ProductGet();
            prodget.Name = "mobile";
            prodget.Price = 6556;

            Console.WriteLine(prodget.Print());

            */



            /*
            Console.WriteLine();
            //date class
            date dateobj1 = new date();
           
            Console.WriteLine("date class ");
           
            dateobj1.Acceptdate(5, "aug", 2023);
            string res=dateobj1.print();
            Console.WriteLine(res);
            Console.WriteLine(" ");

            /*

            /*

            //student class
            Console.WriteLine("student class ");
            student stdobj = new student();  //pass deafult para
            stdobj.MarkCal();
           // string std_res = stdobj.stdprint();
            Console.WriteLine(stdobj.stdprint());
            stdobj.grade();

            //second object create 
            //pass parameter
            student stdobj3 = new student(4, 23, "alisha", "comp", 90, 60, 60);
            stdobj3.MarkCal();
            Console.WriteLine(stdobj3.stdprint());
            stdobj3.grade();
            Console.WriteLine(" ");

            */


            /*
            //employee class
            Console.WriteLine("employee class ");
            employee empobj = new employee();  //default para
            employee empobj2 = new employee( "pashya", "hgdsj", 676767);
            employee empobj3 = new employee("prasad", "hghhj", 6766367);
            empobj.Calculatesalary();
            Console.WriteLine(empobj.empprint());
            empobj2.Calculatesalary();
            Console.WriteLine(empobj2.empprint());
            empobj3.Calculatesalary();
            Console.WriteLine(empobj3.empprint());
            Console.WriteLine(" ");

            //static method call using class name
            Console.WriteLine("count vaule" + employee.getcount());

            */


            /*

            Console.WriteLine(" ");
            //book class
            Console.WriteLine("book class ");
            book bookobj = new book();
            bookobj.book_accpect(23, 657, "python", "tanu gaygoye");
            string book_res = bookobj.printbook();
            Console.WriteLine(book_res);
            Console.WriteLine(" ");

            //
            Console.WriteLine("car class ");
            Car carobj = new Car();
            carobj.CarAccpect(5569, 675677, "mercdes");
            string car_res = carobj.CarPrint();
            Console.WriteLine(car_res);
            Console.WriteLine(" ");

            */


            /*
            //account details
            Console.WriteLine("account class ");
            account Accobj = new account();
            Accobj.AccAccpect(234324, "saving ", 547);
            Console.WriteLine(Accobj.AccShow());
            Accobj.withdraw();
            Accobj.Deposite();
            */




            /*
            //bank class
            Console.WriteLine("Enter the default balance");
            double bal = Convert.ToDouble(Console.ReadLine());
            Bank b1 = new Bank(101, "kiran", bal);
            Console.WriteLine(b1.Print());
            b1.Credit(2300.50);

            Console.WriteLine(b1.Print());

            string msg = b1.Debit(345);
            Console.WriteLine(msg);
            Console.WriteLine(b1.Print());

            */


            /*
            //product class
            Product p = new Product();
            Product p1 = new Product(1, 34, "mobile");
            Product p2 = new Product(3, 65, "mouse");

            Console.WriteLine(p1.Discount(34));
            Console.WriteLine(p2.Discount(60));
           
            */
        }
    }
}
