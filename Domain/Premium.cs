using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ApplicationCore.Domain
{
    public class Premium : Utilisateur
    {
        public DateTime DateExpiration { get; set; }
        public int PointsFidelite { get; set; }

    }
}
