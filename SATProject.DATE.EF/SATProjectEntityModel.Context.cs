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
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<ScheduledClass> ScheduledClasses { get; set; }
        public virtual DbSet<ScheduledClassStatus> ScheduledClassStatus { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentStatus> StudentStatus { get; set; }
    }
}
