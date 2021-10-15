using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATProject.DATE.EF
{
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {
    }
    public class CourseMetadata
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course")]
        [StringLength(50, ErrorMessage = "Max 50 Characters")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(250, ErrorMessage = "Max 250 Characters")]
        public string CourseDescription { get; set; }

        [Required]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "Max 250 Characters")]
        public string Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "Max 500 Characters")]
        public string Notes { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(ScheduledClassesMetadata))]
    public partial class ScheduledClass
    {
    }
    public class ScheduledClassesMetadata
    {
        [Required]
        public int ScheduledClassId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Instructor Name")]
        [StringLength(40, ErrorMessage = "Max 40 Characters")]
        public string InstructorName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Max 20 Characters")]
        public string Location { get; set; }

        [Required]
        public int SCSID { get; set; }
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
        [Display(Name = "Full Class Info")]
        public string ClassInfo { get { return ScheduledClass.StartDate + " | " + ScheduledClass.EndDate + " | " + ScheduledClass.Cours.CourseName; } }
    }

    public class EnrollmentMetadata
    {

        [Required]
        public int EnrollmentId { get; set; }

        [Required]
        public int StudentID { get; set; }

        [Display(Name = "Scheduled Class Information")]
        public Nullable<int> ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime EnrollmentDate { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [Display(Name = "Student Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
    }
    public class StudentMetadata
    {

        [Required]
        public int StudentID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "Max 20 Characters")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Max 20 Characters")]
        public string LastName { get; set; }

        [StringLength(15, ErrorMessage = "Max 15 Characters")]
        public string Major { get; set; }

        [StringLength(50, ErrorMessage = "Max 50 Characters")]
        public string Address { get; set; }

        [StringLength(50, ErrorMessage = "Max 50 Characters")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "Max 2 Characters")]
        public string State { get; set; }
        
        [StringLength(10, ErrorMessage = "Max 10 Characters")]
        public string ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "Max 13 Characters")]
        public string Phone { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Max 50 Characters")]
        public string Email { get; set; }

        [Display(Name = "Student Image")]
        [StringLength(100, ErrorMessage = "Max 100 Characters")]
        public string PhotoUrl { get; set; }

        [Required]
        public int SSID { get; set; }
    }


    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus
    {
    }
    public class StudentStatusMetadata
    {
        [Required]
        public int SSID { get; set; }

        [Required]
        [Display(Name = "Status Name")]
        [StringLength(30, ErrorMessage = "Max 30 Characters")]
        public string SSName { get; set; }

        
        [Display(Name = "Status Description")]
        [StringLength(250, ErrorMessage = "Max 250 Characters")]
        [DisplayFormat(NullDisplayText = "Never connected")]
        public string SSDescription { get; set; }
    }
}