﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegePortal.Data.Context.Entities
{
    [Table("Student_Course")]
    public class StudentCourse
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}