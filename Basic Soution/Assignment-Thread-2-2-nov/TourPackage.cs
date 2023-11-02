using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Thread_2_2_nov
{
    internal class TourPackage
    {  
        public static List<TourPackage> Tourpackages = new List<TourPackage>();
        public TourPackage(int packageId, string? destination, string? startDate, double price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            this.price = price;
        }

        public int PackageId {  get; set; }
        public string? Destination { get; set; }
        public string? StartDate { get; set; }
        public double price {  get; set; }

        public static void HotelReservation()
        {
            Console.WriteLine("Enter the Id to book");
            int a = Convert.ToInt32(Console.ReadLine());
            lock (Tourpackages)
            {
                var b = Tourpackages.Find(x => x.PackageId == a);
                Console.WriteLine("Package booked Destianation :{0} \t StartDate  {1} \t price {2}", b.Destination, b.StartDate, b.price);

            }
        }
        }

    }

