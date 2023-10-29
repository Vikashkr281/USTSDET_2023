using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_29_oct
{
    internal class Book
    {
        public Book(string? title, string? author, int isbn, double price, string? availability)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            this.Price = price;
            Availability = availability;
        }

        public string? Title { get; set; }
        public string? Author { get; set;}
        public int Isbn { get; set; }
        public double Price { get; set; }
        public string? Availability { get; set; }
    }
}
