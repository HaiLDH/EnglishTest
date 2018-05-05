using EnglishTest.Common;
using System.Web;

namespace EnglishTest.UserHelper
{

    public class SessionHelper
    {
        public static bool IsAuthenticated
        {
            get { return HttpContext.Current.Session != null && HttpContext.Current.Session[Constants.LoggedUser] != null; }
        }

        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session[Constants.LoggedUser] = session;
        }

        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session[Constants.LoggedUser];
            return session as UserSession;
        }


        public static void DeleteSession()
        {
            var session = HttpContext.Current.Session[Constants.LoggedUser];
            if (session != null)
            {
                HttpContext.Current.Session.Abandon();
            }
        }
    }
}
