using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Models
{
    public class EF_FootballerRepository : IFootballerRepository
    {

        private ApplicatonContext context;
        public EF_FootballerRepository(ApplicatonContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Footballer> Footballers => context.Footballers;
    }
}
