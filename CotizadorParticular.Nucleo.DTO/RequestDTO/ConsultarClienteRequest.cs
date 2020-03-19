using CotizadorParticular.Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Nucleo.DTO.RequestDTO
{
    public class ConsultarClienteRequest
    {
        public string DNI { get; set; }
        public string Parametros { get; set; }

        public List<Parametro> lstParametro  { get; set;}
        public List<Parametro_Producto_PV> lstParametroPV { get; set; }
        public List<Parametro_Cotizador> lstParametroCotizador { get; set; }
        //public List<ConsultarClienteRequest> lstparam { get; set; }
    }
}
