//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCATEGORIA_PROD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCATEGORIA_PROD()
        {
            this.TBLPRODUCTO = new HashSet<TBLPRODUCTO>();
        }
    
        public int IdCategoria { get; set; }
        public string StrDescripcion { get; set; }
        public Nullable<System.DateTime> DtmFechaModifica { get; set; }
        public string StrUsuarioModifico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPRODUCTO> TBLPRODUCTO { get; set; }
    }
}
