using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Models;

namespace WebApp.ApplicationPresentation.Models.ViewModels.Candidato
{
    public class CandidatoCreateViewModel
    {
        public CandidatoCreateViewModel()
        {

        }
        public CandidatoCreateViewModel(int id, string nome, int idade, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Email = email;
        }

        public CandidatoCreateViewModel(IEnumerable<Tecnologia> tecnologias, IEnumerable<Vaga> vagas)
        {
            this.VagasCadastradas = vagas;
            this.TecnologiasCadastradas = tecnologias;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public IEnumerable<int> IdVagas { get; set; }
        public IEnumerable<int> IdTecnologias { get; set; }

        public IEnumerable<Vaga> VagasCadastradas { get; set; }
        public IEnumerable<Tecnologia> TecnologiasCadastradas { get; set; }

        public int qtdVagas => IdVagas == null ? 0 : IdVagas.Count();
        public int qtdTecnologias => IdTecnologias == null ? 0 : IdTecnologias.Count();
    }
}
