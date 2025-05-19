using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Domain
{
    public class Utilisateur
    {
        public DateTime DateNaissance { get; set; }
        [EmailAddress (ErrorMessage = " adresse mail non valide")]
        public string Email { get; set; }
        public string NomUtilisateur { get; set; }
        public int UtilisateurId { get; set; }
        public virtual List<Visionnage> Visionnages { get; set; }

    }
}
