﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SATProject.DATE.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SATProjectEntities : DbContext
    {
        public SATProjectEntities()
            : base("name=SATProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<ScheduledClasses> ScheduledClasses1 { get; set; }
        public virtual DbSet<ScheduledClassStatuses> ScheduledClassStatuses { get; set; }
        public virtual DbSet<Students> Students1 { get; set; }
        public virtual DbSet<StudentStatuses> StudentStatuses { get; set; }
    }
}
