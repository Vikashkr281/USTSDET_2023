// See https://aka.ms/new-console-template for more informatio
using AbstractClass;

EV eV = new();
eV.VechicleNumber = 7217;
eV.Brand = "Apache";
eV.Model = "TVS";
eV.Display();
Console.WriteLine(eV.SetTypeForVechicle());
