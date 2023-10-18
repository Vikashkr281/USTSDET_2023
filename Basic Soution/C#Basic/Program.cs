// See https://aka.ms/new-console-template for more information
using C_Basic;

internal class Program
{
    private static void Main(string[] args)
    {
       /* Console.WriteLine("Hello, World!");*/
        Electricity electricity = new Electricity(12345,9000,9300,"vikash");
      Console.WriteLine(electricity.CalculateNumber());
        Console.WriteLine(electricity.consumerName);
    }
}