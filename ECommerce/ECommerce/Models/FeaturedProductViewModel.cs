using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class FeaturedProductViewModel
    {
        private List<ProductViewModel> products;

        public FeaturedProductViewModel()
        {
            this.products = new List<ProductViewModel>();
        }

        public IList<ProductViewModel> Products
        { get { return this.products; } }
    }
}