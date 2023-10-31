// See https://aka.ms/new-console-template for more information
using GenericCollection;

ListExample<int> listExample = new ListExample<int>(19,20);
Console.WriteLine(listExample.Vall+" "+listExample.Vall2);


ListExample<double>listExample1= new ListExample<double>(19.5,20.4);
Console.WriteLine(listExample1.Vall+" "+listExample1.Vall2);

ListExample<string> listExample2 = new ListExample<string>("vikash", "kumar");
Console.WriteLine(listExample2.Vall+" "+listExample2.Vall2);