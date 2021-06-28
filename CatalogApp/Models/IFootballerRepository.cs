using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Models
{
    public interface IFootballerRepository
    {
        public IQueryable<Footballer> Footballers { get; }
    }
}
