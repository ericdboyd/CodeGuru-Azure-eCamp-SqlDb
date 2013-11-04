using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeGuru.eSeminar.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var serviceUri = new Uri(ConfigurationManager.AppSettings["ODataUri"]);
            var context = new ShoppingListService.ShoppingListEntities(serviceUri);
            var query = from p in context.People.Expand("Items")
                select p;
            var result = query.ToList();
            return View(result);
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