using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    internal class ArrayExample
    {
        int[] number = new int[5];
        int[,] number2 = new int[2,2];

        public void oneDimension() 
        {
            Console.WriteLine("enter five number");
            for(int i = 0; i < 5; i++) 
            {    
                number[i] =Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("number store in array");
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }

            Array.Sort(number);
            Console.WriteLine("After sorting the result is");
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
        }
        public void twoDimension()
        {
            number2[0, 0] = 100;
            number2[0, 1] = 200;
            number2[1, 0] = 300;
            number2[1, 1] = 500;

            int[,] a = new int[4, 4] {
   {0, 1, 2, 3} ,
   {4, 5, 6, 7} ,
   {8, 9, 10, 11} ,
   {12, 13, 14, 15}
};
            foreach (int i in number2)
            {
                Console.WriteLine(i);
            }


        }

        public void threeDimension() 
        {
            int[][,]number = {
                new int[ ,]{ { 1, 2 } , { 3, 4 } },
                new int[ ,]{ { 4, 5, },{4,6 }, { 8,10} },
cc
                 


                }
        }
    }
}
