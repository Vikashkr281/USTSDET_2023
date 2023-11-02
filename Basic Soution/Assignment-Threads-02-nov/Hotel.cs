using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Threads_02_nov
{
    internal class Hotel : TourismDestination
    {
        
        public string Name {  get; set; }
        public int AvailableRooms { get; set; }

        public Hotel(string? name, string? country, double? rate,string customerName,int isavailable) : base(name, country, rate)
        {
            Name = customerName;
            AvailableRooms = isavailable;
        }
        public async Task  BookRoomRequest(int roomavailable,Hotel hotel)
        {
            if(roomavailable <=AvailableRooms)
            {
                await Task.Delay(1000);
                AvailableRooms -= roomavailable;
                Console.WriteLine("HOTEL BOOKED FOR {0} \t Rooms left {1} in Location {2} \t ", hotel.Name, AvailableRooms,hotel.Country);

            }
            else
            {
                Console.WriteLine("room is not available");
            }
        }

       
    }
}
