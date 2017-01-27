using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class FeaturesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Features
        public ActionResult Index()
        {
            return View(db.Features.ToList());
        }

        // GET: Features/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Features features = db.Features.Find(id);
            if (features == null)
            {
                return HttpNotFound();
            }
            return View(features);
        }

        // GET: Features/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Features/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FeaturesId,Name,Description,Duree,Start_Date_Real,Start_Date_Estimated,End_Date_Real,End_Date_Estimated,Remarks,Status")] Features features)
        {
            if (ModelState.IsValid)
            {
                db.Features.Add(features);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(features);
        }

        // GET: Features/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Features features = db.Features.Find(id);
            if (features == null)
            {
                return HttpNotFound();
            }
            return View(features);
        }

        // POST: Features/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FeaturesId,Name,Description,Duree,Start_Date_Real,Start_Date_Estimated,End_Date_Real,End_Date_Estimated,Remarks,Status")] Features features)
        {
            if (ModelState.IsValid)
            {
                db.Entry(features).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(features);
        }

        // GET: Features/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Features features = db.Features.Find(id);
            if (features == null)
            {
                return HttpNotFound();
            }
            return View(features);
        }

        // POST: Features/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Features features = db.Features.Find(id);
            db.Features.Remove(features);
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
