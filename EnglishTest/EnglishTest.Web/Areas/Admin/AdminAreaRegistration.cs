using System.Web.Mvc;

namespace EnglishTest.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "Admin Login",
                url: "admin/login",
                defaults: new { controller = "AdminUser", action = "Index" },
                namespaces: new string[] { "EnglishTest.Web.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                name: "Admin Default",
                url: "admin",
                defaults: new { controller = "AdminHome", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "EnglishTest.Web.Areas.Admin.Controllers" }
            );
        }
    }
}