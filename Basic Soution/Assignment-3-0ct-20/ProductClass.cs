using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_0ct_20
{
    public class ProductClass
    {
        public String? name;
        public double? price;
        public int quantity;

        public ProductClass(string? name, double? price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Name = {0}\t Price = {1}\t Quantity = {2}",name,price,quantity);
        }
    }
}
