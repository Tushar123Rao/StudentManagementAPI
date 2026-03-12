using System;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; } // primary key of the Student table

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(18,60)]
        public int Age { get; set; }

        [Required]
        public int CourseId { get; set; } // Foreign key CourseID which references Course.Id

        public Course? Course { get; set; } // Navigation property which tells student table about the course table
    }
}