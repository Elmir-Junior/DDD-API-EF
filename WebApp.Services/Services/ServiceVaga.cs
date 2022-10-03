using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Domain.Models;
using WebApp.Infrasctructure.Repository.Interfaces;
using WebApp.Infrastructure.Interfaces.Repositorys;
using WebApp.Services.Interfaces;

namespace WebApp.Services.Services
{
    public class ServiceVaga : ServiceBase<Vaga>,IServiceVaga
    {
        public readonly IRepositoryVaga _repositoryVaga;

        public ServiceVaga(IRepositoryVaga Repository) : base(Repository)
        {
            _repositoryVaga = Repository;
        }
    }
}
