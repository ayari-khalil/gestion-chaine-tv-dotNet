using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ApplicationCore.Domain;

namespace App.ApplicationCore.Interfaces
{
    public interface IProgrammeService : IService<Programme>
    {
        public Chaine GrandNombreProgrammeVisionnee();
        public List<Programme> GetProgrammesByUserDate(Utilisateur utilisateur, DateTime dateDebut,DateTime dateFin);

    }
}

