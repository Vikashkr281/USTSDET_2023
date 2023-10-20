using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_19_0ct
{
    internal class Product
    {
        private string? Name;
        private double productPrice;
        private int productQuantity;

        public Product(string? name, double productPrice, int productQuantity)
        {
            this.Name = name;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
         public void DisplayProduct() 
        {
            Console.WriteLine("Product Name = {0} Product Price = {1} Product Quantity {2}", Name, productPrice, productQuantity);
            Console.WriteLine();
        }
        public void TotalCost()
        {
            Console.WriteLine(" Total price of Product {0 } is   {1}",Name, (productPrice*productQuantity));
        Console.WriteLine();
        }
        
       
    }
  
}
