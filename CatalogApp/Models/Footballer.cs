using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Models
{
    public class Footballer
    {
        public int FootballerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public DateTime DateBirth { get; set; }
        public string NameCommand { get; set; }
        public string Country { get; set; } 
    }
}
