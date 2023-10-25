using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_Collection
{
    internal class NGC
    {
        public void ArrayListHandling()
        {
            ArrayList array = new ArrayList();
            array.Add(10);
            array.Add(20);
            array.Add(30);
            foreach (int i in array)
            Console.WriteLine(i);
        }
    }
}
