// See https://aka.ms/new-console-template for more information
using Assignment_Thread_2_2_nov;

TourPackage package = new(1, "varanasi", "20-12-2023", 4399);
TourPackage package1 = new(2, "patna", "212-20-2023", 43443);
TourPackage package2 = new(3, "Deldi", "30-23-345", 34234);
TourPackage.Tourpackages.Add(package);
TourPackage.Tourpackages.Add ( package1);
TourPackage.Tourpackages.Add(package2 );
Thread thread = new Thread(TourPackage.HotelReservation);
Thread thread1=new Thread(TourPackage.HotelReservation);
thread1.Start();
thread1.Join();
thread.Start();