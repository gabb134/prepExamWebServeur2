using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercices1_3.Models;

namespace Exercices1_3.Controllers
{
    public class Serie02Controller : Controller
    {
        // GET: Serie02
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CalculatriceV3(string tbNombre1, string tbNombre2)
        {
            //Ajouter du code à cette méthode qui répond à la requête GET
            ViewBag.Resultat = "En attente...";

            return View();
        }
        [HttpPost]
        public ActionResult CalculatriceV3(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            // Ajouter du code à cette méthode qui répond à la requête POST
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
        [HttpGet]
        public ActionResult CalculatriceV4(string tbNombre1, string tbNombre2)
        {
            //Ajouter du code à cette méthode qui répond à la requête GET
            ViewBag.Resultat = "En attente...";
            ViewBag.Afficher = "Visible";
            tbNombre1 = "";
            tbNombre2 = "";
            return View();
        }
        [HttpPost]
        public ActionResult CalculatriceV4(string tbNombre1, string tbNombre2, string ddlOperateur)
        {
            // Ajouter du code à cette méthode qui répond à la requête POST
            ViewBag.Resultat = "En attente...";
            ViewBag.Afficher = "Visible";
            switch (ddlOperateur)
            {
                case "+":
                    if (tbNombre1 != "" && tbNombre2 != "")
                        ViewBag.Resultat = int.Parse(tbNombre1) + int.Parse(tbNombre2);
                    break;
                case "-":
                    if (tbNombre1 != "" && tbNombre2 != "")
                        ViewBag.Resultat = int.Parse(tbNombre1) - int.Parse(tbNombre2);
                    break;
                case "x":
                    if (tbNombre1 != "" && tbNombre2 != "")
                        ViewBag.Resultat = int.Parse(tbNombre1) * int.Parse(tbNombre2);
                    break;
                case "/":

                    if (tbNombre1 != "" && tbNombre2 != "")
                    {
                        if (Convert.ToUInt32(tbNombre2) == 0)
                        {
                            ViewBag.Resultat = "Erreur";
                        }
                        else
                            ViewBag.Resultat = Convert.ToString(Convert.ToDouble(tbNombre1) / Convert.ToDouble(tbNombre2));
                    }


                    break;
                case "Mod":
                    if (tbNombre1 != "" && tbNombre2 != "")
                        ViewBag.Resultat = Convert.ToString(Convert.ToDouble(tbNombre1) % Convert.ToDouble(tbNombre2));
                    break;
                case "%":
                    if (tbNombre1 != "")
                    {
                        ViewBag.Afficher = "invisible";
                        ViewBag.Resultat = Convert.ToDouble(tbNombre1) / 100;
                    }

                    break;
            }
            return View();
        }
        [HttpGet]
        public ActionResult CalculatriceV5()
        {
            Calculatrice calculatrice = new Calculatrice();
            calculatrice.Resultat = "En attente...";
            calculatrice.Afficher = "Visible";
            calculatrice.tbNombre1 = "";
            calculatrice.tbNombre2 = "";
            return View(calculatrice);
        }
        [HttpPost]
        public ActionResult CalculatriceV5(Calculatrice calculatrice)
        {
            calculatrice.Resultat = "En attente...";
            calculatrice.Afficher = "Visible";
            switch (calculatrice.ddlOperateur)
            {
                case "+":
                    if (calculatrice.tbNombre1  != null && calculatrice.tbNombre2 != null)
                        calculatrice.Resultat = Convert.ToString( int.Parse(calculatrice.tbNombre1) + int.Parse(calculatrice.tbNombre2));
                    break;
                case "-":
                    if (calculatrice.tbNombre1 != null && calculatrice.tbNombre2 != null)
                        calculatrice.Resultat = Convert.ToString(int.Parse(calculatrice.tbNombre1) - int.Parse(calculatrice.tbNombre2));
                    break;
                case "x":
                    if (calculatrice.tbNombre1 != null && calculatrice.tbNombre2 != null)
                        calculatrice.Resultat = Convert.ToString(int.Parse(calculatrice.tbNombre1) * int.Parse(calculatrice.tbNombre2));
                    break;
                case "/":

                    if (calculatrice.tbNombre1 != null && calculatrice.tbNombre2 != null)
                    {
                        if (Convert.ToUInt32(calculatrice.tbNombre2) == 0)
                        {
                            calculatrice.Resultat = "Erreur";
                        }
                        else
                            calculatrice.Resultat = Convert.ToString(Convert.ToDouble(calculatrice.tbNombre1) / Convert.ToDouble(calculatrice.tbNombre2));
                    }


                    break;
                case "Mod":
                    if (calculatrice.tbNombre1 != null && calculatrice.tbNombre2 != null)
                        calculatrice.Resultat = Convert.ToString(Convert.ToDouble(calculatrice.tbNombre1) % Convert.ToDouble(calculatrice.tbNombre2));
                    break;
                case "%":
                    if (calculatrice.tbNombre1 != "")
                    {
                        calculatrice.Afficher = "invisible";
                        calculatrice.Resultat = Convert.ToString(Convert.ToDouble(calculatrice.tbNombre1) / 100);
                    }

                    break;
            }

            return View(calculatrice);
        }
    }
}