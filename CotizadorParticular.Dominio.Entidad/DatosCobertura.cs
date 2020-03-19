using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class DatosCobertura
    {
        public int TipoCobertura { get; set; }
        public int PorcentajeCobertura { get; set; }
        public int PeriodoCobertura { get; set; }
        public decimal MontoCobertura { get; set; }
        public int MonedaCobertura { get; set; }
        public string TablaMortalidadMuerte { get; set; }
        public string TablaFactorMejoraMuerte { get; set; }
        public decimal PorcentajeMejoraMuerte { get; set; }
        public string TablaMortalidadSob { get; set; }
        public string TablaFactorMejoraSob { get; set; }
        public decimal PorcentajeMejoraSob { get; set; }
        public decimal TasaReservAnualCobertura { get; set; }

    }
}
