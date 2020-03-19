using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class Anexo3
    {
        public decimal NumeroGrupo { get; set; }
        public decimal NumeroCotizacion { get; set; }
        public string FechaCalculoAdelanto { get; set; }
        public int Ano { get; set; }
        public decimal MontoMaximo { get; set; }
        public decimal MontoMaximoPension { get; set; }
        public decimal MontoMaximoDevolucion { get; set; }
        public decimal MontoMinimo { get; set; }
        public decimal MontoMinimoPension { get; set; }
        public decimal MontoMinimoDevolucion { get; set; }
    }
}
