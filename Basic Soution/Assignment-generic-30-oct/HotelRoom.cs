using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_generic_30_oct
{
    internal class HotelRoom
    {
        public HotelRoom(int roomNumber, string? roomType)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsRoom = false;
        }

        public int RoomNumber {  get; set; }
        public string? RoomType {  get; set; }
        public bool IsRoom { get; set; }

    }
}
