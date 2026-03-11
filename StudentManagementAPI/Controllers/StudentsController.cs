using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentsService;
        public StudentController()
        {
            _studentsService = new StudentService();
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_studentsService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentsService.GetStudent(id);

            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentsService.AddStudent(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            student.Id = id;
            _studentsService.UpdateStudent(student);
            return Ok(student);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteStudent(int id)
        {
            var student = _studentsService.GetStudent(id);

            if (student == null)
            {
                return NotFound();
            }

            _studentsService.DeleteStudent(student);
            return Ok("Student Deleted");
        }
    }
}