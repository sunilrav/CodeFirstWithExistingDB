using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstWithExistingDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyCompanyDbContext context = new MyCompanyDbContext();
            Product product = context.Products.Single(x => x.Id == 1);
            
            return View();
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