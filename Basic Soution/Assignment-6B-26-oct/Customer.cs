using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6B_26_oct
{
    internal class Customer
    {   
        public static List<Customer>list=new List<Customer>();
        public int Id { get; set; }
        public long PhoneNUMBER { get; set; }
        public double CallDuration { get; set; }

        public void DisplayCallRecord(long phoneNumber)
        {
            var num=list.FindAll(x => x.PhoneNUMBER == phoneNumber);
            Console.WriteLine("Call details of the number  {0} is", phoneNumber);
            foreach (var item in num)
            {
                Console.WriteLine(" ID = {0}  PhoneNumber = {1}  CallDuration = {2} ", item.Id, item.PhoneNUMBER, item.CallDuration);
            }
        }

        public void DisplayCount()
        {
            Dictionary<long,int> count=new Dictionary<long,int>();

            foreach (var item in list)
            {
                if(count.ContainsKey(item.PhoneNUMBER)) count[item.PhoneNUMBER]++;

                else count[item.PhoneNUMBER] = 1;
            }
            foreach (var item in count) 
            Console.WriteLine("Count for {0} :{1}", item.Key, item.Value);
        }

    }
}
