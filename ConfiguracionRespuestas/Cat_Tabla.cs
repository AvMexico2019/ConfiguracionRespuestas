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
    
    public partial class Cat_Tabla
    {
        public Cat_Tabla()
        {
            this.SelloDigital = new HashSet<SelloDigital>();
        }
    
        public short IdCatTabla { get; set; }
        public string DescripcionTabla { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public bool EstatusRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ICollection<SelloDigital> SelloDigital { get; set; }
    }
}
