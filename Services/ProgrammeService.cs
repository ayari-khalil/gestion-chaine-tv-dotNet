using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ApplicationCore.Domain;
using App.ApplicationCore.Interfaces;

namespace App.ApplicationCore.Services
{
    public class ProgrammeService : Service<Programme>, IProgrammeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProgrammeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Programme> GetProgrammesByUserDate(Utilisateur utilisateur, DateTime dateDebut, DateTime dateFin)
        {
            throw new NotImplementedException();
        }
        



        public Chaine GrandNombreProgrammeVisionnee()
        {
            {
                var programmes = UnitOfWork.Repository<Programme>().GetMany(v => v.Visionnages != null);

                var programmePlusDemande = programmes
                    .OrderByDescending(v => v.Visionnages.Count) // Trier par le nombre de courses
                    .First(); // Prendre la première voiture

                return programmePlusDemande.Chaine;
            }
        }
    }
}
