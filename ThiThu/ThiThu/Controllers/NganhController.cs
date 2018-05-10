using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThiThu.Framework;

namespace ThiThu.Controllers
{
    public class NganhController : Controller
    {
        WebMVCDbContext db = new WebMVCDbContext();
        // GET: Nganh
        public ActionResult ds_nganh()
        {
            var listNganh = db.dbo_nganh.ToList();
            return View(listNganh);
        }
        public ActionResult them_nganh()
        {
            return View();
        }

        [HttpPost, ActionName("themnganh")]
        [ValidateInput(false)]
        public ActionResult them_nganh(dbo_nganh nganh)
        {
            if (ModelState.IsValid)
            {
                db.dbo_nganh.Add(nganh);
                db.SaveChanges();

            }
            var listNganh = from n in db.dbo_nganh select n;
            return View("ds_nganh", listNganh);

        }
        [HttpGet]
        public ActionResult sua_nganh(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             dbo_nganh nganh = db.dbo_nganh.SingleOrDefault(n => n.MaNganh == id);
            return View(nganh);

        }
        [HttpPost, ActionName("sua_nganh")]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Sua_nganh(string id)
        {
            var nganhUpdate = db.dbo_nganh.Find(id);
            if (TryUpdateModel(nganhUpdate, "", new string[] { "MaNganh", "MaKhoa", "TenNganh", "SoNamDT" }))
            {
                try
                {
                    db.Entry(nganhUpdate).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (RetryLimitExceededException)
                {
                    ModelState.AddModelError("", "Error Save Data");
                }
            }

            return RedirectToAction("ds_nganh");
        }
        [HttpGet]
        public ActionResult xoa_nganh(string id)
        {
            dbo_nganh nganh = db.dbo_nganh.SingleOrDefault(n => n.MaNganh == id);
            if (nganh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.dbo_nganh.Remove(nganh);
            db.SaveChanges();
            return RedirectToAction("ds_nganh");
        }
        public ActionResult nganh()
        {
            ViewBag.MaKhoa = new SelectList(db.dbo_khoa, "MaKhoa", "TenKhoa");
            return View();
        }
        [HttpPost]
        public ActionResult showInfo(string id)
        {
            //var listNganhTheoKhoa = db.dbo_nganh.Include(n => n.dbo_khoa).Where(n => n.MaNganh == id).ToList();
            
            var listNganhTheoKhoa = from n in db.dbo_nganh  where n.MaKhoa == id select n;
            return View(listNganhTheoKhoa);
        }
        
    }
}