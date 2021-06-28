using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Models.ViewModels
{
    public class FootballerEditViewModel
    {
        public IEnumerable<Footballer> Footballers { get; set; }
        public Footballer Footballer { get; set; }
    }
}
