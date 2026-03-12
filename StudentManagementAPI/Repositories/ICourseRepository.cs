using System;
using StudentManagementAPI.Models;
namespace StudentManagementAPI.Repositories
{
    public interface ICourseRepository
    {
        List<Course> GetAllCourse();
        Course GetCourseById(int id);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
    }
}
