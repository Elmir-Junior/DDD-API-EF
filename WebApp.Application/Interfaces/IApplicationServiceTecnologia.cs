using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Application.DTO.DTO;

namespace WebApp.Application.Interfaces
{
    public interface IApplicationServiceTecnologia
    {
        void Add(TecnologiaDTO tecnologiaDTO);
        TecnologiaDTO GetById(int id);
        IEnumerable<TecnologiaDTO> GetAll();
        void Update(TecnologiaDTO tecnologiaDTO);
        void Remove(TecnologiaDTO tecnologiaDTO);
    }
}
