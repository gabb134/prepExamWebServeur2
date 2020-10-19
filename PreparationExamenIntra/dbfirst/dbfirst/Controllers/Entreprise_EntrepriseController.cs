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
    public class Entreprise_EntrepriseController : Controller
    {
        private BDW56Projet1GabrielEntities db = new BDW56Projet1GabrielEntities();

        // GET: Entreprise_Entreprise
        public ActionResult Index()
        {
            return View(db.Entreprise_Entreprise.ToList());
        }

        // GET: Entreprise_Entreprise/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_Entreprise entreprise_Entreprise = db.Entreprise_Entreprise.Find(id);
            if (entreprise_Entreprise == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_Entreprise);
        }

        // GET: Entreprise_Entreprise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entreprise_Entreprise/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EntrepriseID,EntrepriseName,EntrepriseNote,DateInscrit,DateMod")] Entreprise_Entreprise entreprise_Entreprise)
        {
            if (ModelState.IsValid)
            {
                db.Entreprise_Entreprise.Add(entreprise_Entreprise);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entreprise_Entreprise);
        }

        // GET: Entreprise_Entreprise/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_Entreprise entreprise_Entreprise = db.Entreprise_Entreprise.Find(id);
            if (entreprise_Entreprise == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_Entreprise);
        }

        // POST: Entreprise_Entreprise/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EntrepriseID,EntrepriseName,EntrepriseNote,DateInscrit,DateMod")] Entreprise_Entreprise entreprise_Entreprise)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entreprise_Entreprise).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entreprise_Entreprise);
        }

        // GET: Entreprise_Entreprise/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise_Entreprise entreprise_Entreprise = db.Entreprise_Entreprise.Find(id);
            if (entreprise_Entreprise == null)
            {
                return HttpNotFound();
            }
            return View(entreprise_Entreprise);
        }

        // POST: Entreprise_Entreprise/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entreprise_Entreprise entreprise_Entreprise = db.Entreprise_Entreprise.Find(id);
            db.Entreprise_Entreprise.Remove(entreprise_Entreprise);
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
