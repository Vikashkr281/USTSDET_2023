// See https://aka.ms/new-console-template for more information
using Assignment_6_26_oct;
using System.Transactions;
Customer customer1 = new Customer();

Console.WriteLine("Enter details of customer\n");
for(int i = 0; i < 3 ; i++)
{
    Customer customer = new Customer();
    Console.WriteLine("Enter the customer id");
    customer.Id=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Customer Name\n");
    customer.Name = Console.ReadLine();
    Console.WriteLine("Enter the Balance\n");
    customer.Balance= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the phone Number\n");
    customer.PhoneNumber=Convert.ToInt64(Console.ReadLine());
    Customer.list.Add(customer);
    
}

customer1.Display();
customer1.SearchByPhone(7903324843);
