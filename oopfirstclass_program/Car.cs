using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program
{
    public class Car
    {
        private int car_num, car_price;
        private string car_name;


        public void CarAccpect(int c_num,int c_price,string c_name)
        {
            car_num = c_num;
            car_price = c_price;
            car_name = c_name;

        }

        public string CarPrint()
        {
            return $"car_num: {car_num} car_price: {car_price} car_name:{ car_name}";
        }
    }
}
