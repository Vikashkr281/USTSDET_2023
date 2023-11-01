using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Linq_q_2_01_nov
{
    internal class InputOutput
    {

        public List<TourismDestination> Tours = new List<TourismDestination>();

        public void AddDetails()
        {
            Tours.Add(new TourismDestination("vikash", "India", 3.5,4000));
            Tours.Add(new TourismDestination("Vysnav", "canada", 4.5,8000));
            Tours.Add(new TourismDestination("Armoal", "japan", 5,2000));

        }
        public void Dispaly()
        {
            var ascendingorder = Tours.OrderBy(x => x.PricePerNight);
            Console.WriteLine("Data sorted in Asscending order based on price");

            foreach (var t in ascendingorder)
            {
                Console.WriteLine("Name = {0}  Country = {1}  Rating = {2}  Price = {3}", t.Name, t.Country, t.Rating,t.PricePerNight);
            }

            Console.WriteLine("\n Rating above 3 is ");
            var rating = Tours.FindAll(x => x.Rating > 3);
            foreach (var t in rating)
            {
                Console.WriteLine("Name = {0}  Country = {1}  Rating = {2}  Price = {3}", t.Name, t.Country, t.Rating, t.PricePerNight);
            }

            Console.WriteLine("\n Hotel located in india \n");
            var loc = Tours.FindAll(x => x.Country == "India");
            foreach(var t in loc)
            {
                Console.WriteLine("Name = {0}  Country = {1}  Rating = {2}  Price = {3}", t.Name, t.Country, t.Rating, t.PricePerNight);
            }
        }
        }
        
}
