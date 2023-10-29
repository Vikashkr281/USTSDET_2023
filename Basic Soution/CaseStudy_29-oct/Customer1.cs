using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_29_oct
{
    internal class Customer1
    {
            public int CustomerID { get; set; }
            public string? CustomerName { get; set; }
            public string? Email { get; set; }
            public List<DigitalProduct> orders = new List<DigitalProduct>();
            public List<PhysicalProduct> ordersphy = new List<PhysicalProduct>();
            public List<DigitalProduct> confirmedorders = new List<DigitalProduct>();
            public List<PhysicalProduct> confirmedordersphy = new List<PhysicalProduct>();
            public static List<Customer1> customers = new List<Customer1>();
        }
}
