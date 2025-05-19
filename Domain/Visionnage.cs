using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Domain
{
    public class Visionnage
    {
        public DateTime DateVisionnage { get; set; }
        public bool Favori { get; set; }
        public virtual Programme Programme { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }

        public int ProgrammeKey { get; set; }
        public int UtilisateurKey { get; set; }



    }
}
