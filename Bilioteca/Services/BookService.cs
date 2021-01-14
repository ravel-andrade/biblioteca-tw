using Bilioteca.Data;
using Bilioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilioteca.Services
{
    public class BookService
    {
        private readonly BiliotecaContext _context;

        public BookService(BiliotecaContext context) {
            _context = context;
        }

        public List<Book> FindAll()
        {  
            return _context.Book.ToList();
        }

        public void Insert(Book obj)
        {
            obj.User = _context.User.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
