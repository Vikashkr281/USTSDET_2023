using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Delegate_2_31_oct
{
    internal class HotelEvent
    {
        public HotelEvent(string? name, string? date, string? location, int capacity)
        {
            Name = name;
            Date = date;
            Location = location;
            this.capacity = capacity;
        }

        public string? Name {  get; set; }
        public string ? Date { get; set; }
        public string? Location { get; set; }
        public int capacity { get; set; }
         public static void Display(HotelEvent hotelEvent)
        {
            Console.WriteLine("welcome to party");
        }
    }
}
