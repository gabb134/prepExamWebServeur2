using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercices1_3.Controllers
{
    public class Serie01Controller : Controller
    {

        public ActionResult CalculatriceV1(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            //ajoutez votre code ici pour effectuer les opérations de la calculatrice.

            ViewBag.Resultat = "En attente...";

            switch (ddlOperateur)
            {
                case "+":
                    ViewBag.Resultat = Convert.ToString( Convert.ToInt32(tbNombre1) + Convert.ToInt32(tbNombre2));
                    break;
                case "-":
                    ViewBag.Resultat = Convert.ToString(Convert.ToInt32(tbNombre1) - Convert.ToInt32(tbNombre2));
                    break;
                case "x":
                    ViewBag.Resultat = Convert.ToString(Convert.ToInt32(tbNombre1) * Convert.ToInt32(tbNombre2));
                    break;
                case "/":
                 

                    if(Convert.ToUInt32(tbNombre2) == 0)
                    {
                        ViewBag.Resultat = "Erreur";
                    }
                    else
                    ViewBag.Resultat = Convert.ToString(Convert.ToDouble(tbNombre1) / Convert.ToDouble(tbNombre2));

                    break;
            }
            return View();
        }
        public ActionResult CalculatriceV2(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            //ajoutez votre code ici pour effectuer les opérations de la calculatrice.

            ViewBag.Resultat = "En attente...";

            switch (ddlOperateur)
            {
                case "+":
                    ViewBag.Resultat = Convert.ToString(Convert.ToInt32(tbNombre1) + Convert.ToInt32(tbNombre2));
                    break;
                case "-":
                    ViewBag.Resultat = Convert.ToString(Convert.ToInt32(tbNombre1) - Convert.ToInt32(tbNombre2));
                    break;
                case "x":
                    ViewBag.Resultat = Convert.ToString(Convert.ToInt32(tbNombre1) * Convert.ToInt32(tbNombre2));
                    break;
                case "/":


                    if (Convert.ToUInt32(tbNombre2) == 0)
                    {
                        ViewBag.Resultat = "Erreur";
                    }
                    else
                        ViewBag.Resultat = Convert.ToString(Convert.ToDouble(tbNombre1) / Convert.ToDouble(tbNombre2));

                    break;
            }
            return View();
        }

        // GET: Serie01
        public ActionResult Index()
        {
            return View();
        }

        // GET: Serie01/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Serie01/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Serie01/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Serie01/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Serie01/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Serie01/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Serie01/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
