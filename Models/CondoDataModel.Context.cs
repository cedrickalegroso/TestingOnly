﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CondoDataEntities : DbContext
    {
        public CondoDataEntities()
            : base("name=CondoDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Commission> Commissions { get; set; }
        public virtual DbSet<UnitDetail> UnitDetails { get; set; }
        public virtual DbSet<UnitType> UnitTypes { get; set; }
    }
}
