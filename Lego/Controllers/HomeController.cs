using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lego.DAL;
using Lego.Models;

namespace Lego.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LegoSetDAL dal = new LegoSetDAL();
            List<LegoSet> model = dal.GetSets();

            return View(model);
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