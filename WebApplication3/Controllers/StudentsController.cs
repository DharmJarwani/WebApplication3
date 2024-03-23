using WebApplication3.Models;
using WebApplication3.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            IEnumerable<Student> students = await _studentService.GetStudentsAsync();
            return Ok(students);
        }
    }
}
