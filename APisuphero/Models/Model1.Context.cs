﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APisuphero.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SuperHeroesEntities : DbContext
    {
        public SuperHeroesEntities()
            : base("name=SuperHeroesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Heroe_Poder> Heroe_Poder { get; set; }
        public virtual DbSet<Heroes_Misiones> Heroes_Misiones { get; set; }
        public virtual DbSet<Misiones> Misiones { get; set; }
        public virtual DbSet<Poder> Poder { get; set; }
        public virtual DbSet<SuperHeroe> SuperHeroe { get; set; }
        public virtual DbSet<TipoMision> TipoMision { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
    }
}
