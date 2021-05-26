using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SATCroftNelson.DATA.EF
{
    #region Course Metadata
    public class CourseMetadata
    {
        //public int CourseId { get; set; }
        [Required(ErrorMessage = "Course Name is a required field.")]
        [Display(Name = "Course Name")]
        [StringLength(50, ErrorMessage = "Course Name must be 50 characters or less.")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Course Description is a required field.")]
        [UIHint("MultilineText")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "Credit Hours is a required field.")]
        [Display(Name = "Credit Hours")]
        [Range(0, byte.MaxValue, ErrorMessage = "Must be 0 or greater.")]
        public byte CreditHours { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(250, ErrorMessage = "Curriculum must be 250 characters or less.")]
        public string Curriculum { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(500, ErrorMessage = "Notes must be 500 characters or less.")]
        [UIHint("MultilineText")]
        public string Notes { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CourseMetadata))]
    public partial class Course { }
    #endregion

    #region Enrollment Metadata
    public class EnrollmentMetadata
    {
        //public int EnrollmentId { get; set; }

        [Required(ErrorMessage = "Student ID is a required field.")]
        [Display(Name = "Student ID")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be 1 or greater.")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Scheduled Class ID is a required field.")]
        [Display(Name = "Scheduled Class ID")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be 1 or greater.")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Enrollment Date is a required field.")]
        [Display(Name = "Enrollment Date")]
        public System.DateTime EnrollmentDate { get; set; }
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }
    #endregion

    #region Scheduled Class

    public class ScheduledClassMetadata
    {
        //public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Course ID is a required field.")]
        [Display(Name = "Course ID")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be 1 or greater.")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Start Date is a required field.")]
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is a required field.")]
        [Display(Name = "End Date")]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Instructor Name is a required field.")]
        [Display(Name = "Instructor Name")]
        [StringLength(40, ErrorMessage = "Instructor Name must be 40 characters or less.")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "Location is a required field.")]
        [StringLength(20, ErrorMessage = "Location must be 20 characters or less.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "SCSID is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be 1 or greater.")]
        public int SCSID { get; set; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }

    #endregion

    #region Student Metadata
    public class StudentMetadata
    {
        //public int StudentId { get; set; }

        [Required(ErrorMessage = "First Name is a required field.")]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "First Name must be 20 characters or less.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required field.")]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Last Name must be 20 characters or less.")]
        public string LastName { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(15, ErrorMessage = "Major must be 15 characters or less.")]
        public string Major { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(50, ErrorMessage = "Address must be 50 characters or less.")]
        public string Address { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(25, ErrorMessage = "City must be 25 characters or less.")]
        public string City { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(2, ErrorMessage = "State must be 2 characters or less.")]
        public string State { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(10, ErrorMessage = "Zip Code must be 10 characters or less.")]
        public string ZipCode { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")] // TODO format phone number to look nice
        [StringLength(15, ErrorMessage = "Phone must be 15 characters or less.")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Email is a required field.")]
        [StringLength(60, ErrorMessage = "Email must be 60 characters or less.")]
        public string Email { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(100, ErrorMessage = "Photo URL must be 100 characters or less.")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "SSID is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be 1 or greater.")]
        public int SSID { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student { }

    #endregion

    #region Student Status Metadata
    public class StudentStatusMetadata
    {
        //public int SSID { get; set; }

        [Required(ErrorMessage = "SS Name is a required field.")]
        [Display(Name = "SS Name")]
        [StringLength(30, ErrorMessage = "SS Name must be 30 characters or less.")]
        public string SSName { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(250, ErrorMessage = "Description must be 250 characters or less.")]
        [Display(Name = "Description")]
        [UIHint("MultilineText")]
        public string SSDescription { get; set; }
    }

    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }

    #endregion

}
