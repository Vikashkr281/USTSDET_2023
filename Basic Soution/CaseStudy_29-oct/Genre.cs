using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_29_oct
{
    internal class Genre:Book
    { 
      public Genre(string? title, string? author, int isbn, double price, string? availability, string typeOfWork) : base(title, author, isbn, price, availability)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        Price = price;
        Availability = availability;
        TypeOfBook = typeOfWork;

    }

    public string? TypeOfBook { get; set; }

}
}
