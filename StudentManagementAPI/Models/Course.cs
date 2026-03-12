using System.ComponentModel.DataAnnotations;
namespace StudentManagementAPI.Models
{
    public class Course
    {
        [Range(1,int.MaxValue)]
        public int Id { get; set; } // this is the primary key of the Course table 

        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }

        public ICollection<Student>? Students { get; set; } // Navigation property which tells the Course table about the student table
    }
}
