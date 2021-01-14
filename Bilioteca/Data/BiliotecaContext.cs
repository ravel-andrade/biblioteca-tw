
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bilioteca.Models;

namespace Bilioteca.Data
{
    public class BiliotecaContext : DbContext
    {
        public BiliotecaContext(DbContextOptions<BiliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Bilioteca.Models.User> User { get; set; }

        public DbSet<Bilioteca.Models.Book> Book { get; set; }
    }
}