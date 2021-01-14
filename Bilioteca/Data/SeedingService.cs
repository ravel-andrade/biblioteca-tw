using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilioteca.Models;
using Bilioteca.Models.Enums;

namespace Bilioteca.Data
{
    public class SeedingService
    {
        private BiliotecaContext _context;

        public SeedingService(BiliotecaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Book.Any() ||
                _context.User.Any())
            {
                return; // DB has been seeded
            }

            User u1 = new User(1, "Biblioteca", "Av. Brasil");
            User u2 = new User(2, "Ravel", "Av. Brasil");
            User u3 = new User(3, "Lohan", "Av. Primeiro de maio");

            Book b1 = new Book(1, "Como fazer sentido e bater o martelo", "Alexandro Aolchique", 2017, BookStatus.Disponivel, u1);
            Book b2 = new Book(2, "Código limpo", "Tio Bob", 2001, BookStatus.Disponivel, u1);
            Book b3 = new Book(3, "Basquete 101", "Hortência Marcari", 2010, BookStatus.Disponivel, u1);



            _context.User.AddRange(u1,u2,u3);

            _context.Book.AddRange(b1,b2,b3);

            _context.SaveChanges();
        }
    }
}