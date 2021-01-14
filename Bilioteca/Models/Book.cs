using Bilioteca.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilioteca.Models
{
    public class Book
    {
        public int Id  { get; set; }
        
        public string Title  { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public BookStatus Status { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        public Book()
        {

        }

        public Book(int id, string title, string author, int year, BookStatus status, User user)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Status = status;
            User = user;
        }
    }
}
