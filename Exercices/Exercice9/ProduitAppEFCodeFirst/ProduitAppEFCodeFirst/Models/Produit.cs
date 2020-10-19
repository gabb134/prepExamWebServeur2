using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProduitAppEFCodeFirst.Models
{
    public class Produit
    {
        [Required]
        public int ProduitID { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [RegularExpression(@"^[A-Za-z]{5,25}$", ErrorMessage = "La désignation doit être une chaine de caractères dont la longueur est dans l’intervalle [5, 25]!")]
        public string designation { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [Range(50, 1000000, ErrorMessage = "Plage !")]
        public double prix { get; set; }
        public int CategorieID { get; set; }
        public virtual Categorie Categorie { get; set;}
    }
}