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

    public partial class TBLEMPLEADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLEMPLEADO()
        {
            this.TBLFACTURA = new HashSet<TBLFACTURA>();
            this.TBLSEGURIDAD = new HashSet<TBLSEGURIDAD>();
        }

        [Key]
        public int IdEmpleado { get; set; }
        [Display(Name ="Nombre")]
        public string strNombre { get; set; }
        [Display(Name ="Nº Documento")]
        public long NumDocumento { get; set; }
        [Display(Name ="Direccion")]
        public string StrDireccion { get; set; }
        [Display(Name ="Telefono")]
        public string StrTelefono { get; set; }
        [Display(Name ="Email")]
        public string StrEmail { get; set; }
        [Display(Name ="Rol Empleado")]
        public Nullable<int> IdRolEmpleado { get; set; }

        [Display (Name= "FechaIngreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-mm-dd 00:00:00.0}", ApplyFormatInEditMode = true)]

        public Nullable<System.DateTime> DtmIngreso { get; set; }
        [Display(Name ="FechaRetiro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DtmRetiro { get; set; }
        [Display(Name="Datos Adicionales")]
        public string strDatosAdicionales { get; set; }
        public Nullable<System.DateTime> DtmFechaModifica { get; set; }
        public string StrUsuarioModifico { get; set; }

        public virtual TBLROLES TBLROLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFACTURA> TBLFACTURA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSEGURIDAD> TBLSEGURIDAD { get; set; }
    }
}