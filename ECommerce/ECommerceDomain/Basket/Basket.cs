using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDomain.Basket
{
    public class Basket
    {
        private readonly IPrincipal owner;
        private readonly List<Extent> contents;

        public Basket(IPrincipal owner)
        {
            if (owner == null)
                throw new ArgumentNullException("owner");
            this.contents = new List<Extent>();

            this.owner = owner;
        }

        public IList<Extent>Contents
        { get { return this.contents; } }

        public IPrincipal Owner { get { return this.owner; } }

        
    }
}
