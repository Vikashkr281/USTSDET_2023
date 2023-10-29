using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_29_oct
{
    internal class Customer
    {
        public string? Name { get; set; }
        public int ContactId {  get; set; }
        public int CustomerId { get; set; }

        public void GetCustomerDetails()
        {
            Console.WriteLine("Name : {0}  Contact : {1}  Customer : {2}  CustomerID {3}",Name,ContactId);
        }


    }
}
