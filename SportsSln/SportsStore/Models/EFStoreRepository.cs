using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {

        private StoreDbContext Context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            Context = ctx;
        }
        public IQueryable<Product> Products => Context.Products;
    }
}
