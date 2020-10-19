using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProduitAppEFCodeFirst.Models
{
    public class Categorie
    {
        public int CategorieID { get; set; }
        public string NomCategorie { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
    }
}