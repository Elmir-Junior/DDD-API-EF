using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.ApplicationPresentation.Models.ViewModels;
using WebApp.ApplicationPresentation.Models.ViewModels.Candidato;
using WebApp.Domain.Models;

namespace WebApp.ApplicationPresentation.Service
{
    public class ServiceApiCandidato : ServiceApi<Candidato>
    {
        readonly ServiceApiTecnologia _serviceApiTecnologia;
        readonly ServiceApiVaga _serviceApiVaga;

        public ServiceApiCandidato()
        {

        }

        public ServiceApiCandidato(ServiceApiTecnologia serviceApiTecnologia, ServiceApiVaga serviceApiVaga)
        {
            _serviceApiTecnologia = serviceApiTecnologia;
            _serviceApiVaga = serviceApiVaga;
        }

        public IEnumerable<CandidatoIndexViewModel> GetAll()
        {
            var obj = GetAll("/Api/Candidato/");
            IList<CandidatoIndexViewModel> candidatoViewModels = new List<CandidatoIndexViewModel>();
            obj.ToList().ForEach(a => candidatoViewModels.Add(new CandidatoIndexViewModel(a.Id.Value, a.Nome, a.Idade, a.Email, a.VagasCadastradas, a.TecnologiasCadastradas)));
            return candidatoViewModels;
        }

        public Candidato getById(int id)
        {
            return GetById("/Api/Candidato/", id);
        }

        public bool Put(Candidato candidato)
        {
            return Put("/Api/Candidato/Put", candidato);
        }

        public bool Post(Candidato candidato)
        {
            return Post("/Api/Candidato/Post", candidato);
        }
        public bool Delete(int id)
        {
            return Delete("/Api/Candidato/Delete/" + id);
        }
        public CandidatoCreateViewModel CandidatoCreate()
        {
            var obj = new CandidatoCreateViewModel(_serviceApiTecnologia.GetTecnologias(), _serviceApiVaga.GetVagas());

            return obj;
        }

        public Candidato CandidatoCreate(CandidatoCreateViewModel candidatoCreateView)
        {
            IList<Tecnologia> tecnologias = new List<Tecnologia>();
            IList<Vaga> vagas = new List<Vaga>();

            if (candidatoCreateView.qtdTecnologias > 0)
            {
                candidatoCreateView.IdTecnologias.ToList().ForEach(a => tecnologias.Add(_serviceApiTecnologia.getById(a)));
            }

            if (candidatoCreateView.qtdVagas > 0)
            {
                candidatoCreateView.IdVagas.ToList().ForEach(a => vagas.Add(_serviceApiVaga.getById(a)));
            }


            var obj = new Candidato
            {
                Email = candidatoCreateView.Email,
                Nome = candidatoCreateView.Nome,
                Idade = candidatoCreateView.Idade,
                TecnologiasCadastradas = tecnologias.ToList(),
                VagasCadastradas = vagas.ToList()
            };
            return obj;
        }
    }
}
