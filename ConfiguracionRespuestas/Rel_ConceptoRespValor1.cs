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
    
    public partial class Rel_ConceptoRespValor1
    {
        public int IdConceptoRespValor { get; set; }
        public Nullable<int> Fk_IdInstitucion { get; set; }
        public byte Fk_IdTema { get; set; }
        public int Fk_IdConcepto { get; set; }
        public int Fk_IdRespuesta { get; set; }
        public decimal NumOrden { get; set; }
        public bool EsDeterminante { get; set; }
        public Nullable<decimal> ValorRespuesta { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public string Comentario { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual Cat_Tema1 Cat_Tema1 { get; set; }
        public virtual Concepto1 Concepto1 { get; set; }
        public virtual Respuesta1 Respuesta1 { get; set; }
    }
}
