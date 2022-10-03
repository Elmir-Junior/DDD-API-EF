using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Domain.Models;
using WebApp.Infrastructure.Interfaces.Repositorys;
using WebApp.Services.Interfaces;

namespace WebApp.Services.Services
{
    public class ServiceTecnologia : ServiceBase<Tecnologia>,IServiceTecnologia
    {
        public readonly IRepositoryTecnologia _repositoryTecnologias;
        public ServiceTecnologia(IRepositoryTecnologia Repository) : base(Repository)
        {
            _repositoryTecnologias = Repository;
        }
    }
}
