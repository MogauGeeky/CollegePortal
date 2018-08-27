using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegePortal.Data.Context.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [MaxLength(60), Required]
        public string FirstName { get; set; }
        [MaxLength(60), Required]
        public string Surname { get; set; }
        [MaxLength(120), Required]
        public string EmailAddress { get; set; }
        [MinLength(13), MaxLength(13), Required]
        public string IDNumber { get; set; }

        public IEnumerable<StudentCourse> Courses {get; set;}
    }
}