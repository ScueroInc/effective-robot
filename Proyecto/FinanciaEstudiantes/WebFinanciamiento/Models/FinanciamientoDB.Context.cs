﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFinanciamiento.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_FinanciamientoEntities : DbContext
    {
        public BD_FinanciamientoEntities()
            : base("name=BD_FinanciamientoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria_Deuda> Categoria_Deuda { get; set; }
        public virtual DbSet<Categoria_Gasto> Categoria_Gasto { get; set; }
        public virtual DbSet<Categoria_Ingreso> Categoria_Ingreso { get; set; }
        public virtual DbSet<Deuda> Deuda { get; set; }
        public virtual DbSet<Divisa> Divisa { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Entidad_Tipo> Entidad_Tipo { get; set; }
        public virtual DbSet<Frecuencia> Frecuencia { get; set; }
        public virtual DbSet<Mes> Mes { get; set; }
        public virtual DbSet<Reporte> Reporte { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<Transaccion> Transaccion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
