using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Models;

namespace WebApp.Infrastructure.Context
{
    public class SQLContext:DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }
        
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
    }
}
