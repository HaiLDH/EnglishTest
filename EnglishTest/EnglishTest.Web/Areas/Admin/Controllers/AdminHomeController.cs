using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnglishTest.Web.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin/AdminHome
        public ActionResult Index()
        {
            return View();
        }


        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView("~/Areas/Admin/Views/Shared/_Footer.cshtml");
        }

        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView("~/Areas/Admin/Views/Shared/_Header.cshtml");
        }

        [ChildActionOnly]
        public ActionResult LeftMenu()
        {
            return PartialView("~/Areas/Admin/Views/Shared/_LeftMenu.cshtml");
        }
    }
}