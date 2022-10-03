using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Application.DTO.DTO;

namespace WebApp.Application.Interfaces
{
    public interface IApplicationServiceVaga
    {
        void Add(VagaDTO vagaDTO);
        VagaDTO GetById(int id);
        IEnumerable<VagaDTO> GetAll();
        void Update(VagaDTO vagaDTO);
        void Remove(VagaDTO vagaDTO);
    }
}
