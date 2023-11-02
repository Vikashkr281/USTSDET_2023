// See https://aka.ms/new-console-template for more information
using Assignment_Threads_02_nov;
Hotel hotel =new Hotel("miraz","india",4,"Vikash",10);
Hotel hotel1 = new Hotel("Taj", "bangaladesh", 5, "vysanav", 4);
await hotel.BookRoomRequest(5, hotel);
await hotel1.BookRoomRequest(2, hotel1);