using B1400974.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B1400974_NguyenThiBichNgoc.Controllers
{
    public class lopchuyennganhController : Controller
    {
        B1400974_DbContext db = new B1400974_DbContext();
        // GET: lopchuyennganh
        public ActionResult Index()
        {
            return View();
        }
    }
}