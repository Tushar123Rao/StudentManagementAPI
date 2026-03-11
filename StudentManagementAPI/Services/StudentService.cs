using studentManagementAPI.Repositories;
using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;
namespace StudentManagementAPI.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService()
        {
            _repository = new StudentRepository();
        }
        public List<Student> GetStudents()
        {
            return _repository.GetAllStudents();
        }

        public Student GetStudent(int id)
        {
            return _repository.GetStudentById(id);
        }

        public void AddStudent(Student student)
        {
            _repository.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            _repository.UpdateStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            _repository.DeleteStudent(student);
        }
    }
}