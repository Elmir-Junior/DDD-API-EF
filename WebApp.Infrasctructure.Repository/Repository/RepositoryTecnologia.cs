using System.Linq;
using WebApp.Domain.Models;
using WebApp.Infrastructure.Context;
using WebApp.Infrastructure.Interfaces.Repositorys;

namespace WebApp.Infrasctructure.Repository.Repository
{
    public class RepositoryTecnologia : RepositoryBase<Tecnologia>, IRepositoryTecnologia
    {
        private readonly SQLContext _context;
        public RepositoryTecnologia(SQLContext context) : base(context)
        {
            _context = context;
        }

        public override void Remove(Tecnologia tecnologia)
        {
            var entry = _context.Tecnologias.First(e => e.Id == tecnologia.Id);

            _context.Set<Tecnologia>().Remove(entry);
            _context.SaveChanges();
        }
        public override Tecnologia GetById(int id)
        {
            var entry = _context.Tecnologias.First(e => e.Id == id);
            return entry;
        }
    }
}
