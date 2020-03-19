using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class Anexo4
    {
        public decimal NumeroGrupo { get; set; }
        public decimal NumeroCotizacion { get; set; }
        public string FechaCalculoAdelanto { get; set; }
        public int Ano { get; set; }
        public decimal MontoMaximo { get; set; }
        public decimal MontoMaximoPagoDotal { get; set; }
        public decimal MontoMinimo { get; set; }
        public decimal MontoMinimoPagoDotal { get; set; }
    }
}
