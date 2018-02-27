using System;

namespace ECommerceDomain
{
    public class DiscountedProduct
    {
        private string name;
        private decimal unitPrice;

        public DiscountedProduct(string name, decimal unitPrice)
        {
            if(name==null)
            {
                throw new ArgumentNullException("name");
            }
            this.name = name;
            this.unitPrice = unitPrice;
        }

        public string Name
        {
            get { return this.name; }
        }

        public decimal UnitPrice
        {
            get { return this.unitPrice; }
        }
    }
}