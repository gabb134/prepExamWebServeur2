using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Marrero_projet01.Models
{
    public class Entreprise_Entreprise
    {
        [Key]
        public int EntrepriseID { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [Display(Name = "Nom de l'entreprise")]
        public string EntrepriseName { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [Display(Name = "Information sur l'entreprise")]
        public string EntrepriseNote { get; set; }
        //   [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [Display(Name = "Date d'inscription")]
        public DateTime DateInscrit { get; set; }
        //    [Required(ErrorMessage = "Ce champ est obligatoire!")]
        [Display(Name = "Date de modification")]
        public DateTime DateMod { get; set; } 

        public virtual ICollection<Entreprise_Address> Entreprise_Addresses { get; set; }//Entreprise ont plusieurs adresses
        public virtual ICollection<Employee_Employee> Employee_Employees { get; set; } //Entreprise ont plusieurs employess


    }
}