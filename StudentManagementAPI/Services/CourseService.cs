using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;
namespace StudentManagementAPI.Services
{
    public class CourseService
    {
        private readonly ICourseRepository _repository;

        public CourseService()
        {
            _repository = new CourseRepository();
        }

        public List<Course> GetCourses()
        {
            return _repository.GetAllCourse();
        }

        public Course GetCourse(int id)
        {
            return _repository.GetCourseById(id);
        }

        public void AddCourse(Course course)
        {
            _repository.AddCourse(course);
        }

        public void UpdateCourse(Course course)
        {
            _repository.UpdateCourse(course);
        }

        public void DeleteCourse(Course course)
        {
            _repository.DeleteCourse(course);
        }
    }
}
