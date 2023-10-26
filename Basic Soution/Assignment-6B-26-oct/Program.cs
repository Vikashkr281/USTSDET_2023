// See https://aka.ms/new-console-template for more information
using Assignment_6B_26_oct;
Customer customer1 = new Customer();

Console.WriteLine("Enter the Call record");
for (int i = 0; i < 3; i++)
{
    Customer customer = new Customer();
    Console.WriteLine("Enter customer Id");
    customer.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Customer Phone Number");
    customer.PhoneNUMBER = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine("Enter Call time");
    customer.CallDuration = Convert.ToDouble(Console.ReadLine());

    Customer.list.Add(customer);

}

customer1.DisplayCallRecord(7903324843);
customer1.DisplayCount();
