// See https://aka.ms/new-console-template for more information
using Assisemment_1_oct_21;
using System;
using System.Collections;

Book[] books = new Book[10];
Customer[] customers = new Customer[2];
Order[] orders = new Order[2];
int option=1,choice,num1=0,ON=0,CN=0;

Console.WriteLine("_____________________________Book Store_______________________________");
while(option==1)
{
    Console.WriteLine("_____________________ENTER YOUR CHOICE_____________________________");
Console.WriteLine("1 For Enter Book Details");
Console.WriteLine("2 For Enter Customer Details");
Console.WriteLine("3 for Placed Order");
Console.WriteLine("4 for Search Book");
    Console.WriteLine("5 See the Customer Details");
    Console.WriteLine("6 for See the order placed And Total cost");
Console.WriteLine("Enter ur choice");
    choice=Convert.ToInt32(Console.ReadLine());


switch(choice)
{
    case 1:
        Console.WriteLine("Enter the Book Details");
            Console.WriteLine("enter how many book u wish to insert");
            int num=Convert.ToInt32(Console.ReadLine());
            num1 = num;
            
            for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter The book title ");
            string? bookTitle = Console.ReadLine();
            Console.WriteLine("Enter Author Name");
            string? author = Console.ReadLine();
            Console.WriteLine("Enter ISBN");
            int isbn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price ");
            double price = Convert.ToDouble(Console.ReadLine());
            books[i] = new Book(bookTitle, author, isbn, price, true);
            Console.WriteLine("Enter the next Entry");
        }
        break;
        case 2:
        Console.WriteLine("Enter the Customer Details");
            Console.WriteLine("Enter the nuber of  customer u wish");
            int Cn=Convert.ToInt32(Console.ReadLine());
            CN = Cn;
        for (int i = 0; i < Cn; i++)
        {     
            Console.WriteLine("Enter the Name");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the ContactDetail");
            string? contractDetails = Console.ReadLine();
            Console.WriteLine("Enter the unique Customer ID");
            int id=Convert.ToInt32(Console.ReadLine());
            customers[i] = new Customer(name,contractDetails,id);
            Console.WriteLine("Enter the other entry");
                }
        break;
        case 3:
        Console.WriteLine("Enter order details");
            Console.WriteLine("Enter how many Order U Wish To Give");
            int oNumber=Convert.ToInt32(Console.ReadLine());
            ON = oNumber;
        for(int i = 0;i < oNumber;i++)
        {
            Console.WriteLine("Enter the Name of book U Wish to order");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the order date");
            string date=Console.ReadLine();
                orders[i]=new Order(name,date);
        }
        break;
        case 4:
        Console.WriteLine("Enter the ISBN Number to search");
        int number=Convert.ToInt32(Console.ReadLine());
        int count = 0;
            
         
          for(int i=0;i < num1;i++)
        {
            if (books[i].iSBN==number)
            {
                count++;
            }

        }
          if(count > 0) 
        {
            Console.WriteLine("Book Available");
                }
          else { Console.WriteLine("Not Available"); }
          break;
        case 5:
        
        Console.WriteLine(" Customer Details are");
        for(int i = 0; i < CN;i++) 
        {
            customers[i].CustomerDetails();
        }
        break;
            case 6: Console.WriteLine("See the order place");
            for (int i = 0; i < ON; i++)
            {
                orders[i].DisplayOrder();
            }
            break;


        }

    
    Console.WriteLine("Do U Wish To Continue press 1 else 0");
   option=Convert.ToInt32(Console.ReadLine());
}
