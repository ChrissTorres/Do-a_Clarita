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
    
    public partial class HUESPED
    {
        public int ID { get; set; }
        public int TRABAJADOR_ID { get; set; }
        public int HABITACION_ID { get; set; }
        public int ENTRADA { get; set; }
        public int SALIDA { get; set; }
    
        public virtual HABITACION HABITACION { get; set; }
        public virtual TRABAJADOR TRABAJADOR { get; set; }
    }
}
