//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentID { get; set; }
        public Nullable<int> ScheduledClassId { get; set; }
        public System.DateTime EnrollmentDate { get; set; }
    
        public virtual ScheduledClasses ScheduledClass { get; set; }
        public virtual Students Student { get; set; }
    }
}
