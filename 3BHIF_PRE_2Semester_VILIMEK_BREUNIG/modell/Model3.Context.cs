﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3BHIF_PRE_2Semester_VILIMEK_BREUNIG.modell
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PatientendatenEntities : DbContext
    {
        public PatientendatenEntities()
            : base("name=PatientendatenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Behandlung> Behandlungs { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<TundBvonP> TundBvonPs { get; set; }
        public virtual DbSet<Verletzung> Verletzungs { get; set; }
        public virtual DbSet<VvonP> VvonPs { get; set; }
    }
}
