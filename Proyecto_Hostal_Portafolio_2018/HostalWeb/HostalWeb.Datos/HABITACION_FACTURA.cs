//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalWeb.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class HABITACION_FACTURA
    {
        public int ID { get; set; }
        public int HABITACION_ID { get; set; }
        public int FACTURA_ID { get; set; }
        public string NOMBRE { get; set; }
        public int VALOR { get; set; }
    
        public virtual FACTURA FACTURA { get; set; }
        public virtual HABITACION HABITACION { get; set; }
    }
}
