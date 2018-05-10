using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThiThu.Framework;

namespace ThiThu.Controllers
{
    public class dbo_nganhController : Controller
    {
        private WebMVCDbContext db = new WebMVCDbContext();

        // GET: dbo_nganh
        public ActionResult Index()
        {
            var dbo_nganh = db.dbo_nganh.Include(d => d.dbo_khoa);
            return View(dbo_nganh.ToList());
        }

        // GET: dbo_nganh/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbo_nganh dbo_nganh = db.dbo_nganh.Find(id);
            if (dbo_nganh == null)
            {
                return HttpNotFound();
            }
            return View(dbo_nganh);
        }

        // GET: dbo_nganh/Create
        public ActionResult Create()
        {
            ViewBag.MaKhoa = new SelectList(db.dbo_khoa, "MaKhoa", "TenKhoa");
            return View();
        }

        // POST: dbo_nganh/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNganh,MaKhoa,TenNganh,SoNamDT")] dbo_nganh dbo_nganh)
        {
            if (ModelState.IsValid)
            {
                db.dbo_nganh.Add(dbo_nganh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhoa = new SelectList(db.dbo_khoa, "MaKhoa", "TenKhoa", dbo_nganh.MaKhoa);
            return View(dbo_nganh);
        }

        // GET: dbo_nganh/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbo_nganh dbo_nganh = db.dbo_nganh.Find(id);
            if (dbo_nganh == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhoa = new SelectList(db.dbo_khoa, "MaKhoa", "TenKhoa", dbo_nganh.MaKhoa);
            return View(dbo_nganh);
        }

        // POST: dbo_nganh/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNganh,MaKhoa,TenNganh,SoNamDT")] dbo_nganh dbo_nganh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbo_nganh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhoa = new SelectList(db.dbo_khoa, "MaKhoa", "TenKhoa", dbo_nganh.MaKhoa);
            return View(dbo_nganh);
        }

        // GET: dbo_nganh/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbo_nganh dbo_nganh = db.dbo_nganh.Find(id);
            if (dbo_nganh == null)
            {
                return HttpNotFound();
            }
            return View(dbo_nganh);
        }

        // POST: dbo_nganh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dbo_nganh dbo_nganh = db.dbo_nganh.Find(id);
            db.dbo_nganh.Remove(dbo_nganh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
