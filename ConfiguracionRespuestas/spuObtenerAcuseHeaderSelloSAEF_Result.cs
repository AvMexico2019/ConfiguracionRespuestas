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
    
    public partial class spuObtenerAcuseHeaderSelloSAEF_Result
    {
        public int IdAplicacionConcepto { get; set; }
        public int FolioAplicacionConcepto { get; set; }
        public string FolioSAEF { get; set; }
        public Nullable<int> Fk_IdInmuebleArrendamiento { get; set; }
        public string CadenaOriginal { get; set; }
        public string SelloDigital { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public string QR { get; set; }
        public Nullable<int> Fk_IdInstitucion { get; set; }
        public string NombreInmueble { get; set; }
        public Nullable<int> Fk_IdInmueble { get; set; }
        public string DescripcionInstitucion { get; set; }
        public Nullable<int> Fk_IdRIUF { get; set; }
        public string RIUF { get; set; }
    }
}
