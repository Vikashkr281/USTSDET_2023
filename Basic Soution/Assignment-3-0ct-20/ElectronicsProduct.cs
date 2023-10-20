using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_0ct_20
{
    public class ElectronicsProduct :ProductClass
    {
        
        public int warrantyYear;

        public ElectronicsProduct(int warrantyYear, string? name, double? price, int quantity) : base(name,  price, quantity)
        {
            this.warrantyYear = warrantyYear;
        }
        public void Display()
        {
            Console.WriteLine("Name = {0}\t Price = {1}\t Quantity = {2}\t WarrantyYear ={3}", name, price, quantity, warrantyYear);
        }
    }
    }

