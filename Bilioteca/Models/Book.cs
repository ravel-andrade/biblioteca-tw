﻿using System;
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
        public string Status { get; set; }
        public string BorrowedFor { get; set; }

    }
}
