﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI4_WEBSERVICE.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PI4_WSEntities : DbContext
    {
        public PI4_WSEntities()
            : base("name=PI4_WSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<funcionario> funcionario { get; set; }
        public virtual DbSet<predio> predio { get; set; }
        public virtual DbSet<sala> sala { get; set; }
    }
}