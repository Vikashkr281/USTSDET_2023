using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_Collection
{
    internal class HashTable
    {
        public void HThandling()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1,10);
            ht.Add(2,20);
            ht.Add(3,30);
            ht.Add("3", "vikas");

            foreach (var item in  ht) 
            {
                Console.WriteLine(item);
            }
        }
        public void SortedListHandling()
        {
            SortedList s1= new SortedList();
            s1.Add(1,10);
            s1.Add(4,20);
            s1.Add(2,30);
            s1.Add(3, "AA");
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
