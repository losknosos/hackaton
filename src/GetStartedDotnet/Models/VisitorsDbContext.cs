using Microsoft.EntityFrameworkCore;

namespace GetStartedDotnet.Models
{
    public class VisitorsDbContext : DbContext
    {
        public VisitorsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<AccountsRewards> AccountsRewards { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Products> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => new { e.Codcuent, e.Idclient });

                entity.ToTable("Accounts", "compose");

                entity.Property(e => e.Codcuent)
                    .HasColumnName("CODCUENT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idclient)
                    .HasColumnName("IDCLIENT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Apellid1).HasColumnName("APELLID1");

                entity.Property(e => e.Apellid2).HasColumnName("APELLID2");

                entity.Property(e => e.Cheqdata).HasColumnName("CHEQDATA");

                entity.Property(e => e.Codentid).HasColumnName("CODENTID");

                entity.Property(e => e.Codprogr).HasColumnName("CODPROGR");

                entity.Property(e => e.Codultex)
                    .HasColumnName("CODULTEX")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contcanj)
                    .HasColumnName("CONTCANJ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descccue).HasColumnName("DESCCCUE");

                entity.Property(e => e.Fechacti)
                    .HasColumnName("FECHACTI")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fechalta)
                    .HasColumnName("FECHALTA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fechbaja)
                    .HasColumnName("FECHBAJA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fecultex)
                    .HasColumnName("FECULTEX")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Indblqac)
                    .HasColumnName("INDBLQAC")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Indblqrd)
                    .HasColumnName("INDBLQRD")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombreid).HasColumnName("NOMBREID");

                entity.Property(e => e.Obscuent).HasColumnName("OBSCUENT");

                entity.Property(e => e.Tipidcli).HasColumnName("TIPIDCLI");
            });

            modelBuilder.Entity<AccountsRewards>(entity =>
            {
                entity.HasKey(e => e.Fecultac);

                entity.ToTable("AccountsRewards", "compose");

                entity.Property(e => e.Fecultac)
                    .HasColumnName("FECULTAC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cantpunt).HasColumnName("CANTPUNT");

                entity.Property(e => e.Cheqdata)
                    .HasColumnName("CHEQDATA")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Codcuent)
                    .HasColumnName("CODCUENT")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Codentid)
                    .IsRequired()
                    .HasColumnName("CODENTID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codprogr)
                    .IsRequired()
                    .HasColumnName("CODPROGR")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Fechproc)
                    .HasColumnName("FECHPROC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipopunt)
                    .HasColumnName("TIPOPUNT")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.HasKey(e => new { e.Codentid, e.Codcatal, e.Fechvigh });

                entity.ToTable("Campaigns", "compose");

                entity.Property(e => e.Codentid)
                    .HasColumnName("CODENTID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Codcatal)
                    .HasColumnName("CODCATAL")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Fechvigh)
                    .HasColumnName("FECHVIGH")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cheqdata)
                    .HasColumnName("CHEQDATA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Desccata)
                    .HasColumnName("DESCCATA")
                    .HasMaxLength(95)
                    .IsUnicode(false);

                entity.Property(e => e.Dvigprem)
                    .HasColumnName("DVIGPREM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fechacti)
                    .HasColumnName("FECHACTI")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Fechalta)
                    .HasColumnName("FECHALTA")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Fechbaja)
                    .HasColumnName("FECHBAJA")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Fechvigd)
                    .HasColumnName("FECHVIGD")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obscatal)
                    .HasColumnName("OBSCATAL")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Categories", "compose");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Category)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerChannels>(entity =>
            {
                entity.HasKey(e => e.Idclient);

                entity.ToTable("CustomerChannels", "compose");

                entity.Property(e => e.Idclient)
                    .HasColumnName("IDCLIENT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEntidad, e.CodigoProducto, e.CodigoSubproduct });

                entity.ToTable("Products", "compose");

                entity.Property(e => e.CodigoEntidad)
                    .HasColumnName("﻿CODIGO_ENTIDAD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .HasColumnName("CODIGO_PRODUCTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSubproduct)
                    .HasColumnName("CODIGO_SUBPRODUCT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AmpliacionDisp)
                    .HasColumnName("AMPLIACION_DISP")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AplicacionLaCuo).HasColumnName("APLICACION_LA_CUO");

                entity.Property(e => e.ClaseSegmentoDe).HasColumnName("CLASE_SEGMENTO_DE");

                entity.Property(e => e.ClaveMoneda)
                    .HasColumnName("CLAVE_MONEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ControlConcurren).HasColumnName("CONTROL_CONCURREN");

                entity.Property(e => e.DescripcionProdu).HasColumnName("DESCRIPCION_PRODU");

                entity.Property(e => e.DescripcionReducida).HasColumnName("DESCRIPCION_REDUCIDA");

                entity.Property(e => e.DiasAMantenerUn)
                    .HasColumnName("DIAS_A_MANTENER_UN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntidadUltimaModif).HasColumnName("ENTIDAD_ULTIMA_MODIF");

                entity.Property(e => e.FechaAltaDelPr)
                    .HasColumnName("FECHA_ALTA_DEL_PR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaFinProduct)
                    .HasColumnName("FECHA_FIN_PRODUCT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("FECHA_INICIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaProceso)
                    .HasColumnName("FECHA_PROCESO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormaPagoPorDe)
                    .HasColumnName("FORMA_PAGO_POR_DE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrupoLiquidacion)
                    .HasColumnName("GRUPO_LIQUIDACION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteMaximoPor)
                    .HasColumnName("IMPORTE_MAXIMO_POR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteMaximoTo)
                    .HasColumnName("IMPORTE_MAXIMO_TO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteMinimoPa)
                    .HasColumnName("IMPORTE_MINIMO_PA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteMinimoPara)
                    .HasColumnName("IMPORTE_MINIMO_PARA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteMinimoporOp)
                    .HasColumnName("IMPORTE_MINIMOPOR_OP")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteParaGenerar)
                    .HasColumnName("IMPORTE_PARA_GENERAR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteToleradoDe)
                    .HasColumnName("IMPORTE_TOLERADO_DE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IndAdmisionDomi).HasColumnName("IND_ADMISION_DOMI");

                entity.Property(e => e.IndAdmisionPerio).HasColumnName("IND_ADMISION_PERIO");

                entity.Property(e => e.IndAdmisionUna).HasColumnName("IND_ADMISION_UNA");

                entity.Property(e => e.IndLimiteContrato).HasColumnName("IND_LIMITE_CONTRATO");

                entity.Property(e => e.IndLimiteLinea).HasColumnName("IND_LIMITE_LINEA");

                entity.Property(e => e.IndLimiteUnico).HasColumnName("IND_LIMITE_UNICO");

                entity.Property(e => e.IndicadorCuenta).HasColumnName("INDICADOR_CUENTA");

                entity.Property(e => e.IndicadorGaranti).HasColumnName("INDICADOR_GARANTI");

                entity.Property(e => e.IndicadorNivel).HasColumnName("INDICADOR_NIVEL");

                entity.Property(e => e.IndicadorRiesgo).HasColumnName("INDICADOR_RIESGO");

                entity.Property(e => e.IndicadorSiEl).HasColumnName("INDICADOR_SI_EL");

                entity.Property(e => e.IndicadorVertien).HasColumnName("INDICADOR_VERTIEN");

                entity.Property(e => e.IndicativoCobro)
                    .HasColumnName("INDICATIVO_COBRO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LimiteMaxCreditCompra)
                    .HasColumnName("LIMITE_MAX_CREDIT_COMPRA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LimiteMaxCreditCuenta)
                    .HasColumnName("LIMITE_MAX_CREDIT_CUENTA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LimiteMinCreditCompra)
                    .HasColumnName("LIMITE_MIN_CREDIT_COMPRA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LimiteMinCreditCuenta)
                    .HasColumnName("LIMITE_MIN_CREDIT_CUENTA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaximoNumeroDia)
                    .HasColumnName("MAXIMO_NUMERO_DIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroDiasMaxim)
                    .HasColumnName("NUMERO_DIAS_MAXIM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroMaximoPla)
                    .HasColumnName("NUMERO_MAXIMO_PLA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroMesesD)
                    .HasColumnName("NUMERO_MESES_D")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroMinimoMes)
                    .HasColumnName("NUMERO_MINIMO_MES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OficinaUltimaModif).HasColumnName("OFICINA_ULTIMA_MODIF");

                entity.Property(e => e.PorcenToleraInpago)
                    .HasColumnName("PORCEN_TOLERA_INPAGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PorcenToleraPago)
                    .HasColumnName("PORCEN_TOLERA_PAGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerminalUltimaModi).HasColumnName("TERMINAL_ULTIMA_MODI");

                entity.Property(e => e.TipoSegmentoDel).HasColumnName("TIPO_SEGMENTO_DEL");

                entity.Property(e => e.TratamientoSaldoAc).HasColumnName("TRATAMIENTO_SALDO_AC");

                entity.Property(e => e.TratamientoSaldoDi).HasColumnName("TRATAMIENTO_SALDO_DI");

                entity.Property(e => e.UsuarioUltimaModif).HasColumnName("USUARIO_ULTIMA_MODIF");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEntidad, e.CentroAltaCuentaTarjeta, e.SecuenciaTarjeta, e.PanTarjetaOperacion, e.SecuenciaOperFranq });

                entity.ToTable("Transactions", "compose");

                entity.HasIndex(e => e.SecuenciaOperFranq)
                    .HasName("SECUENCIA_OPER_FRANQ_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CodigoEntidad)
                    .HasColumnName("CODIGO_ENTIDAD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CentroAltaCuentaTarjeta)
                    .HasColumnName("CENTRO_ALTA_CUENTA_TARJETA")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SecuenciaTarjeta)
                    .HasColumnName("SECUENCIA_TARJETA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PanTarjetaOperacion)
                    .HasColumnName("PAN_TARJETA_OPERACION")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SecuenciaOperFranq)
                    .HasColumnName("SECUENCIA_OPER_FRANQ")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CargosAbonosPeriodo)
                    .HasColumnName("CARGOS_ABONOS_PERIODO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoActividad)
                    .HasColumnName("CODIGO_ACTIVIDAD")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoComercio)
                    .HasColumnName("CODIGO_COMERCIO")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoMonedaOperacion)
                    .HasColumnName("CODIGO_MONEDA_OPERACION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoPais)
                    .HasColumnName("CODIGO_PAIS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoTipoCompraCuot)
                    .HasColumnName("CODIGO_TIPO_COMPRA_CUOT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Contratos)
                    .HasColumnName("CONTRATOS")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CuotasPendientes)
                    .HasColumnName("CUOTAS_PENDIENTES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescripcionTipoFact)
                    .HasColumnName("DESCRIPCION_TIPO_FACT")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FecProcEntOperacion)
                    .HasColumnName("FEC_PROC_ENT_OPERACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaContableOperar)
                    .HasColumnName("FECHA_CONTABLE_OPERAR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("FECHA_FACTURA")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLiquidacion)
                    .HasColumnName("FECHA_LIQUIDACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaProceso)
                    .HasColumnName("FECHA_PROCESO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FormaPagoOperacion)
                    .HasColumnName("FORMA_PAGO_OPERACION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteAmortParaCred)
                    .HasColumnName("IMPORTE_AMORT_PARA_CRED")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteCuota)
                    .HasColumnName("IMPORTE_CUOTA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteDivisaOrig)
                    .HasColumnName("IMPORTE_DIVISA_ORIG")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteFactura)
                    .HasColumnName("IMPORTE_FACTURA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImporteImpuesto)
                    .HasColumnName("IMPORTE_IMPUESTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IndicadorDbCr)
                    .HasColumnName("INDICADOR_DB_CR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IndicadorDeMovimiento)
                    .HasColumnName("INDICADOR_DE_MOVIMIENTO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorIncidenEst)
                    .HasColumnName("INDICADOR_INCIDEN_EST")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IndicadorMoviExtracto)
                    .HasColumnName("INDICADOR_MOVI_EXTRACTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IndicadorMoviRetenido)
                    .HasColumnName("INDICADOR_MOVI_RETENIDO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IndicadorNormalCorr)
                    .HasColumnName("INDICADOR_NORMAL_CORR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LineaReferenciaMov)
                    .HasColumnName("LINEA_REFERENCIA_MOV")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NoReferenciaFactura)
                    .HasColumnName("NO_REFERENCIA_FACTURA")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComercioRedu)
                    .HasColumnName("NOMBRE_COMERCIO_REDU")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAutorizacion)
                    .HasColumnName("NUMERO_AUTORIZACION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroCuotasFact)
                    .HasColumnName("NUMERO_CUOTAS_FACT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroExtracto)
                    .HasColumnName("NUMERO_EXTRACTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroOperCompraCuot)
                    .HasColumnName("NUMERO_OPER_COMPRA_CUOT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumeroSecuenciaMaest)
                    .HasColumnName("NUMERO_SECUENCIA_MAEST")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTotalCuotas)
                    .HasColumnName("NUMERO_TOTAL_CUOTAS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrigenOperacion)
                    .HasColumnName("ORIGEN_OPERACION")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PoblacionRealizoOper)
                    .HasColumnName("POBLACION_REALIZO_OPER")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeInteresApl)
                    .HasColumnName("PORCENTAJE_INTERES_APL")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.TasaEfectivaAnual)
                    .HasColumnName("TASA_EFECTIVA_ANUAL")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.TipoFactura)
                    .HasColumnName("TIPO_FACTURA")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFranquicia)
                    .HasColumnName("TIPO_FRANQUICIA")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ValorPendienteDiferir)
                    .HasColumnName("VALOR_PENDIENTE_DIFERIR")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Visitors>(entity =>
            {
                entity.ToTable("Visitors", "compose");

                entity.Property(e => e.Id).HasColumnType("int(11)");
            });
        }



    }
}
