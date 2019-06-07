using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Criminal.Models;

namespace Criminal.Controllers
{
    public class CrimesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Crimes
        public ActionResult Index()
        {
            return View(db.Crims.ToList());
        }

        // GET: Crimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crime crime = db.Crims.Find(id);
            if (crime == null)
            {
                return HttpNotFound();
            }
            return View(crime);
        }

        // GET: Crimes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CrimId,CrimeName,CrimeDate")] Crime crime)
        {
            if (ModelState.IsValid)
            {
                db.Crims.Add(crime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(crime);
        }

        // GET: Crimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crime crime = db.Crims.Find(id);
            if (crime == null)
            {
                return HttpNotFound();
            }
            return View(crime);
        }

        // POST: Crimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CrimId,CrimeName,CrimeDate")] Crime crime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(crime);
        }

        // GET: Crimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crime crime = db.Crims.Find(id);
            if (crime == null)
            {
                return HttpNotFound();
            }
            return View(crime);
        }

        // POST: Crimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Crime crime = db.Crims.Find(id);
            db.Crims.Remove(crime);
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
