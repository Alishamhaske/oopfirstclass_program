using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
   public class date
    {
       private int day,  year;
        private string month;
         
        public void Acceptdate(int dd, string mm,int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        }

        public string print()
        {
            return $"day:month:year = {day}/ {month} /{year} ";
          
        }


    }
}
