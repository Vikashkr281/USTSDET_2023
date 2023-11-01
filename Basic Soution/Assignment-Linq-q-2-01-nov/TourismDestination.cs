using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Linq_q_2_01_nov
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double rating, double pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public double Rating { get; set; }
        public double PricePerNight {  get; set; }
    }
}
