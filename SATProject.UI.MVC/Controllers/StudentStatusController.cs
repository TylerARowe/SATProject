using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SATProject.DATE.EF;

namespace SATProject.UI.MVC.Controllers
{
    public class StudentStatusController : Controller
    {
        private SATProjectEntities db = new SATProjectEntities();

        // GET: StudentStatus
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(db.StudentStatus.ToList());
        }

        // GET: StudentStatus/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentStatus studentStatus = db.StudentStatus.Find(id);
            if (studentStatus == null)
            {
                return HttpNotFound();
            }
            return View(studentStatus);
        }

        // GET: StudentStatus/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "SSID,SSName,SSDescription")] StudentStatus studentStatus)
        {
            if (ModelState.IsValid)
            {
                db.StudentStatus.Add(studentStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentStatus);
        }

        // GET: StudentStatus/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentStatus studentStatus = db.StudentStatus.Find(id);
            if (studentStatus == null)
            {
                return HttpNotFound();
            }
            return View(studentStatus);
        }

        // POST: StudentStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "SSID,SSName,SSDescription")] StudentStatus studentStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentStatus);
        }

        // GET: StudentStatus/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentStatus studentStatus = db.StudentStatus.Find(id);
            if (studentStatus == null)
            {
                return HttpNotFound();
            }
            return View(studentStatus);
        }

        // POST: StudentStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentStatus studentStatus = db.StudentStatus.Find(id);
            db.StudentStatus.Remove(studentStatus);
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

        public ActionResult IndexTile()
        {
            return View(db.StudentStatus.ToList());
        }
    }
}
