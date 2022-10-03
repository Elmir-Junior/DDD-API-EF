using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Domain.Models.Entity;

namespace WebApp.Domain.Models
{
    public class Candidato:Base
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public IEnumerable<Vaga> VagasCadastradas { get; set; }
        public IEnumerable<Tecnologia> TecnologiasCadastradas { get; set; }
    }
}
