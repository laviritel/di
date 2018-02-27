using ECommerceDomain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce
{
    public class RootComposition
    {
        private readonly IControllerFactory factory;

        public RootComposition()
        {
            this.factory = RootComposition.CreateControllerFactory();
        }

        public IControllerFactory GetControllerFactory
        {
            get { return factory; }
        }
        private static IControllerFactory CreateControllerFactory()
        {
            string connString = ConfigurationManager.ConnectionStrings["ECommerceEntities"].ConnectionString;
            string productRepositoryTypeName = ConfigurationManager.AppSettings["ProductRepositoryType"];

            var productRepositoryType = Type.GetType(productRepositoryTypeName, true);

            var repository = (ProductRepository)Activator.CreateInstance(productRepositoryType, connString);

            var controllerFactory = new CommerceControllerFactory(repository);
            return controllerFactory;
        }
    }
}