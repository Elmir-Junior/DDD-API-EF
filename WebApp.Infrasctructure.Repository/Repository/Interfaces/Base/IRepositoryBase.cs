using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Infrasctructure.Repository.Interfaces
{
    public interface IRepositoryBase<TEntity>:IDisposable where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
