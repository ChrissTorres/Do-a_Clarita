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
    
    public partial class ORDEN_COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDEN_COMPRA()
        {
            this.HABITACION_ORDEN_COMPRA = new HashSet<HABITACION_ORDEN_COMPRA>();
            this.SERVICIO_ODEN_COMPRA = new HashSet<SERVICIO_ODEN_COMPRA>();
        }
    
        public int ID { get; set; }
        public string DETALLE { get; set; }
        public int EMPRESA_ID { get; set; }
        public int CREADOR_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HABITACION_ORDEN_COMPRA> HABITACION_ORDEN_COMPRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_ODEN_COMPRA> SERVICIO_ODEN_COMPRA { get; set; }
    }
}
