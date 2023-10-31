using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_generic_30_oct
{
    internal class RoomReservation<T> where T : HotelRoom
    {
        private List<T> rooms;
        public RoomReservation()
        {
         rooms = new List<T>();
        }
        public void AddRoom(T room)
        {
            rooms.Add(room);
        }
    }
}
