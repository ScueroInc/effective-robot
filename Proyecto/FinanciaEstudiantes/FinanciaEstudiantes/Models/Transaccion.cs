//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanciaEstudiantes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaccion()
        {
            this.Reporte = new HashSet<Reporte>();
        }
    
        public int IDTransaccion { get; set; }
        public string NTransaccion { get; set; }
        public decimal MontoTransaccion { get; set; }
        public System.DateTime FechaTransaccion { get; set; }
        public int IDDivisa { get; set; }
        public int IDMes { get; set; }
        public int IDUsuario { get; set; }
        public int IDFrecuencia { get; set; }
    
        public virtual Divisa Divisa { get; set; }
        public virtual Frecuencia Frecuencia { get; set; }
        public virtual Mes Mes { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reporte> Reporte { get; set; }
        public virtual Categoria_Gasto Categoria_Gasto { get; set; }
        public virtual Categoria_Ingreso Categoria_Ingreso { get; set; }
    }
}
