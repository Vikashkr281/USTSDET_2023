// See https://aka.ms/new-console-template for more information
using Polymorphisim;
BankDetailsNew bankDetailsNew = new BankDetailsNew(1, 54324, "gfd", "gfd");
bankDetailsNew.WelcomeMessage();

BankDetails bankDetails = new BankDetails(1234, 123456789, "Aaa", "Inactive");

Console.WriteLine("How You Want to see Your Account Information Press");
Console.WriteLine("1.Custid \n2.Accno \n3.Name");
int choice=Convert.ToInt32(Console.ReadLine());
switch(choice)
{
    case 1:
        Console.WriteLine("Enter your customer id");
        bankDetails.GetAccDetails(Convert.ToInt32(Console.ReadLine())); break;
        case 2:
        Console.WriteLine("Enter your Acount number");
        bankDetails.GetAccDetails(Convert.ToInt64(Console.ReadLine())); break;
        case 3:
        Console.WriteLine("Enter your Name");
        bankDetails.GetAccDetails(Console.ReadLine()); break;
}
