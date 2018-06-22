using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_School.Models;

namespace E_School.Controllers
{
    public class ClassCategoriesController : Controller
    {
        private SSRSEntities db = new SSRSEntities();

        // GET: ClassCategories
        public ActionResult Index()
        {
            return View(db.ClassCategories.ToList());
        }

        // GET: ClassCategories/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassCategory classCategory = db.ClassCategories.Find(id);
            if (classCategory == null)
            {
                return HttpNotFound();
            }
            return View(classCategory);
        }

        // GET: ClassCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryID,Name")] ClassCategory classCategory)
        {
            if (ModelState.IsValid)
            {
                db.ClassCategories.Add(classCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classCategory);
        }

        // GET: ClassCategories/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassCategory classCategory = db.ClassCategories.Find(id);
            if (classCategory == null)
            {
                return HttpNotFound();
            }
            return View(classCategory);
        }

        // POST: ClassCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryID,Name")] ClassCategory classCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classCategory);
        }

        // GET: ClassCategories/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassCategory classCategory = db.ClassCategories.Find(id);
            if (classCategory == null)
            {
                return HttpNotFound();
            }
            return View(classCategory);
        }

        // POST: ClassCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ClassCategory classCategory = db.ClassCategories.Find(id);
            db.ClassCategories.Remove(classCategory);
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
