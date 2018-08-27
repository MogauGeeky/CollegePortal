using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegePortal.Data.Context.Entities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [MaxLength(200), Required]
        public string CourseName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public IEnumerable<StudentCourse> Students { get; set; }
    }
}