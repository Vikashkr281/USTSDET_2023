// See https://aka.ms/new-console-template for more information
using C_Basic;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Console.WriteLine("Hello, World!");*/
        /* Electricity electricity = new Electricity(12345,9000,9300,"vikash");
       Console.WriteLine(electricity.CalculateNumber());
         Console.WriteLine(electricity.consumerName);*/

       /* Employees employees = new(111, "A", "IT", 10000);
        Console.WriteLine(employees.Eid+"\n"+ employees.Ename +"\n"+ employees.Dept +"\n"+ employees.BasicPay);
        Console.WriteLine(employees.CalculateSalary()); */

        ArrayExample example = new ArrayExample();
        //example.oneDimension();
        example.twoDimension();
    }
}