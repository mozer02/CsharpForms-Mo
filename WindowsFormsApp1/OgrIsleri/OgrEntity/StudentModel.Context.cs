﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.OgrIsleri.OgrEntity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentEntities : DbContext
    {
        public StudentEntities()
            : base("name=StudentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_sehirler> tbl_sehirler { get; set; }
        public virtual DbSet<tblDeparments> tblDeparments { get; set; }
        public virtual DbSet<tblOgrBilgi> tblOgrBilgi { get; set; }
    }
}
