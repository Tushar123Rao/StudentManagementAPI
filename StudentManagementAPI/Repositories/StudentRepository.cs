using Microsoft.AspNetCore.Http.HttpResults;
using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;
namespace studentManagementAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> students = new List<Student>()
        {
            new Student {Id = 1, Name = "Tushar", Age = 25, Course = ".NET"}
        };

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            var existing = students.FirstOrDefault(x => x.Id == student.Id);
            if (existing != null)
            {
                existing.Name = student.Name;
                existing.Age = student.Age;
                existing.Course = student.Course;
            }
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
        }
    }
}