using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using XconApp.Data;
using XconApp.Infrastructures;
using XconApp.Repository;

namespace XconApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _user;
        private readonly OrderRepository _order;

        public HomeController()
        {
            _user = new UserRepository();
            _order = new OrderRepository();
        }

        [Authorize]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Greeting = $"Hello { UserContext.GetUser().ProjectCode}";
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(GC_USER model)
        {

            if (_user.IsValidUser(model.UserID, model.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(model.UserID, true);
            }

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login");
        }

        [Authorize]
        public ActionResult Order()
        {
            var user = UserContext.GetUser();
            var model = _order.GetOrder(user.UserID, user.CardCode);
            return View(model);
        }

        [Authorize]
        public ActionResult OrderDetail()
        {
           
            return View();
        }

    }
}
