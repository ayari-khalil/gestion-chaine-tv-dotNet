using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ApplicationCore.Domain;
using App.ApplicationCore.Interfaces;

namespace App.ApplicationCore.Services
{
    public class VisionnageService : Service<Visionnage>, IVisionnageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VisionnageService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public float DureeTotalVisionnee(Utilisateur utilisateur)
        {
            throw new NotImplementedException();
        }


    }
}

