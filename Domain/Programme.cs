using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Domain
{
    public class Programme
    {
        public string Animateur { get; set; }
        public TimeSpan Duree { get; set; }
        [Required]
        [MaxLength(100)]
        public string NomProgramme { get; set; }
        public int ProgrammeId { get; set; }
        public virtual List<Visionnage> Visionnages { get; set; }
        public virtual Chaine Chaine { get; set; }



    }
}
