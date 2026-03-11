using System;
namespace StudentManagementAPI.DTOs
{
    public class CreateStudentDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }
}