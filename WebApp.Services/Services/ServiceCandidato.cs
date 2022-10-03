using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Domain.Models;
using WebApp.Infrasctructure.Repository.Interfaces;
using WebApp.Infrastructure.Interfaces.Repositorys;
using WebApp.Services.Interfaces;

namespace WebApp.Services.Services
{
    public class ServiceCandidato : ServiceBase<Candidato>,IServiceCandidato
    {

        public readonly IRepositoryCandidato _repositoryCandidato;

        public ServiceCandidato(IRepositoryCandidato Repository) : base(Repository)
        {
            _repositoryCandidato = Repository;
        }
    }
}
