using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Domain
{
    public class Chaine
    {
        public int ChaineId { get; set; }
        public string NomChaine { get; set; }
        public Thematique Thematique { get; set; }
        public virtual List<Programme> Programmes { get; set; }



    }
}
