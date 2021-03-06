﻿using ECommerceDomain;

namespace ECommerce.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public ProductViewModel(DiscountedProduct product)
        {
            this.Name = product.Name;
            this.UnitPrice = product.UnitPrice;
        }

        public string SummaryText {
            get { return $"{Name} {UnitPrice}"; }
        }
    }
}