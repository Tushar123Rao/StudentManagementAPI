using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseService _courseservice;
        public CourseController()
        {
            _courseservice =  new CourseService();
        }

        [HttpGet]
        public IActionResult GetCourse()
        {
            return Ok(_courseservice.GetCourses());
        }

        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _courseservice.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            _courseservice.AddCourse(course);
            return Ok(course);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id,Course course)
        {
            course.Id = id;
            _courseservice.UpdateCourse(course);
            return Ok(course);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id, Course course)
        {
            var courses = _courseservice.GetCourse(id);
            if(courses == null)
            {
                return NotFound();
            }
           
            _courseservice.DeleteCourse(course);
            return Ok("Course Deleted");
        }
    }
}
