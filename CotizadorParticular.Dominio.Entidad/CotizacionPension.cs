using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class CotizacionPension
    {
		public decimal NumeroGrupo { get; set; }
        public decimal NumeroCotizacion { get; set; }
        public decimal NumeroBeneficiario { get; set; }
        public decimal PorcentajeBeneficio { get; set; }
        public decimal MontoPension { get; set; }
        public decimal CRU { get; set; }
        public decimal EdadAnual { get; set; }
        public decimal EdadMensual { get; set; }
        public string CodigoTMPension { get; set; }
        public string CodigoTMReserva { get; set; }
        public decimal PorcentajeBeneficioAFP { get; set; }
        public decimal MontoPensionAFP { get; set; }
        public decimal CRUAFP { get; set; }

        public string CodigoTFMejora { get; set; }
        public decimal PorcentajeExperiencia { get; set; }
        public string CodigoTFMPension { get; set; }
        public decimal PorcentajePension { get; set; }
        public string CodigoTMReservaOficial { get; set; }
        public string CodigoTFMReservaOficial { get; set; }
        public decimal PorcentajeReservaOficial { get; set; }
    }
}
