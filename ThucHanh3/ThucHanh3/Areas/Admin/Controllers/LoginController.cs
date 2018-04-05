using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucHanh3.Areas.Admin.Models;
using ThucHanh3.Areas.Admin.Code;
using System.Web.Security;

namespace ThucHanh3.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //public object SessionHelper { get; private set; }

        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            //var result = new Model1.AccountModel().Login(model.UserName, model.Password);
            if (Membership.ValidateUser(model.UserName, model.Password) && ModelState.IsValid)
            {
                //Nếu thành công chúng ta cần tạo session
                //SessionHelper.SetSession(new UserSession(model.UserName));
                FormsAuthentication.SetAuthCookie(model.UserName, model.Remenberme);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc Password không đúng!");
            }
            return View(model);

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }


    }
}
