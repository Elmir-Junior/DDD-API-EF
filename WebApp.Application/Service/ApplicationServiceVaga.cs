using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Application.DTO.DTO;
using WebApp.Application.Interfaces;
using WebApp.Domain.Models;
using WebApp.Services.Interfaces;

namespace WebApp.Application.Service
{
    public class ApplicationServiceVaga : IApplicationServiceVaga
    {
        readonly IServiceVaga _serviceVaga;
        readonly IMapper _mapper;


        public ApplicationServiceVaga(IServiceVaga serviceVaga, IMapper mapper)
        {
            _serviceVaga = serviceVaga;
            _mapper = mapper;
        }

        public void Add(VagaDTO vagaDTO)
        {
            var vagadto = _mapper.Map<Vaga>(vagaDTO);
            _serviceVaga.Add(vagadto);
        }

        public IEnumerable<VagaDTO> GetAll()
        {
            var vagas = _serviceVaga.GetAll();
            return _mapper.Map<List<VagaDTO>>(vagas);
        }

        public VagaDTO GetById(int id)
        {
            var vaga = _serviceVaga.GetById(id);
            return _mapper.Map<VagaDTO>(vaga);
        }

        public void Remove(VagaDTO vagaDTO)
        {
            _serviceVaga.Remove(_mapper.Map<Vaga>(vagaDTO));
        }

        public void Update(VagaDTO vagaDTO)
        {
            _serviceVaga.Update(_mapper.Map<Vaga>(vagaDTO));
        }
    }
}
