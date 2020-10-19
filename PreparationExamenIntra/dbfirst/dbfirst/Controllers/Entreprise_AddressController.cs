using System;
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
    public class Entreprise_AddressController : Controller
    {
        private BDW56Projet1GabrielEntities db = new BDW56Projet1GabrielEntities();

        // GET: Entreprise_Address
        public ActionResult Index()
        {
            var entreprise_Address = db.Entreprise_Address.Include(e => e.Entreprise_AddressType).Include(e => e.Entreprise_Entreprise);
            return View(entreprise_Address.ToList());
        }

        // GET: Entreprise_Address/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_Address entreprise_Address = db.Entreprise_Address.Find(id);
            if (entreprise_Address == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_Address);
        }

        // GET: Entreprise_Address/Create
        public ActionResult Create()
        {
            ViewBag.AddressTypeID = new SelectList(db.Entreprise_AddressType, "AddressTypeID", "AddressType");
            ViewBag.EntrepriseID = new SelectList(db.Entreprise_Entreprise, "EntrepriseID", "EntrepriseName");
            return View();
        }

        // POST: Entreprise_Address/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AddressID,AddressLine1,AddressLine2,City,Province,Country,PostalCode,EntrepriseAddWeb,ModifiedDate,AddressTypeID,EntrepriseID")] Entreprise_Address entreprise_Address)
        {
            if (ModelState.IsValid)
            {
                db.Entreprise_Address.Add(entreprise_Address);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AddressTypeID = new SelectList(db.Entreprise_AddressType, "AddressTypeID", "AddressType", entreprise_Address.AddressTypeID);
            ViewBag.EntrepriseID = new SelectList(db.Entreprise_Entreprise, "EntrepriseID", "EntrepriseName", entreprise_Address.EntrepriseID);
            return View(entreprise_Address);
        }

        // GET: Entreprise_Address/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_Address entreprise_Address = db.Entreprise_Address.Find(id);
            if (entreprise_Address == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressTypeID = new SelectList(db.Entreprise_AddressType, "AddressTypeID", "AddressType", entreprise_Address.AddressTypeID);
            ViewBag.EntrepriseID = new SelectList(db.Entreprise_Entreprise, "EntrepriseID", "EntrepriseName", entreprise_Address.EntrepriseID);
            return View(entreprise_Address);
        }

        // POST: Entreprise_Address/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AddressID,AddressLine1,AddressLine2,City,Province,Country,PostalCode,EntrepriseAddWeb,ModifiedDate,AddressTypeID,EntrepriseID")] Entreprise_Address entreprise_Address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entreprise_Address).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressTypeID = new SelectList(db.Entreprise_AddressType, "AddressTypeID", "AddressType", entreprise_Address.AddressTypeID);
            ViewBag.EntrepriseID = new SelectList(db.Entreprise_Entreprise, "EntrepriseID", "EntrepriseName", entreprise_Address.EntrepriseID);
            return View(entreprise_Address);
        }

        // GET: Entreprise_Address/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_Address entreprise_Address = db.Entreprise_Address.Find(id);
            if (entreprise_Address == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_Address);
        }

        // POST: Entreprise_Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entreprise_Address entreprise_Address = db.Entreprise_Address.Find(id);
            db.Entreprise_Address.Remove(entreprise_Address);
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
