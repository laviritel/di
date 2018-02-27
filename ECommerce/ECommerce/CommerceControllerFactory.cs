using Antlr.Runtime.Misc;
using ECommerce.Controllers;
using ECommerceDomain;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace ECommerce
{
    internal class CommerceControllerFactory :DefaultControllerFactory
    {
        private ProductRepository repository;
        private readonly Dictionary<string, Func<RequestContext, IController>> controllerMap;
        public CommerceControllerFactory(ProductRepository repository)
        {
            this.repository = repository;
            this.controllerMap = new Dictionary<string, Func<RequestContext, IController>>();
            this.controllerMap["Home"] = ctx => new HomeController(repository);
        }

        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            return this.controllerMap[controllerName](requestContext);
        }
    }
}