//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConfiguracionRespuestas
{
    using System;
    using System.Collections.Generic;
    
    public partial class AplicacionConcepto
    {
        public AplicacionConcepto()
        {
            this.ContratoArrto = new HashSet<ContratoArrto>();
            this.EmisionOpinonContrato = new HashSet<EmisionOpinonContrato>();
            this.Movimiento = new HashSet<Movimiento>();
            this.RespuestaConcepto = new HashSet<RespuestaConcepto>();
            this.AplicacionConcepto1 = new HashSet<AplicacionConcepto>();
        }
    
        public int IdAplicacionConcepto { get; set; }
        public byte Fk_IdTipoArrendamiento { get; set; }
        public int Fk_IdInstitucion { get; set; }
        public Nullable<int> Fk_IdInmuebleArrendamiento { get; set; }
        public byte Fk_IdTema { get; set; }
        public int FolioAplicacionConcepto { get; set; }
        public Nullable<int> Fk_IdAplicacionConceptoSMOI { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string CargoUsuarioRegistro { get; set; }
        public string Observaciones { get; set; }
        public Nullable<decimal> SMOIm2FactorY { get; set; }
        public string FolioSAEF { get; set; }
    
        public virtual Cat_Tema Cat_Tema { get; set; }
        public virtual InmuebleArrendamiento InmuebleArrendamiento { get; set; }
        public virtual ICollection<ContratoArrto> ContratoArrto { get; set; }
        public virtual ICollection<EmisionOpinonContrato> EmisionOpinonContrato { get; set; }
        public virtual ICollection<Movimiento> Movimiento { get; set; }
        public virtual ICollection<RespuestaConcepto> RespuestaConcepto { get; set; }
        public virtual Cat_TipoArrendamiento Cat_TipoArrendamiento { get; set; }
        public virtual ICollection<AplicacionConcepto> AplicacionConcepto1 { get; set; }
        public virtual AplicacionConcepto AplicacionConcepto2 { get; set; }
    }
}
