using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisemment_1_oct_21
{
    internal class Customer
    {
        public Customer(string customer_Name, string contact_Details, int customer_ID)
        {
            Customer_Name = customer_Name;
            Contact_Details = contact_Details;
            Customer_ID = customer_ID;
        }

        public string Customer_Name {  get; set; }
        public string Contact_Details {  get; set; }
         
        public int Customer_ID { get; set; }

        public void CustomerDetails()
        {
            Console.WriteLine("Customer Name ={0}\t Contact_Details ={1}");
        }
        

    }
}
