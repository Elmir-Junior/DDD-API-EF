using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Application.DTO.DTO;
using WebApp.Domain.Models;

namespace WebApp.ApplicationPresentation.Service
{
    public class ServiceApiTecnologia:ServiceApi<Tecnologia>
    {

        public IEnumerable<Tecnologia> GetTecnologias()
        {
            return GetAll("/Api/Tecnologia/");
        }

        public Tecnologia getById(int id)
        {
            return GetById("/Api/Tecnologia/",id);
        }

        public bool Put(Tecnologia tecnologia)
        {
            return Put("/Api/Tecnlogia/", tecnologia);
        }

        public bool Post(Tecnologia tecnologia)
        {
            return Post("/Api/Tecnologia/", tecnologia);
        }
        public bool Delete(int id)
        {
            return Delete("/Api/Tecnologia/Delete/" + id);
        }
    }
}
