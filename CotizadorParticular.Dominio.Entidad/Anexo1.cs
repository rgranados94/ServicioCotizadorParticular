using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class Anexo1
    {
        public decimal NumeroGrupo { get; set; }
        public decimal NumeroCotizacion { get; set; }
        public int Periodo { get; set; }
        public decimal BeneficioFallecimiento { get; set; }
        public decimal ValorRescate { get; set; }
        public decimal ReservaPrimaRecalculo { get; set; }
        public decimal TasaReservaDevolucionPrima { get; set; }
        public decimal TasaReservaSeguroVidaFijo { get; set; }
        public decimal TasaReservaValorRescate { get; set; }
        public string FechaProyeccion { get; set; }
        public decimal PensionNominal { get; set; }
        public decimal PagoDotalMinimoCotizacionNominal { get; set; }
        public decimal TasaVentaCotizacionNominal { get; set; }
        public decimal EstadoCotizacionNominal { get; set; }
        public decimal PensionAjustada { get; set; }
        public decimal PagoDotalMinimoCotizacionAjustada { get; set; }
        public decimal TasaVentaCotizacionAjustada { get; set; }
        public decimal EstadoCotizacionAjustada { get; set; }
        public decimal TasaReservaSeguroVidaVariable { get; set; }
        public decimal TasaReservaBeneficioMuerteAccidental { get; set; }
    
    }
}
