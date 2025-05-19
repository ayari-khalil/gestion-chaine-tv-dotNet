using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ApplicationCore.Domain;
using App.ApplicationCore.Interfaces;

namespace App.ApplicationCore.Services
{
    public class UtilisateurService : Service<Utilisateur>, IUtilisateurService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UtilisateurService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


    }
}