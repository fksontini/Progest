﻿using System;
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
    public class DiscussionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Discussions
        public ActionResult Index()
        {
            return View(db.Discussion.ToList());
        }

        // GET: Discussions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discussion discussion = db.Discussion.Find(id);
            if (discussion == null)
            {
                return HttpNotFound();
            }
            return View(discussion);
        }

        // GET: Discussions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Discussions/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiscID,DateStart")] Discussion discussion)
        {
            if (ModelState.IsValid)
            {
                db.Discussion.Add(discussion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(discussion);
        }

        // GET: Discussions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discussion discussion = db.Discussion.Find(id);
            if (discussion == null)
            {
                return HttpNotFound();
            }
            return View(discussion);
        }

        // POST: Discussions/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiscID,DateStart")] Discussion discussion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(discussion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(discussion);
        }

        // GET: Discussions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Discussion discussion = db.Discussion.Find(id);
            if (discussion == null)
            {
                return HttpNotFound();
            }
            return View(discussion);
        }

        // POST: Discussions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Discussion discussion = db.Discussion.Find(id);
            db.Discussion.Remove(discussion);
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
