using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XconApp.Data;

namespace XconApp.Infrastructures
{
    public class UserContext
    {
        #region local variables
        private static XCON_GCEntities _db;
        private static GC_USER _user;
        #endregion

        private static XCON_GCEntities DBContext()
        {
            if (_db == null)
            {
                _db = new XCON_GCEntities();
            }

            return _db;
        }

        private static bool IsAuthen()
        {
            var context = HttpContext.Current;
            if (context == null && context.User == null) return false;
            return context.User.Identity.IsAuthenticated;

        }

        private static string UserId()
        {
            return (IsAuthen()) ? HttpContext.Current.User.Identity.Name : string.Empty;

        }

        public static GC_USER GetUser()
        {
            if (IsAuthen())
            {
                if (_user == null)
                {
                    var userId = UserId();
                    _user = DBContext().GC_USER.SingleOrDefault(u => u.UserID == userId);
                }

                return _user;
            }

            return null;
        }


    }
}