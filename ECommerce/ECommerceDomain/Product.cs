﻿using System.Security.Principal;

namespace ECommerceDomain
{
    public class Product
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public DiscountedProduct ApplyDiscountFor(IPrincipal user)
        {
            var discount = user.IsInRole("adm") ? .95m : 1;
            return new DiscountedProduct(this.Name, this.UnitPrice * discount);
        }
    }
}
