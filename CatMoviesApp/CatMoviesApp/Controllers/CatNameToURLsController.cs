using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CatMoviesApp.Models;

namespace CatMoviesApp.Controllers
{
    public class CatNameToURLsController : Controller
    {
        private CatVideoAppEntities db = new CatVideoAppEntities();

        // GET: CatNameToURLs
        public ActionResult Index()
        {
            return View(db.CatNameToURLs.ToList());
        }

        // GET: CatNameToURLs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatNameToURL catNameToURL = db.CatNameToURLs.Find(id);
            if (catNameToURL == null)
            {
                return HttpNotFound();
            }
            return View(catNameToURL);
        }

        // GET: CatNameToURLs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatNameToURLs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CatID,URL,Name")] CatNameToURL catNameToURL)
        {
            if (ModelState.IsValid)
            {
                db.CatNameToURLs.Add(catNameToURL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catNameToURL);
        }

        // GET: CatNameToURLs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatNameToURL catNameToURL = db.CatNameToURLs.Find(id);
            if (catNameToURL == null)
            {
                return HttpNotFound();
            }
            return View(catNameToURL);
        }

        // POST: CatNameToURLs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CatID,URL,Name")] CatNameToURL catNameToURL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catNameToURL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catNameToURL);
        }

        // GET: CatNameToURLs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatNameToURL catNameToURL = db.CatNameToURLs.Find(id);
            if (catNameToURL == null)
            {
                return HttpNotFound();
            }
            return View(catNameToURL);
        }

        // POST: CatNameToURLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CatNameToURL catNameToURL = db.CatNameToURLs.Find(id);
            db.CatNameToURLs.Remove(catNameToURL);
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
