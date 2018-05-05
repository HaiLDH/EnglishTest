using EnglishTest.Common;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EnglishTest.UserHelper
{
    public class LoginRequiredAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session[Constants.LoggedUser] == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "User", action = "Index", redirectUrl = HttpContext.Current.Request.Url.PathAndQuery }));
            }
        }
    }
}
