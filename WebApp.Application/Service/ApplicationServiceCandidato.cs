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
    public class ApplicationServiceCandidato : IApplicationServiceCandidato
    {
        readonly IServiceCandidato _serviceCandidato;
        readonly IMapper _mapper;

        public ApplicationServiceCandidato(IServiceCandidato serviceCandidato, IMapper mapper)
        {
            _serviceCandidato = serviceCandidato;
            _mapper = mapper;
        }

        public void Add(CandidatoDTO candidatoDTO)
        {
            var candidatodto = _mapper.Map<Candidato>(candidatoDTO);
            _serviceCandidato.Add(candidatodto);
        }

        public IEnumerable<CandidatoDTO> GetAll()
        {
            var candidato = _serviceCandidato.GetAll();
            return _mapper.Map<List<CandidatoDTO>>(candidato);
        }

        public CandidatoDTO GetById(int id)
        {
            var candidato = _serviceCandidato.GetById(id);
            return _mapper.Map<CandidatoDTO>(candidato);
        }

        public void Remove(CandidatoDTO candidatoDTO)
        {
            _serviceCandidato.Remove(_mapper.Map<Candidato>(candidatoDTO));
        }

        public void Update(CandidatoDTO candidatoDTO)
        {
            _serviceCandidato.Update(_mapper.Map<Candidato>(candidatoDTO));
        }
    }
}
