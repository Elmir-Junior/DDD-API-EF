using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Models;

namespace WebApp.ApplicationPresentation.Service
{
    public class ServiceApiVaga:ServiceApi<Vaga>
    {
        public IEnumerable<Vaga> GetVagas()
        {
            return GetAll("/Api/Vagas/");
        }

        public Vaga getById(int id)
        {
            return GetById("/Api/Vagas/", id);
        }

        public bool Put(Vaga vaga)
        {
            return Put("/Api/Vagas/", vaga);
        }

        public bool Post(Vaga vaga)
        {
            return Post("/Api/Vagas/", vaga);
        }
        public bool Delete(int id)
        {
            return Delete("/Api/Vagas/Delete/" + id);
        }
    }
}
