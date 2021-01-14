using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilioteca.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        

        public User() 
        {
        }

        public User(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }

    }
}
