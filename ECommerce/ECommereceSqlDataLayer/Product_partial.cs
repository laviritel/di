using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommereceSqlDataLayer
{
    public partial class Product
    {
        public ECommerceDomain.Product ToDomainProduct()
        {
            var prod = new ECommerceDomain.Product();
            prod.Name = this.Name;
            prod.UnitPrice = this.UnitPrice;
            return prod;
        }
    }
}
