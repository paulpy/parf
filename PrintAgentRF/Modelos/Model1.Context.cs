﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintAgentRF.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class parestfEntities : DbContext
    {
        public parestfEntities()
            : base("name=parestfEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<configuracion> configuracion { get; set; }
        public virtual DbSet<estados> estados { get; set; }
        public virtual DbSet<impresion> impresion { get; set; }
        public virtual DbSet<impresoras> impresoras { get; set; }
        public virtual DbSet<plantilla> plantilla { get; set; }
        public virtual DbSet<trabajosterminados> trabajosterminados { get; set; }
    }
}