﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VitalSigns
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class heightsemr_dbEntities : DbContext
    {
        public heightsemr_dbEntities()
            : base("name=heightsemr_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<enrollee_type> enrollee_type { get; set; }
        public virtual DbSet<HMO> HMOes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<VitalSign> VitalSigns { get; set; }
    }
}