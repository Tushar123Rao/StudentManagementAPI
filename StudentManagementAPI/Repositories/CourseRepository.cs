using StudentManagementAPI.Models;
namespace StudentManagementAPI.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course(){Id = 1, CourseName = "AI"},
            new Course(){Id = 2, CourseName = ".NET"},
            new Course(){Id = 3, CourseName = "SQL"}
        };

        public List<Course> GetAllCourse()
        {
            return courses;
        }

        public Course GetCourseById(int id)
        {
            return courses.FirstOrDefault(x => x.Id == id);
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            var existing = courses.FirstOrDefault(x => x.Id == course.Id);
            if(existing != null)
            {
                existing.Id = course.Id;
                existing.CourseName = course.CourseName;
            }
        }

        public void DeleteCourse(Course course)
        {
            courses.Remove(course);
        }
    }
}
