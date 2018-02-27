using ECommerceDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommereceSqlDataLayer
{
    public class SqlProductRepository : ProductRepository
    {
        private readonly ECommerceEntities context;

        public SqlProductRepository(string conString)
        {
            this.context = new ECommerceEntities(conString);
        }
        public override IEnumerable<ECommerceDomain.Product> GetFeaturedProducts()
        {
            var products = (from p in this.context.Product
                            where p.Featured
                            select p).AsEnumerable();

            return from p in products
                   select p.ToDomainProduct();
        }
    }
}
