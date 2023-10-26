using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class MyExceotion
    {
        public static Dictionary<string, string> exe = new Dictionary<int, string>()
        {
            {"One","Divide By Zero Not Possible" },
            {"Two","IndexOutOfRangeFound" },
            {"Three","Age is Less" },
            {
                "Four","Age Is More"
            }
        };
    
    internal class Num2Exception : Exception
    {
        public Num2Exception(string message):base(message) { }
    }
        internal class Num1Exception : Exception
        {
            public Num1Exception(string message):base(message) { }
        }
}
}
