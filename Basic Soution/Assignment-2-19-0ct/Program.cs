// See https://aka.ms/new-console-template for more information
using Assignment_2_19_0ct;
using System.Transactions;

Product[]products = new Product[3];
for(int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Enter the Name of Product ");
  string Name=  Console.ReadLine();
    Console.WriteLine("enter product price");
    double productPrice=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Quantity of the product ");
    int productQuantity=Convert.ToInt32(Console.ReadLine());
    products[i]=new Product(Name, productPrice,productQuantity);
    if (i < products.Length-1)
    {
        Console.WriteLine("enter the next product");
    }

}
Console.WriteLine(" Product Details Are Store is  ");
for(int i=0; i < products.Length; i++)
{
    products[i].DisplayProduct();
    products[i].TotalCost();
}



