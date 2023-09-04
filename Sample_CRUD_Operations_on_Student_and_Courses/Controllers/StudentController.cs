using Microsoft.AspNetCore.Mvc;
using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Requests;
using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Responses;
using Sample_CRUD_Operations_on_Student_and_Courses.Services;

namespace Sample_CRUD_Operations_on_Student_and_Courses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("/students")]
        public List<StudentResponse> GetAll()
        {
            return _studentService.GetAll();
        }
        
        [HttpGet("/students/{id}")]
        public StudentResponse GetByStudentId(int id)
        {
            return _studentService.GetByStudentId(id);
        }

        [HttpPost("/students")]
        public StudentResponse Add([FromForm] StudentRequest student)
        {
            return _studentService.Add(student);
        }

        [HttpPut("/students/{id}")]
        public StudentResponse Update(int id, [FromForm] StudentRequest student)
        {
            return _studentService.Update(id, student);
        }

        [HttpDelete("/students/{id}")]
        public bool DeleteByStudentId(int id)
        {
            return _studentService.DeleteByStudentId(id);
        }

    }

}