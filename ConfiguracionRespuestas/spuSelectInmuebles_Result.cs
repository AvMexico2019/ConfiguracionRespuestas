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
    
    public partial class spuSelectInmuebles_Result
    {
        public int IdInmueble { get; set; }
        public Nullable<int> Fk_IdTipoInmueble { get; set; }
        public int Fk_IdPais { get; set; }
        public Nullable<int> Fk_IdEstado { get; set; }
        public Nullable<int> Fk_IdMunicipio { get; set; }
        public Nullable<int> Fk_IdLocalidad { get; set; }
        public string OtraColonia { get; set; }
        public int Fk_IdTipoVialidad { get; set; }
        public string NombreVialidad { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string CodigoPostal { get; set; }
        public string CodigoPostalExtranjero { get; set; }
        public string EstadoExtranjero { get; set; }
        public string CiudadExtranjero { get; set; }
        public string MunicipioExtranjero { get; set; }
        public Nullable<decimal> GeoRefLatitud { get; set; }
        public Nullable<decimal> GeoRefLongitud { get; set; }
        public string NombreInmueble { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<int> Fk_IdRIUF { get; set; }
        public Nullable<int> IdRIUF { get; set; }
        public string RIUF1 { get; set; }
        public Nullable<int> Fk_IdEstadoRIUF { get; set; }
        public Nullable<int> DigitoVerificador { get; set; }
        public Nullable<int> Consecutivo { get; set; }
    }
}
