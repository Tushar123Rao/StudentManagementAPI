using System;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(18,60)]
        public int Age { get; set; }

        [Required]
        [StringLength(100)]
        public string Course { get; set; }
    }
}