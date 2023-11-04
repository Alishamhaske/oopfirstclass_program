using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class moive
    {
        private int mid;
        private string m_name;
        private int tprice;
        private int numofticket = 20;
        private int avaibleticket;
        private string type;
        private int userticket;
        private int totalcost;
      



        public moive(int mid, string m_name,int tprice,int numofticket)
        {
            this.mid = mid;
            this.m_name = m_name;
            this.tprice = tprice;
            this.numofticket = numofticket;
     
        }
        
        public void caltic()
            {
            Console.WriteLine("how many ticket you want: ");
             userticket = Convert.ToInt32(Console.ReadLine());
            if(userticket<=numofticket)
            {
                avaibleticket = numofticket - userticket;
                Console.WriteLine("avaible ticket is:" + avaibleticket);
                this.pricetic();
              
            }
            else
            {
                Console.WriteLine("no avaible ticket");
            }
           

        }

        public void pricetic()
        {
            Console.WriteLine("which ticket you want:");
            Console.WriteLine("1.sliver =100 rs");
            Console.WriteLine("2.gold=200 rs");
            Console.WriteLine("3.platinum=300 rs");
          
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    type = "sliver";
                    tprice = 100;
                    break;
                case 2:
                    type = "Glod";
                    tprice = 200;
                     
                    break;
                case 3:
                    type = "platium";
                    tprice = 300;
                    break;

            }
            totalcost = numofticket * tprice;
            Console.WriteLine("total cost is:"+totalcost);


        }

        public string Display()
        {
            return $"moive id:{mid} moive name:{m_name} Price:{tprice}" +
                $" Number of ticket:{numofticket} Total cost:{totalcost} ";
        }



    }
}
