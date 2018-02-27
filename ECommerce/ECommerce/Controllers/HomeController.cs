using ECommerce.Models;
using ECommerceDomain;
using ECommereceSqlDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository repository;
       public HomeController(ProductRepository repository)
        {
            if(repository==null)
            {
                throw new ArgumentNullException("repository");
            }

            this.repository = repository;
            
        }
        public ActionResult Index()
        {
            ProductService productService = new ProductService(this.repository);

            FeaturedProductViewModel vm = new FeaturedProductViewModel();
            var products = productService.GetFeaturedProducts(this.User);

            foreach (var item in products)
            {
                var productVM = new ProductViewModel(item);
                vm.Products.Add(productVM);
            }

            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}