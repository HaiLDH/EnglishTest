using EnglishTest.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnglishTest.Web.Areas.Admin.Controllers
{
    public class AdminTestKitController : Controller
    {
        private TestKitService _testKitService;

        public AdminTestKitController(TestKitService testKitService)
        {
            _testKitService = testKitService;
        }

        // GET: Admin/AdminTestKit
        public ActionResult Index()
        {
            var testkits = _testKitService.GetAll();

            var a = testkits.Count();

            return View("~/Areas/Admin/Views/AdminTestKit/Index.cshtml", testkits);
        }
    }
}