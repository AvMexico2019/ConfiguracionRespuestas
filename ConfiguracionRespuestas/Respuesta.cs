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
    
    public partial class Respuesta
    {
        public Respuesta()
        {
            this.Rel_ConceptoRespValor = new HashSet<Rel_ConceptoRespValor>();
        }
    
        public int IdRespuesta { get; set; }
        public string DescripcionRespuesta { get; set; }
        public string Comentario { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ICollection<Rel_ConceptoRespValor> Rel_ConceptoRespValor { get; set; }
    }
}
