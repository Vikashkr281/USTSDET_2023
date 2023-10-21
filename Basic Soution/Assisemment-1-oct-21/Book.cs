using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisemment_1_oct_21
{
    internal class Book 
    {
        public Book(string? book_Title, string? author, int iSBN, double price, bool availability)
        {
            this.book_Title = book_Title;
            this.author = author;
            this.iSBN = iSBN;
            this.price = price;
            this.availability = availability;
        }

        public string? book_Title {  get; set; }
        public string? author { get; set; }
        public int iSBN { get; set; }   
        public double price {  get; set; }
        public bool availability { get; set; }


        public void Display()
        {
            Console.WriteLine("Book Title ={0}\t Author ={1}\tISBN ={2}\t Price ={3}\t Availability ={4}", book_Title, author, iSBN, price, availability);
           
        }
       
    }

}
