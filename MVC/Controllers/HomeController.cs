using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        public RedirectToRouteResult RedirectToRoute()
        {
            return RedirectToRoute("default");
        }
        public ViewResult ActionDemo()
        {
            return View();
        }
        public PartialViewResult PartialDemo()
        {
            return PartialView();
        } 
        public RedirectResult RedirectToIndex()
        {

           //return View();
           return Redirect("Index");
        }
        public JsonResult JsonResultDemo()
        {
            userData obj = new userData()
            {
                UserName = "Test name",
                email = "testmail@test.com",
                phone = "123456789"
            };
            return Json(obj,JsonRequestBehavior.AllowGet);
        }

    }
}