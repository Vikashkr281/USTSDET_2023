using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseStudy_29_oct
{
    internal class DigitalProduct :Product,IOrderable
    {
        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }
        public static List<DigitalProduct> Products = new List<DigitalProduct>();
        public void DeliverProduct()
        {
            Console.WriteLine("Download link is {0}", DownloadLink);
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Do you want to continue the order\n1.yes\n2.no");
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
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine("payment successful");
            }
        }
    }
}

