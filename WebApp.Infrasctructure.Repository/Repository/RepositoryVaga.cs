using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Domain.Models;
using WebApp.Infrastructure.Context;
using WebApp.Infrastructure.Interfaces.Repositorys;

namespace WebApp.Infrasctructure.Repository.Repository
{
    public class RepositoryVaga : RepositoryBase<Vaga>, IRepositoryVaga
    {
        private readonly SQLContext _context;
        public RepositoryVaga(SQLContext context) : base(context)
        {
            _context = context;
        }

        public override void Remove(Vaga vaga)
        {
            var entry = _context.Vagas.First(e => e.Id == vaga.Id);

            _context.Set<Vaga>().Remove(entry);
            _context.SaveChanges();
        }

    }
}
