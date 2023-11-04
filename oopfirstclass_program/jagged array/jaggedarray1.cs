using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.jagged_array
{
    public class jaggedarray1
    {
        static void Main(string[] args)
        {
            int[][] arr2 = new int[4][];

            arr2[0] =new int []{ 1,2,3,5,8};
            arr2[1] = new int[] { 2, 3, 7, 5 };
            arr2[2] = new int[] { 7, 9, 7 };
            arr2[3] = new int[] { 2, 9 };
     
            
            for(int row=0;row<arr2.Length;row++)
            {
                for(int col = 0; col < arr2[row].Length;col++)
                {
                    Console.Write(arr2[row][col]+" ");
                }
                Console.WriteLine("\n");
            }



        }
    }
}
