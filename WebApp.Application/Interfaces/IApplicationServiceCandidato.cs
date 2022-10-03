using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Application.DTO.DTO;

namespace WebApp.Application.Interfaces
{
    public interface IApplicationServiceCandidato
    {
        void Add(CandidatoDTO candidatoDTO);
        CandidatoDTO GetById(int id);
        IEnumerable<CandidatoDTO> GetAll();
        void Update(CandidatoDTO candidatoDTO);
        void Remove(CandidatoDTO candidatoDTO);
    }
}
