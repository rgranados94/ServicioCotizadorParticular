using AutoMapper;
using CotizadorParticular.Dominio.Entidad;
using CotizadorParticular.Nucleo.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Infraestructura.AutoMapper
{
    public class MapperInstance : Profile
    {
        public MapperInstance()
        {
            CreateMap<Cliente, ConsultarClienteResponse>();
            CreateMap<ConsultarClienteResponse, Cliente>();
            //CreateMap<cli>

        }

    }
}
