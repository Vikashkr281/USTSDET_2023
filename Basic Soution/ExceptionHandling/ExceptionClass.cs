using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ExceptionClass
    {
        public ExceptionClass(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int num1 {  get; set; }
        public int num2 { get; set; }

        public void Divide()
        {
            int[] num = {10,20,30};
                int res = num1 / num2;
                Console.WriteLine(res);
 
            
        }
        public void NumCheck()
        {
            if(num1>=100)
            {
                Console.WriteLine("Congraz");
            }
            else
            {
                throw new Num1
            }
        }

    }
}
