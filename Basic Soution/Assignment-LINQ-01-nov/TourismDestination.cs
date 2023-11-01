using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_LINQ_01_nov
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country {  get; set; }
        public double Rating { get; set; }

       

    }
}
