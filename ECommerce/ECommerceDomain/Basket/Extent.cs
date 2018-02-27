using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDomain.Basket
{
    public class Extent
    {
        private readonly Product product;

        public Extent(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            this.product = product;
        }

        public Product Product { get { return this.product; } }

        public int Quantity { get; set; }

    }
}
