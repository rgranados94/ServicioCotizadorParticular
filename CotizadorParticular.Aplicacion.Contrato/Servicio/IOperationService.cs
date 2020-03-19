using CotizadorParticular.Nucleo.DTO.RequestDTO;
using CotizadorParticular.Nucleo.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Aplicacion.Contrato.Servicio
{
    public interface IOperationService
    {
        IEnumerable<decimal> OperacionSuma(int Dato1, int Dato2, int Dato3);
        IEnumerable<ConsultarClienteResponse> ConsultaClientexDNI(ConsultarClienteRequest objRequest);
        IEnumerable<ConsultarClienteResponse> ObtenerClientes();
    }
}
