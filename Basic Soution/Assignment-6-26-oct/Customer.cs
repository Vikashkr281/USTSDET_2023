using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_26_oct
{
    internal class Customer
    {
        public static List<Customer> list = new List<Customer>();
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }


        public void SearchByPhone(long phoneNumber)
        {
            var Num = list.Find(x => x.PhoneNumber == phoneNumber);
            if (Num != null)
            {
                Console.WriteLine("Customer Belong to this phone number {0} is = ", phoneNumber);
                Console.WriteLine("Customer Id= {0} \n Customer Name= {1} \n Customer Balance {2} \n Customer Phone ={3}", Num.Id, Num.Name, Num.Balance, Num.PhoneNumber);
            }
            else { Console.WriteLine("Customer Details not Available "); }
        }

        public void Display()
        {

             Console.WriteLine("Customer Data store in List is \n");
            foreach (var item in list)
            {
                Console.WriteLine("Customer Id = {0}\t Customer Name = {1}   Customer Balance {2}\t Customer Phone = {3}", item.Id, item.Name, item.Balance, item.PhoneNumber);
            }

        }
    }
}
