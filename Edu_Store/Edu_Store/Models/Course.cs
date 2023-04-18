﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edu_Store.Models
{
    public class Course
    {
        [Key] public int CourseID { get; set; }

        [Required( ErrorMessage = "Title is required" )]
        [StringLength( 50 )]
        public required string Title { get; set; }

        public string? Description { get; set; }

        [StringLength( 10 )]
        public int? Duration { get; set; }

        [ForeignKey( "Teacher" )]
        [Column( TypeName = "nvarchar(450)" )]
        public string? TeacherID { get; set; }
        public ApplicationUser? Teacher { get; set; }

        public ICollection<StudentCourse>? StudentCourses { get; set; }
        //public ICollection<Student>? Students { get; set; }
    }
}
