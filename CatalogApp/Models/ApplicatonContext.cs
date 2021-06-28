using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Models
{
    public class ApplicatonContext : DbContext
    {
        public ApplicatonContext(DbContextOptions<ApplicatonContext> options) : base(options) { }

        public DbSet<Footballer> Footballers { get; set; }

        internal void Migrate()
        {
            throw new NotImplementedException();
        }
    }
}
