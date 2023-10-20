using Assignment_3_0ct_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3B_20_Oct
{
    internal class ClothingProduct : ProductClass
    {
        string? size;

        public ClothingProduct(string? size, string? name, double? price, int quantity) : base(name, price, quantity)         {
            this.size = size;
        }
        public void DisplayClothingProduct()
        {
            Console.WriteLine(" Size is {0}", size);
        }
    }
}
