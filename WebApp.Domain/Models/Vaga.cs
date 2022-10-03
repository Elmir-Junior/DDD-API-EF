using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Domain.Models.Entity;

namespace WebApp.Domain.Models
{
    public class Vaga:Base
    {
        public string Nome { get; set; }
        public int Ponto { get; set; }
    }
}
