// See https://aka.ms/new-console-template for more information
using Assignment_Delegate_2_31_oct;
using System.Xml.XPath;

class Program
{
    public delegate void EventNotification(HotelEvent hotelEvent);
    public static void Main(string[] args)
    {
        HotelEvent hotelEvent = new HotelEvent("vikash", "12-09-5674", "patna", 5000);
        HotelEvent hotelEvent1 = new HotelEvent("vysanav", "12-3-4555", "delhi", 3456);
        EventNotification eve = HotelEvent.Display;
        eve(hotelEvent);

        Console.WriteLine("Name = {0} Date = {1} Location = {2}  capacity = {3}",hotelEvent.Name,hotelEvent.Date,hotelEvent.Location,hotelEvent.capacity);
        Console.WriteLine("Name = {0} Date = {1} Location = {2}  capacity = {3}", hotelEvent1.Name, hotelEvent1.Date, hotelEvent1.Location, hotelEvent1.capacity);


    }

}
