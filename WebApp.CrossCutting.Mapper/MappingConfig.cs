using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Application.DTO.DTO;
using WebApp.Domain.Models;

namespace WebApp.CrossCutting.Mapper
{
    public class MappingConfig
    {
        public static MapperConfiguration registerMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<Tecnologia, TecnologiaDTO>();
                    config.CreateMap<Vaga, VagaDTO>();
                    config.CreateMap<Candidato, CandidatoDTO>();

                    config.CreateMap<TecnologiaDTO, Tecnologia>();
                    config.CreateMap<VagaDTO, Vaga>();
                    config.CreateMap<CandidatoDTO, Candidato>();

                }
                );
            return mappingConfig;
        }
    }
}
