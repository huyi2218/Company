using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESCprogram.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ICustomerRepository _repository;
        public ActionResult Index()
        {
            ViewBag.Message = User.Identity.Name;
            ViewBag.xx = "_repository" ;
            
          //  ViewBag.name

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
