using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class Cotizacion
    {
        public decimal NumeroGrupo { get; set; }
        public decimal NumeroCotizacion { get; set; }
        public string AuditoriaAutorizacion { get; set; }
        public string NivelAutorizacion { get; set; }
        public decimal NumeroCorrelativoCotizacion { get; set; }
        public string Moneda { get; set; }
        public string ModalidadCalculo { get; set; }
        public decimal TasaVentaAnualObj { get; set; }
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
        public string Estado { get; set; }

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
        public string IndicesCobertura { get; set; }
        public DateTime FechaCotizacionReal { get; set; }

        public decimal MontoPensionBaseSBS { get; set; }
        public decimal MontoPensionGarantizada { get; set; }
        public decimal TasaVentaRealAnual { get; set; }
        public decimal MontoPensionBaseSBSAFP { get; set; }
        public decimal Spread { get; set; }
        
        public string ParticionCapital { get; set; }
        public decimal PorcentajeParticionCapitalDolares { get; set; }
        public decimal PorcentajeParticionCapitalSoles { get; set; }
        public string MotivoRechazoCotizacion { get; set; }
        public string TipoAjustePension { get; set; }
        public decimal TasaFijaAjustePensionAnual { get; set; }
        public int NumeroMesesPeriodoAjustePension { get; set; }
        public string TipoPeriodoAjustePension { get; set; }
        public decimal NumeroModalidad { get; set; }
        
        public decimal MontoPrimaDevolver { get; set; }
        public decimal TasaReservaDevolucionPrima { get; set; }
        public decimal TasaReservaDevolucionPrimaRef { get; set; }
        public decimal TasaReservaSepelioRef { get; set; }
        public decimal MontoRecalculoGastoMantenimiento { get; set; }
        public decimal TasaRecalculoReservaInicialPension { get; set; }
        public decimal TasaRecalculoReservaInicialDevolucion { get; set; }
        public decimal TasaRecalculoReservaInicialGastoSepelio { get; set; }
        public decimal TasaRecalculoInversion { get; set; }
        public decimal TasaRecalculoReinversion { get; set; }
        public decimal TasaLibreRiesgo { get; set; }
        public decimal TasaVentaPromedio { get; set; }
        public decimal TasaInversionNIIF { get; set; }
        public decimal TasaReinversionNIIF { get; set; }
        public decimal FactorSeguridadNIIF { get; set; }
        public decimal TasaRecalculoReservaBMARef { get; set; }
        public decimal PorcentajeGastosMantenimiento { get; set; }
        public decimal TasaReservaSeguroVida { get; set; }
        public decimal TasaReservaSeguroVidaRef { get; set; }
        public decimal TasaReservaBMA { get; set; }
        public decimal TasaReservaBMARef { get; set; }
        public decimal SumaAseguradaSeguroVida { get; set; }
        public decimal SumaAseguradaBMA { get; set; }
        public decimal MontoPrimaSepelio { get; set; }
        public decimal MontoPrimaSeguroVida { get; set; }
        public decimal MontoPrimaBMA { get; set; }
        public decimal TotalCRUSeguroVida { get; set; }
        public decimal TotalCRUBMA { get; set; }

    }
}
