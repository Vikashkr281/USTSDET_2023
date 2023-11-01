using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_LINQ_01_nov
{
    internal class Sorting
    {
        public List<TourismDestination> Tours = new List<TourismDestination>();

        public void AddDetails()
        {
            Tours.Add(new TourismDestination("vikash", "India", 3.5));
            Tours.Add(new TourismDestination("Vysnav", "canada", 4.5));
            Tours.Add(new TourismDestination("Armoal", "japan", 5));

        }
        public void Dispaly()
        {
            var descendingorder = Tours.OrderByDescending(x => x.Rating);
            Console.WriteLine("Data sorted in Descending order");

            foreach (var t in descendingorder)
            {
                Console.WriteLine("Name = {0}  Country = {1}  Rating = {2}", t.Name, t.Country, t.Rating);
            }
        }
    }
}
