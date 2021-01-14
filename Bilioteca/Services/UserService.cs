using Bilioteca.Data;
using Bilioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilioteca.Services
{
    public class UserService
    {
        private readonly BiliotecaContext _context;

        public UserService(BiliotecaContext context)
        {
            _context = context;
        }

        public List<User> FindAll()
        {
            return _context.User.OrderBy(x => x.Name).ToList();
        }
    }
}