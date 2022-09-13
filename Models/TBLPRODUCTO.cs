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
    using System.ComponentModel.DataAnnotations;

    public partial class TBLPRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPRODUCTO()
        {
            this.TBLDETALLE_FACTURA = new HashSet<TBLDETALLE_FACTURA>();
        }

        [Key]
        public int IdProducto { get; set; }

        [Display(Name = "Nombre")]
        public string StrNombre { get; set; }

        [Display(Name = "Codigo")]
        public string StrCodigo { get; set; }

        [Display(Name = "Precio Compra")]
        public double NumPrecioCompra { get; set; }

        [Display(Name = "Precio Venta")]
        public double NumPrecioVenta { get; set; }

        [Display(Name = "ID Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Detalle")]
        public string StrDetalle { get; set; }

        [Display(Name = "Direccion Foto")]
        public string strFoto { get; set; }

        [Display(Name = "Cantidad en Stock")]
        public Nullable<int> NumStock { get; set; }
        public System.DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; }
    
        public virtual TBLCATEGORIA_PROD TBLCATEGORIA_PROD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLDETALLE_FACTURA> TBLDETALLE_FACTURA { get; set; }
    }
}
