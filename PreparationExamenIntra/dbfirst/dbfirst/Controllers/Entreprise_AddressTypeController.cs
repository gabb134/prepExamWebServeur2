﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dbfirst.Models;

namespace dbfirst.Controllers
{
    public class Entreprise_AddressTypeController : Controller
    {
        private BDW56Projet1GabrielEntities db = new BDW56Projet1GabrielEntities();

        // GET: Entreprise_AddressType
        public ActionResult Index()
        {
            return View(db.Entreprise_AddressType.ToList());
        }

        // GET: Entreprise_AddressType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_AddressType entreprise_AddressType = db.Entreprise_AddressType.Find(id);
            if (entreprise_AddressType == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_AddressType);
        }

        // GET: Entreprise_AddressType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entreprise_AddressType/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AddressTypeID,AddressType,ModifiedDate")] Entreprise_AddressType entreprise_AddressType)
        {
            if (ModelState.IsValid)
            {
                db.Entreprise_AddressType.Add(entreprise_AddressType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entreprise_AddressType);
        }

        // GET: Entreprise_AddressType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_AddressType entreprise_AddressType = db.Entreprise_AddressType.Find(id);
            if (entreprise_AddressType == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_AddressType);
        }

        // POST: Entreprise_AddressType/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AddressTypeID,AddressType,ModifiedDate")] Entreprise_AddressType entreprise_AddressType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entreprise_AddressType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entreprise_AddressType);
        }

        // GET: Entreprise_AddressType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_AddressType entreprise_AddressType = db.Entreprise_AddressType.Find(id);
            if (entreprise_AddressType == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_AddressType);
        }

        // POST: Entreprise_AddressType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entreprise_AddressType entreprise_AddressType = db.Entreprise_AddressType.Find(id);
            db.Entreprise_AddressType.Remove(entreprise_AddressType);
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
