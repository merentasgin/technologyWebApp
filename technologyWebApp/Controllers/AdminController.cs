using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using technologyWebApp.Models;

namespace technologyWebApp.Controllers
{
    public class AdminController : Controller
    {
        technologyWebSiteDBEntities1 entity2 = new technologyWebSiteDBEntities1();

        // GET: Admin
        public ActionResult Index()
        {





            return View();
        }
    }
}