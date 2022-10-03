using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Infrasctructure.Repository.Interfaces;
using WebApp.Infrastructure.Interfaces.Repositorys;
using WebApp.Services.Interfaces.Base;

namespace WebApp.Services.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> Repository)
        {
            _repository = Repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
