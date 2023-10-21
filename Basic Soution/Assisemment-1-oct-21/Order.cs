using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisemment_1_oct_21
{
    internal class Order 
    {
        public Order(string? name, string? date)
        {
            Name = name;
            Date = date;
        }

        public string? Name { get; set; }
        public string? Date { get; set; }

        public void DisplayOrder()
        {
            if (Date == null) 
            {
                Console.WriteLine("No order Placed");
            }
            else
            {
                Console.WriteLine("Name={0}\t Date{1}",Name,Date);
            }
        }

       

        

    }
}
