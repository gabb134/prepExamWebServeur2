using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProduitAppEFCodeFirst.Models;
 

namespace ProduitAppEFCodeFirst.Context
{
    public class GestionProduitContext : DbContext
    {
        public GestionProduitContext() : base("GestionProduitContextBD")
        { }

        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }

    }
}