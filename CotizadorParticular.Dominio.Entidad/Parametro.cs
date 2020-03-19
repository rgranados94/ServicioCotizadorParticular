using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class Parametro
    {

        public string CodigoTabla { get; set; }
        public string Descripcion { get; set; }
        public string CodigoParametro { get; set; }
        public decimal ValorNumerico { get; set; }
        public string ValorAlfanumerico { get; set; }
        public string FechaInicioVigencia { get; set; }
    }
    public class Parametro_Producto_PV
    {
        public string CodigoTabla { get; set; }
        public string Codigo_producto_pv { get; set; }
        public string FechaInicioVigencia { get; set; }
        public decimal ValorNumericoSoles { get; set; }
        public decimal ValorNumericoSolesReajustados { get; set; }
        public decimal ValorNumerico { get; set; }
        public decimal ValorNumericoDolaresReajustados { get; set; }
        public decimal ValorNumericoSolesNominales { get; set; }
        public int DuracionProductoBasicoDesde { get; set; }
        public int DuracionProductoBasicoHasta { get; set; }
    }
     public class Parametro_Cotizador
    {
        public string CodigoTabla { get; set; }
        public string Codigo_producto_pv { get; set; }
        public string FechaInicioVigencia { get; set; }
        public decimal ValorNumericoSoles { get; set; }
        public decimal ValorNumericoSolesReajustados { get; set; }
        public decimal ValorNumerico { get; set; }
        public decimal ValorNumericoDolaresReajustados { get; set; }
        public decimal ValorNumericoSolesNominales { get; set; }
        public int DuracionProductoBasicoDesde { get; set; }
        public int DuracionProductoBasicoHasta { get; set; }
    }
}
