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
    public class Employee_PhoneNumberController : Controller
    {
        private BDW56Projet1GabrielEntities db = new BDW56Projet1GabrielEntities();

        // GET: Employee_PhoneNumber
        public ActionResult Index()
        {
            var employee_PhoneNumber = db.Employee_PhoneNumber.Include(e => e.Employee_Employee).Include(e => e.Employee_PhoneNumberType);
            return View(employee_PhoneNumber.ToList());
        }

        // GET: Employee_PhoneNumber/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_PhoneNumber employee_PhoneNumber = db.Employee_PhoneNumber.Find(id);
            if (employee_PhoneNumber == null)
            {
                return HttpNotFound();
            }
            return View(employee_PhoneNumber);
        }

        // GET: Employee_PhoneNumber/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employee_Employee, "EmployeeID", "FirstName");
            ViewBag.PhoneNumberTypeID = new SelectList(db.Employee_PhoneNumberType, "PhoneNumberTypeID", "PhoneNumbertype");
            return View();
        }

        // POST: Employee_PhoneNumber/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PhoneNumberID,EmployeeID,PhoneNumber,ModifiedDate,PhoneNumberTypeID")] Employee_PhoneNumber employee_PhoneNumber)
        {
            if (ModelState.IsValid)
            {
                db.Employee_PhoneNumber.Add(employee_PhoneNumber);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employee_Employee, "EmployeeID", "FirstName", employee_PhoneNumber.EmployeeID);
            ViewBag.PhoneNumberTypeID = new SelectList(db.Employee_PhoneNumberType, "PhoneNumberTypeID", "PhoneNumbertype", employee_PhoneNumber.PhoneNumberTypeID);
            return View(employee_PhoneNumber);
        }

        // GET: Employee_PhoneNumber/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_PhoneNumber employee_PhoneNumber = db.Employee_PhoneNumber.Find(id);
            if (employee_PhoneNumber == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employee_Employee, "EmployeeID", "FirstName", employee_PhoneNumber.EmployeeID);
            ViewBag.PhoneNumberTypeID = new SelectList(db.Employee_PhoneNumberType, "PhoneNumberTypeID", "PhoneNumbertype", employee_PhoneNumber.PhoneNumberTypeID);
            return View(employee_PhoneNumber);
        }

        // POST: Employee_PhoneNumber/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhoneNumberID,EmployeeID,PhoneNumber,ModifiedDate,PhoneNumberTypeID")] Employee_PhoneNumber employee_PhoneNumber)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_PhoneNumber).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employee_Employee, "EmployeeID", "FirstName", employee_PhoneNumber.EmployeeID);
            ViewBag.PhoneNumberTypeID = new SelectList(db.Employee_PhoneNumberType, "PhoneNumberTypeID", "PhoneNumbertype", employee_PhoneNumber.PhoneNumberTypeID);
            return View(employee_PhoneNumber);
        }

        // GET: Employee_PhoneNumber/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_PhoneNumber employee_PhoneNumber = db.Employee_PhoneNumber.Find(id);
            if (employee_PhoneNumber == null)
            {
                return HttpNotFound();
            }
            return View(employee_PhoneNumber);
        }

        // POST: Employee_PhoneNumber/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee_PhoneNumber employee_PhoneNumber = db.Employee_PhoneNumber.Find(id);
            db.Employee_PhoneNumber.Remove(employee_PhoneNumber);
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
