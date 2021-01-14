using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilioteca.Models
{
    public class BorrowFormViewModel
    {
        public Book Book { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
