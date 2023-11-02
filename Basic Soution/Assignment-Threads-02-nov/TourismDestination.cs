using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Threads_02_nov
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double? rate)
        {
            Name = name;
            Country = country;
            Rate = rate;
        }

        public string? Name { get; set; }
        public string? Country {  get; set; }
        public double? Rate { get; set; }
    }
}
