using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using CotizadorParticular.Aplicacion.Contrato.Servicio;
using CotizadorParticular.Nucleo.DTO.ResponseDTO;
using CotizadorParticular.Nucleo.DTO.RequestDTO;
using AutoMapper;
using CotizadorParticular.Infraestructura.Loggin;
using System;
using Microsoft.Extensions.Logging;
using CotizadorParticular.Dominio.Entidad;

namespace CotizadorParticular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        #region .::Constantes::.
        protected readonly IOperationService Operationservice;
        private readonly IMapper _mapper;
        private readonly ILogger<OperationController> _logger;
        private MyService _myService;
        private ConsultarClienteRequest _paramPrueba;

        //private ILogger _log;
        public OperationController(IOperationService _operationservice, IMapper mapper, ILogger<OperationController> logger,
                                    MyService myService, ConsultarClienteRequest paramPrueba)
        {
            Operationservice = _operationservice;
            _mapper = mapper;
            _logger = logger;
            _myService = myService;
            _paramPrueba = paramPrueba;
            //_myParametro = myParametro;
            //_log = log;
        }
        #endregion


        #region Base
        // GET: api/Operation
        [HttpGet]
        public IEnumerable<string> Get()
        {
            /*_myService.Message = "Hola Mundo";
            return new string[] { _myService.Message };*/
            var resultado = new string[] { _myService.Message };
            _myService.Message = "Hola Mundo";
            return resultado;
        }

        // GET: api/Operation/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Operation
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Operation/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion


        // GET: api/Operation
        //[HttpGet]
        [HttpGet]
        [Route("Suma")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IEnumerable<decimal> Sumar()
        {
            var result = Operationservice.OperacionSuma(4, 5, 6);
            return result;
        }

        [HttpPost]
        [Route("ConsultarCliente")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IEnumerable<ConsultarClienteResponse> ConsultarClientexDni([FromBody] ConsultarClienteRequest objRequest)
        {

            // var resultado = new string[] { _clienteService.DNI };
            //objRequest.DNI

            //var resultado = new ConsultarClienteResponse();
            if (objRequest.Parametros != null)
            {
                var result = Operationservice.ConsultaClientexDNI(objRequest);
                return result;
                //resultado = Operation service.ConsultaClientexDNI(objRequest);
            }
            else
            {
                var result = Operationservice.ObtenerClientes();
                return result;
            }
            /*try
            {*/

            /*}
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host builder error");

                throw;
            }*/
            //finally
            //{
            //    Log.CloseAndFlush();
            //}

        }


        [HttpPost]
        [Route("ConsultaPrueba")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IEnumerable<string> PruebaCliente([FromBody] ConsultarClienteRequest objRequest)
        {
            /*_myService.Message = "Hola Mundo";
            return new string[] { _myService.Message };*/
            if (objRequest.Parametros != null)
            {
                _myService.Message = objRequest.DNI;
            }
            //else
            //{
            //    //_myService.Message = objRequest.DNI;
            //    var resultado = new string[] { _myService.Message };
            //    return resultado;
            //}
            var resultado = new string[] { _myService.Message };
            return resultado;
            //_myService.Message = objRequest.DNI;

        }
        [HttpGet]
        [Route("Pruebas2")]
        public IEnumerable<string> PruebaList([FromBody] ConsultarClienteRequest objReq)
        {
            string resul = "";

            if (objReq.Parametros != null)
            {

                var parametros = new List<Parametro>();
                objReq.lstParametro.ForEach(objReq =>
                {
                    Parametro param = new Parametro();
                    param.CodigoTabla = objReq.CodigoTabla;
                    param.Descripcion = objReq.Descripcion;
                    param.CodigoParametro = objReq.CodigoParametro;
                    param.ValorNumerico = objReq.ValorNumerico;
                    param.FechaInicioVigencia = objReq.FechaInicioVigencia;
                    param.ValorAlfanumerico = objReq.ValorAlfanumerico;
                    parametros.Add(param);
                });
                _paramPrueba.lstParametro = parametros;
                //_paramPrueba.lstParametro = parametros;
                resul = _paramPrueba.lstParametro[0].Descripcion + " " + _paramPrueba.lstParametro[1].Descripcion + " " + _paramPrueba.lstParametro[2].Descripcion;
                List<Parametro_Producto_PV> parametropv = new List<Parametro_Producto_PV>();
                objReq.lstParametroPV.ForEach(objReq =>
                {
                    Parametro_Producto_PV prmPV = new Parametro_Producto_PV();
                    prmPV.CodigoTabla = objReq.CodigoTabla;
                    prmPV.Codigo_producto_pv = objReq.Codigo_producto_pv;
                    prmPV.FechaInicioVigencia = objReq.FechaInicioVigencia;
                    prmPV.ValorNumericoSoles = objReq.ValorNumericoSoles;
                    prmPV.ValorNumericoSolesReajustados = objReq.ValorNumericoSolesReajustados;
                    prmPV.ValorNumerico = objReq.ValorNumerico;
                    prmPV.ValorNumericoDolaresReajustados = objReq.ValorNumericoDolaresReajustados;
                    prmPV.ValorNumericoSolesNominales = objReq.ValorNumericoSolesNominales;
                    prmPV.DuracionProductoBasicoDesde = objReq.DuracionProductoBasicoDesde;
                    prmPV.DuracionProductoBasicoHasta = objReq.DuracionProductoBasicoHasta;
                    parametropv.Add(prmPV);
                });
                _paramPrueba.lstParametroPV = parametropv;
                List<Parametro_Cotizador> prmCoti = new List<Parametro_Cotizador>();
                objReq.lstParametroCotizador.ForEach(objReq =>
                {
                    Parametro_Cotizador prmCo = new Parametro_Cotizador();
                    prmCo.CodigoTabla = objReq.CodigoTabla;
                    prmCo.Codigo_producto_pv = objReq.Codigo_producto_pv;
                    prmCo.FechaInicioVigencia = objReq.FechaInicioVigencia;
                    prmCo.ValorNumericoSoles = objReq.ValorNumericoSoles;
                    prmCo.ValorNumericoSolesReajustados = objReq.ValorNumericoSolesReajustados;
                    prmCo.ValorNumerico = objReq.ValorNumerico;
                    prmCo.ValorNumericoDolaresReajustados = objReq.ValorNumericoDolaresReajustados;
                    prmCo.ValorNumericoSolesNominales = objReq.ValorNumericoSolesNominales;
                    prmCo.DuracionProductoBasicoDesde = objReq.DuracionProductoBasicoDesde;
                    prmCo.DuracionProductoBasicoHasta = objReq.DuracionProductoBasicoHasta;
                    prmCoti.Add(prmCo);
                });
                _paramPrueba.lstParametroCotizador = prmCoti;
            }

            else
            {
                resul = _paramPrueba.lstParametro[0].Descripcion + " " + _paramPrueba.lstParametro[1].Descripcion + " " + _paramPrueba.lstParametro[2].Descripcion;
            }

            yield return resul;
        }

        [HttpGet]
        [Route("PruebaObtener")]
        public IEnumerable<AnexosResponse> ObtenerAnexos()
        {
            var anexos = new AnexosResponse();

            #region Anexo1
            var ListAnexo1 = new List<Anexo1>();
            var anexo1 = new Anexo1();
            anexo1.NumeroCotizacion = 5674;
            anexo1.NumeroGrupo = 8733;
            anexo1.PensionAjustada = 234;
            ListAnexo1.Add(anexo1);
            #endregion

            #region Anexo3
            var ListAnexo3 = new List<Anexo3>();
            var anexi03 = new Anexo3();
            anexi03.NumeroCotizacion = 1233;
            anexi03.NumeroGrupo = 321;
            anexi03.FechaCalculoAdelanto = DateTime.Now.ToString();
            ListAnexo3.Add(anexi03);
            #endregion

            #region Anexo4
            var ListAnexo4 = new List<Anexo4>();
            var anexo4 = new Anexo4();
            anexo4.MontoMaximo = 4;
            anexo4.NumeroGrupo = 1;
            anexo4.NumeroCotizacion = 123;
            ListAnexo4.Add(anexo4);
            #endregion

            anexos.ListAnexo1 = ListAnexo1;
            anexos.ListAnexo3 = ListAnexo3;
            anexos.ListAnexo4 = ListAnexo4;


            yield return anexos;
        }

        [HttpGet]
        [Route("EnvioCotizacion")]
        public IEnumerable<string> ObtenerDatos([FromBody] CotizacionParticularRequest objCotizacion)
        {

            string resultado;

            if (objCotizacion.NumeroCotizacion != 0)
                resultado = "ok";
            else
                resultado = "nulo";

            yield return resultado;
        }
    }
}
