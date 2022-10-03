using System.Linq;
using WebApp.Domain.Models;
using WebApp.Infrastructure.Context;
using WebApp.Infrastructure.Interfaces.Repositorys;

namespace WebApp.Infrasctructure.Repository.Repository
{
    public class RepositoryCandidato : RepositoryBase<Candidato>, IRepositoryCandidato
    {
        private readonly SQLContext _context;
        public RepositoryCandidato(SQLContext context) : base(context)
        {
            _context = context;
        }
        public override void Remove(Candidato candidato)
        {
            var entry = _context.Candidatos.First(e => e.Id == candidato.Id);

            _context.Set<Candidato>().Remove(entry);
            _context.SaveChanges();
        }
    }
}
