using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class ListExample
    {
        List<int > l=new List<int>();
        List<string> s=new List<string>();
        public void DisplayData()
        {
            l.Add(0);
            l.Add(1);
                
        l.Add(2);
            l.Add(3);
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }
        }
        public void StringExample()
        {
            s.Add("vikash");
            s.Add("Kumar");
            s.Add("Mishra");
            s.Sort();
            
 
              for(int i = 0; i < s.Count; i++)
            {
                for(int j=0; j < s.Count; j++) 
                Console.WriteLine(s[i][j]);
            }
            
        }
    }
}
