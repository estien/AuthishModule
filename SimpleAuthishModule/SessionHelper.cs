using System.Web;
using System.Web.SessionState;

namespace SimpleAuthishModule
{
    public class SessionHelper
    {
        private const string SessionKey = "abcDeFghIjKLm";
        public static bool IsAuthenticated(HttpSessionState app)
        {
            return app[SessionKey] != null;
        }

        public static void SetAuthenticated(HttpContext context)
        {
            context.Session[SessionKey] = true;
        }
    }
}
