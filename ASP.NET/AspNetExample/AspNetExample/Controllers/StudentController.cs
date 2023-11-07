using AspNetExample.Domain.Models.Student;
using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Student;
using AspNetExampleDomain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentRequest createStudentRequest)
        {
            await _studentService.CreateStudentAsync(createStudentRequest);

            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateStudent([FromBody] UpdateStudentRequest updateStudentRequest)
        {
            await _studentService.UpdateStudentAsync(updateStudentRequest);

            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetStudentResponse>> GetSudent(Guid id)
        {
            var students = await _studentService.GetStudentAsync(id);

            return Ok(students);
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetStudentResponse[]>> GetSudents()
        {
           var students = await _studentService.GetStudentsAsync();

            return Ok(students);
        }
    }
}
