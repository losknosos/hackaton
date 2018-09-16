using System;
using System.Collections.Generic;

namespace GetStartedDotnet.Models
{
    public partial class Transactions
    {
        public string CodigoEntidad { get; set; }
        public string CentroAltaCuentaTarjeta { get; set; }
        public int SecuenciaTarjeta { get; set; }
        public int? IndicadorNormalCorr { get; set; }
        public string TipoFactura { get; set; }
        public string DescripcionTipoFact { get; set; }
        public string FechaFactura { get; set; }
        public string NoReferenciaFactura { get; set; }
        public string PanTarjetaOperacion { get; set; }
        public int? CodigoMonedaOperacion { get; set; }
        public int? ImporteDivisaOrig { get; set; }
        public int? ImporteFactura { get; set; }
        public int NumeroAutorizacion { get; set; }
        public string CodigoComercio { get; set; }
        public string NombreComercioRedu { get; set; }
        public int? CodigoActividad { get; set; }
        public int? ImporteImpuesto { get; set; }
        public string FecProcEntOperacion { get; set; }
        public int? CodigoPais { get; set; }
        public string PoblacionRealizoOper { get; set; }
        public string FechaContableOperar { get; set; }
        public string OrigenOperacion { get; set; }
        public string TipoFranquicia { get; set; }
        public string SecuenciaOperFranq { get; set; }
        public string NumeroSecuenciaMaest { get; set; }
        public string FechaLiquidacion { get; set; }
        public string IndicadorIncidenEst { get; set; }
        public string LineaReferenciaMov { get; set; }
        public int? NumeroOperCompraCuot { get; set; }
        public int? NumeroTotalCuotas { get; set; }
        public int? ImporteCuota { get; set; }
        public string CodigoTipoCompraCuot { get; set; }
        public decimal? PorcentajeInteresApl { get; set; }
        public int? IndicadorMoviExtracto { get; set; }
        public int? IndicadorMoviRetenido { get; set; }
        public int? IndicadorDbCr { get; set; }
        public int? FormaPagoOperacion { get; set; }
        public int? NumeroExtracto { get; set; }
        public int? ImporteAmortParaCred { get; set; }
        public decimal? TasaEfectivaAnual { get; set; }
        public int? CargosAbonosPeriodo { get; set; }
        public int? ValorPendienteDiferir { get; set; }
        public int? NumeroCuotasFact { get; set; }
        public int? CuotasPendientes { get; set; }
        public string IndicadorDeMovimiento { get; set; }
        public string FechaProceso { get; set; }
        public string Contratos { get; set; }
    }
}
