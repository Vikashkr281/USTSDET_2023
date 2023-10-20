using Assignment_3_0ct_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3B_20_Oct
{
    internal class DigitalProduct :ElectronicsProduct
    {
        string? fileformate;

        public DigitalProduct(string? fileformate, int warrantyYear, string? name, double? price, int quantity) :base(warrantyYear,name,price,quantity)
        {
            this.fileformate = fileformate;
        }
        public void DisplayFileformate()
        {
            Console.WriteLine("file formate {0}", fileformate);
        }
   
    }
}
