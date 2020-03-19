using AutoMapper;
using CotizadorParticular.Aplicacion.Contrato.Servicio;
using CotizadorParticular.Dominio.Entidad;
using CotizadorParticular.Infraestructura.Loggin;
using CotizadorParticular.Nucleo.DTO.RequestDTO;
using CotizadorParticular.Nucleo.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CotizadorParticular.Aplicacion.Servicio.Servicio
{
    public class OperationService : IOperationService
    {

        #region .::Constantes::.
        protected readonly IMapper _mapper;
        //private ILogger _log;
        #endregion

        #region .::Constructor::.
        public OperationService(IMapper Mapper)
        {
            _mapper = Mapper;
            //_log = log;
        }
        #endregion
        public IEnumerable<decimal> OperacionSuma(int Dato1, int Dato2, int Dato3)
        {
            IEnumerable<decimal> prices = new List<decimal>() { Dato1, Dato2, Dato3 };
            decimal discountPercentage = 20;
            var discounted = prices.Select(x => x - x / 100 * discountPercentage).ToList();

            return discounted;
        }
        public IEnumerable<ConsultarClienteResponse> ConsultaClientexDNI(ConsultarClienteRequest objRequest)
        {
            List<Cliente> objCliente = new List<Cliente>();
            Cliente objCliente2 = new Cliente();
            ConsultarClienteResponse objResponse = new ConsultarClienteResponse();

            #region Insertar Clientes

            objCliente.Add(new Cliente
            {
                Id = 1,
                Nombre = "Rafael",
                ApellidoPaterno = "me",
                ApellidoMaterno = "pe",
                DNI = "45770312",
                Edad = 29,
                Informacion1 = "dato1",
                Informacion2 = "dato2",
                Informacion3 = "dato3"
            });

            objCliente.Add(new Cliente
            {
                Id = 2,
                Nombre = "aa",
                ApellidoPaterno = "me",
                ApellidoMaterno = "oo.",
                DNI = "46770334",
                Edad = 28,
                Informacion1 = "aaa",
                Informacion2 = "dato2",
                Informacion3 = "dato3"
            });

            objCliente.Add(new Cliente
            {
                Id = 3,
                Nombre = "martin",
                ApellidoPaterno = "fuxion",
                ApellidoMaterno = "bitcoin",
                DNI = "46770356",
                Edad = 28,
                Informacion1 = "hace hora",
                Informacion2 = "dato2",
                Informacion3 = "dato3"
            });

            #endregion
            //try
            //{
            objCliente2 = objCliente.Find(x => x.DNI.Equals(objRequest.DNI));
            objResponse = _mapper.Map<ConsultarClienteResponse>(objCliente2);
            //}
            //catch (Exception ex)
            //{
            //    _log.Error(ex.Message, ex);
            //    yield break;
            //}

            yield return objResponse;

        }
        public IEnumerable<ConsultarClienteResponse> ObtenerClientes()
        {
            List<Cliente> objCliente = new List<Cliente>();
            Cliente objCliente2 = new Cliente();
            ConsultarClienteResponse objResponse = new ConsultarClienteResponse();

            #region Insertar Clientes

            objCliente.Add(new Cliente
            {
                Id = 1,
                Nombre = "Rafael",
                ApellidoPaterno = "me",
                ApellidoMaterno = "pe",
                DNI = "45770312",
                Edad = 29,
                Informacion1 = "dato1",
                Informacion2 = "dato2",
                Informacion3 = "dato3"
            });

            objCliente.Add(new Cliente
            {
                Id = 2,
                Nombre = "aa",
                ApellidoPaterno = "me",
                ApellidoMaterno = "oo.",
                DNI = "46770334",
                Edad = 28,
                Informacion1 = "aaa",
                Informacion2 = "dato2",
                Informacion3 = "dato3"
            });

            objCliente.Add(new Cliente
            {
                Id = 3,
                Nombre = "martin",
                ApellidoPaterno = "fuxion",
                ApellidoMaterno = "bitcoin",
                DNI = "46770356",
                Edad = 28,
                Informacion1 = "hace hora",
                Informacion2 = "dato2",
                Informacion3 = "dato3"
            });

            #endregion
            //try
            //{
            objCliente2 = objCliente.Find(x => x.DNI.Equals("46770356"));
            objResponse = _mapper.Map<ConsultarClienteResponse>(objCliente2);
            //objResponse = objCliente;
            //}
            //catch (Exception ex)
            //{
            //    _log.Error(ex.Message, ex);
            //    yield break;
            //}

            yield return objResponse;

        }
    }
}
