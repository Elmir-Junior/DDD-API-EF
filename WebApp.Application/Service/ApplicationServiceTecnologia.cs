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
    public class ApplicationServiceTecnologia : IApplicationServiceTecnologia
    {
        readonly IMapper _mapper;
        readonly IServiceTecnologia _serviceTecnologia;

        public ApplicationServiceTecnologia(IServiceTecnologia serviceTecnologia, IMapper mapper)
        {
            _mapper = mapper;
            _serviceTecnologia = serviceTecnologia;
        }

        public void Add(TecnologiaDTO tecnologiaDTO)
        {
            _serviceTecnologia.Add(_mapper.Map<Tecnologia>(tecnologiaDTO));
        }

        public IEnumerable<TecnologiaDTO> GetAll()
        {
            var candidatodto = _serviceTecnologia.GetAll();
            return _mapper.Map<List<TecnologiaDTO>>(candidatodto);
        }

        public TecnologiaDTO GetById(int id)
        {
            var tecnologia = _serviceTecnologia.GetById(id);
            return _mapper.Map<TecnologiaDTO>(tecnologia);
        }

        public void Remove(TecnologiaDTO tecnologiaDTO)
        {
            var obj = _mapper.Map<Tecnologia>(tecnologiaDTO);
            _serviceTecnologia.Remove(obj);
        }

        public void Update(TecnologiaDTO tecnologiaDTO)
        {
            _serviceTecnologia.Update(_mapper.Map<Tecnologia>(tecnologiaDTO));
        }
    }
}
