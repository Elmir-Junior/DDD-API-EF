using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Models;

namespace WebApp.ApplicationPresentation.Models.ViewModels.Candidato
{
    public class CandidatoIndexViewModel
    {
        public CandidatoIndexViewModel()
        {

        }

        public CandidatoIndexViewModel(int id, string nome, int idade, string email, IEnumerable<Vaga> vagasCadastradas, IEnumerable<Tecnologia> tecnologiasCadastradas)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade= idade;
            this.Email = email;
            this.qtdVagas = vagasCadastradas == null ? 0 : vagasCadastradas.Count();
            this.qtdTecnologias = tecnologiasCadastradas == null ? 0 : tecnologiasCadastradas.Count();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public int qtdVagas { get; set; }
        public int qtdTecnologias { get; set; }
    }
}
