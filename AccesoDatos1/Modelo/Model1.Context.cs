﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos1.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class petServicesEntities1 : DbContext
    {
        public petServicesEntities1()
            : base("name=petServicesEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<calificacione> calificaciones { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<mascota> mascotas { get; set; }
        public virtual DbSet<reserva> reservas { get; set; }
        public virtual DbSet<reservaServico> reservaServicoes { get; set; }
        public virtual DbSet<servicio> servicios { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
    }
}