using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseStudy_29_oct
{
    internal class PhysicalProduct: Product, IOrderable
    {
        public double Weight { get; set; }
        public string? Dimension { get; set; }
        public static List<PhysicalProduct> Products = new List<PhysicalProduct>();
        public void DeliverProduct()
        {
            Console.WriteLine(Name + " is shipped and shipping cost is {0}", Weight * 10);
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Do you want to continue the order\n1.Yes\n2.No");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (StockQuantity > 0)
                    Console.WriteLine("Continue to payment");
                else
                    Console.WriteLine("product not available");
            }
            else
            {
                Console.WriteLine("reverting");
            }
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Enter the card details for product {0}", Name);
            string? credit = Console.ReadLine();
            if (credit == null)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine("Payment Successful");
            }
        }
    }
}
   
