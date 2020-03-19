using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Nucleo.DTO.RequestDTO
{
    public class CotizacionParticularRequest
    {
        public int NumeroGrupo { get; set; }
        public int NumeroCotizacion { get; set; }
        public string AuditoriaAutorizacion { get; set; }
        public int NivelAutorizacion { get; set; }
        public string NumeroCorrelativoCotizacion { get; set; }
        public string Moneda { get; set; }
        public int ModalidadCalculo { get; set; }
        public int TasaVentaAnualObj { get; set; }
        public decimal TasaInternaRetornoAnualObj { get; set; }
        public decimal MontoPensionObj { get; set; }
        public decimal TasaVentaAnual { get; set; }
        public decimal TasaRentabilidadAFPAnual { get; set; }
        public decimal TotalCRUAFP { get; set; }
        public decimal TotalCRUDevengado { get; set; }
        public decimal TotalCRU { get; set; }
        public decimal MontoGastosSepelio { get; set; }
        public decimal MontoCapitalTransferir { get; set; }
        public decimal MontoPensionAFP { get; set; }
        public decimal MontoPensionPV { get; set; }
        public decimal TasaReservaAnual { get; set; }
        public decimal PorcentajeMargenSolvencia { get; set; }
        public decimal TasaInversionAnual { get; set; }
        public decimal TasaReinversionAnual { get; set; }
        public decimal PeriodoInversionAnos { get; set; }
        public decimal DurationActivoAnos { get; set; }
        public decimal PorcentajeGastosAdquisicion { get; set; }
        public decimal MontoMinimoGastosAdquisicion { get; set; }
        public decimal MontoMaximoGastosAdquisicion { get; set; }
        public decimal MontoGastosMantenimientoAnual { get; set; }
        public decimal PorcentajeComision { get; set; }
        public decimal TasaImpuestoRenta { get; set; }
        public decimal DurationPasivoAnos { get; set; }
        public decimal MontoPrimaVPFlujosPension { get; set; }
        public decimal ExcesoDurationAnos { get; set; }
        public decimal TasaInternaRetornoAnual { get; set; }
        public decimal PorcentajeAporteReserva { get; set; }
        public decimal PorcentajeAporteCapital { get; set; }
        public decimal RatioPerdidaContable { get; set; }
        public int Estado { get; set; }
        public string AuditoriaAprobacion { get; set; }
        public string AuditoriaCreacion { get; set; }
        public string AuditoriaModificacion { get; set; }
        public decimal TotalCRUGastosSepelioAFP { get; set; }
        public decimal TotalCRUGastosSepelioPV { get; set; }
        public decimal TotalCRUGastosSepelio { get; set; }
        public decimal MontoPensionBase { get; set; }
        public decimal TasaReservaPensionAnual { get; set; }
        public decimal TasaReservaGastosSepelioAnual { get; set; }
        public decimal TasaMercadoAnual { get; set; }
        public decimal TasaAnclajeAnual { get; set; }
        public decimal FactorSeguridad { get; set; }
        public int IndicesCobertura { get; set; }
        public string FechaCotizacionReal { get; set; }
        public decimal MontoPensionBaseSBS { get; set; }
        public decimal MontoPensionGarantizada { get; set; }
        public decimal TasaVentaRealAnual { get; set; }
        public decimal MontoPensionBaseSBSAFP { get; set; }
        public string Spread { get; set; }
        public string ParticionCapital { get; set; }
        public int PorcentajeParticionCapitalDolares { get; set; }
        public int PorcentajeParticionCapitalSoles { get; set; }
        public string MotivoRechazoCotizacion { get; set; }
        public int TipoAjustePension { get; set; }
        public decimal TasaFijaAjustePensionAnual { get; set; }
        public int NumeroMesesPeriodoAjustePension { get; set; }
        public string TipoPeriodoAjustePension { get; set; }
        public int NumeroModalidad { get; set; }
        public string MontoPrimaDevolver { get; set; }
        public string TasaReservaDevolucionPrima { get; set; }
        public string TasaReservaDevolucionPrimaRef { get; set; }
        public string TasaReservaSepelioRef { get; set; }
        public string MontoRecalculoGastoMantenimiento { get; set; }
        public string TasaRecalculoReservaInicialPension { get; set; }
        public string TasaRecalculoReservaInicialDevolucion { get; set; }
        public string TasaRecalculoReservaInicialGastoSepelio { get; set; }
        public string TasaRecalculoInversion { get; set; }
        public string TasaRecalculoReinversion { get; set; }
        public string TasaLibreRiesgo { get; set; }
        public string TasaVentaPromedio { get; set; }
        public string TasaInversionNIIF { get; set; }
        public string TasaReinversionNIIF { get; set; }
        public string FactorSeguridadNIIF { get; set; }
        public string TasaRecalculoReservaBMARef { get; set; }
        public string PorcentajeGastosMantenimiento { get; set; }
        public string TasaReservaSeguroVida { get; set; }
        public string TasaReservaSeguroVidaRef { get; set; }
        public string TasaReservaBMA { get; set; }
        public string TasaReservaBMARef { get; set; }
        public decimal SumaAseguradaSeguroVida { get; set; }
        public decimal SumaAseguradaBMA { get; set; }
        public string MontoPrimaSepelio { get; set; }
        public string MontoPrimaSeguroVida { get; set; }
        public string MontoPrimaBMA { get; set; }
        public string TotalCRUSeguroVida { get; set; }
        public string TotalCRUBMA { get; set; }
        public List<ModalidadRequest>  listModalidades { get; set; }

    }
}
