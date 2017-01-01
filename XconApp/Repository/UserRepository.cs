using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XconApp.Data;

namespace XconApp.Repository
{
    public class UserRepository
    {
        private readonly XCON_GCEntities _db;
        public UserRepository()
        {
            _db = new XCON_GCEntities();
        }

        public bool IsValidUser(string userId, string password)
        {
            var user = _db.GC_USER.SingleOrDefault(u => u.UserID == userId && u.Password == password);
            return (user != null);
        }
    }
}