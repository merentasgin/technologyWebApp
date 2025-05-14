using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using technologyWebApp.Models;
namespace technologyWebApp.Controllers
{
    public class LogİnController : Controller
    {
        
        // GET: Logİn
        technologyWebSiteDBEntities1 entity1 = new technologyWebSiteDBEntities1();


        public ActionResult Index()

        {
            ViewBag.mesaj = null;
            return View();
        }
        [HttpPost]
        public ActionResult Index(string userName, string userPassword)
        {

            var Users = (from u in entity1.Users where u.usNickname == userName && u.usPassword == userPassword select u).FirstOrDefault();
            if (Users != null)
            {

                Session["usName"] = Users.usNickname;
                Session["usID"] = Users.usID;
                Session["usType"] = Users.usType;

                switch (Users.usType)
                {
                    case 1:
                        return RedirectToAction("Index", "Yönetici");

                    case 2:
                        return RedirectToAction("Index", "Kullanıcı");                             // database de değişken türünü bitdfen inte çevir
                    default:
                        return View();
                }

            }
            else
            {
                ViewBag.mesaj = "Kullanıcı adı yada Parola yanlış";
                return View();
            }



        }
        

       








    }
}
