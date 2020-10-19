using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercices1_3.Models;

namespace Exercices1_3.Controllers
{
    public class Serie03Controller : Controller
    {
        // GET: Serie03
 
        [HttpGet]
        public ActionResult Index()
        {
            //Ajoutez du code à cette méthode qui répond à la requête GET
            ModelSerie03 model = new ModelSerie03();



            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ModelSerie03 model)
        {
            // Ajoutez du code à cette méthode qui répond à la requête POST
            if (model.Categorie == "Selectionnez")
            {
                model.Afficher = "invisible";
            }

            return View(model);
        }
    }
}