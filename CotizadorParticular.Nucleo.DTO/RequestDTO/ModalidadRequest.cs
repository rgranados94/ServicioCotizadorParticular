using CotizadorParticular.Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Nucleo.DTO.RequestDTO
{
    public class ModalidadRequest
    {
        public int NumeroCotizacion { get; set; }
        public string FechaDevengue { get; set; }
        public decimal MontoPension { get; set; }
        public int PeriodoPension { get; set; }
        public int PeriodoGarantizadoAnos { get; set; }
        public int PeriodoEscalonadoAnos { get; set; }
        public int PocentajeEscalonado { get; set; }
        public int MonedaPension { get; set; }
        public bool SepelioTemporal { get; set; }
        public TipoAjuste TipoAjuste { get; set; }
        public decimal MontoMaximoSepelio { get; set; }
        public int MonedaSepelio { get; set; }
        public int MontoGastoMantenimiento { get; set; }
        public List<Persona> ListPersonas { get; set; }
        public List<DatosCobertura> ListDatosCobertura { get; set; }
    }
}
